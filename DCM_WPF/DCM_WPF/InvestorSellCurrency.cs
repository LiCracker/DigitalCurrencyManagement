using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace DCM_WPF
{
    public partial class InvestorSellCurrency : Form
    {
        private string globalUsername;
        private string globalEmail;
        private SqlConnectionStringBuilder cb;

        private RootObject globalRootObject;
        private double BTC_amount = 0;
        private double BTC_amount_USD = 0;
        private double ETH_amount = 0;
        private double ETH_amount_USD = 0;
        private double LTC_amount = 0;
        private double LTC_amount_USD = 0;
        private double USD_amount = 0;

        private string selectCurrency = "";
        private double selectPrice = 0;

        private double volume = 0.0;

        Login prior;

        public InvestorSellCurrency(string username, string email, Login L)
        {
            InitializeComponent();
            globalUsername = username;
            globalEmail = email;

            prior = L;
        }

        private async void InvestorSellCurrency_Load(object sender, EventArgs e)
        {
            cb = new SqlConnectionStringBuilder();
            cb.DataSource = "dcm01.database.windows.net";
            cb.UserID = "serverAdmin";
            cb.Password = "Admin123456";
            cb.InitialCatalog = "DCMdb";

            await refresh_prices();

            System.Windows.Forms.Timer timerRefreshPrices = new System.Windows.Forms.Timer();
            timerRefreshPrices.Interval = 12000;
            timerRefreshPrices.Tick += new EventHandler(timerRefreshPrices_Tick);
            timerRefreshPrices.Start();

            groupBox_selected_currency.Enabled = true;

            textBox3.Text = "$ " + string.Format("{0:N2}", 0.00);
        }

        public static async Task<RootObject> GetResult()
        {
            string apiUrl = "https://min-api.cryptocompare.com/data/pricemulti?fsyms=BTC,ETH,LTC&tsyms=USD";

            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    var rootResult = JsonConvert.DeserializeObject<RootObject>(result);
                    return rootResult;
                }
                else
                {
                    return null;
                }
            }
        }

        private void refresh_account_info(RootObject currencies)
        {
            string getAccountTxt = Query_get_accounts();
            using (SqlConnection connection = new SqlConnection(cb.ConnectionString))
            {
                SqlCommand getAccountCommand = new SqlCommand(getAccountTxt, connection);
                getAccountCommand.Parameters.AddWithValue("@Email", globalEmail);

                try
                {
                    connection.Open();
                    SqlDataReader reader = getAccountCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        string currency = reader[0].ToString();
                        double balance = (double)reader[1];
                        if (currency.Equals("BTC"))
                        {
                            BTC_amount = balance;
                            BTC_amount_USD = currencies.BTC.USD * balance;
                        }
                        else if (currency.Equals("ETH"))
                        {
                            ETH_amount = balance;
                            ETH_amount_USD = currencies.ETH.USD * balance;
                        }
                        else if (currency.Equals("LTC"))
                        {
                            LTC_amount = balance;
                            LTC_amount_USD = currencies.LTC.USD * balance;
                        }
                        else if (currency.Equals("USD"))
                        {
                            USD_amount = balance;
                            USDAmount.Text = balance.ToString();
                            USDAmountUSD.Text = "$ " + string.Format("{0:N2}", USD_amount);
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void refresh_UI()
        {
            if (selectCurrency == "BTC")
            {
                CurrencyPrice1.Text = "$ " + string.Format("{0:N2}", globalRootObject.BTC.USD);
                CurrencyPrice2.Text = "$ " + string.Format("{0:N2}", globalRootObject.BTC.USD);
                selectPrice = globalRootObject.BTC.USD;

                CurrencyAmount.Text = BTC_amount.ToString();
                CurrencyAmountUSD.Text = "$ " + string.Format("{0:N2}", BTC_amount_USD);

                textBox3.Text = "$ " + string.Format("{0:N2}", volume * globalRootObject.BTC.USD);
            }
            else if (selectCurrency == "ETH")
            {
                CurrencyPrice1.Text = "$ " + string.Format("{0:N2}", globalRootObject.ETH.USD);
                CurrencyPrice2.Text = "$ " + string.Format("{0:N2}", globalRootObject.ETH.USD);
                selectPrice = globalRootObject.ETH.USD;

                CurrencyAmount.Text = ETH_amount.ToString();
                CurrencyAmountUSD.Text = "$ " + string.Format("{0:N2}", ETH_amount_USD);

                textBox3.Text = "$ " + string.Format("{0:N2}", volume * globalRootObject.ETH.USD);
            }
            else if (selectCurrency == "LTC")
            {
                CurrencyPrice1.Text = "$ " + string.Format("{0:N2}", globalRootObject.LTC.USD);
                CurrencyPrice2.Text = "$ " + string.Format("{0:N2}", globalRootObject.LTC.USD);
                selectPrice = globalRootObject.LTC.USD;

                CurrencyAmount.Text = LTC_amount.ToString();
                CurrencyAmountUSD.Text = "$ " + string.Format("{0:N2}", LTC_amount_USD);

                textBox3.Text = "$ " + string.Format("{0:N2}", volume * globalRootObject.LTC.USD);
            }
        }

        static string Query_get_accounts()
        {
            return @"SELECT Currency, Balance FROM Account WHERE Email = @Email";
        }

        private async Task refresh_prices()
        {
            var res = Task<RootObject>.Run(() =>
            {
                return GetResult();
            });

            //RootObject result = await res;
            globalRootObject = await res;

            System.DateTime currentTime = new System.DateTime();
            currentTime = System.DateTime.Now;
            label6.Text = "Last Update: " + currentTime.ToString("hh:mm:ss");

            refresh_account_info(globalRootObject);
            refresh_UI();
        }

        private async void timerRefreshPrices_Tick(object sender, EventArgs e)
        {
            await refresh_prices();
        }

        private void button_BTC_Click(object sender, EventArgs e)
        {
            groupBox_price.Enabled = true;
            groupBox_accounts.Enabled = true;
            groupBox_buy.Enabled = true;

            button_BTC.Enabled = false;
            button_ETH.Enabled = true;
            button_LTC.Enabled = true;

            CurrencyName1.Text = "BTC";
            CurrencyName2.Text = "BTC Price";
            CurrencyName3.Text = "BTC";

            CurrencyPrice1.Text = "$ " + string.Format("{0:N2}", globalRootObject.BTC.USD);
            CurrencyPrice2.Text = "$ " + string.Format("{0:N2}", globalRootObject.BTC.USD);

            CurrencyAmount.Text = BTC_amount.ToString();
            CurrencyAmountUSD.Text = "$ " + string.Format("{0:N2}", BTC_amount_USD);

            textBox1.Text = "0.00";
            selectCurrency = "BTC";
            selectPrice = globalRootObject.BTC.USD;
        }

        private void button_ETH_Click(object sender, EventArgs e)
        {
            groupBox_price.Enabled = true;
            groupBox_accounts.Enabled = true;
            groupBox_buy.Enabled = true;

            button_BTC.Enabled = true;
            button_ETH.Enabled = false;
            button_LTC.Enabled = true;

            CurrencyName1.Text = "ETH";
            CurrencyName2.Text = "ETH Price";
            CurrencyName3.Text = "ETH";

            CurrencyPrice1.Text = "$ " + string.Format("{0:N2}", globalRootObject.ETH.USD);
            CurrencyPrice2.Text = "$ " + string.Format("{0:N2}", globalRootObject.ETH.USD);

            CurrencyAmount.Text = ETH_amount.ToString();
            CurrencyAmountUSD.Text = "$ " + string.Format("{0:N2}", ETH_amount_USD);

            textBox1.Text = "0.00";
            selectCurrency = "ETH";
            selectPrice = globalRootObject.ETH.USD;
        }

        private void button_LTC_Click(object sender, EventArgs e)
        {
            groupBox_price.Enabled = true;
            groupBox_accounts.Enabled = true;
            groupBox_buy.Enabled = true;

            button_BTC.Enabled = true;
            button_ETH.Enabled = true;
            button_LTC.Enabled = false;

            CurrencyName1.Text = "LTC";
            CurrencyName2.Text = "LTC Price";
            CurrencyName3.Text = "LTC";

            CurrencyPrice1.Text = "$ " + string.Format("{0:N2}", globalRootObject.LTC.USD);
            CurrencyPrice2.Text = "$ " + string.Format("{0:N2}", globalRootObject.LTC.USD);

            CurrencyAmount.Text = LTC_amount.ToString();
            CurrencyAmountUSD.Text = "$ " + string.Format("{0:N2}", LTC_amount_USD);

            textBox1.Text = "0.00";
            selectCurrency = "LTC";
            selectPrice = globalRootObject.LTC.USD;
        }

        private void button_Lock_Click(object sender, EventArgs e)
        {
            double max_volume = 0.0;
            if (selectCurrency == "BTC")
            {
                max_volume = BTC_amount;
            }
            else if (selectCurrency == "ETH")
            {
                max_volume = ETH_amount;
            }
            else if (selectCurrency == "LTC")
            {
                max_volume = LTC_amount;
            }

            bool isDouble = System.Double.TryParse(textBox1.Text, out volume);
            if (isDouble)
            {
                if (volume > 0.0 && volume <= max_volume)
                {
                    button_Lock.Enabled = false;
                    button_Unlock.Enabled = true;
                    textBox1.Enabled = false;
                    groupBox_confirm.Enabled = true;
                    groupBox_selected_currency.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Sell volume should less than your account holdings and can not be zero.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "0.00";
                    volume = 0.00;
                }
            }
            else
            {
                MessageBox.Show("please input valid volume!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Unlock_Click(object sender, EventArgs e)
        {
            button_Lock.Enabled = true;
            button_Unlock.Enabled = false;
            textBox1.Enabled = true;
            groupBox_confirm.Enabled = false;
            groupBox_selected_currency.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double max_volume = 0.0;
            if (selectCurrency == "BTC")
            {
                max_volume = BTC_amount;
            }
            else if (selectCurrency == "ETH")
            {
                max_volume = ETH_amount;
            }
            else if (selectCurrency == "LTC")
            {
                max_volume = LTC_amount;
            }

            if (System.Double.TryParse(textBox1.Text, out volume))
            {
                if (volume >= 0.0 && volume <= max_volume)
                {
                    textBox3.Text = "$ " + string.Format("{0:N2}", volume * selectPrice);
                }
                else
                {
                    MessageBox.Show("Sell volume should less than your current volume", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "0.00";
                    volume = 0.00;
                }
            }
            else
            {
                MessageBox.Show("please input valid volume!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Confirm_Purchase_Click(object sender, EventArgs e)
        {
            update_currency();

            textBox1.Text = "0.00";
            volume = 0.0;

            button_Lock.Enabled = true;
            button_Unlock.Enabled = false;
            textBox1.Enabled = true;
            groupBox_confirm.Enabled = false;
            groupBox_selected_currency.Enabled = true;
        }

        private bool update_currency()
        {
            double update_currency_volume = 0.00;
            double update_USD_volume = USD_amount;
            double cost = Math.Round(volume * selectPrice, 2);
            DateTime dateTimeVariable = DateTime.Now;
            string type = "sell";

            if (selectCurrency == "BTC")
            {
                update_currency_volume = BTC_amount - volume;
                update_USD_volume = USD_amount + cost;
            }
            else if (selectCurrency == "ETH")
            {
                update_currency_volume = ETH_amount - volume;
                update_USD_volume = USD_amount + cost;
            }
            else if (selectCurrency == "LTC")
            {
                update_currency_volume = LTC_amount - volume;
                update_USD_volume = USD_amount + cost;
            }

            if (update_currency_volume < 0)
            {
                update_currency_volume = 0;
            }

            update_USD_volume = Math.Round(update_USD_volume, 2);

            string updateCurrencyTxt = Query_update_Currency();
            string updateUSDTxt = Query_update_USD();
            string insertTransantionTxt = Query_insert_transaction();

            using (SqlConnection connection = new SqlConnection(cb.ConnectionString))
            {
                SqlCommand updateCurrencyCommand = new SqlCommand(updateCurrencyTxt, connection);
                updateCurrencyCommand.Parameters.AddWithValue("@BalanceCurrency", update_currency_volume);
                updateCurrencyCommand.Parameters.AddWithValue("@Email", globalEmail);
                updateCurrencyCommand.Parameters.AddWithValue("@Currency", selectCurrency);

                SqlCommand updateUSDCommand = new SqlCommand(updateUSDTxt, connection);
                updateUSDCommand.Parameters.AddWithValue("@BalanceUSD", update_USD_volume);
                updateUSDCommand.Parameters.AddWithValue("@Email", globalEmail);

                SqlCommand insertTransactionCommand = new SqlCommand(insertTransantionTxt, connection);
                insertTransactionCommand.Parameters.AddWithValue("@Email", globalEmail);
                insertTransactionCommand.Parameters.AddWithValue("@Currency", selectCurrency);
                insertTransactionCommand.Parameters.AddWithValue("@Volume", volume);
                insertTransactionCommand.Parameters.AddWithValue("@Price", selectPrice);
                insertTransactionCommand.Parameters.AddWithValue("@Cost", cost);
                insertTransactionCommand.Parameters.AddWithValue("@RecordDatetime", dateTimeVariable);
                insertTransactionCommand.Parameters.AddWithValue("@RecordType", type);

                try
                {
                    connection.Open();
                    int updatecurrencyAffected = updateCurrencyCommand.ExecuteNonQuery();
                    int updateUSDAffected = updateUSDCommand.ExecuteNonQuery();
                    int insertTransactionAffected = insertTransactionCommand.ExecuteNonQuery();

                    if (updatecurrencyAffected == 1 && updateUSDAffected == 1 && insertTransactionAffected == 1)
                    {
                        MessageBox.Show("Thank you, you successfully sell " + volume.ToString() + " " + selectCurrency + " for " + "$ " + string.Format("{0:N2}", cost), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    refresh_account_info(globalRootObject);
                    refresh_UI();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
            return true;
        }

        static string Query_update_Currency()
        {
            return @"UPDATE Account SET Balance = @BalanceCurrency FROM Account WHERE Email = @Email AND Currency = @Currency";
        }

        static string Query_update_USD()
        {
            return @"UPDATE Account SET Balance = @BalanceUSD FROM Account WHERE Email = @Email AND Currency =  'USD'";
        }

        static string Query_insert_transaction()
        {
            return @"INSERT INTO Transactions (Email, Currency, Volume, Price, Cost, RecordDatetime, RecordType) VALUES (@Email, @Currency, @Volume, @Price, @Cost, @RecordDatetime, @RecordType)";
        }

        private void InvestorSellCurrency_FormClosing(object sender, FormClosingEventArgs e)
        {
            InvestorDashboard ID = new InvestorDashboard(globalUsername, globalEmail, prior);
            ID.Show();
        }
    }
}

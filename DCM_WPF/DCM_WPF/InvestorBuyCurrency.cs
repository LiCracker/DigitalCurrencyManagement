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
    public partial class InvestorBuyCurrency : Form
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

        public InvestorBuyCurrency(string username, string email)
        {
            InitializeComponent();
            globalUsername = username;
            globalEmail = email;
        }

        private async void InvestorBuyCurrency_Load(object sender, EventArgs e)
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

            if (!button_BTC.Enabled)
            {
                CurrencyPrice1.Text = "$ " + string.Format("{0:N2}", globalRootObject.BTC.USD);
                CurrencyPrice2.Text = "$ " + string.Format("{0:N2}", globalRootObject.BTC.USD);

                CurrencyAmount.Text = BTC_amount.ToString();
                CurrencyAmountUSD.Text = "$ " + string.Format("{0:N2}", BTC_amount_USD);
            }
            else if (!button_ETH.Enabled)
            {
                CurrencyPrice1.Text = "$ " + string.Format("{0:N2}", globalRootObject.ETH.USD);
                CurrencyPrice2.Text = "$ " + string.Format("{0:N2}", globalRootObject.ETH.USD);

                CurrencyAmount.Text = ETH_amount.ToString();
                CurrencyAmountUSD.Text = "$ " + string.Format("{0:N2}", ETH_amount_USD);
            }
            else if (!button_LTC.Enabled)
            {
                CurrencyPrice1.Text = "$ " + string.Format("{0:N2}", globalRootObject.LTC.USD);
                CurrencyPrice2.Text = "$ " + string.Format("{0:N2}", globalRootObject.LTC.USD);

                CurrencyAmount.Text = LTC_amount.ToString();
                CurrencyAmountUSD.Text = "$ " + string.Format("{0:N2}", LTC_amount_USD);
            }
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
        }
    }
}

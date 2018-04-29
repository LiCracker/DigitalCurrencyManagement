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
    public partial class InvestorUSDManager : Form
    {
        private string globalUsername;
        private string globalEmail;
        private SqlConnectionStringBuilder cb;

        private double deposit_limit = 50000;
        private double USD_amount = 0;

        private string linkedBank = "";
        private string linkedAccount = "";

        private double deposit_volume = 0.0;
        private double withdraw_volume = 0.0;

        public InvestorUSDManager(string username, string email)
        {
            InitializeComponent();
            globalUsername = username;
            globalEmail = email;
        }

        private void InvestorUSDManager_Load(object sender, EventArgs e)
        {
            cb = new SqlConnectionStringBuilder();
            cb.DataSource = "dcm01.database.windows.net";
            cb.UserID = "serverAdmin";
            cb.Password = "Admin123456";
            cb.InitialCatalog = "DCMdb";

            refresh_account_info();
        }

        private void refresh_account_info()
        {
            string getAccountTxt = Query_get_accounts();
            string getLinkedBankTxt = Query_get_linkedBank();

            using (SqlConnection connection = new SqlConnection(cb.ConnectionString))
            {
                SqlCommand getAccountCommand = new SqlCommand(getAccountTxt, connection);
                getAccountCommand.Parameters.AddWithValue("@Email", globalEmail);

                SqlCommand getLinkedBankCommand = new SqlCommand(getLinkedBankTxt, connection);
                getLinkedBankCommand.Parameters.AddWithValue("@Email", globalEmail);

                try
                {
                    connection.Open();
                    SqlDataReader reader = getAccountCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        string currency = reader[0].ToString();
                        double balance = (double)reader[1];
                        if (currency.Equals("USD"))
                        {
                            USD_amount = balance;
                            USDAmount.Text = "$ " + string.Format("{0:N2}", USD_amount);
                            label13.Text = "(limit " + "$ " + string.Format("{0:N2}", USD_amount) + ")";
                        }
                    }
                    reader.Close();

                    SqlDataReader reader_bank = getLinkedBankCommand.ExecuteReader();
                    while (reader_bank.Read())
                    {
                        linkedBank = reader_bank[0].ToString();
                        linkedAccount = reader_bank[1].ToString();
                        label6.Text = linkedBank + ", No: " + linkedAccount;
                        label8.Text = linkedBank + ", No: " + linkedAccount;
                    }
                    reader_bank.Close();

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
            return @"SELECT Currency, Balance FROM Account WHERE Email = @Email AND Currency = 'USD'";
        }

        static string Query_get_linkedBank()
        {
            return @"SELECT LinkedBank, LinkedAccount FROM Investor WHERE Email = @Email";
        }

        private void textBox_deposit_TextChanged(object sender, EventArgs e)
        {
            if (System.Double.TryParse(textBox_deposit.Text, out deposit_volume))
            {
                if (deposit_volume >= 0.0 && deposit_volume <= deposit_limit)
                {
                    
                }
                else
                {
                    MessageBox.Show("Deposit volume should more than zero and less than deposit limit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_deposit.Text = "0.00";
                    deposit_volume = 0.00;
                }
            }
            else
            {
                MessageBox.Show("Please input valid volume!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_deposit_confirm_Click(object sender, EventArgs e)
        {
            if (System.Double.TryParse(textBox_deposit.Text, out deposit_volume))
            {
                if (deposit_volume > 0.0 && deposit_volume <= deposit_limit)
                {
                    double update_USD_volume = USD_amount + deposit_volume;
                    string updateUSDTxt = Query_deposit();
                    string insertTransantionTxt = Query_insert_transaction();

                    DateTime dateTimeVariable = DateTime.Now;
                    string type = "deposit";

                    using (SqlConnection connection = new SqlConnection(cb.ConnectionString))
                    {
                        SqlCommand updateUSDCommand = new SqlCommand(updateUSDTxt, connection);
                        updateUSDCommand.Parameters.AddWithValue("@BalanceUSD", update_USD_volume);
                        updateUSDCommand.Parameters.AddWithValue("@Email", globalEmail);

                        SqlCommand insertTransactionCommand = new SqlCommand(insertTransantionTxt, connection);
                        insertTransactionCommand.Parameters.AddWithValue("@Email", globalEmail);
                        insertTransactionCommand.Parameters.AddWithValue("@Currency", "USD");
                        insertTransactionCommand.Parameters.AddWithValue("@Volume", deposit_volume);
                        insertTransactionCommand.Parameters.AddWithValue("@Price", 0);
                        insertTransactionCommand.Parameters.AddWithValue("@Cost", 0);
                        insertTransactionCommand.Parameters.AddWithValue("@RecordDatetime", dateTimeVariable);
                        insertTransactionCommand.Parameters.AddWithValue("@RecordType", type);

                        try
                        {
                            connection.Open();
                            int updateUSDAffected = updateUSDCommand.ExecuteNonQuery();
                            int insertTransactionAffected = insertTransactionCommand.ExecuteNonQuery();

                            if (updateUSDAffected == 1 && insertTransactionAffected == 1)
                            {
                                MessageBox.Show("Thank you, you successfully deposit $ " + string.Format("{0:N2}", deposit_volume), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            refresh_account_info();

                            textBox_deposit.Text = "0.00";
                            deposit_volume = 0.00;
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
                else
                {
                    MessageBox.Show("Deposit volume should more than zero and less than deposit limit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_deposit.Text = "0.00";
                    deposit_volume = 0.00;
                }
            }
            else
            {
                MessageBox.Show("Please input valid volume!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static string Query_deposit()
        {
            return @"UPDATE Account SET Balance = @BalanceUSD FROM Account WHERE Email = @Email AND Currency =  'USD'";
        }

        static string Query_insert_transaction()
        {
            return @"INSERT INTO Transactions (Email, Currency, Volume, Price, Cost, RecordDatetime, RecordType) VALUES (@Email, @Currency, @Volume, @Price, @Cost, @RecordDatetime, @RecordType)";
        }

        private void InvestorUSDManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            InvestorDashboard ID = new InvestorDashboard(globalUsername, globalEmail);
            ID.Show();
        }

        private void button_deposit_Click(object sender, EventArgs e)
        {
            groupBox_deposit.Enabled = true;
            groupBox_withdraw.Enabled = false;
            button_deposit.Enabled = false;
            button_withdraw.Enabled = true;
        }

        private void button_withdraw_Click(object sender, EventArgs e)
        {
            groupBox_deposit.Enabled = false;
            groupBox_withdraw.Enabled = true;
            button_deposit.Enabled = true;
            button_withdraw.Enabled = false;
        }

        private void button_withdraw_confirm_Click(object sender, EventArgs e)
        {
            if (System.Double.TryParse(textBox_withdraw.Text, out withdraw_volume))
            {
                if (withdraw_volume > 0.0 && withdraw_volume <= USD_amount)
                {
                    double update_USD_volume = USD_amount - withdraw_volume;
                    string updateUSDTxt = Query_withdraw();
                    string insertTransantionTxt = Query_insert_transaction();

                    DateTime dateTimeVariable = DateTime.Now;
                    string type = "withdraw";

                    using (SqlConnection connection = new SqlConnection(cb.ConnectionString))
                    {
                        SqlCommand updateUSDCommand = new SqlCommand(updateUSDTxt, connection);
                        updateUSDCommand.Parameters.AddWithValue("@BalanceUSD", update_USD_volume);
                        updateUSDCommand.Parameters.AddWithValue("@Email", globalEmail);

                        SqlCommand insertTransactionCommand = new SqlCommand(insertTransantionTxt, connection);
                        insertTransactionCommand.Parameters.AddWithValue("@Email", globalEmail);
                        insertTransactionCommand.Parameters.AddWithValue("@Currency", "USD");
                        insertTransactionCommand.Parameters.AddWithValue("@Volume", withdraw_volume);
                        insertTransactionCommand.Parameters.AddWithValue("@Price", 0);
                        insertTransactionCommand.Parameters.AddWithValue("@Cost", 0);
                        insertTransactionCommand.Parameters.AddWithValue("@RecordDatetime", dateTimeVariable);
                        insertTransactionCommand.Parameters.AddWithValue("@RecordType", type);

                        try
                        {
                            connection.Open();
                            int updateUSDAffected = updateUSDCommand.ExecuteNonQuery();
                            int insertTransactionAffected = insertTransactionCommand.ExecuteNonQuery();

                            if (updateUSDAffected == 1 && insertTransactionAffected == 1)
                            {
                                MessageBox.Show("Thank you, you successfully withdraw $ " + string.Format("{0:N2}", withdraw_volume), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            refresh_account_info();

                            textBox_withdraw.Text = "0.00";
                            withdraw_volume = 0.00;
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
                else
                {
                    MessageBox.Show("Withdraw volume should more than zero and less than your account volume.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_deposit.Text = "0.00";
                    withdraw_volume = 0.00;
                }
            }
            else
            {
                MessageBox.Show("Please input valid volume!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static string Query_withdraw()
        {
            return @"UPDATE Account SET Balance = @BalanceUSD FROM Account WHERE Email = @Email AND Currency =  'USD'";
        }

        private void textBox_withdraw_TextChanged(object sender, EventArgs e)
        {
            if (System.Double.TryParse(textBox_withdraw.Text, out withdraw_volume))
            {
                if (withdraw_volume >= 0.0 && withdraw_volume <= USD_amount)
                {

                }
                else
                {
                    MessageBox.Show("Withdraw volume should more than zero and less than your account volume.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_deposit.Text = "0.00";
                    withdraw_volume = 0.00;
                }
            }
            else
            {
                MessageBox.Show("Please input valid volume!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

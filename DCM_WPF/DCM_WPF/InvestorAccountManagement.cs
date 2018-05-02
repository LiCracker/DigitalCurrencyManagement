using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime;
using System.Runtime.InteropServices;

namespace DCM_WPF
{
    public partial class InvestorAccountManagement : Form
    {
        private string globalUsername;
        private string globalEmail;
        private SqlConnectionStringBuilder cb;

        Login prior;

        public InvestorAccountManagement(string username, string email, Login L)
        {
            InitializeComponent();
            globalUsername = username;
            globalEmail = email;

            prior = L;
        }

        private void InvestorAccountManagement_Load(object sender, EventArgs e)
        {
            cb = new SqlConnectionStringBuilder();
            cb.DataSource = "dcm01.database.windows.net";
            cb.UserID = "serverAdmin";
            cb.Password = "Admin123456";
            cb.InitialCatalog = "DCMdb";

            textBox_Email.Text = globalEmail;
            textBox_Username.Text = globalUsername;
            getInfo();
            refresh_account_info();
            tableLayoutPanel1.Enabled = false;
            button2.Enabled = false;

        }

        private void getInfo()
        {
            string checkLoginTxt = Query_getInvestor();
            using (SqlConnection connection = new SqlConnection(cb.ConnectionString))
            {
                SqlCommand checkLoginCommand = new SqlCommand(checkLoginTxt, connection);
                checkLoginCommand.Parameters.AddWithValue("@Email", globalEmail);

                string password = "";
                string linkedBank = "";
                string linkedAccount = "";
                try
                {
                    connection.Open();
                    SqlDataReader reader = checkLoginCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        password = reader[0].ToString();
                        linkedBank = reader[1].ToString();
                        linkedAccount = reader[2].ToString();
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
                    textBox_Password.Text = Cryptography.Decrypt(password);
                    textBox_Password_Confirm.Text = textBox_Password.Text;
                    textBox_Linked_Bank.Text = linkedBank;
                    textBox_Bank_Account_Number.Text = linkedAccount;
                    connection.Close();
                }
            }
        }

        static string Query_getInvestor()
        {
            return @"SELECT Password, LinkedBank, LinkedAccount FROM Investor WHERE Email = @Email";
        }

        private void refresh_account_info()
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
                        string address = reader[2].ToString();
                        if (currency.Equals("BTC"))
                        {
                            BTC_Label.Text = balance.ToString();
                            BTC_Address_Label.Text = address;
                        }
                        else if (currency.Equals("ETH"))
                        {
                            ETH_Label.Text = balance.ToString();
                            ETH_Address_Label.Text = address;
                        }
                        else if (currency.Equals("LTC"))
                        {
                            LTC_Label.Text = balance.ToString();
                            LTC_Address_Label.Text = address;
                        }
                        else if (currency.Equals("USD"))
                        {
                            USD_Label.Text = balance.ToString();
                            USD_Address_Label.Text = address;
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
            return @"SELECT Currency, Balance, DigitalAddress FROM Account WHERE Email = @Email";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!tableLayoutPanel1.Enabled)
            {
                tableLayoutPanel1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                tableLayoutPanel1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void InvestorAccountManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            InvestorDashboard ID = new InvestorDashboard(globalUsername, globalEmail, prior);
            ID.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update_info();
        }

        private void update_info()
        {
            if (inputCorrect())
            {
                string investorUpdateTxt = Query_updateInvestor();

                using (SqlConnection connection = new SqlConnection(cb.ConnectionString))
                {
                    string email = textBox_Email.Text;
                    string username = textBox_Username.Text;
                    string password = textBox_Password.Text;
                    string linked_bank = textBox_Linked_Bank.Text;
                    string bank_account_number = textBox_Bank_Account_Number.Text;

                    SqlCommand investorSignupCommand = new SqlCommand(investorUpdateTxt, connection);
                    investorSignupCommand.Parameters.AddWithValue("@Email", email);
                    investorSignupCommand.Parameters.AddWithValue("@Password", Cryptography.Encrypt(password));
                    investorSignupCommand.Parameters.AddWithValue("@LinkedBank", linked_bank);
                    investorSignupCommand.Parameters.AddWithValue("@LinkedAccount", bank_account_number);

                    try
                    {
                        connection.Open();
                        int investorUpdateAffected = investorSignupCommand.ExecuteNonQuery();

                        if (investorUpdateAffected == 1)
                        {
                            MessageBox.Show("Thank you, you successfully update your info!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tableLayoutPanel1.Enabled = false;
                            button2.Enabled = false;
                        }
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
        }

        private bool inputCorrect()
        {
            if (textBox_Password.Text == "" || textBox_Password_Confirm.Text == "")
            {
                MessageBox.Show("Signup Failed. Please complete required fileds!", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBox_Password.Text.Equals(textBox_Password_Confirm.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Signup Failed. Input Password Not Matched!", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        static string Query_updateInvestor()
        {
            return @"UPDATE Investor SET Password = @Password, LinkedBank = @LinkedBank, LinkedAccount = @LinkedAccount WHERE Email = @Email";
        }
    }
}

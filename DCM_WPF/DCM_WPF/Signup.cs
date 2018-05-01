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
    public partial class Signup : Form
    {
        private SqlConnectionStringBuilder cb;
        Login prior;

        public Signup(Login lg)
        {
            InitializeComponent();
            prior = lg;
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            cb = new SqlConnectionStringBuilder();
            cb.DataSource = "dcm01.database.windows.net";
            cb.UserID = "serverAdmin";
            cb.Password = "Admin123456";
            cb.InitialCatalog = "DCMdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputCorrect())
            {
                string investorSignupTxt = Query_investorSignup();
                string accountSignupTxt = Query_accountSignup();

                using (SqlConnection connection = new SqlConnection(cb.ConnectionString))
                {
                    string email = textBox_Email.Text;
                    string username = textBox_Username.Text;
                    string password = textBox_Password.Text;
                    string linked_bank = textBox_Linked_Bank.Text;
                    string bank_account_number = textBox_Bank_Account_Number.Text;

                    SqlCommand investorSignupCommand = new SqlCommand(investorSignupTxt, connection);
                    investorSignupCommand.Parameters.AddWithValue("@Email", email);
                    investorSignupCommand.Parameters.AddWithValue("@Username", username);
                    investorSignupCommand.Parameters.AddWithValue("@Password", Cryptography.Encrypt(password));
                    investorSignupCommand.Parameters.AddWithValue("@LinkedBank", linked_bank);
                    investorSignupCommand.Parameters.AddWithValue("@LinkedAccount", bank_account_number);

                    double initial_balance = 0.0;
                    string digital_address_firstpart = Convert.ToInt64(DateTime.Now.Subtract(DateTime.MinValue.AddYears(1969)).TotalMilliseconds).ToString();

                    SqlCommand USDaccountSignupCommand = new SqlCommand(accountSignupTxt, connection);
                    USDaccountSignupCommand.Parameters.AddWithValue("Email", email);
                    USDaccountSignupCommand.Parameters.AddWithValue("Currency", "USD");
                    USDaccountSignupCommand.Parameters.AddWithValue("Balance", initial_balance);
                    USDaccountSignupCommand.Parameters.AddWithValue("DigitalAddress", digital_address_firstpart + "00");

                    SqlCommand BTCaccountSignupCommand = new SqlCommand(accountSignupTxt, connection);
                    BTCaccountSignupCommand.Parameters.AddWithValue("Email", email);
                    BTCaccountSignupCommand.Parameters.AddWithValue("Currency", "BTC");
                    BTCaccountSignupCommand.Parameters.AddWithValue("Balance", initial_balance);
                    BTCaccountSignupCommand.Parameters.AddWithValue("DigitalAddress", digital_address_firstpart + "01");

                    SqlCommand ETHaccountSignupCommand = new SqlCommand(accountSignupTxt, connection);
                    ETHaccountSignupCommand.Parameters.AddWithValue("Email", email);
                    ETHaccountSignupCommand.Parameters.AddWithValue("Currency", "ETH");
                    ETHaccountSignupCommand.Parameters.AddWithValue("Balance", initial_balance);
                    ETHaccountSignupCommand.Parameters.AddWithValue("DigitalAddress", digital_address_firstpart + "02");

                    SqlCommand LTCaccountSignupCommand = new SqlCommand(accountSignupTxt, connection);
                    LTCaccountSignupCommand.Parameters.AddWithValue("Email", email);
                    LTCaccountSignupCommand.Parameters.AddWithValue("Currency", "LTC");
                    LTCaccountSignupCommand.Parameters.AddWithValue("Balance", initial_balance);
                    LTCaccountSignupCommand.Parameters.AddWithValue("DigitalAddress", digital_address_firstpart + "03");

                    try
                    {
                        connection.Open();
                        int investorSignupAffected = investorSignupCommand.ExecuteNonQuery();
                        int USDsignupAffected = USDaccountSignupCommand.ExecuteNonQuery();
                        int BTCsignupAffected = BTCaccountSignupCommand.ExecuteNonQuery();
                        int ETHsignupAffected = ETHaccountSignupCommand.ExecuteNonQuery();
                        int LTCsignupAffected = LTCaccountSignupCommand.ExecuteNonQuery();

                        if (investorSignupAffected == 1 && USDsignupAffected == 1 && BTCsignupAffected == 1 && ETHsignupAffected == 1 && LTCsignupAffected == 1)
                        {
                            MessageBox.Show("Thank you, you successfully signup Username: " + textBox_Username.Text + ", Password: " + textBox_Password.Text + ", Email: " + textBox_Email.Text + "!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
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

        static string Query_investorSignup()
        {
            return @"INSERT INTO Investor (Email, Username, Password, LinkedBank, LinkedAccount) VALUES (@Email, @Username, @Password, @LinkedBank, @LinkedAccount)";
        }

        static string Query_accountSignup()
        {
            return @"INSERT INTO Account (Email, Currency, Balance, DigitalAddress) VALUES (@Email, @Currency, @Balance, @DigitalAddress)";
        }

        private bool inputCorrect()
        {
            if (textBox_Email.Text == "" || textBox_Email_Confirm.Text == "" || textBox_Password.Text == "" || textBox_Password_Confirm.Text == "" || textBox_Username.Text == "")
            {
                MessageBox.Show("Signup Failed. Please complete required fileds!", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBox_Email.Text.Equals(textBox_Email_Confirm.Text))
            {
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
            else
            {
                MessageBox.Show("Signup Failed. Input Email Not Matched!", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            prior.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

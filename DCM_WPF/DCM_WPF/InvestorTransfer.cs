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
    public partial class InvestorTransfer : Form
    {
        private string globalUsername;
        private string globalEmail;
        private SqlConnectionStringBuilder cb;

        Login prior;

        string selectedCurrency = "";

        double BTC_MAX = 0.0;
        double ETH_MAX = 0.0;
        double LTC_MAX = 0.0;

        public InvestorTransfer(string username, string email, Login L)
        {
            InitializeComponent();
            globalUsername = username;
            globalEmail = email;

            prior = L;
        }

        private void InvestorTransfer_Load(object sender, EventArgs e)
        {
            cb = new SqlConnectionStringBuilder();
            cb.DataSource = "dcm01.database.windows.net";
            cb.UserID = "serverAdmin";
            cb.Password = "Admin123456";
            cb.InitialCatalog = "DCMdb";

            groupBox_Find_Email.Enabled = false;
            groupBox_Find_Username.Enabled = false;
            groupBox_Make_Transfer.Enabled = false;

            textBox_sender_email.Text = globalEmail;
            textBox_sender_username.Text = globalUsername;

            refresh_account_info();
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
                            BTC_MAX = balance;
                            BTC_Label.Text = balance.ToString();
                            BTC_Address_Label.Text = address;
                        }
                        else if (currency.Equals("ETH"))
                        {
                            ETH_MAX = balance;
                            ETH_Label.Text = balance.ToString();
                            ETH_Address_Label.Text = address;
                        }
                        else if (currency.Equals("LTC"))
                        {
                            LTC_MAX = balance;
                            LTC_Label.Text = balance.ToString();
                            LTC_Address_Label.Text = address;
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

        private void button_BTC_Click(object sender, EventArgs e)
        {
            groupBox_Find_Email.Enabled = true;
            groupBox_Find_Username.Enabled = true;
            groupBox_Make_Transfer.Enabled = false;

            button_BTC.Enabled = false;
            button_ETH.Enabled = true;
            button_LTC.Enabled = true;

            selectedCurrency = "BTC";
            textBox_Currency.Text = "BTC";

            textBox_Sender_Address.Text = BTC_Address_Label.Text;
        }

        private void button_ETH_Click(object sender, EventArgs e)
        {
            groupBox_Find_Email.Enabled = true;
            groupBox_Find_Username.Enabled = true;
            groupBox_Make_Transfer.Enabled = false;

            button_BTC.Enabled = true;
            button_ETH.Enabled = false;
            button_LTC.Enabled = true;

            selectedCurrency = "ETH";
            textBox_Currency.Text = "ETH";

            textBox_Sender_Address.Text = ETH_Address_Label.Text;
        }

        private void button_LTC_Click(object sender, EventArgs e)
        {
            groupBox_Find_Email.Enabled = true;
            groupBox_Find_Username.Enabled = true;
            groupBox_Make_Transfer.Enabled = false;

            button_BTC.Enabled = true;
            button_ETH.Enabled = true;
            button_LTC.Enabled = false;

            selectedCurrency = "LTC";
            textBox_Currency.Text = "LTC";

            textBox_Sender_Address.Text = LTC_Address_Label.Text;
        }

        private void button_search_email_Click(object sender, EventArgs e)
        {
            cleanReceiver();
            if (!textBox_by_email.Text.Equals("") && !textBox_by_email.Text.Equals(globalEmail))
            {
                findAddressByEmail(textBox_by_email.Text);
                textBox_by_username.Text = "";
            }
        }

        private void findAddressByEmail(string email)
        {
            string getAddressByEmailTxt = Query_find_by_email();
            using (SqlConnection connection = new SqlConnection(cb.ConnectionString))
            {
                SqlCommand getAddressByEmail = new SqlCommand(getAddressByEmailTxt, connection);
                getAddressByEmail.Parameters.AddWithValue("@Email", email);
                getAddressByEmail.Parameters.AddWithValue("@Currency", selectedCurrency);

                try
                {
                    connection.Open();
                    SqlDataReader reader = getAddressByEmail.ExecuteReader();
                    while (reader.Read())
                    {
                        string output_username = reader[0].ToString();
                        string output_email = reader[1].ToString();
                        string output_address = reader[2].ToString();

                        if (output_address != "")
                        {
                            textBox_receiver_username.Text = output_username;
                            textBox_receiver_email.Text = output_email;
                            textBox_Receiver_Address.Text = output_address;
                            groupBox_Make_Transfer.Enabled = true;
                        }
                        else
                        {
                            cleanReceiver();
                            MessageBox.Show("Sorry, cannot find receiver, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        static string Query_find_by_email()
        {
            return @"SELECT Username, Email, DigitalAddress FROM FindDigitalAddress WHERE Email = @Email AND Currency = @Currency";
        }

        private void button_search_username_Click(object sender, EventArgs e)
        {
            cleanReceiver();
            if (!textBox_by_username.Text.Equals("") && !textBox_by_username.Text.Equals(globalUsername))
            {
                findAddressByUsername(textBox_by_username.Text);
                textBox_by_email.Text = "";
            }
        }

        private void findAddressByUsername(string username)
        {
            string getAddressByUsernameTxt = Query_find_by_username();
            using (SqlConnection connection = new SqlConnection(cb.ConnectionString))
            {
                SqlCommand getAddressByUsername = new SqlCommand(getAddressByUsernameTxt, connection);
                getAddressByUsername.Parameters.AddWithValue("@Username", username);
                getAddressByUsername.Parameters.AddWithValue("@Currency", selectedCurrency);

                try
                {
                    connection.Open();
                    SqlDataReader reader = getAddressByUsername.ExecuteReader();
                    while (reader.Read())
                    {
                        string output_username = reader[0].ToString();
                        string output_email = reader[1].ToString();
                        string output_address = reader[2].ToString();

                        if (output_address != "")
                        {
                            textBox_receiver_username.Text = output_username;
                            textBox_receiver_email.Text = output_email;
                            textBox_Receiver_Address.Text = output_address;
                            groupBox_Make_Transfer.Enabled = true;
                        }
                        else
                        {
                            cleanReceiver();
                            MessageBox.Show("Sorry, cannot find receiver, please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        static string Query_find_by_username()
        {
            return @"SELECT Username, Email, DigitalAddress FROM FindDigitalAddress WHERE Username = @Username AND Currency = @Currency";
        }

        private void cleanReceiver()
        {
            textBox_receiver_username.Text = "";
            textBox_receiver_email.Text = "";
            textBox_Receiver_Address.Text = "";
        }

        private void InvestorTransfer_FormClosing(object sender, FormClosingEventArgs e)
        {
            InvestorDashboard ID = new InvestorDashboard(globalUsername, globalEmail, prior);
            ID.Show();
        }

        private void button_make_transfer_Click(object sender, EventArgs e)
        {

        }
    }
}

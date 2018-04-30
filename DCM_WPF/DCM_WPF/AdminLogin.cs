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
    public partial class AdminLogin : Form
    {
        Login prior;
        public AdminLogin(Login lg)
        {
            InitializeComponent();
            prior = lg;
        }

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(int Description, int ReservedValue);

        private SqlConnectionStringBuilder cb;

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            cb = new SqlConnectionStringBuilder();
            cb.DataSource = "dcm01.database.windows.net";
            cb.UserID = "serverAdmin";
            cb.Password = "Admin123456";
            cb.InitialCatalog = "DCMdb";

            using (SqlConnection connection = new SqlConnection(cb.ConnectionString))
            {
                try
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open && IsConnectInternet())
                    {
                        label5.Text = "Internet: [Connected] | Database: [Connected]";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message);
                    this.Close();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public static bool IsConnectInternet()
        {
            int Description = 0;
            return InternetGetConnectedState(Description, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkLoginTxt = Query_checkLogin();
            using (SqlConnection connection = new SqlConnection(cb.ConnectionString))
            {
                SqlCommand checkLoginCommand = new SqlCommand(checkLoginTxt, connection);
                checkLoginCommand.Parameters.AddWithValue("@Username", textBox1.Text);
                checkLoginCommand.Parameters.AddWithValue("@Password", textBox2.Text);

                string result = null;
                try
                {
                    connection.Open();
                    SqlDataReader reader = checkLoginCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        result = reader[0].ToString();
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
                    if (result == null)
                    {
                        MessageBox.Show("Login failed! Please check your username and password!", "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Login complete! Welcome back, " + textBox1.Text, "Login Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminDashboard AD = new AdminDashboard(this);
                        AD.Show();
                        this.Hide();
                    }
                }
            }
        }

        static string Query_checkLogin()
        {
            return @"SELECT Email FROM Admin WHERE Username = @Username AND Password = @Password";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            prior.Show();
            this.Close();
        }
    }
}

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
    public partial class AdminSignup : Form
    {
        private SqlConnectionStringBuilder cb;
        AdminLogin prior;

        public AdminSignup(AdminLogin AL)
        {
            InitializeComponent();
            prior = AL;
        }

        private void AdminSignup_Load(object sender, EventArgs e)
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
                string adminSignupTxt = Query_adminSignup();

                using (SqlConnection connection = new SqlConnection(cb.ConnectionString))
                {
                    string email = textBox_Email.Text;
                    string username = textBox_Username.Text;
                    string password = textBox_Password.Text;

                    SqlCommand adminSignupCommand = new SqlCommand(adminSignupTxt, connection);
                    adminSignupCommand.Parameters.AddWithValue("@Email", email);
                    adminSignupCommand.Parameters.AddWithValue("@Username", username);
                    adminSignupCommand.Parameters.AddWithValue("@Password", Cryptography.Encrypt(password));

                    try
                    {
                        connection.Open();
                        int adminSignupAffected = adminSignupCommand.ExecuteNonQuery();

                        if (adminSignupAffected == 1)
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

        static string Query_adminSignup()
        {
            return @"INSERT INTO Admin (Email, Username, Password) VALUES (@Email, @Username, @Password)";
        }

        private bool inputCorrect()
        {
            if (!textBox_invite.Text.Equals("cmpe226"))
            {
                MessageBox.Show("Signup Failed. Please input the correct invite code!", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminSignup_FormClosing(object sender, FormClosingEventArgs e)
        {
            prior.Show();
        }
    }
}

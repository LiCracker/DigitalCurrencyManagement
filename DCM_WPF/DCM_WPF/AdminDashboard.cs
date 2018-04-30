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
    public partial class AdminDashboard : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter1 = new SqlDataAdapter();

        private BindingSource bindingSource2 = new BindingSource();
        private SqlDataAdapter dataAdapter2 = new SqlDataAdapter();

        private BindingSource bindingSource5 = new BindingSource();
        private SqlDataAdapter dataAdapter5 = new SqlDataAdapter();

        private SqlConnectionStringBuilder cb;

        AdminLogin prior;

        public AdminDashboard(AdminLogin AL)
        {
            InitializeComponent();
            prior = AL;
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            this.accountTableAdapter.Fill(this.dCMdbDataSet.Account);
            this.investorTableAdapter.Fill(this.dCMdbDataSet.Investor);

            cb = new SqlConnectionStringBuilder();
            cb.DataSource = "dcm01.database.windows.net";
            cb.UserID = "serverAdmin";
            cb.Password = "Admin123456";
            cb.InitialCatalog = "DCMdb";

            dataGridView1.DataSource = bindingSource1;
            string query1 = Query_get_recentBuySell();
            GetBuySellData(query1);
            dataGridView1.ClearSelection();

            dataGridView2.DataSource = bindingSource2;
            string query2 = Query_get_recentDepositWithdraw();
            GetDepositWithdrawData(query2);
            dataGridView2.ClearSelection();

            dataGridView5.DataSource = bindingSource5;
            string query5 = Query_get_recentTransfers();
            GetRecentTransfers(query5);
            dataGridView3.ClearSelection();

            GetIncome();
        }

        private void GetIncome()
        {
            string getIncomeTxt = Query_get_income();
            using (SqlConnection connection = new SqlConnection(cb.ConnectionString))
            {
                SqlCommand getAccountCommand = new SqlCommand(getIncomeTxt, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = getAccountCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        double income = Convert.ToDouble(reader[0]);
                        label2.Text = "$ " + string.Format("{0:N2}", income);
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

        static string Query_get_income()
        {
            return @"SELECT COUNT(*) * 3 FROM Transactions WHERE RecordType = 'buy'";
        }

        private void GetBuySellData(string selectCommand)
        {
            try
            {
                String connectionString = cb.ConnectionString;

                // Create a new data adapter based on the specified query.
                dataAdapter1 = new SqlDataAdapter(selectCommand, connectionString);

                // These are used to update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter1);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter1.Fill(table);
                bindingSource1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        static string Query_get_recentBuySell()
        {
            return "SELECT Email, Currency, Volume, Price, Cost, RecordDateTime, RecordType FROM Transactions WHERE RecordType IN ('buy', 'sell') ORDER BY RecordDateTime DESC";
        }

        private void GetDepositWithdrawData(string selectCommand)
        {
            try
            {
                String connectionString = cb.ConnectionString;

                // Create a new data adapter based on the specified query.
                dataAdapter2 = new SqlDataAdapter(selectCommand, connectionString);

                // These are used to update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter2);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter2.Fill(table);
                bindingSource2.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        static string Query_get_recentDepositWithdraw()
        {
            return "SELECT Email, Currency, Volume, Price, Cost, RecordDateTime, RecordType FROM Transactions WHERE RecordType IN ('deposit', 'withdraw') ORDER BY RecordDateTime DESC";
        }

        private void GetRecentTransfers(string selectCommand)
        {
            try
            {
                String connectionString = cb.ConnectionString;

                // Create a new data adapter based on the specified query.
                dataAdapter5 = new SqlDataAdapter(selectCommand, connectionString);

                // These are used to update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter5);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter5.Fill(table);
                bindingSource5.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        static string Query_get_recentTransfers()
        {
            return "SELECT * FROM RecentTransferActivities ORDER BY RecordDatetime DESC";
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            prior.Show();
        }
    }
}

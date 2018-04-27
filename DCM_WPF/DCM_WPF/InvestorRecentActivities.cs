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
    public partial class InvestorRecentActivities : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private SqlDataAdapter dataAdapter1 = new SqlDataAdapter();

        private BindingSource bindingSource2 = new BindingSource();
        private SqlDataAdapter dataAdapter2 = new SqlDataAdapter();

        private string globalUsername;
        private string globalEmail;
        private SqlConnectionStringBuilder cb;

        public InvestorRecentActivities(string username, string email)
        {
            InitializeComponent();
            globalUsername = username;
            globalEmail = email;
        }

        private void InvestorRecentActivities_Load(object sender, EventArgs e)
        {
            cb = new SqlConnectionStringBuilder();
            cb.DataSource = "dcm01.database.windows.net";
            cb.UserID = "serverAdmin";
            cb.Password = "Admin123456";
            cb.InitialCatalog = "DCMdb";

            dataGridView1.DataSource = bindingSource1;
            string query1 = Query_get_recentBuySell(globalEmail);
            GetBuySellData(query1);
            dataGridView1.ClearSelection();

            dataGridView2.DataSource = bindingSource2;
            string query2 = Query_get_recentDepositWithdraw(globalEmail);
            GetDepositWithdrawData(query2);
            dataGridView2.ClearSelection();
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

        static string Query_get_recentBuySell(string globalEmail)
        {
            return "SELECT Currency, Volume, Price, Cost, RecordDateTime, RecordType FROM Transactions WHERE Email = '"+ globalEmail + "' AND RecordType IN ('buy', 'sell') ORDER BY RecordDateTime DESC";
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

        static string Query_get_recentDepositWithdraw(string globalEmail)
        {
            return "SELECT Currency, Volume, Price, Cost, RecordDateTime, RecordType FROM Transactions WHERE Email = '" + globalEmail + "' AND RecordType IN ('deposit', 'withdraw') ORDER BY RecordDateTime DESC";
        }

        private void InvestorRecentActivities_FormClosing(object sender, FormClosingEventArgs e)
        {
            InvestorDashboard ID = new InvestorDashboard(globalUsername, globalEmail);
            ID.Show();
        }
    }
}

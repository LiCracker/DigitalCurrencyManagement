namespace DCM_WPF
{
    partial class InvestorBuyCurrency
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox_selected_currency = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_LTC = new System.Windows.Forms.Button();
            this.button_ETH = new System.Windows.Forms.Button();
            this.button_BTC = new System.Windows.Forms.Button();
            this.groupBox_price = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CurrencyPrice1 = new System.Windows.Forms.Label();
            this.CurrencyName1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrencyName3 = new System.Windows.Forms.Label();
            this.USDAmount = new System.Windows.Forms.Label();
            this.CurrencyAmount = new System.Windows.Forms.Label();
            this.USDAmountUSD = new System.Windows.Forms.Label();
            this.CurrencyAmountUSD = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox_accounts = new System.Windows.Forms.GroupBox();
            this.groupBox_buy = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Unlock = new System.Windows.Forms.Button();
            this.button_Lock = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.CurrencyPrice2 = new System.Windows.Forms.TextBox();
            this.CurrencyName2 = new System.Windows.Forms.Label();
            this.groupBox_confirm = new System.Windows.Forms.GroupBox();
            this.button_Confirm_Purchase = new System.Windows.Forms.Button();
            this.timerRefreshPrices = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox_selected_currency.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_price.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox_accounts.SuspendLayout();
            this.groupBox_buy.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox_confirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(837, 42);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(4, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(494, 40);
            this.label7.TabIndex = 1;
            this.label7.Text = "Digital Currency Management System";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Arial", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(505, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(328, 40);
            this.label10.TabIndex = 2;
            this.label10.Text = "Buy Currency";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_selected_currency
            // 
            this.groupBox_selected_currency.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_selected_currency.Enabled = false;
            this.groupBox_selected_currency.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox_selected_currency.Location = new System.Drawing.Point(12, 61);
            this.groupBox_selected_currency.Name = "groupBox_selected_currency";
            this.groupBox_selected_currency.Size = new System.Drawing.Size(837, 100);
            this.groupBox_selected_currency.TabIndex = 5;
            this.groupBox_selected_currency.TabStop = false;
            this.groupBox_selected_currency.Text = "Select Currency";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button_LTC, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_ETH, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_BTC, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(823, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_LTC
            // 
            this.button_LTC.BackColor = System.Drawing.Color.GhostWhite;
            this.button_LTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_LTC.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LTC.Location = new System.Drawing.Point(551, 3);
            this.button_LTC.Name = "button_LTC";
            this.button_LTC.Size = new System.Drawing.Size(269, 48);
            this.button_LTC.TabIndex = 2;
            this.button_LTC.Text = "LTC";
            this.button_LTC.UseVisualStyleBackColor = false;
            this.button_LTC.Click += new System.EventHandler(this.button_LTC_Click);
            // 
            // button_ETH
            // 
            this.button_ETH.BackColor = System.Drawing.Color.Honeydew;
            this.button_ETH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ETH.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ETH.Location = new System.Drawing.Point(277, 3);
            this.button_ETH.Name = "button_ETH";
            this.button_ETH.Size = new System.Drawing.Size(268, 48);
            this.button_ETH.TabIndex = 1;
            this.button_ETH.Text = "ETH";
            this.button_ETH.UseVisualStyleBackColor = false;
            this.button_ETH.Click += new System.EventHandler(this.button_ETH_Click);
            // 
            // button_BTC
            // 
            this.button_BTC.BackColor = System.Drawing.Color.FloralWhite;
            this.button_BTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_BTC.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BTC.Location = new System.Drawing.Point(3, 3);
            this.button_BTC.Name = "button_BTC";
            this.button_BTC.Size = new System.Drawing.Size(268, 48);
            this.button_BTC.TabIndex = 0;
            this.button_BTC.Text = "BTC";
            this.button_BTC.UseVisualStyleBackColor = false;
            this.button_BTC.Click += new System.EventHandler(this.button_BTC_Click);
            // 
            // groupBox_price
            // 
            this.groupBox_price.Controls.Add(this.tableLayoutPanel10);
            this.groupBox_price.Enabled = false;
            this.groupBox_price.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox_price.Location = new System.Drawing.Point(12, 168);
            this.groupBox_price.Name = "groupBox_price";
            this.groupBox_price.Size = new System.Drawing.Size(279, 152);
            this.groupBox_price.TabIndex = 6;
            this.groupBox_price.TabStop = false;
            this.groupBox_price.Text = "Price";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(8, 24);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(271, 121);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Arial", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(3, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Last Update: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "(Refresh every 12 seconds)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.CurrencyPrice1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CurrencyName1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(265, 66);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // CurrencyPrice1
            // 
            this.CurrencyPrice1.AutoSize = true;
            this.CurrencyPrice1.BackColor = System.Drawing.Color.White;
            this.CurrencyPrice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrencyPrice1.Font = new System.Drawing.Font("Square721 BT", 10.2F);
            this.CurrencyPrice1.Location = new System.Drawing.Point(82, 0);
            this.CurrencyPrice1.Name = "CurrencyPrice1";
            this.CurrencyPrice1.Size = new System.Drawing.Size(180, 66);
            this.CurrencyPrice1.TabIndex = 2;
            this.CurrencyPrice1.Text = "0.00";
            this.CurrencyPrice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrencyName1
            // 
            this.CurrencyName1.AutoSize = true;
            this.CurrencyName1.BackColor = System.Drawing.Color.White;
            this.CurrencyName1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrencyName1.Font = new System.Drawing.Font("Square721 BT", 10.2F);
            this.CurrencyName1.Location = new System.Drawing.Point(3, 0);
            this.CurrencyName1.Name = "CurrencyName1";
            this.CurrencyName1.Size = new System.Drawing.Size(73, 66);
            this.CurrencyName1.TabIndex = 1;
            this.CurrencyName1.Text = "XXX";
            this.CurrencyName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.Controls.Add(this.label19, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label18, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.CurrencyName3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.USDAmount, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.CurrencyAmount, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.USDAmountUSD, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.CurrencyAmountUSD, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 24);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(540, 121);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label19.Location = new System.Drawing.Point(354, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(183, 24);
            this.label19.TabIndex = 12;
            this.label19.Text = "Equivalent USD";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label18.Location = new System.Drawing.Point(165, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(183, 24);
            this.label18.TabIndex = 11;
            this.label18.Text = "Holding Amount";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 49);
            this.label2.TabIndex = 5;
            this.label2.Text = "USD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrencyName3
            // 
            this.CurrencyName3.AutoSize = true;
            this.CurrencyName3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrencyName3.Font = new System.Drawing.Font("Arial", 10F);
            this.CurrencyName3.Location = new System.Drawing.Point(3, 24);
            this.CurrencyName3.Name = "CurrencyName3";
            this.CurrencyName3.Size = new System.Drawing.Size(156, 48);
            this.CurrencyName3.TabIndex = 4;
            this.CurrencyName3.Text = "XXX";
            this.CurrencyName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // USDAmount
            // 
            this.USDAmount.AutoSize = true;
            this.USDAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USDAmount.Font = new System.Drawing.Font("Arial", 10F);
            this.USDAmount.Location = new System.Drawing.Point(165, 72);
            this.USDAmount.Name = "USDAmount";
            this.USDAmount.Size = new System.Drawing.Size(183, 49);
            this.USDAmount.TabIndex = 7;
            this.USDAmount.Text = "0.00";
            this.USDAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrencyAmount
            // 
            this.CurrencyAmount.AutoSize = true;
            this.CurrencyAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrencyAmount.Font = new System.Drawing.Font("Arial", 10F);
            this.CurrencyAmount.Location = new System.Drawing.Point(165, 24);
            this.CurrencyAmount.Name = "CurrencyAmount";
            this.CurrencyAmount.Size = new System.Drawing.Size(183, 48);
            this.CurrencyAmount.TabIndex = 6;
            this.CurrencyAmount.Text = "0.00";
            this.CurrencyAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // USDAmountUSD
            // 
            this.USDAmountUSD.AutoSize = true;
            this.USDAmountUSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USDAmountUSD.Font = new System.Drawing.Font("Arial", 10F);
            this.USDAmountUSD.Location = new System.Drawing.Point(354, 72);
            this.USDAmountUSD.Name = "USDAmountUSD";
            this.USDAmountUSD.Size = new System.Drawing.Size(183, 49);
            this.USDAmountUSD.TabIndex = 9;
            this.USDAmountUSD.Text = "0.00";
            this.USDAmountUSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrencyAmountUSD
            // 
            this.CurrencyAmountUSD.AutoSize = true;
            this.CurrencyAmountUSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrencyAmountUSD.Font = new System.Drawing.Font("Arial", 10F);
            this.CurrencyAmountUSD.Location = new System.Drawing.Point(354, 24);
            this.CurrencyAmountUSD.Name = "CurrencyAmountUSD";
            this.CurrencyAmountUSD.Size = new System.Drawing.Size(183, 48);
            this.CurrencyAmountUSD.TabIndex = 8;
            this.CurrencyAmountUSD.Text = "0.00";
            this.CurrencyAmountUSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 24);
            this.label17.TabIndex = 10;
            this.label17.Text = "Account";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_accounts
            // 
            this.groupBox_accounts.Controls.Add(this.tableLayoutPanel4);
            this.groupBox_accounts.Enabled = false;
            this.groupBox_accounts.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox_accounts.Location = new System.Drawing.Point(297, 168);
            this.groupBox_accounts.Name = "groupBox_accounts";
            this.groupBox_accounts.Size = new System.Drawing.Size(552, 152);
            this.groupBox_accounts.TabIndex = 7;
            this.groupBox_accounts.TabStop = false;
            this.groupBox_accounts.Text = "Your Accounts";
            // 
            // groupBox_buy
            // 
            this.groupBox_buy.Controls.Add(this.tableLayoutPanel9);
            this.groupBox_buy.Controls.Add(this.tableLayoutPanel5);
            this.groupBox_buy.Enabled = false;
            this.groupBox_buy.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox_buy.Location = new System.Drawing.Point(12, 326);
            this.groupBox_buy.Name = "groupBox_buy";
            this.groupBox_buy.Size = new System.Drawing.Size(837, 151);
            this.groupBox_buy.TabIndex = 8;
            this.groupBox_buy.TabStop = false;
            this.groupBox_buy.Text = "Buy Currancy";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.button_Unlock, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.button_Lock, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(649, 35);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(179, 100);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // button_Unlock
            // 
            this.button_Unlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Unlock.Enabled = false;
            this.button_Unlock.Font = new System.Drawing.Font("Arial", 10.8F);
            this.button_Unlock.Location = new System.Drawing.Point(3, 53);
            this.button_Unlock.Name = "button_Unlock";
            this.button_Unlock.Size = new System.Drawing.Size(173, 44);
            this.button_Unlock.TabIndex = 2;
            this.button_Unlock.Text = "Unlock";
            this.button_Unlock.UseVisualStyleBackColor = true;
            this.button_Unlock.Click += new System.EventHandler(this.button_Unlock_Click);
            // 
            // button_Lock
            // 
            this.button_Lock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Lock.Font = new System.Drawing.Font("Arial", 10.8F);
            this.button_Lock.Location = new System.Drawing.Point(3, 3);
            this.button_Lock.Name = "button_Lock";
            this.button_Lock.Size = new System.Drawing.Size(173, 44);
            this.button_Lock.TabIndex = 1;
            this.button_Lock.Text = "Lock";
            this.button_Lock.UseVisualStyleBackColor = true;
            this.button_Lock.Click += new System.EventHandler(this.button_Lock_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel5.Controls.Add(this.label8, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(8, 35);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(638, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 100);
            this.label8.TabIndex = 6;
            this.label8.Text = "=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 100);
            this.label3.TabIndex = 0;
            this.label3.Text = "Buy";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 100);
            this.label4.TabIndex = 2;
            this.label4.Text = "X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.textBox3, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(487, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(148, 94);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Arial", 10.8F);
            this.textBox3.Location = new System.Drawing.Point(3, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(142, 28);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 47);
            this.label9.TabIndex = 4;
            this.label9.Text = "USD Price";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(283, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(147, 94);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 47);
            this.label5.TabIndex = 3;
            this.label5.Text = "Volume";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Arial", 10.8F);
            this.textBox1.Location = new System.Drawing.Point(3, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0.00";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.CurrencyPrice2, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.CurrencyName2, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(79, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(147, 94);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // CurrencyPrice2
            // 
            this.CurrencyPrice2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrencyPrice2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyPrice2.Location = new System.Drawing.Point(3, 56);
            this.CurrencyPrice2.Name = "CurrencyPrice2";
            this.CurrencyPrice2.ReadOnly = true;
            this.CurrencyPrice2.Size = new System.Drawing.Size(141, 28);
            this.CurrencyPrice2.TabIndex = 5;
            this.CurrencyPrice2.Text = "0.00";
            // 
            // CurrencyName2
            // 
            this.CurrencyName2.AutoSize = true;
            this.CurrencyName2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrencyName2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyName2.Location = new System.Drawing.Point(3, 0);
            this.CurrencyName2.Name = "CurrencyName2";
            this.CurrencyName2.Size = new System.Drawing.Size(141, 47);
            this.CurrencyName2.TabIndex = 4;
            this.CurrencyName2.Text = "XXX Price";
            this.CurrencyName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_confirm
            // 
            this.groupBox_confirm.Controls.Add(this.label11);
            this.groupBox_confirm.Controls.Add(this.button_Confirm_Purchase);
            this.groupBox_confirm.Enabled = false;
            this.groupBox_confirm.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox_confirm.Location = new System.Drawing.Point(12, 484);
            this.groupBox_confirm.Name = "groupBox_confirm";
            this.groupBox_confirm.Size = new System.Drawing.Size(837, 98);
            this.groupBox_confirm.TabIndex = 9;
            this.groupBox_confirm.TabStop = false;
            this.groupBox_confirm.Text = "Confirm";
            // 
            // button_Confirm_Purchase
            // 
            this.button_Confirm_Purchase.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_Confirm_Purchase.Font = new System.Drawing.Font("Arial", 10.8F);
            this.button_Confirm_Purchase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Confirm_Purchase.Location = new System.Drawing.Point(8, 41);
            this.button_Confirm_Purchase.Name = "button_Confirm_Purchase";
            this.button_Confirm_Purchase.Size = new System.Drawing.Size(820, 51);
            this.button_Confirm_Purchase.TabIndex = 0;
            this.button_Confirm_Purchase.Text = "Confirm Buy";
            this.button_Confirm_Purchase.UseVisualStyleBackColor = false;
            this.button_Confirm_Purchase.Click += new System.EventHandler(this.button_Confirm_Purchase_Click);
            // 
            // timerRefreshPrices
            // 
            this.timerRefreshPrices.Tick += new System.EventHandler(this.timerRefreshPrices_Tick);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(5, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(262, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "($3.00 service fee for each transection)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InvestorBuyCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 594);
            this.Controls.Add(this.groupBox_confirm);
            this.Controls.Add(this.groupBox_buy);
            this.Controls.Add(this.groupBox_accounts);
            this.Controls.Add(this.groupBox_price);
            this.Controls.Add(this.groupBox_selected_currency);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "InvestorBuyCurrency";
            this.Text = "InvestorBuyCurrency";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InvestorBuyCurrency_FormClosing);
            this.Load += new System.EventHandler(this.InvestorBuyCurrency_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox_selected_currency.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_price.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox_accounts.ResumeLayout(false);
            this.groupBox_buy.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBox_confirm.ResumeLayout(false);
            this.groupBox_confirm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox_selected_currency;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_BTC;
        private System.Windows.Forms.Button button_LTC;
        private System.Windows.Forms.Button button_ETH;
        private System.Windows.Forms.GroupBox groupBox_price;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label CurrencyName1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CurrencyName3;
        private System.Windows.Forms.GroupBox groupBox_accounts;
        private System.Windows.Forms.GroupBox groupBox_buy;
        private System.Windows.Forms.Button button_Lock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label CurrencyName2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CurrencyPrice2;
        private System.Windows.Forms.Label CurrencyPrice1;
        private System.Windows.Forms.Label CurrencyAmount;
        private System.Windows.Forms.Label USDAmount;
        private System.Windows.Forms.Label CurrencyAmountUSD;
        private System.Windows.Forms.Label USDAmountUSD;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button button_Unlock;
        private System.Windows.Forms.GroupBox groupBox_confirm;
        private System.Windows.Forms.Button button_Confirm_Purchase;
        private System.Windows.Forms.Timer timerRefreshPrices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
    }
}
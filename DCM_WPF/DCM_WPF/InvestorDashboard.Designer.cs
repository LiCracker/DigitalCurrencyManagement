﻿namespace DCM_WPF
{
    partial class InvestorDashboard
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timerRefreshPrices = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.Total_USD_Label = new System.Windows.Forms.Label();
            this.USD_USD_Label = new System.Windows.Forms.Label();
            this.USD_Label = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.LTC_USD_Label = new System.Windows.Forms.Label();
            this.LTC_Label = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ETH_USD_Label = new System.Windows.Forms.Label();
            this.ETH_Label = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.BTC_USD_Label = new System.Windows.Forms.Label();
            this.BTC_Label = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 218);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.GhostWhite;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Square721 BT", 10.2F);
            this.label6.Location = new System.Drawing.Point(61, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 74);
            this.label6.TabIndex = 5;
            this.label6.Text = "(Updating...)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GhostWhite;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Square721 BT", 10.2F);
            this.label5.Location = new System.Drawing.Point(3, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 74);
            this.label5.TabIndex = 4;
            this.label5.Text = "LTC";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Square721 BT", 10.2F);
            this.label4.Location = new System.Drawing.Point(61, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 72);
            this.label4.TabIndex = 3;
            this.label4.Text = "(Updating...)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Honeydew;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Square721 BT", 10.2F);
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 72);
            this.label3.TabIndex = 2;
            this.label3.Text = "ETH";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Square721 BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 72);
            this.label2.TabIndex = 1;
            this.label2.Text = "(Updating...)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Square721 BT", 10.2F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "BTC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Arial", 9F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buy Currency";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(837, 42);
            this.tableLayoutPanel2.TabIndex = 3;
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
            this.label10.Location = new System.Drawing.Point(505, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(328, 40);
            this.label10.TabIndex = 2;
            this.label10.Text = "Welcome back";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.95238F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(241, 277);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Arial", 9F);
            this.label8.Location = new System.Drawing.Point(3, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Last Update: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label9.Location = new System.Drawing.Point(3, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "(Refresh every 12 seconds)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRefreshPrices
            // 
            this.timerRefreshPrices.Tick += new System.EventHandler(this.timerRefreshPrices_Tick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.Controls.Add(this.label28, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label27, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.Total_USD_Label, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.USD_USD_Label, 2, 4);
            this.tableLayoutPanel4.Controls.Add(this.USD_Label, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.label23, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.LTC_USD_Label, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.LTC_Label, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label20, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.ETH_USD_Label, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.ETH_Label, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.BTC_USD_Label, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.BTC_Label, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label12, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091073F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18215F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18215F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18215F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18215F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18033F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(473, 277);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Arial", 10F);
            this.label28.Location = new System.Drawing.Point(3, 225);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 52);
            this.label28.TabIndex = 17;
            this.label28.Text = "TOTAL";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Location = new System.Drawing.Point(97, 225);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(206, 52);
            this.label27.TabIndex = 16;
            this.label27.Text = "-";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Total_USD_Label
            // 
            this.Total_USD_Label.AutoSize = true;
            this.Total_USD_Label.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Total_USD_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Total_USD_Label.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_USD_Label.Location = new System.Drawing.Point(309, 225);
            this.Total_USD_Label.Name = "Total_USD_Label";
            this.Total_USD_Label.Size = new System.Drawing.Size(161, 52);
            this.Total_USD_Label.TabIndex = 15;
            this.Total_USD_Label.Text = "0.00";
            this.Total_USD_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // USD_USD_Label
            // 
            this.USD_USD_Label.AutoSize = true;
            this.USD_USD_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USD_USD_Label.Font = new System.Drawing.Font("Arial", 10F);
            this.USD_USD_Label.Location = new System.Drawing.Point(309, 175);
            this.USD_USD_Label.Name = "USD_USD_Label";
            this.USD_USD_Label.Size = new System.Drawing.Size(161, 50);
            this.USD_USD_Label.TabIndex = 14;
            this.USD_USD_Label.Text = "0.00";
            this.USD_USD_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // USD_Label
            // 
            this.USD_Label.AutoSize = true;
            this.USD_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USD_Label.Font = new System.Drawing.Font("Arial", 10F);
            this.USD_Label.Location = new System.Drawing.Point(97, 175);
            this.USD_Label.Name = "USD_Label";
            this.USD_Label.Size = new System.Drawing.Size(206, 50);
            this.USD_Label.TabIndex = 13;
            this.USD_Label.Text = "0.00";
            this.USD_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Arial", 10F);
            this.label23.Location = new System.Drawing.Point(3, 175);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 50);
            this.label23.TabIndex = 12;
            this.label23.Text = "USD";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LTC_USD_Label
            // 
            this.LTC_USD_Label.AutoSize = true;
            this.LTC_USD_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LTC_USD_Label.Font = new System.Drawing.Font("Arial", 10F);
            this.LTC_USD_Label.Location = new System.Drawing.Point(309, 125);
            this.LTC_USD_Label.Name = "LTC_USD_Label";
            this.LTC_USD_Label.Size = new System.Drawing.Size(161, 50);
            this.LTC_USD_Label.TabIndex = 11;
            this.LTC_USD_Label.Text = "0.00";
            this.LTC_USD_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LTC_Label
            // 
            this.LTC_Label.AutoSize = true;
            this.LTC_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LTC_Label.Font = new System.Drawing.Font("Arial", 10F);
            this.LTC_Label.Location = new System.Drawing.Point(97, 125);
            this.LTC_Label.Name = "LTC_Label";
            this.LTC_Label.Size = new System.Drawing.Size(206, 50);
            this.LTC_Label.TabIndex = 10;
            this.LTC_Label.Text = "0.00";
            this.LTC_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Arial", 10F);
            this.label20.Location = new System.Drawing.Point(3, 125);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 50);
            this.label20.TabIndex = 9;
            this.label20.Text = "LTC";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ETH_USD_Label
            // 
            this.ETH_USD_Label.AutoSize = true;
            this.ETH_USD_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ETH_USD_Label.Font = new System.Drawing.Font("Arial", 10F);
            this.ETH_USD_Label.Location = new System.Drawing.Point(309, 75);
            this.ETH_USD_Label.Name = "ETH_USD_Label";
            this.ETH_USD_Label.Size = new System.Drawing.Size(161, 50);
            this.ETH_USD_Label.TabIndex = 8;
            this.ETH_USD_Label.Text = "0.00";
            this.ETH_USD_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ETH_Label
            // 
            this.ETH_Label.AutoSize = true;
            this.ETH_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ETH_Label.Font = new System.Drawing.Font("Arial", 10F);
            this.ETH_Label.Location = new System.Drawing.Point(97, 75);
            this.ETH_Label.Name = "ETH_Label";
            this.ETH_Label.Size = new System.Drawing.Size(206, 50);
            this.ETH_Label.TabIndex = 7;
            this.ETH_Label.Text = "0.00";
            this.ETH_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Arial", 10F);
            this.label17.Location = new System.Drawing.Point(3, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 50);
            this.label17.TabIndex = 6;
            this.label17.Text = "ETH";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTC_USD_Label
            // 
            this.BTC_USD_Label.AutoSize = true;
            this.BTC_USD_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTC_USD_Label.Font = new System.Drawing.Font("Arial", 10F);
            this.BTC_USD_Label.Location = new System.Drawing.Point(309, 25);
            this.BTC_USD_Label.Name = "BTC_USD_Label";
            this.BTC_USD_Label.Size = new System.Drawing.Size(161, 50);
            this.BTC_USD_Label.TabIndex = 5;
            this.BTC_USD_Label.Text = "0.00";
            this.BTC_USD_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTC_Label
            // 
            this.BTC_Label.AutoSize = true;
            this.BTC_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTC_Label.Font = new System.Drawing.Font("Arial", 10F);
            this.BTC_Label.Location = new System.Drawing.Point(97, 25);
            this.BTC_Label.Name = "BTC_Label";
            this.BTC_Label.Size = new System.Drawing.Size(206, 50);
            this.BTC_Label.TabIndex = 4;
            this.BTC_Label.Text = "0.00";
            this.BTC_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Arial", 10F);
            this.label14.Location = new System.Drawing.Point(3, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 50);
            this.label14.TabIndex = 3;
            this.label14.Text = "BTC";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label13.Location = new System.Drawing.Point(309, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Equivalent USD";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label12.Location = new System.Drawing.Point(97, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Holding Amount";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Account";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Arial", 9F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(273, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 69);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sell Currency";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox1.Location = new System.Drawing.Point(13, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 320);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currencies Realtime USD Price";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox2.Location = new System.Drawing.Point(273, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 319);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Accounts Infomation";
            // 
            // InvestorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "InvestorDashboard";
            this.Text = "InvestorDashboard";
            this.Load += new System.EventHandler(this.InvestorDashboard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timerRefreshPrices;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label Total_USD_Label;
        private System.Windows.Forms.Label USD_USD_Label;
        private System.Windows.Forms.Label USD_Label;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label LTC_USD_Label;
        private System.Windows.Forms.Label LTC_Label;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label ETH_USD_Label;
        private System.Windows.Forms.Label ETH_Label;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label BTC_USD_Label;
        private System.Windows.Forms.Label BTC_Label;
    }
}
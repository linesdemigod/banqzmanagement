namespace banqzManagement.View.userpanel
{
    partial class LoansManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxOfficer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.addLoanTab = new System.Windows.Forms.TabPage();
            this.btnRefreshLoans = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewLoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountDisbursed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterestAmtDisbursed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Officer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtLoanSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.addLoanFeeTab = new System.Windows.Forms.TabPage();
            this.btnRefreshFee = new Guna.UI2.WinForms.Guna2Button();
            this.txtLoanFeeSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridViewLoanFee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IDFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfficerFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addRepaymentTab = new System.Windows.Forms.TabPage();
            this.btnRefreshRepayment = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewRepayment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IDRepay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameRepay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountRepay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountRepay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutstandindRepay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarkRepay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRepay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfficerRepay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteRepay = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtRepaymentSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupBoxOfficer.SuspendLayout();
            this.tabControlClient.SuspendLayout();
            this.addLoanTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoan)).BeginInit();
            this.addLoanFeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanFee)).BeginInit();
            this.addRepaymentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepayment)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOfficer
            // 
            this.groupBoxOfficer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOfficer.Controls.Add(this.tabControlClient);
            this.groupBoxOfficer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.groupBoxOfficer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOfficer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBoxOfficer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOfficer.Name = "groupBoxOfficer";
            this.groupBoxOfficer.ShadowDecoration.Depth = 5;
            this.groupBoxOfficer.ShadowDecoration.Parent = this.groupBoxOfficer;
            this.groupBoxOfficer.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupBoxOfficer.Size = new System.Drawing.Size(799, 561);
            this.groupBoxOfficer.TabIndex = 3;
            // 
            // tabControlClient
            // 
            this.tabControlClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlClient.Controls.Add(this.addLoanTab);
            this.tabControlClient.Controls.Add(this.addLoanFeeTab);
            this.tabControlClient.Controls.Add(this.addRepaymentTab);
            this.tabControlClient.Location = new System.Drawing.Point(13, 50);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(771, 498);
            this.tabControlClient.TabIndex = 2;
            this.tabControlClient.Click += new System.EventHandler(this.btnRefreshLoans_Click);
            // 
            // addLoanTab
            // 
            this.addLoanTab.BackColor = System.Drawing.Color.White;
            this.addLoanTab.Controls.Add(this.btnRefreshLoans);
            this.addLoanTab.Controls.Add(this.dataGridViewLoan);
            this.addLoanTab.Controls.Add(this.txtLoanSearch);
            this.addLoanTab.Controls.Add(this.guna2HtmlLabel1);
            this.addLoanTab.Location = new System.Drawing.Point(4, 26);
            this.addLoanTab.Name = "addLoanTab";
            this.addLoanTab.Padding = new System.Windows.Forms.Padding(3);
            this.addLoanTab.Size = new System.Drawing.Size(763, 468);
            this.addLoanTab.TabIndex = 0;
            this.addLoanTab.Text = "Loans";
            // 
            // btnRefreshLoans
            // 
            this.btnRefreshLoans.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefreshLoans.CheckedState.Parent = this.btnRefreshLoans;
            this.btnRefreshLoans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshLoans.CustomImages.Parent = this.btnRefreshLoans;
            this.btnRefreshLoans.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(186)))), ((int)(((byte)(244)))));
            this.btnRefreshLoans.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshLoans.ForeColor = System.Drawing.Color.White;
            this.btnRefreshLoans.HoverState.Parent = this.btnRefreshLoans;
            this.btnRefreshLoans.Image = global::banqzManagement.Properties.Resources.refresh_ccw;
            this.btnRefreshLoans.Location = new System.Drawing.Point(625, 30);
            this.btnRefreshLoans.Name = "btnRefreshLoans";
            this.btnRefreshLoans.ShadowDecoration.Depth = 10;
            this.btnRefreshLoans.ShadowDecoration.Enabled = true;
            this.btnRefreshLoans.ShadowDecoration.Parent = this.btnRefreshLoans;
            this.btnRefreshLoans.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btnRefreshLoans.Size = new System.Drawing.Size(120, 30);
            this.btnRefreshLoans.TabIndex = 60;
            this.btnRefreshLoans.Text = "Refresh";
            this.btnRefreshLoans.Click += new System.EventHandler(this.btnRefreshLoans_Click);
            // 
            // dataGridViewLoan
            // 
            this.dataGridViewLoan.AllowUserToAddRows = false;
            this.dataGridViewLoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            this.dataGridViewLoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            this.dataGridViewLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewLoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dataGridViewLoan.ColumnHeadersHeight = 53;
            this.dataGridViewLoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Client,
            this.Account,
            this.AmountDisbursed,
            this.Interest,
            this.Duration,
            this.InterestAmtDisbursed,
            this.ContractStart,
            this.ContractExpiry,
            this.Officer,
            this.Delete});
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLoan.DefaultCellStyle = dataGridViewCellStyle38;
            this.dataGridViewLoan.EnableHeadersVisualStyles = false;
            this.dataGridViewLoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewLoan.Location = new System.Drawing.Point(20, 87);
            this.dataGridViewLoan.Name = "dataGridViewLoan";
            this.dataGridViewLoan.ReadOnly = true;
            this.dataGridViewLoan.RowHeadersVisible = false;
            this.dataGridViewLoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLoan.Size = new System.Drawing.Size(725, 358);
            this.dataGridViewLoan.TabIndex = 59;
            this.dataGridViewLoan.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewLoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewLoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewLoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewLoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewLoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewLoan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewLoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewLoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewLoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewLoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewLoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewLoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewLoan.ThemeStyle.HeaderStyle.Height = 53;
            this.dataGridViewLoan.ThemeStyle.ReadOnly = true;
            this.dataGridViewLoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewLoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewLoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewLoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dataGridViewLoan.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewLoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewLoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewLoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoan_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "loan_id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.DataPropertyName = "Client";
            this.Client.HeaderText = "Name";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // Account
            // 
            this.Account.DataPropertyName = "client_account_num";
            this.Account.HeaderText = "Account Number";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            // 
            // AmountDisbursed
            // 
            this.AmountDisbursed.DataPropertyName = "amount_disbursed";
            this.AmountDisbursed.HeaderText = "Amount Disbursed";
            this.AmountDisbursed.Name = "AmountDisbursed";
            this.AmountDisbursed.ReadOnly = true;
            // 
            // Interest
            // 
            this.Interest.DataPropertyName = "interest";
            this.Interest.HeaderText = "Interest";
            this.Interest.Name = "Interest";
            this.Interest.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "loan_duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // InterestAmtDisbursed
            // 
            this.InterestAmtDisbursed.DataPropertyName = "interest_amount_disbursed";
            this.InterestAmtDisbursed.HeaderText = "Interest & Amt Disbursed";
            this.InterestAmtDisbursed.Name = "InterestAmtDisbursed";
            this.InterestAmtDisbursed.ReadOnly = true;
            // 
            // ContractStart
            // 
            this.ContractStart.DataPropertyName = "date_disbursed";
            dataGridViewCellStyle36.Format = "dd/MM/yyyy";
            dataGridViewCellStyle36.NullValue = null;
            this.ContractStart.DefaultCellStyle = dataGridViewCellStyle36;
            this.ContractStart.HeaderText = "Contract Start";
            this.ContractStart.Name = "ContractStart";
            this.ContractStart.ReadOnly = true;
            // 
            // ContractExpiry
            // 
            this.ContractExpiry.DataPropertyName = "date_expiry";
            dataGridViewCellStyle37.Format = "d";
            dataGridViewCellStyle37.NullValue = null;
            this.ContractExpiry.DefaultCellStyle = dataGridViewCellStyle37;
            this.ContractExpiry.HeaderText = "Contract Expiry";
            this.ContractExpiry.Name = "ContractExpiry";
            this.ContractExpiry.ReadOnly = true;
            // 
            // Officer
            // 
            this.Officer.DataPropertyName = "Officer";
            this.Officer.HeaderText = "Officer";
            this.Officer.Name = "Officer";
            this.Officer.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // txtLoanSearch
            // 
            this.txtLoanSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoanSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLoanSearch.BorderRadius = 6;
            this.txtLoanSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoanSearch.DefaultText = "";
            this.txtLoanSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoanSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoanSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoanSearch.DisabledState.Parent = this.txtLoanSearch;
            this.txtLoanSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoanSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtLoanSearch.FocusedState.Parent = this.txtLoanSearch;
            this.txtLoanSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLoanSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtLoanSearch.HoverState.Parent = this.txtLoanSearch;
            this.txtLoanSearch.Location = new System.Drawing.Point(321, 30);
            this.txtLoanSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoanSearch.Name = "txtLoanSearch";
            this.txtLoanSearch.PasswordChar = '\0';
            this.txtLoanSearch.PlaceholderText = "Account number";
            this.txtLoanSearch.SelectedText = "";
            this.txtLoanSearch.ShadowDecoration.Parent = this.txtLoanSearch;
            this.txtLoanSearch.Size = new System.Drawing.Size(171, 30);
            this.txtLoanSearch.TabIndex = 58;
            this.txtLoanSearch.TextChanged += new System.EventHandler(this.txtLoanSearch_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(100, 38);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(204, 22);
            this.guna2HtmlLabel1.TabIndex = 57;
            this.guna2HtmlLabel1.Text = "Search by Account number";
            // 
            // addLoanFeeTab
            // 
            this.addLoanFeeTab.Controls.Add(this.btnRefreshFee);
            this.addLoanFeeTab.Controls.Add(this.txtLoanFeeSearch);
            this.addLoanFeeTab.Controls.Add(this.guna2HtmlLabel2);
            this.addLoanFeeTab.Controls.Add(this.dataGridViewLoanFee);
            this.addLoanFeeTab.Location = new System.Drawing.Point(4, 26);
            this.addLoanFeeTab.Name = "addLoanFeeTab";
            this.addLoanFeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.addLoanFeeTab.Size = new System.Drawing.Size(763, 468);
            this.addLoanFeeTab.TabIndex = 1;
            this.addLoanFeeTab.Text = "Loan Fee";
            this.addLoanFeeTab.UseVisualStyleBackColor = true;
            // 
            // btnRefreshFee
            // 
            this.btnRefreshFee.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefreshFee.CheckedState.Parent = this.btnRefreshFee;
            this.btnRefreshFee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshFee.CustomImages.Parent = this.btnRefreshFee;
            this.btnRefreshFee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(186)))), ((int)(((byte)(244)))));
            this.btnRefreshFee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshFee.ForeColor = System.Drawing.Color.White;
            this.btnRefreshFee.HoverState.Parent = this.btnRefreshFee;
            this.btnRefreshFee.Image = global::banqzManagement.Properties.Resources.refresh_ccw;
            this.btnRefreshFee.Location = new System.Drawing.Point(620, 27);
            this.btnRefreshFee.Name = "btnRefreshFee";
            this.btnRefreshFee.ShadowDecoration.Depth = 10;
            this.btnRefreshFee.ShadowDecoration.Enabled = true;
            this.btnRefreshFee.ShadowDecoration.Parent = this.btnRefreshFee;
            this.btnRefreshFee.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btnRefreshFee.Size = new System.Drawing.Size(120, 30);
            this.btnRefreshFee.TabIndex = 61;
            this.btnRefreshFee.Text = "Refresh";
            this.btnRefreshFee.Click += new System.EventHandler(this.btnRefreshFee_Click);
            // 
            // txtLoanFeeSearch
            // 
            this.txtLoanFeeSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoanFeeSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLoanFeeSearch.BorderRadius = 6;
            this.txtLoanFeeSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoanFeeSearch.DefaultText = "";
            this.txtLoanFeeSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoanFeeSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoanFeeSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoanFeeSearch.DisabledState.Parent = this.txtLoanFeeSearch;
            this.txtLoanFeeSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoanFeeSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtLoanFeeSearch.FocusedState.Parent = this.txtLoanFeeSearch;
            this.txtLoanFeeSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanFeeSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLoanFeeSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtLoanFeeSearch.HoverState.Parent = this.txtLoanFeeSearch;
            this.txtLoanFeeSearch.Location = new System.Drawing.Point(378, 27);
            this.txtLoanFeeSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoanFeeSearch.Name = "txtLoanFeeSearch";
            this.txtLoanFeeSearch.PasswordChar = '\0';
            this.txtLoanFeeSearch.PlaceholderText = "Account number";
            this.txtLoanFeeSearch.SelectedText = "";
            this.txtLoanFeeSearch.ShadowDecoration.Parent = this.txtLoanFeeSearch;
            this.txtLoanFeeSearch.Size = new System.Drawing.Size(171, 30);
            this.txtLoanFeeSearch.TabIndex = 60;
            this.txtLoanFeeSearch.TextChanged += new System.EventHandler(this.txtLoanFeeSearch_TextChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(157, 35);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(204, 22);
            this.guna2HtmlLabel2.TabIndex = 59;
            this.guna2HtmlLabel2.Text = "Search by Account number";
            // 
            // dataGridViewLoanFee
            // 
            this.dataGridViewLoanFee.AllowUserToAddRows = false;
            this.dataGridViewLoanFee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.White;
            this.dataGridViewLoanFee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle39;
            this.dataGridViewLoanFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLoanFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoanFee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLoanFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLoanFee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewLoanFee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLoanFee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridViewLoanFee.ColumnHeadersHeight = 36;
            this.dataGridViewLoanFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDFee,
            this.ClientFee,
            this.AccountNumber,
            this.Purpose,
            this.Amount,
            this.DateFee,
            this.OfficerFee,
            this.DeleteColumn});
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLoanFee.DefaultCellStyle = dataGridViewCellStyle41;
            this.dataGridViewLoanFee.EnableHeadersVisualStyles = false;
            this.dataGridViewLoanFee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewLoanFee.Location = new System.Drawing.Point(26, 79);
            this.dataGridViewLoanFee.Name = "dataGridViewLoanFee";
            this.dataGridViewLoanFee.ReadOnly = true;
            this.dataGridViewLoanFee.RowHeadersVisible = false;
            this.dataGridViewLoanFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLoanFee.Size = new System.Drawing.Size(714, 348);
            this.dataGridViewLoanFee.TabIndex = 0;
            this.dataGridViewLoanFee.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewLoanFee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewLoanFee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewLoanFee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewLoanFee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewLoanFee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewLoanFee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewLoanFee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewLoanFee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewLoanFee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewLoanFee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewLoanFee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewLoanFee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewLoanFee.ThemeStyle.HeaderStyle.Height = 36;
            this.dataGridViewLoanFee.ThemeStyle.ReadOnly = true;
            this.dataGridViewLoanFee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewLoanFee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewLoanFee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewLoanFee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dataGridViewLoanFee.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewLoanFee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewLoanFee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewLoanFee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLoanFee_CellContentClick);
            // 
            // IDFee
            // 
            this.IDFee.DataPropertyName = "fee_id";
            this.IDFee.HeaderText = "ID";
            this.IDFee.Name = "IDFee";
            this.IDFee.ReadOnly = true;
            // 
            // ClientFee
            // 
            this.ClientFee.DataPropertyName = "Client";
            this.ClientFee.HeaderText = "Name";
            this.ClientFee.Name = "ClientFee";
            this.ClientFee.ReadOnly = true;
            // 
            // AccountNumber
            // 
            this.AccountNumber.DataPropertyName = "client_account_num";
            this.AccountNumber.HeaderText = "Account Number";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.ReadOnly = true;
            // 
            // Purpose
            // 
            this.Purpose.DataPropertyName = "fee_purpose";
            this.Purpose.HeaderText = "Purpose";
            this.Purpose.Name = "Purpose";
            this.Purpose.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // DateFee
            // 
            this.DateFee.DataPropertyName = "created_at";
            this.DateFee.HeaderText = "Date";
            this.DateFee.Name = "DateFee";
            this.DateFee.ReadOnly = true;
            // 
            // OfficerFee
            // 
            this.OfficerFee.DataPropertyName = "Officer";
            this.OfficerFee.HeaderText = "Officer";
            this.OfficerFee.Name = "OfficerFee";
            this.OfficerFee.ReadOnly = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // addRepaymentTab
            // 
            this.addRepaymentTab.Controls.Add(this.btnRefreshRepayment);
            this.addRepaymentTab.Controls.Add(this.dataGridViewRepayment);
            this.addRepaymentTab.Controls.Add(this.txtRepaymentSearch);
            this.addRepaymentTab.Controls.Add(this.guna2HtmlLabel3);
            this.addRepaymentTab.Location = new System.Drawing.Point(4, 26);
            this.addRepaymentTab.Name = "addRepaymentTab";
            this.addRepaymentTab.Padding = new System.Windows.Forms.Padding(3);
            this.addRepaymentTab.Size = new System.Drawing.Size(763, 468);
            this.addRepaymentTab.TabIndex = 2;
            this.addRepaymentTab.Text = "Repayment";
            this.addRepaymentTab.UseVisualStyleBackColor = true;
            // 
            // btnRefreshRepayment
            // 
            this.btnRefreshRepayment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefreshRepayment.CheckedState.Parent = this.btnRefreshRepayment;
            this.btnRefreshRepayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshRepayment.CustomImages.Parent = this.btnRefreshRepayment;
            this.btnRefreshRepayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(186)))), ((int)(((byte)(244)))));
            this.btnRefreshRepayment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshRepayment.ForeColor = System.Drawing.Color.White;
            this.btnRefreshRepayment.HoverState.Parent = this.btnRefreshRepayment;
            this.btnRefreshRepayment.Image = global::banqzManagement.Properties.Resources.refresh_ccw;
            this.btnRefreshRepayment.Location = new System.Drawing.Point(620, 22);
            this.btnRefreshRepayment.Name = "btnRefreshRepayment";
            this.btnRefreshRepayment.ShadowDecoration.Depth = 10;
            this.btnRefreshRepayment.ShadowDecoration.Enabled = true;
            this.btnRefreshRepayment.ShadowDecoration.Parent = this.btnRefreshRepayment;
            this.btnRefreshRepayment.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btnRefreshRepayment.Size = new System.Drawing.Size(120, 30);
            this.btnRefreshRepayment.TabIndex = 64;
            this.btnRefreshRepayment.Text = "Refresh";
            this.btnRefreshRepayment.Click += new System.EventHandler(this.btnRefreshRepayment_Click);
            // 
            // dataGridViewRepayment
            // 
            this.dataGridViewRepayment.AllowUserToAddRows = false;
            this.dataGridViewRepayment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.White;
            this.dataGridViewRepayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle42;
            this.dataGridViewRepayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRepayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRepayment.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRepayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRepayment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRepayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRepayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.dataGridViewRepayment.ColumnHeadersHeight = 36;
            this.dataGridViewRepayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDRepay,
            this.NameRepay,
            this.AccountRepay,
            this.AmountRepay,
            this.OutstandindRepay,
            this.RemarkRepay,
            this.DateRepay,
            this.OfficerRepay,
            this.DeleteRepay});
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRepayment.DefaultCellStyle = dataGridViewCellStyle44;
            this.dataGridViewRepayment.EnableHeadersVisualStyles = false;
            this.dataGridViewRepayment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRepayment.Location = new System.Drawing.Point(25, 75);
            this.dataGridViewRepayment.Name = "dataGridViewRepayment";
            this.dataGridViewRepayment.ReadOnly = true;
            this.dataGridViewRepayment.RowHeadersVisible = false;
            this.dataGridViewRepayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRepayment.Size = new System.Drawing.Size(715, 360);
            this.dataGridViewRepayment.TabIndex = 63;
            this.dataGridViewRepayment.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewRepayment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRepayment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewRepayment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewRepayment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewRepayment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewRepayment.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRepayment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRepayment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewRepayment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewRepayment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRepayment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewRepayment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewRepayment.ThemeStyle.HeaderStyle.Height = 36;
            this.dataGridViewRepayment.ThemeStyle.ReadOnly = true;
            this.dataGridViewRepayment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRepayment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRepayment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRepayment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dataGridViewRepayment.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewRepayment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRepayment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewRepayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRepayment_CellContentClick);
            // 
            // IDRepay
            // 
            this.IDRepay.DataPropertyName = "repay_id";
            this.IDRepay.HeaderText = "ID";
            this.IDRepay.Name = "IDRepay";
            this.IDRepay.ReadOnly = true;
            // 
            // NameRepay
            // 
            this.NameRepay.DataPropertyName = "Client";
            this.NameRepay.HeaderText = "Name";
            this.NameRepay.Name = "NameRepay";
            this.NameRepay.ReadOnly = true;
            // 
            // AccountRepay
            // 
            this.AccountRepay.DataPropertyName = "client_account_num";
            this.AccountRepay.HeaderText = "Account Number";
            this.AccountRepay.Name = "AccountRepay";
            this.AccountRepay.ReadOnly = true;
            // 
            // AmountRepay
            // 
            this.AmountRepay.DataPropertyName = "amount";
            this.AmountRepay.HeaderText = "Amount";
            this.AmountRepay.Name = "AmountRepay";
            this.AmountRepay.ReadOnly = true;
            // 
            // OutstandindRepay
            // 
            this.OutstandindRepay.DataPropertyName = "Outstanding";
            this.OutstandindRepay.HeaderText = "Outstanding";
            this.OutstandindRepay.Name = "OutstandindRepay";
            this.OutstandindRepay.ReadOnly = true;
            // 
            // RemarkRepay
            // 
            this.RemarkRepay.DataPropertyName = "remark";
            this.RemarkRepay.HeaderText = "Remark";
            this.RemarkRepay.Name = "RemarkRepay";
            this.RemarkRepay.ReadOnly = true;
            // 
            // DateRepay
            // 
            this.DateRepay.DataPropertyName = "created_at";
            this.DateRepay.HeaderText = "Date";
            this.DateRepay.Name = "DateRepay";
            this.DateRepay.ReadOnly = true;
            // 
            // OfficerRepay
            // 
            this.OfficerRepay.DataPropertyName = "Officer";
            this.OfficerRepay.HeaderText = "Officer";
            this.OfficerRepay.Name = "OfficerRepay";
            this.OfficerRepay.ReadOnly = true;
            // 
            // DeleteRepay
            // 
            this.DeleteRepay.HeaderText = "Delete";
            this.DeleteRepay.Name = "DeleteRepay";
            this.DeleteRepay.ReadOnly = true;
            this.DeleteRepay.Text = "Delete";
            this.DeleteRepay.UseColumnTextForButtonValue = true;
            // 
            // txtRepaymentSearch
            // 
            this.txtRepaymentSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRepaymentSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRepaymentSearch.BorderRadius = 6;
            this.txtRepaymentSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepaymentSearch.DefaultText = "";
            this.txtRepaymentSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRepaymentSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRepaymentSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRepaymentSearch.DisabledState.Parent = this.txtRepaymentSearch;
            this.txtRepaymentSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRepaymentSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtRepaymentSearch.FocusedState.Parent = this.txtRepaymentSearch;
            this.txtRepaymentSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepaymentSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRepaymentSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtRepaymentSearch.HoverState.Parent = this.txtRepaymentSearch;
            this.txtRepaymentSearch.Location = new System.Drawing.Point(310, 22);
            this.txtRepaymentSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRepaymentSearch.Name = "txtRepaymentSearch";
            this.txtRepaymentSearch.PasswordChar = '\0';
            this.txtRepaymentSearch.PlaceholderText = "Account number";
            this.txtRepaymentSearch.SelectedText = "";
            this.txtRepaymentSearch.ShadowDecoration.Parent = this.txtRepaymentSearch;
            this.txtRepaymentSearch.Size = new System.Drawing.Size(171, 30);
            this.txtRepaymentSearch.TabIndex = 62;
            this.txtRepaymentSearch.TextChanged += new System.EventHandler(this.txtRepaymentSearch_TextChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(89, 30);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(204, 22);
            this.guna2HtmlLabel3.TabIndex = 61;
            this.guna2HtmlLabel3.Text = "Search by Account number";
            // 
            // LoansManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 585);
            this.Controls.Add(this.groupBoxOfficer);
            this.Name = "LoansManagement";
            this.Text = "LoansManagement";
            this.Load += new System.EventHandler(this.LoansManagement_Load);
            this.groupBoxOfficer.ResumeLayout(false);
            this.tabControlClient.ResumeLayout(false);
            this.addLoanTab.ResumeLayout(false);
            this.addLoanTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoan)).EndInit();
            this.addLoanFeeTab.ResumeLayout(false);
            this.addLoanFeeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanFee)).EndInit();
            this.addRepaymentTab.ResumeLayout(false);
            this.addRepaymentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRepayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBoxOfficer;
        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage addLoanTab;
        private System.Windows.Forms.TabPage addLoanFeeTab;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewLoan;
        private Guna.UI2.WinForms.Guna2TextBox txtLoanSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtLoanFeeSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewLoanFee;
        private System.Windows.Forms.TabPage addRepaymentTab;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewRepayment;
        private Guna.UI2.WinForms.Guna2TextBox txtRepaymentSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDRepay;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRepay;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountRepay;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountRepay;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutstandindRepay;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarkRepay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRepay;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfficerRepay;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteRepay;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfficerFee;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountDisbursed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterestAmtDisbursed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Officer;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private Guna.UI2.WinForms.Guna2Button btnRefreshLoans;
        private Guna.UI2.WinForms.Guna2Button btnRefreshFee;
        private Guna.UI2.WinForms.Guna2Button btnRefreshRepayment;
    }
}
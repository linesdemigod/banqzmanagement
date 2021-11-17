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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxOfficer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.addLoanTab = new System.Windows.Forms.TabPage();
            this.dataGridViewLoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtLoanSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.addLoanFeeTab = new System.Windows.Forms.TabPage();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Officer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterestAmtDisbursed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountDisbursed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLoanFee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtLoanFeeSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.IDFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfficerFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBoxOfficer.SuspendLayout();
            this.tabControlClient.SuspendLayout();
            this.addLoanTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoan)).BeginInit();
            this.addLoanFeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoanFee)).BeginInit();
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
            this.tabControlClient.Location = new System.Drawing.Point(13, 50);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(771, 498);
            this.tabControlClient.TabIndex = 2;
            // 
            // addLoanTab
            // 
            this.addLoanTab.BackColor = System.Drawing.Color.White;
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
            // dataGridViewLoan
            // 
            this.dataGridViewLoan.AllowUserToAddRows = false;
            this.dataGridViewLoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewLoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewLoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLoan.ColumnHeadersHeight = 53;
            this.dataGridViewLoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Account,
            this.AmountDisbursed,
            this.Interest,
            this.Duration,
            this.InterestAmtDisbursed,
            this.ContractStart,
            this.ContractExpiry,
            this.Officer,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLoan.DefaultCellStyle = dataGridViewCellStyle3;
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
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Officer
            // 
            this.Officer.DataPropertyName = "Officer";
            this.Officer.HeaderText = "Officer";
            this.Officer.Name = "Officer";
            this.Officer.ReadOnly = true;
            // 
            // ContractExpiry
            // 
            this.ContractExpiry.DataPropertyName = "date_expiry";
            this.ContractExpiry.HeaderText = "Contract Expiry";
            this.ContractExpiry.Name = "ContractExpiry";
            this.ContractExpiry.ReadOnly = true;
            // 
            // ContractStart
            // 
            this.ContractStart.DataPropertyName = "date_disbursed";
            this.ContractStart.HeaderText = "Contract Start";
            this.ContractStart.Name = "ContractStart";
            this.ContractStart.ReadOnly = true;
            // 
            // InterestAmtDisbursed
            // 
            this.InterestAmtDisbursed.DataPropertyName = "interest_amount_disbursed";
            this.InterestAmtDisbursed.HeaderText = "Interest & Amt Disbursed";
            this.InterestAmtDisbursed.Name = "InterestAmtDisbursed";
            this.InterestAmtDisbursed.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "loan_duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // Interest
            // 
            this.Interest.DataPropertyName = "interest";
            this.Interest.HeaderText = "Interest";
            this.Interest.Name = "Interest";
            this.Interest.ReadOnly = true;
            // 
            // AmountDisbursed
            // 
            this.AmountDisbursed.DataPropertyName = "amount_disbursed";
            this.AmountDisbursed.HeaderText = "Amount Disbursed";
            this.AmountDisbursed.Name = "AmountDisbursed";
            this.AmountDisbursed.ReadOnly = true;
            // 
            // Account
            // 
            this.Account.DataPropertyName = "client_account_num";
            this.Account.HeaderText = "Account Number";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "loan_id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // dataGridViewLoanFee
            // 
            this.dataGridViewLoanFee.AllowUserToAddRows = false;
            this.dataGridViewLoanFee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridViewLoanFee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLoanFee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLoanFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoanFee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLoanFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLoanFee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewLoanFee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLoanFee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewLoanFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoanFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDFee,
            this.AccountNumber,
            this.Purpose,
            this.Amount,
            this.OfficerFee,
            this.DeleteColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLoanFee.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewLoanFee.EnableHeadersVisualStyles = false;
            this.dataGridViewLoanFee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewLoanFee.Location = new System.Drawing.Point(26, 94);
            this.dataGridViewLoanFee.Name = "dataGridViewLoanFee";
            this.dataGridViewLoanFee.ReadOnly = true;
            this.dataGridViewLoanFee.RowHeadersVisible = false;
            this.dataGridViewLoanFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLoanFee.Size = new System.Drawing.Size(714, 351);
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
            this.dataGridViewLoanFee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // IDFee
            // 
            this.IDFee.DataPropertyName = "fee_id";
            this.IDFee.HeaderText = "ID";
            this.IDFee.Name = "IDFee";
            this.IDFee.ReadOnly = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountDisbursed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterestAmtDisbursed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn Officer;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private Guna.UI2.WinForms.Guna2TextBox txtLoanFeeSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewLoanFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfficerFee;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
    }
}
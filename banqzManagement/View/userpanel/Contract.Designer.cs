namespace banqzManagement.View.userpanel
{
    partial class Contract
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxOfficer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.addRunningContractTab = new System.Windows.Forms.TabPage();
            this.dataGridViewRunning = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterestAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDisbursed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExpiries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRunningSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.addExpiryContractTab = new System.Windows.Forms.TabPage();
            this.txtSearchExpiry = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridViewExpiry = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ClientExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountDisbursedExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterestExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricncipalExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDisbursedExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExpiryExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxOfficer.SuspendLayout();
            this.tabControlClient.SuspendLayout();
            this.addRunningContractTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunning)).BeginInit();
            this.addExpiryContractTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpiry)).BeginInit();
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
            this.groupBoxOfficer.TabIndex = 4;
            // 
            // tabControlClient
            // 
            this.tabControlClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlClient.Controls.Add(this.addRunningContractTab);
            this.tabControlClient.Controls.Add(this.addExpiryContractTab);
            this.tabControlClient.Location = new System.Drawing.Point(13, 50);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(771, 498);
            this.tabControlClient.TabIndex = 2;
            // 
            // addRunningContractTab
            // 
            this.addRunningContractTab.BackColor = System.Drawing.Color.White;
            this.addRunningContractTab.Controls.Add(this.dataGridViewRunning);
            this.addRunningContractTab.Controls.Add(this.txtRunningSearch);
            this.addRunningContractTab.Controls.Add(this.guna2HtmlLabel1);
            this.addRunningContractTab.Location = new System.Drawing.Point(4, 26);
            this.addRunningContractTab.Name = "addRunningContractTab";
            this.addRunningContractTab.Padding = new System.Windows.Forms.Padding(3);
            this.addRunningContractTab.Size = new System.Drawing.Size(763, 468);
            this.addRunningContractTab.TabIndex = 0;
            this.addRunningContractTab.Text = "Running Contract";
            // 
            // dataGridViewRunning
            // 
            this.dataGridViewRunning.AllowUserToAddRows = false;
            this.dataGridViewRunning.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dataGridViewRunning.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewRunning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRunning.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRunning.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRunning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRunning.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRunning.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRunning.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewRunning.ColumnHeadersHeight = 53;
            this.dataGridViewRunning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.Account,
            this.Amount,
            this.Interest,
            this.Duration,
            this.InterestAmount,
            this.DateDisbursed,
            this.DateExpiries});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRunning.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewRunning.EnableHeadersVisualStyles = false;
            this.dataGridViewRunning.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRunning.Location = new System.Drawing.Point(29, 95);
            this.dataGridViewRunning.Name = "dataGridViewRunning";
            this.dataGridViewRunning.ReadOnly = true;
            this.dataGridViewRunning.RowHeadersVisible = false;
            this.dataGridViewRunning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRunning.Size = new System.Drawing.Size(711, 346);
            this.dataGridViewRunning.TabIndex = 59;
            this.dataGridViewRunning.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewRunning.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRunning.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewRunning.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewRunning.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewRunning.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewRunning.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRunning.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRunning.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewRunning.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewRunning.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRunning.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewRunning.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewRunning.ThemeStyle.HeaderStyle.Height = 53;
            this.dataGridViewRunning.ThemeStyle.ReadOnly = true;
            this.dataGridViewRunning.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRunning.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRunning.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRunning.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dataGridViewRunning.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewRunning.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRunning.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // Amount
            // 
            this.Amount.DataPropertyName = "amount_disbursed";
            this.Amount.HeaderText = "Amount Disbursed";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
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
            // InterestAmount
            // 
            this.InterestAmount.DataPropertyName = "interest_amount_disbursed";
            this.InterestAmount.HeaderText = "Principal & Interest";
            this.InterestAmount.Name = "InterestAmount";
            this.InterestAmount.ReadOnly = true;
            // 
            // DateDisbursed
            // 
            this.DateDisbursed.DataPropertyName = "date_disbursed";
            this.DateDisbursed.HeaderText = "Date Disbursed";
            this.DateDisbursed.Name = "DateDisbursed";
            this.DateDisbursed.ReadOnly = true;
            // 
            // DateExpiries
            // 
            this.DateExpiries.DataPropertyName = "DateExpiry";
            this.DateExpiries.HeaderText = "Expiry Date";
            this.DateExpiries.Name = "DateExpiries";
            this.DateExpiries.ReadOnly = true;
            // 
            // txtRunningSearch
            // 
            this.txtRunningSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRunningSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRunningSearch.BorderRadius = 6;
            this.txtRunningSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRunningSearch.DefaultText = "";
            this.txtRunningSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRunningSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRunningSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRunningSearch.DisabledState.Parent = this.txtRunningSearch;
            this.txtRunningSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRunningSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtRunningSearch.FocusedState.Parent = this.txtRunningSearch;
            this.txtRunningSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRunningSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRunningSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtRunningSearch.HoverState.Parent = this.txtRunningSearch;
            this.txtRunningSearch.Location = new System.Drawing.Point(321, 30);
            this.txtRunningSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRunningSearch.Name = "txtRunningSearch";
            this.txtRunningSearch.PasswordChar = '\0';
            this.txtRunningSearch.PlaceholderText = "Account number";
            this.txtRunningSearch.SelectedText = "";
            this.txtRunningSearch.ShadowDecoration.Parent = this.txtRunningSearch;
            this.txtRunningSearch.Size = new System.Drawing.Size(171, 30);
            this.txtRunningSearch.TabIndex = 58;
            this.txtRunningSearch.TextChanged += new System.EventHandler(this.txtRunningSearch_TextChanged);
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
            // addExpiryContractTab
            // 
            this.addExpiryContractTab.Controls.Add(this.dataGridViewExpiry);
            this.addExpiryContractTab.Controls.Add(this.txtSearchExpiry);
            this.addExpiryContractTab.Controls.Add(this.guna2HtmlLabel2);
            this.addExpiryContractTab.Location = new System.Drawing.Point(4, 26);
            this.addExpiryContractTab.Name = "addExpiryContractTab";
            this.addExpiryContractTab.Padding = new System.Windows.Forms.Padding(3);
            this.addExpiryContractTab.Size = new System.Drawing.Size(763, 468);
            this.addExpiryContractTab.TabIndex = 1;
            this.addExpiryContractTab.Text = "Expiried Contract";
            this.addExpiryContractTab.UseVisualStyleBackColor = true;
            // 
            // txtSearchExpiry
            // 
            this.txtSearchExpiry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchExpiry.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchExpiry.BorderRadius = 6;
            this.txtSearchExpiry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchExpiry.DefaultText = "";
            this.txtSearchExpiry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchExpiry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchExpiry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchExpiry.DisabledState.Parent = this.txtSearchExpiry;
            this.txtSearchExpiry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchExpiry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtSearchExpiry.FocusedState.Parent = this.txtSearchExpiry;
            this.txtSearchExpiry.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchExpiry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchExpiry.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtSearchExpiry.HoverState.Parent = this.txtSearchExpiry;
            this.txtSearchExpiry.Location = new System.Drawing.Point(378, 27);
            this.txtSearchExpiry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchExpiry.Name = "txtSearchExpiry";
            this.txtSearchExpiry.PasswordChar = '\0';
            this.txtSearchExpiry.PlaceholderText = "Account number";
            this.txtSearchExpiry.SelectedText = "";
            this.txtSearchExpiry.ShadowDecoration.Parent = this.txtSearchExpiry;
            this.txtSearchExpiry.Size = new System.Drawing.Size(171, 30);
            this.txtSearchExpiry.TabIndex = 60;
            this.txtSearchExpiry.TextChanged += new System.EventHandler(this.txtSearchExpiry_TextChanged);
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
            // dataGridViewExpiry
            // 
            this.dataGridViewExpiry.AllowUserToAddRows = false;
            this.dataGridViewExpiry.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridViewExpiry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewExpiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewExpiry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExpiry.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewExpiry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewExpiry.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewExpiry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExpiry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewExpiry.ColumnHeadersHeight = 53;
            this.dataGridViewExpiry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientExpiry,
            this.AccountExpiry,
            this.AmountDisbursedExpiry,
            this.InterestExpiry,
            this.DurationExpiry,
            this.PricncipalExpiry,
            this.DateDisbursedExpiry,
            this.DateExpiryExpiry});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExpiry.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewExpiry.EnableHeadersVisualStyles = false;
            this.dataGridViewExpiry.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewExpiry.Location = new System.Drawing.Point(25, 82);
            this.dataGridViewExpiry.Name = "dataGridViewExpiry";
            this.dataGridViewExpiry.ReadOnly = true;
            this.dataGridViewExpiry.RowHeadersVisible = false;
            this.dataGridViewExpiry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExpiry.Size = new System.Drawing.Size(711, 355);
            this.dataGridViewExpiry.TabIndex = 61;
            this.dataGridViewExpiry.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridViewExpiry.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewExpiry.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewExpiry.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewExpiry.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewExpiry.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewExpiry.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewExpiry.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewExpiry.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewExpiry.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewExpiry.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewExpiry.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewExpiry.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewExpiry.ThemeStyle.HeaderStyle.Height = 53;
            this.dataGridViewExpiry.ThemeStyle.ReadOnly = true;
            this.dataGridViewExpiry.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewExpiry.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewExpiry.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewExpiry.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dataGridViewExpiry.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewExpiry.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewExpiry.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ClientExpiry
            // 
            this.ClientExpiry.DataPropertyName = "Client";
            this.ClientExpiry.HeaderText = "Name";
            this.ClientExpiry.Name = "ClientExpiry";
            this.ClientExpiry.ReadOnly = true;
            // 
            // AccountExpiry
            // 
            this.AccountExpiry.DataPropertyName = "client_account_num";
            this.AccountExpiry.HeaderText = "Account Number";
            this.AccountExpiry.Name = "AccountExpiry";
            this.AccountExpiry.ReadOnly = true;
            // 
            // AmountDisbursedExpiry
            // 
            this.AmountDisbursedExpiry.DataPropertyName = "amount_disbursed";
            this.AmountDisbursedExpiry.HeaderText = "Amount Disbursed";
            this.AmountDisbursedExpiry.Name = "AmountDisbursedExpiry";
            this.AmountDisbursedExpiry.ReadOnly = true;
            // 
            // InterestExpiry
            // 
            this.InterestExpiry.DataPropertyName = "interest";
            this.InterestExpiry.HeaderText = "Interest";
            this.InterestExpiry.Name = "InterestExpiry";
            this.InterestExpiry.ReadOnly = true;
            // 
            // DurationExpiry
            // 
            this.DurationExpiry.DataPropertyName = "loan_duration";
            this.DurationExpiry.HeaderText = "Duration";
            this.DurationExpiry.Name = "DurationExpiry";
            this.DurationExpiry.ReadOnly = true;
            // 
            // PricncipalExpiry
            // 
            this.PricncipalExpiry.DataPropertyName = "interest_amount_disbursed";
            this.PricncipalExpiry.HeaderText = "Principal & Interest";
            this.PricncipalExpiry.Name = "PricncipalExpiry";
            this.PricncipalExpiry.ReadOnly = true;
            // 
            // DateDisbursedExpiry
            // 
            this.DateDisbursedExpiry.DataPropertyName = "date_disbursed";
            this.DateDisbursedExpiry.HeaderText = "Date Disbursed";
            this.DateDisbursedExpiry.Name = "DateDisbursedExpiry";
            this.DateDisbursedExpiry.ReadOnly = true;
            // 
            // DateExpiryExpiry
            // 
            this.DateExpiryExpiry.DataPropertyName = "DateExpiry";
            this.DateExpiryExpiry.HeaderText = "Expiry Date";
            this.DateExpiryExpiry.Name = "DateExpiryExpiry";
            this.DateExpiryExpiry.ReadOnly = true;
            // 
            // Contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 585);
            this.Controls.Add(this.groupBoxOfficer);
            this.Name = "Contract";
            this.Text = "Contract";
            this.Load += new System.EventHandler(this.Contract_Load);
            this.groupBoxOfficer.ResumeLayout(false);
            this.tabControlClient.ResumeLayout(false);
            this.addRunningContractTab.ResumeLayout(false);
            this.addRunningContractTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRunning)).EndInit();
            this.addExpiryContractTab.ResumeLayout(false);
            this.addExpiryContractTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpiry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBoxOfficer;
        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage addRunningContractTab;
        private Guna.UI2.WinForms.Guna2TextBox txtRunningSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.TabPage addExpiryContractTab;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchExpiry;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewRunning;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterestAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDisbursed;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExpiries;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountDisbursedExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterestExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricncipalExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDisbursedExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExpiryExpiry;
    }
}
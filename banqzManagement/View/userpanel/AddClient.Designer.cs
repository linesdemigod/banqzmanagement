namespace banqzManagement.View.userpanel
{
    partial class AddClient
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
            this.PanelTopOfficer = new Guna.UI2.WinForms.Guna2Panel();
            this.picMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picMaximize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.addClientTab = new System.Windows.Forms.TabPage();
            this.txtIdNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ComboIdType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAccountNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTelephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dateDob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtLastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFirstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.addGuarantorTab = new System.Windows.Forms.TabPage();
            this.txtSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.txtGAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtGTelephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtGLastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtGFirstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PanelTopOfficer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.tabControlClient.SuspendLayout();
            this.addClientTab.SuspendLayout();
            this.addGuarantorTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTopOfficer
            // 
            this.PanelTopOfficer.Controls.Add(this.picMinimize);
            this.PanelTopOfficer.Controls.Add(this.picMaximize);
            this.PanelTopOfficer.Controls.Add(this.picClose);
            this.PanelTopOfficer.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopOfficer.Location = new System.Drawing.Point(0, 0);
            this.PanelTopOfficer.Name = "PanelTopOfficer";
            this.PanelTopOfficer.ShadowDecoration.Parent = this.PanelTopOfficer;
            this.PanelTopOfficer.Size = new System.Drawing.Size(823, 55);
            this.PanelTopOfficer.TabIndex = 23;
            this.PanelTopOfficer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddClient_MouseDown);
            this.PanelTopOfficer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddClient_MouseMove);
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::banqzManagement.Properties.Resources.Minimize_icon;
            this.picMinimize.Location = new System.Drawing.Point(736, 12);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.ShadowDecoration.Parent = this.picMinimize;
            this.picMinimize.Size = new System.Drawing.Size(21, 19);
            this.picMinimize.TabIndex = 23;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picMaximize
            // 
            this.picMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMaximize.Image = global::banqzManagement.Properties.Resources.Maximize_icon1;
            this.picMaximize.Location = new System.Drawing.Point(763, 12);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.ShadowDecoration.Parent = this.picMaximize;
            this.picMaximize.Size = new System.Drawing.Size(21, 19);
            this.picMaximize.TabIndex = 22;
            this.picMaximize.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::banqzManagement.Properties.Resources.Close_icon1;
            this.picClose.Location = new System.Drawing.Point(790, 12);
            this.picClose.Name = "picClose";
            this.picClose.ShadowDecoration.Parent = this.picClose;
            this.picClose.Size = new System.Drawing.Size(21, 19);
            this.picClose.TabIndex = 21;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.tabControlClient);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(13, 62);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Depth = 10;
            this.guna2GroupBox1.ShadowDecoration.Enabled = true;
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(798, 534);
            this.guna2GroupBox1.TabIndex = 24;
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // tabControlClient
            // 
            this.tabControlClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlClient.Controls.Add(this.addClientTab);
            this.tabControlClient.Controls.Add(this.addGuarantorTab);
            this.tabControlClient.Location = new System.Drawing.Point(13, 49);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(771, 471);
            this.tabControlClient.TabIndex = 0;
            // 
            // addClientTab
            // 
            this.addClientTab.BackColor = System.Drawing.Color.White;
            this.addClientTab.Controls.Add(this.txtIdNumber);
            this.addClientTab.Controls.Add(this.guna2HtmlLabel16);
            this.addClientTab.Controls.Add(this.ComboIdType);
            this.addClientTab.Controls.Add(this.guna2HtmlLabel15);
            this.addClientTab.Controls.Add(this.txtAddress);
            this.addClientTab.Controls.Add(this.guna2HtmlLabel9);
            this.addClientTab.Controls.Add(this.txtAccountNumber);
            this.addClientTab.Controls.Add(this.guna2HtmlLabel6);
            this.addClientTab.Controls.Add(this.comboGender);
            this.addClientTab.Controls.Add(this.guna2HtmlLabel5);
            this.addClientTab.Controls.Add(this.txtTelephone);
            this.addClientTab.Controls.Add(this.guna2HtmlLabel4);
            this.addClientTab.Controls.Add(this.dateDob);
            this.addClientTab.Controls.Add(this.guna2HtmlLabel3);
            this.addClientTab.Controls.Add(this.txtLastname);
            this.addClientTab.Controls.Add(this.guna2HtmlLabel2);
            this.addClientTab.Controls.Add(this.txtFirstname);
            this.addClientTab.Controls.Add(this.guna2HtmlLabel1);
            this.addClientTab.Location = new System.Drawing.Point(4, 26);
            this.addClientTab.Name = "addClientTab";
            this.addClientTab.Padding = new System.Windows.Forms.Padding(3);
            this.addClientTab.Size = new System.Drawing.Size(763, 441);
            this.addClientTab.TabIndex = 0;
            this.addClientTab.Text = "Client";
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdNumber.BorderRadius = 6;
            this.txtIdNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdNumber.DefaultText = "";
            this.txtIdNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdNumber.DisabledState.Parent = this.txtIdNumber;
            this.txtIdNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtIdNumber.FocusedState.Parent = this.txtIdNumber;
            this.txtIdNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtIdNumber.HoverState.Parent = this.txtIdNumber;
            this.txtIdNumber.Location = new System.Drawing.Point(416, 331);
            this.txtIdNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.PasswordChar = '\0';
            this.txtIdNumber.PlaceholderText = "";
            this.txtIdNumber.SelectedText = "";
            this.txtIdNumber.ShadowDecoration.Parent = this.txtIdNumber;
            this.txtIdNumber.Size = new System.Drawing.Size(184, 30);
            this.txtIdNumber.TabIndex = 61;
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel16.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel16.Location = new System.Drawing.Point(416, 305);
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            this.guna2HtmlLabel16.Size = new System.Drawing.Size(72, 19);
            this.guna2HtmlLabel16.TabIndex = 60;
            this.guna2HtmlLabel16.Text = "ID Number";
            // 
            // ComboIdType
            // 
            this.ComboIdType.BackColor = System.Drawing.Color.Transparent;
            this.ComboIdType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboIdType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboIdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboIdType.FocusedColor = System.Drawing.Color.Empty;
            this.ComboIdType.FocusedState.Parent = this.ComboIdType;
            this.ComboIdType.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboIdType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboIdType.FormattingEnabled = true;
            this.ComboIdType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.ComboIdType.HoverState.Parent = this.ComboIdType;
            this.ComboIdType.ItemHeight = 30;
            this.ComboIdType.Items.AddRange(new object[] {
            "Voter\'s Card",
            "Driver License",
            "Ghana Card",
            "Passport"});
            this.ComboIdType.ItemsAppearance.Parent = this.ComboIdType;
            this.ComboIdType.Location = new System.Drawing.Point(162, 325);
            this.ComboIdType.Name = "ComboIdType";
            this.ComboIdType.ShadowDecoration.Parent = this.ComboIdType;
            this.ComboIdType.Size = new System.Drawing.Size(184, 36);
            this.ComboIdType.TabIndex = 59;
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel15.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(162, 299);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(48, 19);
            this.guna2HtmlLabel15.TabIndex = 58;
            this.guna2HtmlLabel15.Text = "ID Type";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.BorderRadius = 6;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.Parent = this.txtAddress;
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtAddress.FocusedState.Parent = this.txtAddress;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtAddress.HoverState.Parent = this.txtAddress;
            this.txtAddress.Location = new System.Drawing.Point(162, 256);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(438, 30);
            this.txtAddress.TabIndex = 39;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(162, 230);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(52, 19);
            this.guna2HtmlLabel9.TabIndex = 38;
            this.guna2HtmlLabel9.Text = "Address";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAccountNumber.BorderRadius = 6;
            this.txtAccountNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNumber.DefaultText = "";
            this.txtAccountNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.DisabledState.Parent = this.txtAccountNumber;
            this.txtAccountNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtAccountNumber.FocusedState.Parent = this.txtAccountNumber;
            this.txtAccountNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAccountNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtAccountNumber.HoverState.Parent = this.txtAccountNumber;
            this.txtAccountNumber.Location = new System.Drawing.Point(162, 400);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.PasswordChar = '\0';
            this.txtAccountNumber.PlaceholderText = "";
            this.txtAccountNumber.SelectedText = "";
            this.txtAccountNumber.ShadowDecoration.Parent = this.txtAccountNumber;
            this.txtAccountNumber.Size = new System.Drawing.Size(438, 30);
            this.txtAccountNumber.TabIndex = 33;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(162, 374);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(114, 19);
            this.guna2HtmlLabel6.TabIndex = 32;
            this.guna2HtmlLabel6.Text = "Account Number";
            // 
            // comboGender
            // 
            this.comboGender.BackColor = System.Drawing.Color.Transparent;
            this.comboGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.FocusedColor = System.Drawing.Color.Empty;
            this.comboGender.FocusedState.Parent = this.comboGender;
            this.comboGender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboGender.FormattingEnabled = true;
            this.comboGender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.comboGender.HoverState.Parent = this.comboGender;
            this.comboGender.ItemHeight = 30;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.ItemsAppearance.Parent = this.comboGender;
            this.comboGender.Location = new System.Drawing.Point(416, 183);
            this.comboGender.Name = "comboGender";
            this.comboGender.ShadowDecoration.Parent = this.comboGender;
            this.comboGender.Size = new System.Drawing.Size(184, 36);
            this.comboGender.TabIndex = 31;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(416, 157);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(51, 19);
            this.guna2HtmlLabel5.TabIndex = 30;
            this.guna2HtmlLabel5.Text = "Gender";
            // 
            // txtTelephone
            // 
            this.txtTelephone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelephone.BorderRadius = 6;
            this.txtTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelephone.DefaultText = "";
            this.txtTelephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelephone.DisabledState.Parent = this.txtTelephone;
            this.txtTelephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtTelephone.FocusedState.Parent = this.txtTelephone;
            this.txtTelephone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelephone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtTelephone.HoverState.Parent = this.txtTelephone;
            this.txtTelephone.Location = new System.Drawing.Point(162, 110);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.PasswordChar = '\0';
            this.txtTelephone.PlaceholderText = "";
            this.txtTelephone.SelectedText = "";
            this.txtTelephone.ShadowDecoration.Parent = this.txtTelephone;
            this.txtTelephone.Size = new System.Drawing.Size(438, 30);
            this.txtTelephone.TabIndex = 29;
            this.txtTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelephone_KeyPress);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(162, 84);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(69, 19);
            this.guna2HtmlLabel4.TabIndex = 28;
            this.guna2HtmlLabel4.Text = "Telephone";
            // 
            // dateDob
            // 
            this.dateDob.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateDob.BorderRadius = 6;
            this.dateDob.CheckedState.Parent = this.dateDob;
            this.dateDob.FillColor = System.Drawing.Color.Transparent;
            this.dateDob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDob.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.dateDob.HoverState.Parent = this.dateDob;
            this.dateDob.Location = new System.Drawing.Point(162, 183);
            this.dateDob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateDob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateDob.Name = "dateDob";
            this.dateDob.ShadowDecoration.Parent = this.dateDob;
            this.dateDob.Size = new System.Drawing.Size(184, 36);
            this.dateDob.TabIndex = 27;
            this.dateDob.Value = new System.DateTime(2021, 11, 10, 23, 25, 47, 251);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(162, 157);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(83, 19);
            this.guna2HtmlLabel3.TabIndex = 26;
            this.guna2HtmlLabel3.Text = "Date of Birth";
            // 
            // txtLastname
            // 
            this.txtLastname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastname.BorderRadius = 6;
            this.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastname.DefaultText = "";
            this.txtLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastname.DisabledState.Parent = this.txtLastname;
            this.txtLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtLastname.FocusedState.Parent = this.txtLastname;
            this.txtLastname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtLastname.HoverState.Parent = this.txtLastname;
            this.txtLastname.Location = new System.Drawing.Point(416, 46);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PasswordChar = '\0';
            this.txtLastname.PlaceholderText = "";
            this.txtLastname.SelectedText = "";
            this.txtLastname.ShadowDecoration.Parent = this.txtLastname;
            this.txtLastname.Size = new System.Drawing.Size(184, 30);
            this.txtLastname.TabIndex = 25;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(416, 20);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(66, 19);
            this.guna2HtmlLabel2.TabIndex = 24;
            this.guna2HtmlLabel2.Text = "Lastname";
            // 
            // txtFirstname
            // 
            this.txtFirstname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirstname.BorderRadius = 6;
            this.txtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstname.DefaultText = "";
            this.txtFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstname.DisabledState.Parent = this.txtFirstname;
            this.txtFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtFirstname.FocusedState.Parent = this.txtFirstname;
            this.txtFirstname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtFirstname.HoverState.Parent = this.txtFirstname;
            this.txtFirstname.Location = new System.Drawing.Point(162, 46);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.PasswordChar = '\0';
            this.txtFirstname.PlaceholderText = "";
            this.txtFirstname.SelectedText = "";
            this.txtFirstname.ShadowDecoration.Parent = this.txtFirstname;
            this.txtFirstname.Size = new System.Drawing.Size(184, 30);
            this.txtFirstname.TabIndex = 23;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(162, 20);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(64, 19);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = "Firstname";
            // 
            // addGuarantorTab
            // 
            this.addGuarantorTab.Controls.Add(this.txtSubmit);
            this.addGuarantorTab.Controls.Add(this.txtGAddress);
            this.addGuarantorTab.Controls.Add(this.guna2HtmlLabel7);
            this.addGuarantorTab.Controls.Add(this.txtGTelephone);
            this.addGuarantorTab.Controls.Add(this.guna2HtmlLabel11);
            this.addGuarantorTab.Controls.Add(this.txtGLastname);
            this.addGuarantorTab.Controls.Add(this.guna2HtmlLabel13);
            this.addGuarantorTab.Controls.Add(this.txtGFirstname);
            this.addGuarantorTab.Controls.Add(this.guna2HtmlLabel14);
            this.addGuarantorTab.Location = new System.Drawing.Point(4, 26);
            this.addGuarantorTab.Name = "addGuarantorTab";
            this.addGuarantorTab.Padding = new System.Windows.Forms.Padding(3);
            this.addGuarantorTab.Size = new System.Drawing.Size(763, 441);
            this.addGuarantorTab.TabIndex = 1;
            this.addGuarantorTab.Text = "Guarantor";
            this.addGuarantorTab.UseVisualStyleBackColor = true;
            // 
            // txtSubmit
            // 
            this.txtSubmit.BorderRadius = 12;
            this.txtSubmit.CheckedState.Parent = this.txtSubmit;
            this.txtSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSubmit.CustomImages.Parent = this.txtSubmit;
            this.txtSubmit.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubmit.ForeColor = System.Drawing.Color.White;
            this.txtSubmit.HoverState.Parent = this.txtSubmit;
            this.txtSubmit.Location = new System.Drawing.Point(161, 336);
            this.txtSubmit.Name = "txtSubmit";
            this.txtSubmit.ShadowDecoration.Parent = this.txtSubmit;
            this.txtSubmit.Size = new System.Drawing.Size(452, 39);
            this.txtSubmit.TabIndex = 54;
            this.txtSubmit.Text = "Submit";
            this.txtSubmit.Click += new System.EventHandler(this.txtSubmit_Click);
            // 
            // txtGAddress
            // 
            this.txtGAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGAddress.BorderRadius = 6;
            this.txtGAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGAddress.DefaultText = "";
            this.txtGAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGAddress.DisabledState.Parent = this.txtGAddress;
            this.txtGAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtGAddress.FocusedState.Parent = this.txtGAddress;
            this.txtGAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtGAddress.HoverState.Parent = this.txtGAddress;
            this.txtGAddress.Location = new System.Drawing.Point(161, 270);
            this.txtGAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGAddress.Name = "txtGAddress";
            this.txtGAddress.PasswordChar = '\0';
            this.txtGAddress.PlaceholderText = "";
            this.txtGAddress.SelectedText = "";
            this.txtGAddress.ShadowDecoration.Parent = this.txtGAddress;
            this.txtGAddress.Size = new System.Drawing.Size(438, 30);
            this.txtGAddress.TabIndex = 53;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(161, 244);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(52, 19);
            this.guna2HtmlLabel7.TabIndex = 52;
            this.guna2HtmlLabel7.Text = "Address";
            // 
            // txtGTelephone
            // 
            this.txtGTelephone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGTelephone.BorderRadius = 6;
            this.txtGTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGTelephone.DefaultText = "";
            this.txtGTelephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGTelephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGTelephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGTelephone.DisabledState.Parent = this.txtGTelephone;
            this.txtGTelephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGTelephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtGTelephone.FocusedState.Parent = this.txtGTelephone;
            this.txtGTelephone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGTelephone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtGTelephone.HoverState.Parent = this.txtGTelephone;
            this.txtGTelephone.Location = new System.Drawing.Point(161, 193);
            this.txtGTelephone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGTelephone.Name = "txtGTelephone";
            this.txtGTelephone.PasswordChar = '\0';
            this.txtGTelephone.PlaceholderText = "";
            this.txtGTelephone.SelectedText = "";
            this.txtGTelephone.ShadowDecoration.Parent = this.txtGTelephone;
            this.txtGTelephone.Size = new System.Drawing.Size(438, 30);
            this.txtGTelephone.TabIndex = 47;
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(161, 167);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(69, 19);
            this.guna2HtmlLabel11.TabIndex = 46;
            this.guna2HtmlLabel11.Text = "Telephone";
            // 
            // txtGLastname
            // 
            this.txtGLastname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGLastname.BorderRadius = 6;
            this.txtGLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGLastname.DefaultText = "";
            this.txtGLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGLastname.DisabledState.Parent = this.txtGLastname;
            this.txtGLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtGLastname.FocusedState.Parent = this.txtGLastname;
            this.txtGLastname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtGLastname.HoverState.Parent = this.txtGLastname;
            this.txtGLastname.Location = new System.Drawing.Point(415, 129);
            this.txtGLastname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGLastname.Name = "txtGLastname";
            this.txtGLastname.PasswordChar = '\0';
            this.txtGLastname.PlaceholderText = "";
            this.txtGLastname.SelectedText = "";
            this.txtGLastname.ShadowDecoration.Parent = this.txtGLastname;
            this.txtGLastname.Size = new System.Drawing.Size(184, 30);
            this.txtGLastname.TabIndex = 43;
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(415, 103);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(66, 19);
            this.guna2HtmlLabel13.TabIndex = 42;
            this.guna2HtmlLabel13.Text = "Lastname";
            // 
            // txtGFirstname
            // 
            this.txtGFirstname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGFirstname.BorderRadius = 6;
            this.txtGFirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGFirstname.DefaultText = "";
            this.txtGFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGFirstname.DisabledState.Parent = this.txtGFirstname;
            this.txtGFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtGFirstname.FocusedState.Parent = this.txtGFirstname;
            this.txtGFirstname.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.txtGFirstname.HoverState.Parent = this.txtGFirstname;
            this.txtGFirstname.Location = new System.Drawing.Point(161, 129);
            this.txtGFirstname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGFirstname.Name = "txtGFirstname";
            this.txtGFirstname.PasswordChar = '\0';
            this.txtGFirstname.PlaceholderText = "";
            this.txtGFirstname.SelectedText = "";
            this.txtGFirstname.ShadowDecoration.Parent = this.txtGFirstname;
            this.txtGFirstname.Size = new System.Drawing.Size(184, 30);
            this.txtGFirstname.TabIndex = 41;
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(161, 103);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(64, 19);
            this.guna2HtmlLabel14.TabIndex = 40;
            this.guna2HtmlLabel14.Text = "Firstname";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 608);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.PanelTopOfficer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClient";
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.PanelTopOfficer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.tabControlClient.ResumeLayout(false);
            this.addClientTab.ResumeLayout(false);
            this.addClientTab.PerformLayout();
            this.addGuarantorTab.ResumeLayout(false);
            this.addGuarantorTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel PanelTopOfficer;
        private Guna.UI2.WinForms.Guna2PictureBox picMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox picMaximize;
        private Guna.UI2.WinForms.Guna2PictureBox picClose;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage addClientTab;
        private System.Windows.Forms.TabPage addGuarantorTab;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2ComboBox comboGender;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtTelephone;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateDob;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtLastname;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstname;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtGAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtGTelephone;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2TextBox txtGLastname;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2TextBox txtGFirstname;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2TextBox txtIdNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private Guna.UI2.WinForms.Guna2ComboBox ComboIdType;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2Button txtSubmit;
    }
}
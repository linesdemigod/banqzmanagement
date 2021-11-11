namespace banqzManagement.View.userpanel
{
    partial class Backup
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnBackup = new Guna.UI2.WinForms.Guna2Button();
            this.btnRestore = new Guna.UI2.WinForms.Guna2Button();
            this.PanelTopOfficer = new Guna.UI2.WinForms.Guna2Panel();
            this.picMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picMaximize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dashboardShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2GroupBox1.SuspendLayout();
            this.PanelTopOfficer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.Controls.Add(this.btnRestore);
            this.guna2GroupBox1.Controls.Add(this.btnBackup);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 61);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Depth = 10;
            this.guna2GroupBox1.ShadowDecoration.Enabled = true;
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.guna2GroupBox1.Size = new System.Drawing.Size(578, 308);
            this.guna2GroupBox1.TabIndex = 1;
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackup.BorderRadius = 12;
            this.btnBackup.CheckedState.Parent = this.btnBackup;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.CustomImages.Parent = this.btnBackup;
            this.btnBackup.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.HoverState.Parent = this.btnBackup;
            this.btnBackup.Location = new System.Drawing.Point(62, 135);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.ShadowDecoration.Parent = this.btnBackup;
            this.btnBackup.Size = new System.Drawing.Size(184, 39);
            this.btnBackup.TabIndex = 25;
            this.btnBackup.Text = "Backup";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestore.BorderRadius = 12;
            this.btnRestore.CheckedState.Parent = this.btnRestore;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.CustomImages.Parent = this.btnRestore;
            this.btnRestore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(27)))), ((int)(((byte)(67)))));
            this.btnRestore.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.HoverState.Parent = this.btnRestore;
            this.btnRestore.Location = new System.Drawing.Point(343, 135);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ShadowDecoration.Parent = this.btnRestore;
            this.btnRestore.Size = new System.Drawing.Size(184, 39);
            this.btnRestore.TabIndex = 26;
            this.btnRestore.Text = "Restore";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
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
            this.PanelTopOfficer.Size = new System.Drawing.Size(601, 55);
            this.PanelTopOfficer.TabIndex = 22;
            this.PanelTopOfficer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Backup_MouseDown);
            this.PanelTopOfficer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Backup_MouseMove);
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::banqzManagement.Properties.Resources.Minimize_icon;
            this.picMinimize.Location = new System.Drawing.Point(514, 12);
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
            this.picMaximize.Location = new System.Drawing.Point(541, 12);
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
            this.picClose.Location = new System.Drawing.Point(568, 12);
            this.picClose.Name = "picClose";
            this.picClose.ShadowDecoration.Parent = this.picClose;
            this.picClose.Size = new System.Drawing.Size(21, 19);
            this.picClose.TabIndex = 21;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 381);
            this.Controls.Add(this.PanelTopOfficer);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Backup_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.PanelTopOfficer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnRestore;
        private Guna.UI2.WinForms.Guna2Button btnBackup;
        private Guna.UI2.WinForms.Guna2Panel PanelTopOfficer;
        private Guna.UI2.WinForms.Guna2PictureBox picMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox picMaximize;
        private Guna.UI2.WinForms.Guna2PictureBox picClose;
        private Guna.UI2.WinForms.Guna2ShadowForm dashboardShadowForm;
    }
}
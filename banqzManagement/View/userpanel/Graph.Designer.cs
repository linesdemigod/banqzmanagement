namespace banqzManagement.View.userpanel
{
    partial class Graph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chartLoans = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PanelTopOfficer = new Guna.UI2.WinForms.Guna2Panel();
            this.picMinimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picMaximize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoans)).BeginInit();
            this.PanelTopOfficer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2GroupBox1.Controls.Add(this.comboYear);
            this.guna2GroupBox1.Controls.Add(this.chartLoans);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(13, 79);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Depth = 10;
            this.guna2GroupBox1.ShadowDecoration.Enabled = true;
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(994, 534);
            this.guna2GroupBox1.TabIndex = 32;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(81, 73);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(89, 18);
            this.guna2HtmlLabel7.TabIndex = 14;
            this.guna2HtmlLabel7.Text = "Filter by year";
            // 
            // comboYear
            // 
            this.comboYear.BackColor = System.Drawing.Color.Transparent;
            this.comboYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboYear.DropDownHeight = 80;
            this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYear.FocusedColor = System.Drawing.Color.Empty;
            this.comboYear.FocusedState.Parent = this.comboYear;
            this.comboYear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboYear.FormattingEnabled = true;
            this.comboYear.HoverState.Parent = this.comboYear;
            this.comboYear.IntegralHeight = false;
            this.comboYear.ItemHeight = 30;
            this.comboYear.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comboYear.ItemsAppearance.Parent = this.comboYear;
            this.comboYear.Location = new System.Drawing.Point(187, 56);
            this.comboYear.Name = "comboYear";
            this.comboYear.ShadowDecoration.Parent = this.comboYear;
            this.comboYear.Size = new System.Drawing.Size(140, 36);
            this.comboYear.TabIndex = 13;
            this.comboYear.SelectedIndexChanged += new System.EventHandler(this.comboYear_SelectedIndexChanged);
            // 
            // chartLoans
            // 
            this.chartLoans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartLoans.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartLoans.Legends.Add(legend1);
            this.chartLoans.Location = new System.Drawing.Point(29, 115);
            this.chartLoans.Name = "chartLoans";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Amount Disbursed";
            series1.YValueMembers = "Amount Disbursed";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Repayment";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Outstanding";
            this.chartLoans.Series.Add(series1);
            this.chartLoans.Series.Add(series2);
            this.chartLoans.Series.Add(series3);
            this.chartLoans.Size = new System.Drawing.Size(938, 409);
            this.chartLoans.TabIndex = 0;
            this.chartLoans.Text = "chart1";
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
            this.PanelTopOfficer.Size = new System.Drawing.Size(1019, 55);
            this.PanelTopOfficer.TabIndex = 31;
            this.PanelTopOfficer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Report_MouseDown);
            this.PanelTopOfficer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Report_MouseMove);
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::banqzManagement.Properties.Resources.Minimize_icon;
            this.picMinimize.Location = new System.Drawing.Point(932, 12);
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
            this.picMaximize.Location = new System.Drawing.Point(959, 12);
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
            this.picClose.Location = new System.Drawing.Point(986, 12);
            this.picClose.Name = "picClose";
            this.picClose.ShadowDecoration.Parent = this.picClose;
            this.picClose.Size = new System.Drawing.Size(21, 19);
            this.picClose.TabIndex = 21;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 615);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.PanelTopOfficer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Graph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoans)).EndInit();
            this.PanelTopOfficer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Panel PanelTopOfficer;
        private Guna.UI2.WinForms.Guna2PictureBox picMinimize;
        private Guna.UI2.WinForms.Guna2PictureBox picMaximize;
        private Guna.UI2.WinForms.Guna2PictureBox picClose;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLoans;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2ComboBox comboYear;
    }
}
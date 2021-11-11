using banqzManagement.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banqzManagement.View.userpanel
{
    public partial class Backup : Form
    {
        Backups backup = new Backups();

        public Backup()
        {
            InitializeComponent();
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            //create shadow around the form
            dashboardShadowForm.SetShadowForm(this);
        }


        //when the control button is clicked 
        #region minimize maximize close
        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMaximize_Click(object sender, EventArgs e)
        {

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        //make the forms draggable
        #region Draggable
        //make forms draggable
        private void Backup_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void Backup_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        #endregion

        private void createFolder()
        {
            string folderName = @"C:\Cog";

            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            createFolder();
            backup.backup();
            MessageBox.Show("Successful");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                backup.restore();
                MessageBox.Show("Successful");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

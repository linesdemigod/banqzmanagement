using banqzManagement.View.userpanel;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banqzManagement.View
{
    public partial class Dashboard : KryptonForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //create shadow around the form
            //dashboardShadowForm.SetShadowForm(this);

            //maximize form
            maximizeForm();
        }

        private void maximizeForm()
        {

            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }
        

        //make the forms draggable
        #region Draggable
        //make forms draggable
        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        #endregion

      
        //open the officer forms
        private void btnOfficer_Click(object sender, EventArgs e)
        {
            Officer user = new Officer();
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
        }

        //logout user out
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to logout? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                Login form = new Login();
                form.Show();
                this.Hide();

            }
        }

        //open the profile form
        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile user = new Profile();
            user.TopLevel = false;
            //this.WindowState = FormWindowState.Maximized;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
        }

        //open the backup forms
        private void btnBackup_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.ShowDialog();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Client user = new Client();
            user.TopLevel = false;
            user.FormBorderStyle = FormBorderStyle.None;
            user.Dock = DockStyle.Fill;
            panelMain.Controls.Add(user);
            panelMain.Tag = user;
            user.BringToFront();
            user.Show();
        }
    }
}

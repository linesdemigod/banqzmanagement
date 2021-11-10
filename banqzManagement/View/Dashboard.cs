using banqzManagement.View.userpanel;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //create shadow around the form
            dashboardShadowForm.SetShadowForm(this);
            //a();
            this.WindowState = FormWindowState.Maximized;
        }

        private void a()
        {
            FormBorderStyle = FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }


        //create tooltip
        #region tooltip for maxi mini close
        public void toolTipMinimize()
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(picMinimize, "Minimize");

        }

        public void toolTipMaximize()
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            if (this.WindowState == FormWindowState.Normal)
            {  
                toolTip1.SetToolTip(picMaximize, "Maximize");  

            } else if (this.WindowState == FormWindowState.Maximized)
            {
                
                toolTip1.SetToolTip(picMaximize, "Restore");
            }
        }


        public void toolTipClose()
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(picClose, "Close");

        }
        #endregion

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

        //when the control button is clicked 
        #region minimize maximize close
        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        //mouser hover event handle for close,  minimize and maximize 
        #region mousehover maxi mini close
        private void picMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTipMinimize();
        }

        private void picMaximize_MouseHover(object sender, EventArgs e)
        {
            toolTipMaximize();
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            toolTipClose();
        }
        #endregion

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
    }
}

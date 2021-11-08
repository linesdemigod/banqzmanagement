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
    public partial class Loadingbar : Form
    {
        public Loadingbar()
        {
            InitializeComponent();
        }

        public void login()
        {
            int role = Convert.ToInt32(Login.Login_role);
            if (role == 1)
            {
                Dashboard admindash = new Dashboard();
                admindash.Show();
                this.Hide();
                Login.L_role = "Super Admin";
            }
            else if (role == 2)
            {
                Dashboard manager = new Dashboard();
                manager.Show();
                this.Hide();
                Login.L_role = "Manager";
            }
            else if (role == 3)
            {
                Dashboard waiter = new Dashboard();
                waiter.Show();
                this.Hide();
                Login.L_role = "Cashier";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //progressBar1.Value += 2;
            guna2CircleProgressBar1.Value = guna2CircleProgressBar1.Value + 1;

            if (guna2CircleProgressBar1.Value >= 99)
            {
                //CALL THE LOGIN METHOD
                login();
                timer1.Enabled = false;
            }
        }
    }
}

using banqzManagement.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banqzManagement.View.userpanel
{
    public partial class Profile : Form
    {
        Profiles profile = new Profiles();

        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lblDoB.Text = Login.Login_dob;
            lblGender.Text = Login.Login_gender;
            lblPhone.Text = Login.Login_phone;
            lblUsername.Text = Login.Login_username;
            lblName.Text = Login.Login_fname + " " + Login.Login_lname;
            lblRole.Text = Login.L_role;
            lblUsername.Text = Login.Login_username;
        }

        //update user password
        public void UpdatePassword()
        {
            //assign the properties of the AddProduct class to the textbox and trim user input
            profile.password = txtPassword.Text.Trim();
            profile.id = Login.Login_username;
            txtConfirmPassword.Text.Trim();

            if (profile.password == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill all field");
                return;
            }

            if (profile.password != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password do not match");
                return;
            }

            if (profile.password.Length < 6)
            {
                MessageBox.Show("Password must be 6 or more");
                return;
            }

            //call the method in the AddProduct class
            profile.updatePassword();
            MessageBox.Show("Password Updated");

            profile.password = txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        //handles the user password
        private void txtSubmit_Click(object sender, EventArgs e)
        {
            UpdatePassword();
        }
    }
}

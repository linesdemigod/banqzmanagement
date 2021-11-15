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
    public partial class AddOfficer : Form
    {

        AddOfficers officer = new AddOfficers();

        public AddOfficer()
        {
            InitializeComponent();
        }

        private void AddOfficer_Load(object sender, EventArgs e)
        {
            getRole();
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
        private void AddOfficer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void AddOfficer_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        #endregion

        //method to put the the role into the combobox
        private void getRole()
        {
            int userLoggedInRole = Convert.ToInt32(Login.Login_role);

            if (userLoggedInRole == 2)
            {
                comboRole.Items.Add("Officer");

            }
            else
            {
                officer.getRole();
                comboRole.DataSource = officer.dt;
                comboRole.DisplayMember = "role";
                comboRole.ValueMember = "role_id";
            }
        }

        private void createOfficer()
        {
            //assign the properties of the AddUsers class to the textbox and trim user input
            officer.firstName = txtFirstname.Text.Trim();
            officer.lastName = txtLastname.Text.Trim();
            officer.dob = dateDob.Text;
            officer.telephone = txtTelephone.Text.Trim();
            officer.gender = comboGender.Text.Trim();
            officer.username = txtUsername.Text.Trim();
            officer.password = txtPassword.Text.Trim();
            officer.role = comboRole.Text.Trim();
            officer.status = comboStatus.Text;

            //check if the username exist
            bool uidExist = officer.uidExist();

            //check if the textboxes are empty
            if (officer.firstName == "" || officer.lastName == "" || officer.telephone == "" || officer.gender == "" || officer.username == "" || officer.password == "" || officer.role == "" || officer.status == "" || officer.dob == "")
            {
                MessageBox.Show("Please Fill all Field");

                return;

            }

            //check if the passwords are the same
            if (officer.password != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password do not match");
                return;
            }

            if (officer.password.Length < 6)
            {
                MessageBox.Show("Password must be 6 or more");
                return;
            }

            //check if username exist
            if (uidExist == true)
            {
                MessageBox.Show("Username Exist, please choose new username");
                return;
            }

            //call the method in the AddUsers class
            officer.createUser();
            MessageBox.Show("New user created");

            //clear textbox after successful insert
            officer.firstName = txtFirstname.Text = "";
            officer.lastName = txtLastname.Text = "";
            officer.telephone = txtTelephone.Text = "";
            officer.gender = comboGender.Text = "";
            officer.username = txtUsername.Text = "";
            officer.password = txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            officer.status = comboStatus.Text = "";
            officer.dob = dateDob.Text = "";

            //officer.role = comboRole.Text = "";
        }

        //handle the create officer function
        private void txtSubmit_Click(object sender, EventArgs e)
        {
            createOfficer();
        }

        //format txtbox to accept only numbers
        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}

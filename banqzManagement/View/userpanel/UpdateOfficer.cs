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
    public partial class UpdateOfficer : Form
    {
        Officers officer = new Officers();

        //variable for the columns
        string code, firstName, lastName, dobs, telephone, sex, uid, pwd, group, stat;

        
        public UpdateOfficer(string id, string role, string fname, string lname, string dob, string phone, string gender, string username, string password, string status)
        {
            InitializeComponent();

            code = id;
            group = role;
            firstName = fname;
            lastName = lname;
            stat = status;
            dobs = dob;
            telephone = phone;
            sex = gender;
            uid = username;
            pwd = password;
        }

        //handle the update event when clicked
        private void txtUpdate_Click(object sender, EventArgs e)
        {
            updateUser();
        }

        //form load
        private void UpdateOfficer_Load(object sender, EventArgs e)
        {
            loadUserInfo();
            setupUserAccess();
        }

        //format textbox to accept only numbers
        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
        private void UpdateOfficer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void UpdateOfficer_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion


        //load the values from the datagridview to the various textbox and combobox
        private void loadUserInfo()
        {
            txtFirstname.Text = firstName;
            txtLastname.Text = lastName;
            dateDob.Text = dobs;
            txtTelephone.Text = telephone;
            comboGender.Text = sex;
            txtUsername.Text = uid;
            txtPassword.Text = pwd;
            comboRole.Text = group;
            comboStatus.Text = stat;
            txtId.Text = code;
        }


        //method to validate before updating the user
        private void updateUser()
        {
            officer.firstName = txtFirstname.Text;
            officer.lastName = txtLastname.Text;
            officer.dob = dateDob.Text;
            officer.telephone = txtTelephone.Text;
            officer.gender = comboGender.Text;
            officer.username = txtUsername.Text;
            officer.password = txtPassword.Text;
            officer.status = comboStatus.Text;
            officer.role = comboRole.Text;
            officer.id = txtId.Text;

            //check if the textboxes are empty
            if (officer.firstName == "" || officer.lastName == "" || officer.telephone == "" || officer.gender == "" || officer.username == "" || officer.password == "" || officer.role == "" || officer.status == "" || officer.dob == "")
            {
                MessageBox.Show("Please Fill all Field");

                return;

            }

            if (officer.password.Length < 6)
            {
                MessageBox.Show("Password must be 6 or more");

                return;
            }

            officer.updateUser();
            MessageBox.Show("Account updated successfully");

            //clear textbox after successful insert
            officer.firstName = txtFirstname.Text = "";
            officer.lastName = txtLastname.Text = "";
            officer.telephone = txtTelephone.Text = "";
            officer.gender = comboGender.Text = "";
            officer.username = txtUsername.Text = "";
            officer.password = txtPassword.Text = "";
            //txtConfirmPassword.Text = "";
            officer.status = comboStatus.Text = "";
            officer.dob = dateDob.Text = "";

            Close();
        }


        //validate Admin and manager
        public void setupUserAccess()
        {

            int userLoggedInRole = Convert.ToInt32(Login.Login_role);

            //Instance of the AddUser class
            AddOfficers user = new AddOfficers();

            switch (userLoggedInRole)
            {
                case 2:
                    txtPassword.Visible = false;
                    comboRole.Items.Add("Officer");


                    break;
                default:
                    user.getRole();
                    comboRole.DataSource = user.dt;
                    comboRole.DisplayMember = "role";
                    comboRole.ValueMember = "role_id";
                    break;
            }

        }

    }
}

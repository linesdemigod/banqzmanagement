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
    public partial class UpdateClient : Form
    {
        Clients client = new Clients();


        string CId, officerName, firstname, lastname, dobs, telephone, sex, CAddress, CIdType, CIdNumber, CAccountNumber, GFirstname, GLastname, GPhone, GAddress;


        public UpdateClient(string id, string officer, string fname, string lname, string dob, string phone, string gender, string address, string idType, string idNumber, string accountNumber, string gFirstname, string gLastname, string gPhone, string gAddress)
        {
            InitializeComponent();

            CId = id;
            officerName = officer;
            firstname = fname;
            lastname = lname;
            dobs = dob;
            telephone = phone;
            sex = gender;
            CAddress = address;
            CIdType = idType;
            CIdNumber = idNumber;
            CAccountNumber = accountNumber;
            GFirstname = gFirstname;
            GLastname = gLastname;
            GPhone = gPhone;
            GAddress = gAddress;
        }

        //when forms load
        private void UpdateClient_Load(object sender, EventArgs e)
        {
            loadClientInfo();
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
        private void AddClient_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void AddClient_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        #endregion


        //handle the update client
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateClient();
        }


        //load the values from the datagridview to the various textbox and combobox
        private void loadClientInfo()
        {
            txtFirstname.Text = firstname;
            txtLastname.Text = lastname;
            dateDob.Text = dobs;
            txtTelephone.Text = telephone;
            comboGender.Text = sex;
            txtAddress.Text = CAddress;
            ComboIdType.Text = CIdType;
            txtIdNumber.Text = CIdNumber;
            txtGFirstname.Text = GFirstname;
            txtGLastname.Text = GLastname;
            txtGTelephone.Text = GPhone;
            txtGAddress.Text = GAddress;
            txtAccountNumber.Text = CAccountNumber;

            txtID.Text = CId;
        }

        private void updateClient()
        {
           
            //assign the properties of the AddUsers class to the textbox and trim user input
            client.firstName = txtFirstname.Text.Trim();
            client.lastName = txtLastname.Text.Trim();
            client.dob = dateDob.Text;
            client.telephone = txtTelephone.Text.Trim();
            client.gender = comboGender.Text.Trim();
            client.accountNumber = txtAccountNumber.Text.Trim();
            client.idNumber = txtIdNumber.Text.Trim();
            client.idType = ComboIdType.Text.Trim();
            client.address = txtAddress.Text.Trim();
            client.guarantorFirstname = txtGFirstname.Text;
            client.guarantorLastname = txtGLastname.Text;
            client.guarantorPhone = txtGTelephone.Text;
            client.guarantorAddress = txtGAddress.Text;
            client.officer = Login.Login_username;
            client.id = txtID.Text;
            

            //check if username exist


            //check if the textboxes are empty
            if (client.firstName == "" || client.lastName == "" || client.telephone == "" || client.gender == "" || client.idNumber == "" || client.idType == "" || client.address == "" || client.guarantorFirstname == "" || client.dob == "" || client.guarantorLastname == "" || client.guarantorPhone == "" || client.guarantorAddress == "")
            {
                MessageBox.Show("Please Fill all Field");

                return;

            }
            


            //call the method in the AddClient class
            client.updateClient();
            MessageBox.Show("Client Account Updated");

            //clear textbox after successful insert
            client.firstName = txtFirstname.Text = "";
            client.lastName = txtLastname.Text = "";
            client.telephone = txtTelephone.Text = "";
            client.gender = comboGender.Text = "";
            client.dob = dateDob.Text = "";
            client.idNumber = txtIdNumber.Text = "";
            client.idType = ComboIdType.Text = "";
            client.address = txtAddress.Text = "";
            client.guarantorFirstname = txtGFirstname.Text = "";
            client.guarantorLastname = txtGLastname.Text = "";
            client.guarantorPhone = txtGTelephone.Text = "";
            client.guarantorAddress = txtGAddress.Text = "";

            //client.role = comboRole.Text = "";

            Close();
        }

        //format textbox to accept only numbers
        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    
}

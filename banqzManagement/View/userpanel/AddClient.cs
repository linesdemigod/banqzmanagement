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
    public partial class AddClient : Form
    {
        AddClients client = new AddClients();

        public AddClient()
        {
            InitializeComponent();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
          //generate random number as accountnumber
            getRand();
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

        //generate random number
        private void getRand()
        {
            Random rand = new Random();
            txtAccountNumber.Text = "0111145444";
                //+ rand.Next();
        }


        private void createClient()
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

            //check if the username exist
            bool accountNumberExist = client.accountNumberExist();


            

            //check if the textboxes are empty
            if (client.firstName == "" || client.lastName == "" || client.telephone == "" || client.gender == "" || client.idNumber == "" || client.idType == "" || client.address == "" || client.guarantorFirstname == "" || client.dob == "" || client.guarantorLastname == "" || client.guarantorPhone == "" || client.guarantorAddress == "")
            {
                MessageBox.Show("Please Fill all Field");

                return;

            }

            //check if username exist
            if (accountNumberExist == true)
            {
                MessageBox.Show("Client ");
                //txtAccountNumber.Text += "1";

                return;
            }

            //call the method in the AddClient class
            client.createUser();
            MessageBox.Show("New Client created");

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
        }

        

        //event handler for the insert click data
        private void txtSubmit_Click(object sender, EventArgs e)
        {
            createClient();
                getRand();
        }

       
    }
}

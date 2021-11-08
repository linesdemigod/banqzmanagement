
using banqzManagement.Controller;
using banqzManagement.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace banqzManagement
{
    public partial class Login : Form
    {
        //instance of login class in the controller
        Logins user = new Logins();

        //transfer to another form
        public static string Login_username { get; set; }
        public static string L_role { get; set; }
        public static string Login_phone { get; set; }
        public static string Login_gender { get; set; }
        public static string Login_fname { get; set; }
        public static string Login_lname { get; set; }
        public static string Login_role { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void login()
        {
            try
            {
                //ASSIGN THE VARIABLE TO THE USER INPUT
                user.username = txtUser.Text.Trim();
                user.password = txtPass.Text.Trim();
                bool verify = user.user_verification();

                //Validate if the textbox is empty
                if (user.username == "" || user.password == "")
                {

                    MessageBox.Show("Fill all field");
                }
                else
                {

                    if (verify)
                    {
                        //MessageBox.Show("Successfully login");
                        int role = user.role;
                        Login_role = user.role.ToString();
                        Login_username = user.username;
                        Login_fname = user.fname;
                        Login_lname = user.lname;
                        Login_phone = user.phone;
                        Login_gender = user.gender;

                        
                        Loadingbar load = new Loadingbar();
                        load.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection error");
            }
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void chkBoxSHowPassword_CheckedChanged(object sender, EventArgs e)
        {
            showHidePassword();
        }

        private void showHidePassword()
        {
            if (chkBoxSHowPassword.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
                txtPass.PasswordChar = '\0';
                chkBoxSHowPassword.Text = "Hide Password";
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                chkBoxSHowPassword.Text = "Show Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        #region Draggable
        //make forms draggable
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        #endregion

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

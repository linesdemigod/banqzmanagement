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
    public partial class UpdateRepayment : Form
    {
        //instance of the update class
        UpdateRepayments repay = new UpdateRepayments();

        public UpdateRepayment(string id, string name, string account, string amount, string outstanding, string remark, string officer)
        {
            InitializeComponent();

            //assign the values to the various labels and textboxes
            lblID.Text = id;
            lblName.Text = name;
            lblAccount.Text = account;
            txtRemark.Text = remark;
            txtAmount.Text = amount;
            txtOutstanding.Text = outstanding;
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

        
        private void updateRepayment()
        {
            repay.officer = Login.Login_username;
            repay.amount = txtAmount.Text;
            repay.outstanding = txtOutstanding.Text;
            repay.id = lblID.Text;

            if (txtAmount.Text == "" || txtOutstanding.Text == "" || txtRemark.Text == "")
            {
                MessageBox.Show("Please Fill all Field");

                return;
            }

            repay.updateRepayment();
            MessageBox.Show("Repayment Updated");
            lblID.Text = "";
            lblAccount.Text = "";
            lblName.Text = "";
            txtAmount.Text = "";
            txtOutstanding.Text = "";
            txtRemark.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Do you want to update? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    updateRepayment();
                }

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       private void acceptOnlyDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

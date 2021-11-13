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
    public partial class Loan : Form
    {
        Loans loan = new Loans();

        public Loan()
        {
            InitializeComponent();
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            getInterestRates();
        }

        private void calcExpiryDate()
        {
            try
            {
                
                DateTime date = Convert.ToDateTime(dateLoanDate.Text);

                int months = Convert.ToInt32(txtLoanDuration.Text);

                DateTime expiry = date.AddMonths(months);

                txtLoanExpiry.Text = expiry.ToShortDateString();
            }
            catch (Exception)
            {

               
            }
           
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            
        }

        private void txtLaonDuration_TextChanged(object sender, EventArgs e)
        {
            

            if (txtLoanDuration.Text == "")
            {
                txtLoanExpiry.Text = "";

            } else
            {
                calcExpiryDate();
            }
            
        }

        private void dateLoanDate_ValueChanged(object sender, EventArgs e)
        {
            txtLoanDuration.Text = "";
        }

        private void getAccountInfos()
        {
            loan.account = txtLoanSearch.Text;
            loan.getAccountInfo();
            lblLoanName.Text = loan.fname + " " + loan.lname;
            lblLoanPhone.Text = loan.phone;
            
            
        }

        private void btnLoanSearch_Click(object sender, EventArgs e)
        {
            getAccountInfos();
        }

        private void getInterestRates()
        {
            loan.getInterestRate();
            lblLoanInterestRate.Text = loan.interestRate + "%";
        }
    }
}

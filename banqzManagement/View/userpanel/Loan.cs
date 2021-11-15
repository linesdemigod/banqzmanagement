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

        #region NEW LOANS
        //add the loan duration to the contract to the get expiry date
        private void calcExpiryDate()
        {
            try
            {
                
                DateTime date = Convert.ToDateTime(dateLoanDate.Text);

                int months = Convert.ToInt32(txtLoanDuration.Text);

                DateTime expiry = date.AddMonths(months);

                txtLoanExpiry.Text = expiry.ToString("yyyy-MM-dd");
            }
            catch (Exception)
            {

               
            }
           
        }

        //call the new loan when the button is clicked
        private void btnLoan_Click(object sender, EventArgs e)
        {
            createNewLoan();
           
        }

        //
        private void txtLaonDuration_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtLoanDuration.Text == "")//check if the loan duration textbox is empty set the loan expiry to empty
                {
                    txtLoanExpiry.Text = "";

                }
                else
                {
                    calcExpiryDate(); //calc the expiry date
                    calcInterest(); //calc the interest
                    getLoanAndinterest(); //add interest and loan
                }
            }
            catch (Exception)
            {

                
            }
            
            
        }

        //set the loan duration textbox empty when the contract date changed
        private void dateLoanDate_ValueChanged(object sender, EventArgs e)
        {
            txtLoanDuration.Text = "";
        }


        //method to search for the client details
        private void getAccountInfos()
        {
            try
            {
                loan.account = txtLoanSearch.Text;
                loan.getAccountInfo();
                lblLoanName.Text = loan.fname + " " + loan.lname;
                lblLoanPhone.Text = loan.phone;
            }
            catch (Exception)
            {
                
            }
             
        }

        //search with the account number and the various result on the txtbox
        private void btnLoanSearch_Click(object sender, EventArgs e)
        {
            if (txtLoanSearch.Text == "")
            {
                lblLoanSearchMsg.Text = "Enter client account number";

                return;
            } else
            {
                getAccountInfos();

                lblLoanSearchMsg.Text = "";
            }
           
        }

        //get the interest rate to the label
        private void getInterestRates()
        {
            try
            {
                loan.getInterestRate();
                lblLoanInterestRate.Text = loan.interestRate;
            }
            catch (Exception)
            {

                
            }
            
        }

        //method to calculate the interest on the amount disbursed
        private void calcInterest()
        {
            try
            {
                double interestRate = Convert.ToDouble(lblLoanInterestRate.Text); //assign the values of the textboxes to a double variable
                double duration = Convert.ToDouble(txtLoanDuration.Text);
                double amountDisbursed = Convert.ToDouble(txtLoanDisbursed.Text);

                //calculate the interest on the loans
                double interest = ((interestRate / 100) * duration) * amountDisbursed;

                txtLoanInterest.Text = interest.ToString(); //assign the result value to the interest txtbox
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
            
        }

        //calculate the interest of the loan disbursed
        private void txtLoanDisbursed_TextChanged(object sender, EventArgs e)
        {
            calcInterest(); //calculate interest
            getLoanAndinterest(); //add loan and interest
        }

        private void txtLoanSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getAccountInfos();
            }
        }

        private void getLoanAndinterest()
        {
            try
            {
                double amountDisbursed = Convert.ToDouble(txtLoanDisbursed.Text);
                double loanInterest = Convert.ToDouble(txtLoanInterest.Text);
                double result = loanInterest + amountDisbursed;
                lblInterestLoanDisbursed.Text = result.ToString();
            }
            catch (Exception)
            {

                
            }
           
        }

        //insert the new loan to the loaninfo table
        private void createNewLoan()
        {
            try
            {
                loan.officer = Login.Login_username;
                loan.account = txtLoanSearch.Text;
                loan.amount = txtLoanDisbursed.Text;
                loan.interest = txtLoanInterest.Text;
                loan.duration = txtLoanDuration.Text;
                loan.dateStart = dateLoanDate.Text;
                loan.interestAmount = lblInterestLoanDisbursed.Text;
                loan.dateExpiry = txtLoanExpiry.Text;


                
                loan.account = txtLoanSearch.Text;
                loan.getOutstanding = "0";
                //check if the outstanding is created than zero
                loan.checkForOutstanding();

                double amount = Convert.ToDouble(loan.getOutstanding); //covert the outstanding value to double
                //MessageBox.Show(loan.getOutstanding);

                //validate the textbox
                if (txtLoanSearch.Text == "" || txtLoanDisbursed.Text == "" || txtLoanDuration.Text == "")
                {
                    MessageBox.Show("Please, fill all field");

                    return;
                }

              if (amount > 0) //check for the outstanding value
                {
                    //MessageBox.Show(amount.ToString());
                    MessageBox.Show("Client has running contract \n You can top up the loan ");

                    return;
                }

               
                    loan.insertNewLoan();
                    insertRepayment(); //call the isertrepayment function
                    MessageBox.Show("Loan created");


                    //clear the textbox 
                    lblLoanName.Text = "";
                    lblLoanPhone.Text = "";
                    txtLoanDisbursed.Text = "";
                    txtLoanInterest.Text = "";
                    txtLoanDuration.Text = "";
                    txtLoanExpiry.Text = "";
                    lblInterestLoanDisbursed.Text = "";
                    txtLoanSearch.Text = "";

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        
        //insert the new loan to repayment
        private void insertRepayment()
        {
            loan.officer = Login.Login_username;
            loan.account = txtLoanSearch.Text;
            loan.amount = "0";
            loan.outstanding = lblInterestLoanDisbursed.Text;
            loan.insertToRepayment();
            
        }

        private void txtLoanDisbursed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLoanDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion


        //search for the info
        private void btnTopSearch_Click(object sender, EventArgs e)
        {
            if (txtLoanSearch.Text == "")
            {
                lblLoanSearchMsg.Text = "Enter client account number";

                return;
            }
            else
            {
                getAccountInfos();

                lblLoanSearchMsg.Text = "";
            }
        }
    }
}

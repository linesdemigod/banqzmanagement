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
        AddTransactions trans = new AddTransactions();

        public Loan()
        {
            InitializeComponent();
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            getInterestRates();
        }

        


        #region NEW LOAN
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
            loan.account = txtLoanSearch.Text;
            bool accExist = loan.accountExist(); // check if account number exist

            if (accExist == false)
            {
                
                lblLoanName.Text = ".";
                lblLoanPhone.Text = ".";
                lblLoanSearchMsg.Text = "Account Number does not exist";

                return;
            }

            lblLoanSearchMsg.Text = "";
            loan.account = txtLoanSearch.Text;
            loan.getAccountInfo(); //call the getAccountInfo at the Loans class
            lblLoanName.Text = loan.fname + " " + loan.lname;
            lblLoanPhone.Text = loan.phone;
            lblAccountNum.Text = loan.account;
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

                
            }
           
        }

        //get the interest rate to the label
        private void getInterestRates()
        {
            try
            {
                loan.getInterestRate();
                lblLoanInterestRate.Text = loan.interestRate; //set the interest rate in the new loan TAB
               
                lblTopInterestRate.Text = loan.interestRate; //set the interest rate in the Top up loan TAB
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

        //allow user to press ENTER key once he enter the account and press enter
        private void txtLoanSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getAccountInfos();
            }
        }

        //add the amount disbursed and the interest
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
                loan.account = lblAccountNum.Text;
                loan.amount = txtLoanDisbursed.Text;
                loan.interest = txtLoanInterest.Text;
                loan.duration = txtLoanDuration.Text;
                loan.dateStart = dateLoanDate.Text;
                loan.interestAmount = lblInterestLoanDisbursed.Text;
                loan.dateExpiry = txtLoanExpiry.Text;


                
                loan.account = lblAccountNum.Text;
                loan.getOutstanding = "0";
                //check if the outstanding is created than zero
                loan.checkForOutstanding();

               
                double amount = Convert.ToDouble(loan.getOutstanding); //covert the outstanding value to double
                //MessageBox.Show(loan.getOutstanding);
                
                //validate the textbox
                if (txtLoanSearch.Text == "" || txtLoanDisbursed.Text == "" || txtLoanDuration.Text == "" || lblLoanName.Text == "." )
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
                    MessageBox.Show("New Loan Created");


                    //clear the textbox 
                    lblLoanName.Text = ".";
                    lblLoanPhone.Text = ".";
                    txtLoanDisbursed.Text = "";
                    txtLoanInterest.Text = "";
                    txtLoanDuration.Text = "";
                    txtLoanExpiry.Text = "";
                    lblInterestLoanDisbursed.Text = "";
                    txtLoanSearch.Text = "";
                    lblAccountNum.Text = "";

                
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
            loan.remark = "Repayment";
            loan.outstanding = lblInterestLoanDisbursed.Text;
            loan.insertToRepayment();
            
        }

        

        private void acceptNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        #endregion


        #region LOAN TOP-UP
        //calculate the expiry date
        private void calcTopExpiryDate()
        {
            try
            {

                DateTime date = Convert.ToDateTime(dateTopDate.Text);

                int months = Convert.ToInt32(txtTopDuration.Text);

                DateTime expiry = date.AddMonths(months);

                txtTopExpiry.Text = expiry.ToString("yyyy-MM-dd");
            }
            catch (Exception)
            {


            }

        }


        //add the amount disbursed and the interest
        private void getTopLoanAndinterest()
        {
            try
            {
                double amountDisbursed = Convert.ToDouble(txtTopAmountDisbursed.Text);
                double loanInterest = Convert.ToDouble(txtTopInterest.Text);
                double result = loanInterest + amountDisbursed;
                lblTopInterestLoanDisbursed.Text = result.ToString();
            }
            catch (Exception)
            {


            }

        }

        //search for the info
        private void btnTopSearch_Click(object sender, EventArgs e)
        {
            if (txtTopSearch.Text == "")
            {
                lblTopSearchMsg.Text = "Enter client account number";

                return;
            }
            else
            {
                getAccountInfoTop();

                
            }
        }

        //get the client info
        private void getAccountInfoTop()
        {
            try
            {
                loan.account = txtTopSearch.Text;
                bool accExist = loan.accountExist(); // check if account number exist

                if (accExist == false)
                {

                    lblTopName.Text = ".";
                    lblTopPhone.Text = ".";
                    lblTopSearchMsg.Text = "Account Number does not exist";

                    return;
                }

                lblTopSearchMsg.Text = "";
                loan.account = txtTopSearch.Text;
                loan.getAccountInfo();
                lblTopName.Text = loan.fname + " " + loan.lname;
                lblTopPhone.Text = loan.phone;
                lblTopAccount.Text = loan.account;
            }
            catch (Exception)
            {

            }
        }

        //press enter to search once the account number is entered in the textbox
        private void txtTopSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getAccountInfos();
            }
        }

        //calc the Top Up interest on the amount disbursed
        private void calcTopInterest()
        {
            try
            {
                double interestRate = Convert.ToDouble(lblTopInterestRate.Text); //assign the values of the textboxes to a double variable
                double duration = Convert.ToDouble(txtTopDuration.Text);
                double amountDisbursed = Convert.ToDouble(txtTopAmountDisbursed.Text);

                //calculate the interest on the loans
                double interest = ((interestRate / 100) * duration) * amountDisbursed;

                txtTopInterest.Text = interest.ToString(); //assign the result value to the interest txtbox
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
        }

        //calculate the interest when the value change in the amount disbursed textbox
        private void txtTopAmountDisbursed_TextChanged(object sender, EventArgs e)
        {
            calcTopInterest(); //calculate loan interest
            getTopLoanAndinterest(); //add interest and loan
        }

        //call the various function when the value of the duration is changed in the Top up
        private void txtTopDuration_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTopDuration.Text == "")//check if the loan duration textbox is empty set the loan expiry to empty
                {
                    txtTopExpiry.Text = "";

                }
                else
                {
                    calcTopExpiryDate(); //calc the expiry date
                    calcTopInterest(); //calc the interest
                    getTopLoanAndinterest(); //add interest and loan
                }
            }
            catch (Exception)
            {


            }
        }

        //set the value of the Duration at the top to empty when the contract date is changed
        private void dateTopDate_ValueChanged(object sender, EventArgs e)
        {
            txtTopDuration.Text = "";
        }


        //insert into loaninfo as new loan
        private void createTopUpLoan()
        {
            try
            {
                loan.officer = Login.Login_username;
                loan.account = lblTopAccount.Text;
                loan.amount = txtTopAmountDisbursed.Text;
                loan.interest = txtTopInterest.Text;
                loan.duration = txtTopDuration.Text;
                loan.dateStart = dateTopDate.Text;
                loan.interestAmount = lblTopInterestLoanDisbursed.Text;
                loan.dateExpiry = txtTopExpiry.Text;



                loan.account = lblTopAccount.Text;
                loan.getOutstanding = "0";
                //check if the outstanding is created than zero
                loan.checkForOutstanding();

                double amount = Convert.ToDouble(loan.getOutstanding); //covert the outstanding value to double
                //MessageBox.Show(loan.getOutstanding);

                //validate the textbox
                if (txtTopSearch.Text == "" || txtTopAmountDisbursed.Text == "" || txtTopDuration.Text == "" || lblTopName.Text == ".")
                {
                    MessageBox.Show("Please, fill all field");

                    return;
                }

                if (amount <= 0) //check for the outstanding value
                {
                    //MessageBox.Show(amount.ToString());
                    MessageBox.Show("You cannot Top-up loan \n Please assign him/her a new loan");

                    return;
                }


                loan.insertNewLoan();
                updateRepaymentTop(amount); //call the insertrepayment function and pass amount left as argument
                MessageBox.Show("Loan is Top-up");


                //clear the textbox 
                lblTopName.Text = ".";
                lblTopPhone.Text = ".";
                txtTopAmountDisbursed.Text = "";
                txtTopInterest.Text = "";
                txtTopDuration.Text = "";
                txtTopExpiry.Text = "";
                lblTopInterestLoanDisbursed.Text = "";
                txtTopSearch.Text = "";
                lblTopAccount.Text = "";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        //insert the new loan to repayment
        private void updateRepaymentTop(double amountLeft)
        {
            trans.officer = Login.Login_username;
            trans.account = txtTopSearch.Text;
            trans.amount = "0";
            trans.remark = "Repayment";
            double interestAmountDisbursed = Convert.ToDouble(lblTopInterestLoanDisbursed.Text);

            double result = interestAmountDisbursed + amountLeft;
            trans.outstanding = result.ToString();
            trans.updateToRepayment();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            createTopUpLoan();
        }

        #endregion

        #region LOAN FEE
        //get the client info in the Loan fees
        private void getAccountInfoFee()
        {
            try
            {
                loan.account = txtFeeSearch.Text;
                bool accExist = loan.accountExist(); // check if account number exist

                if (accExist == false)
                {

                    lblFeeName.Text = ".";
                    lblFeePhone.Text = ".";
                    lblFeeSearchMsg.Text = "Account Number does not exist";

                    return;
                }

                lblFeeSearchMsg.Text = "";

                loan.account = txtFeeSearch.Text;
                loan.getAccountInfo();
                lblFeeName.Text = loan.fname + " " + loan.lname;
                lblFeePhone.Text = loan.phone;
                lblFeeAccount.Text = loan.account;
            }
            catch (Exception)
            {

            }
        }

        //call the search for client function
        private void btnFeeSearch_Click(object sender, EventArgs e)
        {
            if (txtFeeSearch.Text == "")
            {
                lblFeeSearchMsg.Text = "Enter client account number";

                return;
            }
            else
            {
                getAccountInfoFee();
                
            }
        }

       private void insertLoanFee()
        {
            loan.account = lblFeeAccount.Text; 
            loan.officer = Login.Login_username;
            loan.purpose = comboFeePurpose.Text;
            loan.amount = txtFeeAmount.Text;
           

            //validate the textbox
            if (txtFeeSearch.Text == "" || txtFeeAmount.Text == "" || comboFeePurpose.Text == "" || lblFeeName.Text == ".")
            {
                MessageBox.Show("Please, fill all field");

                return;
            }


            loan.insertToLoanFee(); //insert into loan fees
            MessageBox.Show(comboFeePurpose.Text + " inserted");


            lblFeeName.Text = ".";
            lblFeePhone.Text = ".";
            txtFeeAmount.Text = "";
            txtFeeSearch.Text = "";
            comboFeePurpose.SelectedItem = null;
            lblFeeAccount.Text = "";

           

        }

        private void btnFeeSubmit_Click(object sender, EventArgs e)
        {
            insertLoanFee();
        }
        #endregion
    }
}

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
    public partial class AddTransaction : Form
    {
        Loans loan = new Loans();
        AddTransactions trans = new AddTransactions();


        public AddTransaction()
        {
            InitializeComponent();
        }

        #region REPAYMENT
        //get client information
        private void getAccountInfos()
        {
            loan.account = txtRepaymentSearch.Text;
            bool accExist = loan.accountExist(); // check if account number exist

            if (accExist == false)
            {
                //get the various label to period(.) when account number is not found
                lblRepaymentName.Text = ".";
                lblRepaymentPhone.Text = ".";
                txtRepaymentCurreOutstanding.Text = "0";
                lblRepaymentAccount.Text = ".";
                lblRepaymentSearchMsg.Text = "Account Number does not exist";

                return;
            }

            //call the method in the Loans class and insert the value to the various label
            lblRepaymentSearchMsg.Text = "";
            loan.account = txtRepaymentSearch.Text;
            loan.getAccountInfo();
            lblRepaymentAccount.Text = loan.account;
            lblRepaymentName.Text = loan.fname + " " + loan.lname;
            lblRepaymentPhone.Text = loan.phone;

            
            loan.getOutstanding = "0"; //set the outstanding to zero
            
            loan.checkForOutstanding(); //check the outstanding the account you search
            txtRepaymentCurreOutstanding.Text = loan.getOutstanding; //assign the outstanding value to the label
        }

        //handle the getaccountinfos function
        private void btnRepaymentSearch_Click(object sender, EventArgs e)
        {
            if (txtRepaymentSearch.Text == "") //check the search textbox is empty
            {
                lblRepaymentSearchMsg.Text = "Enter client account number";

                return;
            }
            else
            {
                getAccountInfos(); //call the get info function here
            }
        }

        //function to deduct the amount paid from the current oustanding
        //listens to textchange in the txtRepaymentCurreOutstanding and txtRepaymentAmount
        private void calcOutstanding(object sender, EventArgs e)
        {
            try
            {
                double outstanding = Convert.ToDouble(txtRepaymentCurreOutstanding.Text);
                double amount = Convert.ToDouble(txtRepaymentAmount.Text);

                double result = outstanding - amount;

                txtRepaymentOutstanding.Text = result.ToString();
            }
            catch (Exception ex)
            {

                
            }
            
        }

        //insert into repayment table
        private void insertRepayment()
        {
            try
            {
            //assign the values to the various textbox
            trans.officer = Login.Login_username;
            trans.account = lblRepaymentAccount.Text;
            trans.amount = txtRepaymentAmount.Text;
            trans.remark = "Repayment";
            trans.outstanding = txtRepaymentOutstanding.Text;

           

            if (txtRepaymentAmount.Text == "" )
            {
                MessageBox.Show("Please, fill all field");

                return;
            }

            if (lblRepaymentAccount.Text == ".")
            {
                MessageBox.Show("Search for Client Acoount Number");

                return;
            }

            if (txtRepaymentAmount.Text == "0" )
            {
                MessageBox.Show("Amount cannot be Zero");

                return;
            }

                //convert the oustanding to floating number
                double outstandinng = Convert.ToDouble(txtRepaymentOutstanding.Text);

                if (outstandinng < 0)
            {
                MessageBox.Show("Oustanding cannot be negative");

                return;
            }

            //call the insert loan method in the Loans class
            trans.updateToRepayment();
            MessageBox.Show("Repayment successful");

            //clear textbox and label
            lblRepaymentAccount.Text = ".";
            lblRepaymentName.Text = ".";
            lblRepaymentPhone.Text = ".";
            txtRepaymentCurreOutstanding.Text = "";
            txtRepaymentAmount.Text = "0";
            txtRepaymentOutstanding.Text = "";

            }
            catch (Exception)
            {

                
            }
        }



        private void btnRepaymentSubmit_Click(object sender, EventArgs e)
        {
            insertRepayment();
        }
        #endregion REPAYMENT


        #region TRANSFER
        //get client information
        private void getAccountInfosTransfer()
        {
            loan.account = txtTransferSearch.Text;
            bool accExist = loan.accountExist(); // check if account number exist

            if (accExist == false)
            {
                //get the various label to period(.) when account number is not found
                lblTransferName.Text = ".";
                lblTransferPhone.Text = ".";
                txtTransferCurreOutstanding.Text = "0";
                lblTransferAccount.Text = ".";
                lblTransferSearchMsg.Text = "Account Number does not exist";

                return;
            }

            //call the method in the Loans class and insert the value to the various label
            lblRepaymentSearchMsg.Text = "";
            loan.account = txtTransferSearch.Text;
            loan.getAccountInfo();
            lblTransferAccount.Text = loan.account;
            lblTransferName.Text = loan.fname + " " + loan.lname;
            lblTransferPhone.Text = loan.phone;


            loan.getOutstanding = "0"; //set the outstanding to zero
            loan.checkForOutstanding(); //check the outstanding the account you search
            txtTransferCurreOutstanding.Text = loan.getOutstanding; //assign the outstanding value to the textbox


            trans.account = txtTransferSearch.Text;
            trans.getAmount = "0"; //set the transfer amount
            trans.checkForTransfer(); //check the amount
            txtTransferAmount.Text = trans.getAmount; //assign the amount value to the textbox
            lblTransferID.Text = trans.id;
        }

        //
        private void btnTransferSearch_Click(object sender, EventArgs e)
        {
            if (txtTransferSearch.Text == "") //check the search textbox is empty
            {
                lblTransferSearchMsg.Text = "Enter client account number";

                return;
            }
            else
            {
                getAccountInfosTransfer(); //call the get info function here
            }
        }


        //function to deduct the amount paid from the current oustanding
        //listens to textchange in the txtTransferCurreOutstanding and txtTransferAmount
        private void calcOutstandingTransfer(object sender, EventArgs e)
        {
            try
            {
                double outstanding = Convert.ToDouble(txtTransferCurreOutstanding.Text);
                double amount = Convert.ToDouble(txtTransferAmount.Text);

                double result = outstanding - amount;

                txtTransferOutstanding.Text = result.ToString();
            }
            catch (Exception ex)
            {


            }

        }

        //insert the transfer amount to repayment
        private void insertTransfer()
        {
            try
            {

                trans.officer = Login.Login_username;
                trans.account = lblTransferAccount.Text;
                trans.amount = txtTransferAmount.Text;
                trans.remark = "Transfer";
                trans.outstanding = txtTransferOutstanding.Text;
           

                if (txtTransferAmount.Text == "0")
                {
                    MessageBox.Show("Client does not have any money to transfer");

                    return;
                }

                if (lblTransferAccount.Text == ".")
                {
                    MessageBox.Show("Search for Client Acoount Number");

                    return;
                }


                if (txtTransferCurreOutstanding.Text == "0")
                {
                    MessageBox.Show("You cannot make transfer");

                    return;
                }


                //convert the oustanding to floating number
                double outstandinng = Convert.ToDouble(txtTransferOutstanding.Text);

                if (outstandinng < 0)
                {
                    MessageBox.Show("Oustanding cannot be negative");

                    return;
                }



                //call the insert loan method in the Loans class
                trans.updateToRepayment();
                updateTransfers();
                MessageBox.Show("Transfer successful");

                //clear textbox and label
                lblTransferAccount.Text = ".";
                lblTransferName.Text = ".";
                lblTransferPhone.Text = ".";
                txtTransferCurreOutstanding.Text = "";
                txtTransferAmount.Text = "0";
                txtTransferOutstanding.Text = "";

            }
            catch (Exception)
            {

            }
        }

        //update client transfer table
        private void updateTransfers()
        {
            try
            {
                trans.id = lblTransferID.Text;
                trans.accNum = lblTransferAccount.Text;
                trans.officer = Login.Login_username;
                trans.account = lblTransferAccount.Text;
                trans.purpose = "Collateral";
                trans.amount = "0";
                trans.updateLoanFee();
            }
            catch (Exception)
            {

               
            }
            
        }

        //call the insertTransfer here
        private void btnTransferSubmit_Click(object sender, EventArgs e)
        {
            insertTransfer();
        }
        #endregion TRANSFER


        #region CHECK OUTSTANDING
        //function to get the info of client and check the outstanding
        private void getAccountInfosOutstanding()
        {
            loan.account = txtOutSearch.Text;
            bool accExist = loan.accountExist(); // check if account number exist

            if (accExist == false)
            {
                //get the various label to period(.) when account number is not found
                lblOutName.Text = ".";
                lblOutPhone.Text = ".";
                lblOutOutstanding.Text = "0";
                lblOutSearchMsg.Text = "Account Number does not exist";

                return;
            }

            //call the method in the Loans class and insert the value to the various label
            lblOutSearchMsg.Text = "";
            loan.account = txtOutSearch.Text;
            loan.getAccountInfo();
            lblOutName.Text = loan.fname + " " + loan.lname;
            lblOutPhone.Text = loan.phone;


            loan.getOutstanding = "0"; //set the outstanding to zero

            loan.checkForOutstanding(); //check the outstanding the account you search
            lblOutOutstanding.Text = loan.getOutstanding; //assign the outstanding value to the label
        }

        private void btnOutSearch_Click(object sender, EventArgs e)
        {
            if (txtOutSearch.Text == "") //check the search textbox is empty
            {
                lblOutName.Text = ".";
                lblOutPhone.Text = ".";
                lblOutOutstanding.Text = "0";
                lblOutSearchMsg.Text = "Enter client account number";

                return;
            }
            else
            {
                getAccountInfosOutstanding(); //call the get info function here
            }
        }
        #endregion CHECK OUTSTANDING
    }
}

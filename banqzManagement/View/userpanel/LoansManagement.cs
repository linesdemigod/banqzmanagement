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
    public partial class LoansManagement : Form
    {
        LoansManagements loan = new LoansManagements();
        public LoansManagement()
        {
            InitializeComponent();
        }

        //call the various function to the datagridview table
        private void LoansManagement_Load(object sender, EventArgs e)
        {

           /* getAllLoans(); //loan all loans disbursed
           
            getAllRepayment(); // load the repayment

            getAllLoanFee(); //load the loanfee

            getAllRepaymentHistory(); //load repayment history */
        }

        #region LOANS
        //load the datagridview table
        private void getAllLoans()
        {
            //dataGridViewLoan.DataSource = null;
            loan.getLoans();
            dataGridViewLoan.DataSource = loan.dt;
        }

        //search based on the account number
        private void search()
        {
            try
            {
                DataView dv = loan.dt.DefaultView;
                dv.RowFilter = string.Format(@"client_account_num LIKE '%" + txtLoanSearch.Text.Trim() + "%'");
                dataGridViewLoan.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //handle the search 
        private void txtLoanSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }


        //handle the deletion of the values in the dategrid
        private void dataGridViewLoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1) return;

            //code the delete
            if (dataGridViewLoan.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {


                    int id;
                    id = Convert.ToInt32(dataGridViewLoan.Rows[e.RowIndex].Cells["ID"].Value); // convert the ID to integer
                    loan.id = id.ToString();
                    if (Convert.ToInt32(loan.id) > 0)
                    {
                        //call the deleteLoan method in the Loansmanagement class
                        loan.deleteLoan();
                        MessageBox.Show("Loan deleted");
                        getAllLoans();
                    }

                }
            }
        }

        private void btnRefreshLoans_Click(object sender, EventArgs e)
        {
            getAllLoans(); //loan all loans disbursed
        }
        #endregion END OF LOAN

        #region LOAN FEE BEGINS
        //function to get the loans fees to the datagrid
        private void getAllLoanFee()
        {
            loan.getLoanFee();
            dataGridViewLoanFee.DataSource = loan.dat;
        }

        //search the account number from the txtbox
        private void searchFee()
        {
            try
            {
                DataView dv = loan.dat.DefaultView;
                dv.RowFilter = string.Format(@"client_account_num LIKE '%" + txtLoanFeeSearch.Text.Trim() + "%'");
                dataGridViewLoanFee.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //when text change
        private void txtLoanFeeSearch_TextChanged(object sender, EventArgs e)
        {
            searchFee();
        }



        private void dataGridViewLoanFee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1) return;

            //code the delete
            if (dataGridViewLoanFee.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {


                    int id;
                    id = Convert.ToInt32(dataGridViewLoanFee.Rows[e.RowIndex].Cells["IDFee"].Value);
                    loan.idFee = id.ToString();
                    if (Convert.ToInt32(loan.idFee) > 0)
                    {
                        //call the deleteLoan method in the Loansmanagement class
                        loan.deleteLoanFee();
                        MessageBox.Show("LoanFee deleted");
                        getAllLoanFee();
                    }

                }
            }
        }

        private void btnRefreshFee_Click(object sender, EventArgs e)
        {
            getAllLoanFee(); //load the loanfee
        }
        #endregion LOAN FEE ENDS

        #region REPAYMENT START
        //function to get the loans fees to the datagrid
        private void getAllRepayment()
        {
            loan.getRepayment();
            dataGridViewRepayment.DataSource = loan.dtaa;
        }


        //search client by account number
        private void searchRepayment()
        {
            try
            {
                DataView dv = loan.dtaa.DefaultView;
                dv.RowFilter = string.Format(@"client_account_num LIKE '%" + txtRepaymentSearch.Text.Trim() + "%'");
                dataGridViewRepayment.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //handle the repayment
        private void txtRepaymentSearch_TextChanged(object sender, EventArgs e)
        {
            searchRepayment();
        }

        private void dataGridViewRepayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1) return;

            //code the delete
            if (dataGridViewRepayment.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {


                    int id;
                    id = Convert.ToInt32(dataGridViewRepayment.Rows[e.RowIndex].Cells["IDRepay"].Value);
                    loan.idRepay = id.ToString();
                    if (Convert.ToInt32(loan.idRepay) > 0)
                    {
                        //call the deleteLoan method in the Loansmanagement class
                        loan.deleteRepayment();
                        MessageBox.Show("Repayment deleted");
                        getAllRepayment();
                    }

                }
            }

            //code for the update
            if (dataGridViewRepayment.Columns[e.ColumnIndex].HeaderText == "Update")
            {

                string id, name, account, amount, outstanding, remark, officer;

                id = dataGridViewRepayment.Rows[e.RowIndex].Cells["IDRepay"].Value.ToString();
                name = dataGridViewRepayment.Rows[e.RowIndex].Cells["NameRepay"].Value.ToString();
                account = dataGridViewRepayment.Rows[e.RowIndex].Cells["AccountRepay"].Value.ToString();
                amount = dataGridViewRepayment.Rows[e.RowIndex].Cells["AmountRepay"].Value.ToString();
                outstanding = dataGridViewRepayment.Rows[e.RowIndex].Cells["OutstandindRepay"].Value.ToString();
                remark = dataGridViewRepayment.Rows[e.RowIndex].Cells["RemarkRepay"].Value.ToString();
                officer = dataGridViewRepayment.Rows[e.RowIndex].Cells["OfficerRepay"].Value.ToString();

                UpdateRepayment user = new UpdateRepayment(id, name, account, amount, outstanding, remark, officer);
                user.ShowDialog();
            }
        
            
}

        private void btnRefreshRepayment_Click(object sender, EventArgs e)
        {
            getAllRepayment(); // load the repayment

        }

        #endregion REPAYMENT END

        #region REPAYMENT HISTORY
        //function to get the loans fees to the datagrid
        private void getAllRepaymentHistory()
        {
            loan.getRepaymentHistory();
            dataGridViewRepaymentHistory.DataSource = loan.dtas;
        }

        //search client by account number
        private void searchRepaymentHistory()
        {
            try
            {
                DataView dv = loan.dtas.DefaultView;
                dv.RowFilter = string.Format(@"client_account_num LIKE '%" + txtRepaymentHistSearch.Text.Trim() + "%'");
                dataGridViewRepaymentHistory.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

        private void dataGridViewRepaymentHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1) return;

            //code the delete
            if (dataGridViewRepaymentHistory.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {


                    int id;
                    id = Convert.ToInt32(dataGridViewRepaymentHistory.Rows[e.RowIndex].Cells["RepayHistID"].Value);
                    loan.idRepay = id.ToString();
                    if (Convert.ToInt32(loan.idRepay) > 0)
                    {
                        //call the deleteLoan method in the Loansmanagement class
                        loan.deleteRepaymentHistory();
                        MessageBox.Show("Repayment History deleted");
                        getAllRepaymentHistory();
                    }

                }
            }

        }

        private void txtRepaymentHistSearch_TextChanged(object sender, EventArgs e)
        {
            searchRepaymentHistory();
        }

        private void btnRepayHistRefresh_Click(object sender, EventArgs e)
        {
            getAllRepaymentHistory();
        }
        #endregion REPAYMENT HISTORY END
    }
}

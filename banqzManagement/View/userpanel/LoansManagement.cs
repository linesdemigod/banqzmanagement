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

        private void LoansManagement_Load(object sender, EventArgs e)
        {
            getAllLoans();
        }

        private void getAllLoans()
        {
            loan.getLoans();
            dataGridViewLoan.DataSource = loan.dt;
        }

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

        private void txtLoanSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}

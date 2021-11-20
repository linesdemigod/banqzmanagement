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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btnLoanReport_Click(object sender, EventArgs e)
        {
            LoanReport loan = new LoanReport();
            loan.ShowDialog();
        }

        private void btnRepaymentReport_Click(object sender, EventArgs e)
        {
            RepaymentReport loan = new RepaymentReport();
            loan.ShowDialog();
        }

        private void btnLoanFeeReport_Click(object sender, EventArgs e)
        {
            LoanFeeReport loan = new LoanFeeReport();
            loan.ShowDialog();
        }

        private void btnGrpahReport_Click(object sender, EventArgs e)
        {
            Graph loan = new Graph();
            loan.ShowDialog();
        }
    }
}

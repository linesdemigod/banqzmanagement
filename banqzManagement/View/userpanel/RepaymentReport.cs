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
    public partial class RepaymentReport : Form
    {
        RepaymentReports report = new RepaymentReports();
        public RepaymentReport()
        {
            InitializeComponent();
        }

        private void RepaymentReport_Load(object sender, EventArgs e)
        {
            getRepaymentReports();
            calcTotalAmount(); 
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
        private void Report_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void Report_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }



        #endregion

        //function to get all the reapayment on the datagrid
        private void getRepaymentReports()
        {
            dataGridViewRepayment.DataSource = null;
            dataGridViewRepayment.Rows.Clear();
            report.dt.Clear();
            report.getRepaymentReport();
            dataGridViewRepayment.DataSource = report.dt;
        }


        //filter the data in the datagrid based on date range
        private void getRepaymentReportFilters()
        {
            dataGridViewRepayment.DataSource = null;
            dataGridViewRepayment.Rows.Clear();
            report.dt.Clear();
            report.fromDate = dateFrom.Value.ToString("yyyy-MM-dd");
            report.toDate = dateTo.Value.ToString("yyyy-MM-dd");

            report.getRepaymentReportFilter();
            dataGridViewRepayment.DataSource = report.dt;
        }


        //calculate all the totals
        public void calcTotalAmount()
        {
            //calculate the datagridview total amount
            double repayment = 0;
            double outstanding = 0;
            double result = 0;

            //loop through the datagrid to calculate the sum of the selected various column
            for (int i = 0; i < dataGridViewRepayment.Rows.Count; i++)
            {
                repayment += Convert.ToDouble(dataGridViewRepayment.Rows[i].Cells[1].Value);
                outstanding += Convert.ToDouble(dataGridViewRepayment.Rows[i].Cells[2].Value);
              

            }

            //this format the numbers to make it easier to read
            lblOutstanding.Text = String.Format("GHS {0:n}", outstanding);
            lblRepayment.Text = String.Format("GHS {0:n}", repayment);
        }


        //handle the date filter function
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                getRepaymentReportFilters();
                calcTotalAmount();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        //refresh the datagrid by calling the the functions
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getRepaymentReports();
            calcTotalAmount();
        }

        //get the daily report
        private void getDailyReport()
        {
            dataGridViewRepayment.DataSource = null;
            dataGridViewRepayment.Rows.Clear();
            report.dt.Clear();
            report.dailyReport();
            dataGridViewRepayment.DataSource = report.dt;
        }

        //get the weekly report
        private void getWeeklyReport()
        {
            dataGridViewRepayment.DataSource = null;
            dataGridViewRepayment.Rows.Clear();
            report.dt.Clear();
            report.weeklyReport();
            dataGridViewRepayment.DataSource = report.dt;
        }

        //get the monthly report
        private void getMonthlyReport()
        {
            dataGridViewRepayment.DataSource = null;
            dataGridViewRepayment.Rows.Clear();
            report.dt.Clear();
            report.monthlyReport();
            dataGridViewRepayment.DataSource = report.dt;
        }

        //get the yearly report
        private void getYearlyReport()
        {
            dataGridViewRepayment.DataSource = null;
            dataGridViewRepayment.Rows.Clear();
            report.dt.Clear();
            report.getYear = comboYear.Text;

            report.getReportByYear();
            dataGridViewRepayment.DataSource = report.dt;
        }

        private void radioDaily_CheckedChanged(object sender, EventArgs e)
        {
            getDailyReport();
            calcTotalAmount();
        }

        private void radioWeekly_CheckedChanged(object sender, EventArgs e)
        {
            getWeeklyReport();
            calcTotalAmount();
        }

        private void radioMonthly_CheckedChanged(object sender, EventArgs e)
        {
            getMonthlyReport();
            calcTotalAmount();
        }

        private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            getYearlyReport();
            calcTotalAmount();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                saveToExcel();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        //save to excel
        public void saveToExcel()
        {
            //Export to excel
            saveFileDialog.InitialDirectory = "D";
            saveFileDialog.Title = "Save as Excel File";
            saveFileDialog.FileName = "";
            saveFileDialog.Filter = "Excel Files (2007|*.xlsx|Excel Files(.CSV)|*.csv";

            if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                Cursor.Current = Cursors.WaitCursor;
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                //change properties
                excelApp.Columns.ColumnWidth = 28;
                for (int i = 1; i < dataGridViewRepayment.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataGridViewRepayment.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridViewRepayment.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewRepayment.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dataGridViewRepayment.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excelApp.Columns.AutoFit();
                excelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName.ToString());
                excelApp.ActiveWorkbook.Saved = true;
                excelApp.Quit();


                MessageBox.Show("Export Successful");
            }


            Cursor.Current = Cursors.Default;
        }
    }
}

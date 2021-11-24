using banqzManagement.Controller;
using MySql.Data.MySqlClient;
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
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
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

        private void getChartResult()
        {

            Database db = new Database();

            try
            {
                db.conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT Sum(loaninfo.interest_amount_disbursed) AS Principal, SUM(repayment.amount) AS Repayment,  MONTH(loaninfo.created_at) as created FROM loaninfo INNER JOIN repayment WHERE YEAR(loaninfo.created_at) = '" + comboYear.Text + "' group by month(loaninfo.created_at)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = db.conn;
                    db.rd = cmd.ExecuteReader();
                    while (db.rd.Read())
                    {
                        string month = db.rd.GetString("created");
                        string values = db.rd.GetString("Principal");
                        string repayment = db.rd.GetString("Repayment");
                        switch (month)
                        {
                            case "1":
                                month = "Jan";
                                break;
                            case "2":
                                month = "Feb";
                                break;
                            case "3":
                                month = "Mar";
                                break;
                            case "4":
                                month = "Apr";
                                break;
                            case "5":
                                month = "May";
                                break;
                            case "6":
                                month = "Jun";
                                break;
                            case "7":
                                month = "Jul";
                                break;
                            case "8":
                                month = "Aug";
                                break;
                            case "9":
                                month = "Sep";
                                break;
                            case "10":
                                month = "Oct";
                                break;
                            case "11":
                                month = "Nov";
                                break;
                            default:
                                month = "Dec";
                                break;
                        }

                        //chartLoans.Series["Amount Disbursed"].Points.AddXY(month, values);
                        //chartLoans.Series["Amount Disbursed"].Points.AddXY(month, repayment);
                        //chartLoans.Series["Repayment"].YValueMembers = ""
                    }
                }
                db.conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.conn.Close();
            }


        }

        private void comboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartLoans.Series["Amount Disbursed"].Points.Clear();
            getChartResult();
        }
    }
}

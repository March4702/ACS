using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACS
{
    public partial class FormReport : Form
    {
        public DataTable Dtbl = new DataTable();
        public string LBName = string.Empty;

        public FormReport()
        {
            InitializeComponent();
        }
 
        private void MnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Mobile Email Pre Programmed (Fixed) report for all users in the database
        private void MnuPhone_Click(object sender, EventArgs e)
        {
            Dtbl = ReportClass.PhoneReport();
            ShowDGrid(Dtbl);
        }

        // END Mobile, Email

        // All Columns Pre Programmed (Fixed) report, Ideal for XL
        private void MnuAll_Click(object sender, EventArgs e)
        {
            Dtbl = ReportClass.AllReport();
            ShowDGrid(Dtbl);
        }
        // END All Columns


        private void MnuLocation_Click(object sender, EventArgs e)
        {
            Dtbl = ReportClass.LocationReport();
            ShowDGrid(Dtbl);
        }

        // Dates, Category, Gender Pre Programmed (Fixed) report
        private void MnuOther_Click(object sender, EventArgs e)
        {
            Dtbl = ReportClass.OtherReport();
            ShowDGrid(Dtbl);
        }
        // END Other info of person 


        // MMDD, YYYYMMDD, Alphabetical (Fixed) report
        private void BirthdaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dtbl = ReportClass.BirthdayReport();
            ShowDGrid(Dtbl);  
        }
        // END Birthdays person 


        private void ShowDGrid(DataTable dt)
        {
            DGV_Report.DataSource = dt;
            DGV_Report.AutoResizeColumns();
            DGV_Report.Visible = true;
        }

        private void MnuCsv_Click(object sender, EventArgs e)
        {
            DGV_Report = ReportClass.CSV_File(DGV_Report);
        }
    }
}

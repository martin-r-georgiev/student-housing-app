using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedProject1._0
{
    public partial class Reports : Form
    {
        List<Report> myReports;
        Report selectedReport;
        ReportsList myReportsList;
        public Reports()
        {
            InitializeComponent();
            RefreshPanels();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMain adminMainScreen = new AdminMain();
            adminMainScreen.Show();
            this.Close();
        }
     
        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close")) { }
            else Application.Exit();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblReporterName.Text.Length > 0)
            {
                myReportsList = new ReportsList();
                myReportsList.DeleteEntry(selectedReport.ReportId);
                RefreshPanels();
            }
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            if (lblReporterName.Text.Length > 0 && tbReply.Text.Length > 0)
            {
                myReportsList = new ReportsList();
                myReportsList.ReplyTo(selectedReport.ReportId, tbReply.Text);
                RefreshPanels();
            }
        }
        private void RefreshPanels()
        {
            panelReport.Controls.Clear();
            myReports = ReportsList.GetReports();
            ReportPanel[] reportPanels = new ReportPanel[myReports.Count];
            for (int i = 0; i < myReports.Count; i++)
            {
                reportPanels[i] = new ReportPanel(myReports[i]);
                panelReport.Controls.Add(reportPanels[i]);
            }
        }
        public void ChangeDescription(string reporterName, string reportText)
        {
            lblReporterName.Text = reporterName;
            tbReport.Text = reportText;
        }
        public void ChangeSelectedReport(Report newReport)
        {
            selectedReport = newReport;
        }
        public void RefreshReplyTextbox()
        {
            tbReply.Text = "";
        }
    }
}

using System;
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
    public partial class ReportPopup : Form
    {
        User loggedInUser;
        public ReportPopup()
        {
            InitializeComponent();
            loggedInUser = new User(formLogin.userKey);
        }

        private void btnSendReport_Click(object sender, EventArgs e)
        {
            Report newReport = new Report(loggedInUser, tbReport.Text);
            MessageBox.Show($"Report sent. \nThanks for the feedback, {loggedInUser.GetFirstName()}!");
            this.Close();
        }
    }
}

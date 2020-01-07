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
            string reporterDetails = $"{loggedInUser.GetFirstName()} {loggedInUser.GetLastName()}";  // TO DO - Add the house to which the logged user belongs
            string reportString = tbReport.Text;
            System.IO.File.WriteAllText(@"Reports.txt", $"{reporterDetails} - {reportString} \n");
            MessageBox.Show($"Report sent. \nThanks for the feedback, {loggedInUser.GetFirstName()}!");
            this.Close();
        }
    }
}

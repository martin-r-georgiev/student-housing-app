using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedProject1._0
{
    public partial class ReportPanel : UserControl
    {
        private string reporterId;
        private User Reporter;
        private string reportText;
        private Report currentReport;

        [Category("Custom Prop")]
        public string ReportText
        {
            get { return reportText; }
            set { reportText = value; lblReport.Text = ReportText;
            }
        }
        [Category("Custom Prop")]
        public string ReporterId
        {
            get { return reporterId; }
            set
            {
                reporterId = value; this.lblName.Text = $"{Reporter.GetFirstName()}"; this.lblNumber.Text = $"{Reporter.GetHouseID()}";
            }
        }
        public Report CurrentReport
        {
            get { return currentReport; }
            set { currentReport = value; }
        }

        public ReportPanel(Report reportForPanel)
        {
            InitializeComponent();
            this.CurrentReport = reportForPanel;
            this.ReportText = this.CurrentReport.ReportText;
            this.Reporter = this.CurrentReport.Reporter;
            this.ReporterId = this.CurrentReport.Reporter.UserID;
            this.lblReport.AutoEllipsis = true;
        }

        private void ReportPanel_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ReportPanel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void ReportPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Reports pForm = (Reports)this.ParentForm;
            pForm.RefreshReplyTextbox();
            pForm.ChangeSelectedReport(this.CurrentReport);
            pForm.ChangeDescription($"{this.Reporter.Name} {this.Reporter.UnitID}", this.ReportText);
        }
    }
}

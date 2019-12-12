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
    public partial class Reports : Form
    {
        // TO DO - Hover over functionality - double click to remove functionality
        List<Panel> panelList;
        string reportString;
        List<string> reports;
        public Reports()
        {
            InitializeComponent();
            panelList = new List<Panel>();
            reportString = System.IO.File.ReadAllText(@"Reports.txt");
            reports = new List<string>();
            reports = reportString.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            RefreshPanels();   
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMain adminMainScreen = new AdminMain();
            adminMainScreen.Show();
            this.Hide();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
        }
        public string GetReportString(string str, bool areYouLookingForReporter)
        {
            int index = str.IndexOf('-');
            if (areYouLookingForReporter)
                return str.Substring(0, index);
            else
                return str.Substring(index);
        }
        public void RefreshPanels()
        {
            int index = 0;
            foreach (string rep in reports)
            {
                if (index < 10)
                {
                    string reporterName = GetReportString(rep, true);
                    string report = GetReportString(rep, false);

                    Panel tempPanel = new Panel();
                    tempPanel.Name = $"{index}";
                    tempPanel.Size = new System.Drawing.Size(290, 120);
                    tempPanel.BackColor = Color.Green;
                    tempPanel.Location = new System.Drawing.Point(20 + (index / 5) * 320, 50 + (index % 5) * 140);

                    Label tempHeaderLbl = new Label();
                    tempHeaderLbl.Location = new Point(10, 10);
                    tempHeaderLbl.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
                    tempHeaderLbl.AutoSize = true;
                    tempHeaderLbl.Text = reporterName;
                    tempPanel.Controls.Add(tempHeaderLbl);

                    Label tempReportLbl = new Label();
                    tempReportLbl.Location = new Point(10, 30);
                    tempReportLbl.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                    tempReportLbl.Size = new Size(270, 80);
                    tempReportLbl.Text = report;

                    tempPanel.Controls.Add(tempReportLbl);
                    index++;
                    Controls.Add(tempPanel);
                    panelList.Add(tempPanel);
                }
            }
        }
    }
}

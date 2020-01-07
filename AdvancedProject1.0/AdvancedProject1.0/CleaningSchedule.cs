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
    public partial class CleaningSchedule : Form
    {
        void PopulateCalendar()
        {
            CalendarItem[] itemList = new CalendarItem[31];
            CalendarItem today = new CalendarItem();
            DateTime now = DateTime.Now;
            DateTime startDate = new DateTime(now.Year, now.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);
            for (int i = 0; startDate <= endDate; i++)
            {
                itemList[i] = new CalendarItem();
                itemList[i].Date = startDate.ToString("d MMMM, yyyy");
                if (DateTime.Compare(startDate, DateTime.Today) == 0)
                {
                    itemList[i].Date += " (Today)";
                    itemList[i].IsToday(Color.BlueViolet);
                    today = itemList[i];
                }
                itemList[i].DayOfWeek = startDate.DayOfWeek.ToString();
                //if (flowLayoutPanel1.Controls.Count > 0) flowLayoutPanel1.Controls.Clear();
                CalendarPanel.Controls.Add(itemList[i]);
                startDate = startDate.AddDays(1);
            }
            itemList[1].AddEvent("Cleaning", Color.LimeGreen);
            itemList[1].AddEvent("Calendar", Color.Purple, Color.White);
            itemList[0].AddEvent("LAN Party", Color.Black, Color.White);
            itemList[2].AddEvent("Overflow Test", Color.Red);
            itemList[2].AddEvent("Overflow Test", Color.Red);
            itemList[2].AddEvent("Overflow Test", Color.Red);
            itemList[2].AddEvent("Overflow Test", Color.Red);
            itemList[2].AddEvent("Overflow Test", Color.Red);
            itemList[2].AddEvent("Overflow Test", Color.Red);
            itemList[2].AddEvent("Overflow Test", Color.Red);
        }

        public CleaningSchedule()
        {
            InitializeComponent();
            PopulateCalendar();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TenantMain tenantMainScreen = new TenantMain();
            tenantMainScreen.Show();
            this.Close(); //h
        }

        private void CleaningSchedule_Load(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

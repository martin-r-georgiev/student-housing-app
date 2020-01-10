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
        User loggedInUser;

        public void ChangeDescription(string description)
        {
            if (!string.IsNullOrEmpty(description)) rtbDescription.Text = description;
            else rtbDescription.Text = "No event description";

        }

        public void ChangePicture(Image img)
        {
            pbEventImage.Image = img;
        }

        void PopulateCalendar()
        {
            CalendarPanel.Controls.Clear();
            CalendarItem[] itemList = new CalendarItem[31];
            CalendarItem today = new CalendarItem();
            CalendarItem.unitID = loggedInUser.GetHouseID();
            DateTime now = DateTime.Now;
            DateTime startDate = new DateTime(now.Year, now.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);
            for (int i = 0; startDate <= endDate; i++)
            {
                itemList[i] = new CalendarItem();
                itemList[i].RawDate = startDate;
                itemList[i].Date = startDate.ToString("d MMMM, yyyy");
                itemList[i].LoadEvents();
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
            /*itemList[1].AddEvent("Cleaning", Color.LimeGreen);
            itemList[1].AddEvent("Calendar", Color.Purple, Color.White);
            itemList[0].AddEvent("LAN Party", Color.Black, Color.White);
            itemList[2].AddEvent("Overflow Test", Color.Red);
            itemList[2].AddEvent("Overflow Test", Color.Red);
            itemList[2].AddEvent("Overflow Test", Color.Red);
            itemList[2].AddEvent("Overflow Test", Color.Red);
            itemList[2].AddEvent("Overflow Test", Color.Red);
            itemList[2].AddEvent("Overflow Test", Color.Red);
            itemList[2].AddEvent("Overflow Test", Color.Red);
            itemList[4].AddEvent("ID test", Color.Red);*/
        }

        public CleaningSchedule()
        {
            InitializeComponent();
            loggedInUser = new User(formLogin.userKey);
            PopulateCalendar();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TenantMain tenantMainScreen = new TenantMain();
            tenantMainScreen.Show();
            this.Close(); //h
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            EventsPopup eventsPopupScreen = new EventsPopup();

            eventsPopupScreen.FormClosed += new FormClosedEventHandler(eventsPopupScreen_FormClosed);
            eventsPopupScreen.Show();
        }

        private void eventsPopupScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            PopulateCalendar();
        }

        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
            SchedulePopup scheduleForm = new SchedulePopup();
            scheduleForm.Show();
        }
    }
}

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

        public static DateTime GetPreviousWeekday(DateTime start, DayOfWeek day)
        {
            int daysToAdd = ((int)day - (int)start.DayOfWeek - 7) % 7;
            return start.AddDays(daysToAdd);
        }

        void PopulateCalendar()
        {
            CalendarPanel.SuspendLayout();
            while (CalendarPanel.Controls.Count > 0) CalendarPanel.Controls[0].Dispose();
            CalendarItem[] itemList = new CalendarItem[38];
            CalendarItem.unitID = loggedInUser.GetHouseID();
            DateTime now = DateTime.Now;
            lblMonth.Text = DateTime.Now.ToString("MMMM");
            lblYear.Text = now.Year.ToString();
            DateTime startDate = new DateTime(now.Year, now.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);
            if(startDate.DayOfWeek != DayOfWeek.Monday)startDate = GetPreviousWeekday(startDate, DayOfWeek.Monday);
            for (int i = 0; startDate <= endDate; i++)
            {
                itemList[i] = new CalendarItem();
                itemList[i].RawDate = startDate;
                itemList[i].Date = startDate.ToString("dd");
                itemList[i].LoadEvents();
                if (DateTime.Compare(startDate, DateTime.Today) == 0)
                {
                    itemList[i].IsToday(Color.BlueViolet);
                }
                itemList[i].WeekDay = startDate.DayOfWeek.ToString();
                if (i > 6) itemList[i].HideHeader(true);
                CalendarPanel.Controls.Add(itemList[i]);
                startDate = startDate.AddDays(1);
            }
            CalendarPanel.ResumeLayout();
            CalendarPanel.AutoScroll = false;
            CalendarPanel.AutoScroll = true;
            /*Example of adding event through CalendarItem
            itemList[0].AddEvent("LAN Party", Color.Black, Color.White);
            */
        }

        public CleaningSchedule()
        {
            InitializeComponent();
            loggedInUser = new User(formLogin.userKey);
            this.DoubleBuffered = true;
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
            this.Enabled = false;
        }

        private void eventsPopupScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            PopulateCalendar();
        }

        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
            SchedulePopup scheduleForm = new SchedulePopup();
            scheduleForm.FormClosed += new FormClosedEventHandler(scheduleForm_FormClosed);
            scheduleForm.Show();
            this.Enabled = false;
        }

        private void scheduleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            PopulateCalendar();
        }

        private void CalendarPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach(Control control in CalendarPanel.Controls)
            {
                control.Height = (int)(CalendarPanel.Height / 3.5);
                control.Width = (int)(CalendarPanel.Width / 7.41);
            }
        }
    }
}

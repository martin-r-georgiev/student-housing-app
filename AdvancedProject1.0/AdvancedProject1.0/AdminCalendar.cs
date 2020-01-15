using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdvancedProject1._0
{
    public partial class AdminCalendar : Form
    {
        User loggedInUser;
        List<HouseUnit> unitList;
        HouseUnit lastSelectedUnit;

        public AdminCalendar()
        {
            InitializeComponent();
            loggedInUser = new User(formLogin.userKey);
            unitList = new List<HouseUnit>();
            this.DoubleBuffered = true;
            PopulateCalendar(0);
            
        }

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

        void PopulateCalendar(int tenantUnitID)
        {
            CalendarPanel.SuspendLayout();
            while (CalendarPanel.Controls.Count > 0) CalendarPanel.Controls[0].Dispose();
            CalendarItem[] itemList = new CalendarItem[38];
            CalendarItem.unitID = tenantUnitID;
            DateTime now = DateTime.Now;
            lblMonth.Text = DateTime.Now.ToString("MMMM");
            lblYear.Text = now.Year.ToString();
            DateTime startDate = new DateTime(now.Year, now.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);
            if (startDate.DayOfWeek != DayOfWeek.Monday) startDate = GetPreviousWeekday(startDate, DayOfWeek.Monday);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            adminMain.Show();
            this.Close();
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
            if(lastSelectedUnit != null) PopulateCalendar(lastSelectedUnit.GetUnitID());
            else PopulateCalendar(0);
        }

        private void CalendarPanel_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in CalendarPanel.Controls)
            {
                control.Height = (int)(CalendarPanel.Height / 3.5);
                control.Width = (int)(CalendarPanel.Width / 7.41);
            }
        }

        private void AdminCalendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close")) { }
            else Application.Exit();
        }

        private void cmbUnits_DropDown(object sender, EventArgs e)
        {
            cmbUnits.Items.Clear();
            unitList.Clear();
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand($"SELECT unitID FROM HUnitTable", con);
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                cmbUnits.Items.Add(new HouseUnit(dataReader.GetInt32(0)).GetInfo());
                unitList.Add(new HouseUnit(dataReader.GetInt32(0)));
            }
            dataReader.Close();
            cmd.Dispose();
            con.Close();
        }

        private void cmbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUnits.SelectedIndex != -1)
            {
                lastSelectedUnit = unitList[cmbUnits.SelectedIndex];
                PopulateCalendar(lastSelectedUnit.GetUnitID());
            }
        }
    }
}

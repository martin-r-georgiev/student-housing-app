using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedProject1._0
{
    public partial class CleaningSchedule : Form
    {
        User loggedInUser;
        List<User> Residents;
        int garbageCounter;

        HouseUnit tenantUnit;
        SettingsHandler settingsHandler;

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

        void GenerateCleaningEvents()
        {
            CalendarItem.unitID = loggedInUser.GetHouseID();
            User orderUser;
            EventColorHandler colorHandler = new EventColorHandler();
            OrderScheduler scheduler = new OrderScheduler(tenantUnit);
            DateTime startDate = SchedulePopup.GetNextWeekday(DateTime.Today, DayOfWeek.Monday);
            DateTime iterator;
            DateTime endDate = startDate.AddDays(7);
            //Cleaning Common Rooms
            if (settingsHandler.CommonValue > 0)
            {
                iterator = scheduler.GetLastDate(EventType.CommonRoom);
                if (iterator.Date != startDate.Date) iterator = iterator.AddDays(settingsHandler.CommonValue);
                while (iterator < endDate)
                {
                    scheduler.SetLastDate(EventType.CommonRoom, iterator);
                    colorHandler = EventColorHandler.GetColorHandler(EventType.CommonRoom);
                    orderUser = scheduler.GetNextUser(EventType.CommonRoom);
                    CalendarItem.AddEventToDB(iterator, colorHandler.BackColor, colorHandler.TextColor, orderUser.GetFirstName(),
                                              $"On this day:\n{orderUser.GetName()} should clean all shared facilities.", Properties.Resources.CommonRoom);
                    iterator = iterator.AddDays(settingsHandler.CommonValue);
                }
            }
            //Cleaning Kitchen
            if (settingsHandler.KitchenValue > 0)
            {
                iterator = scheduler.GetLastDate(EventType.Kitchen);
                if (iterator.Date != startDate.Date) iterator = iterator.AddDays(settingsHandler.KitchenValue);
                while (iterator < endDate)
                {
                    scheduler.SetLastDate(EventType.Kitchen, iterator);
                    colorHandler = EventColorHandler.GetColorHandler(EventType.Kitchen);
                    orderUser = scheduler.GetNextUser(EventType.Kitchen);
                    CalendarItem.AddEventToDB(iterator, colorHandler.BackColor, colorHandler.TextColor, orderUser.GetFirstName(),
                                              $"On this day:\n{orderUser.GetName()} should clean the kitchen.", Properties.Resources.Cleaning);
                    iterator = iterator.AddDays(settingsHandler.KitchenValue);
                }
            }
            //Cleaning Bathroom/Toilet
            if (settingsHandler.BathroomValue > 0)
            {
                iterator = scheduler.GetLastDate(EventType.Bathroom);
                if (iterator.Date != startDate.Date) iterator = iterator.AddDays(settingsHandler.BathroomValue);
                while (iterator < endDate)
                {
                    scheduler.SetLastDate(EventType.Bathroom, iterator);
                    colorHandler = EventColorHandler.GetColorHandler(EventType.Bathroom);
                    orderUser = scheduler.GetNextUser(EventType.Bathroom);
                    CalendarItem.AddEventToDB(iterator, colorHandler.BackColor, colorHandler.TextColor, orderUser.GetFirstName(),
                                              $"On this day:\n{orderUser.GetName()} should clean the bathroom and toilet facilities.", Properties.Resources.Toilet);
                    iterator = iterator.AddDays(settingsHandler.BathroomValue);
                }
            }
        }

        public CleaningSchedule()
        {
            InitializeComponent();
            loggedInUser = new User(formLogin.userKey);
            tenantUnit = new HouseUnit(loggedInUser.GetHouseID());
            settingsHandler = new SettingsHandler(tenantUnit);
            this.DoubleBuffered = true;
            GenerateCleaningEvents();
            PopulateCalendar();
            

            garbageCounter = 0;
            Residents = new List<User>();
            HouseUnit newUnit = new HouseUnit(loggedInUser.GetHouseID());
            Residents = newUnit.Tenants();
            NameSwap();
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

        private void CleaningSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close")) { }
            else Application.Exit();
        }

        private void cbArduino_DropDown(object sender, EventArgs e)
        {
            cbArduino.Items.Clear();
            foreach (string port in SerialPort.GetPortNames())
                cbArduino.Items.Add(port);
        }

        private void cbArduino_SelectedIndexChanged(object sender, EventArgs e)
        {
            spArduino.PortName = cbArduino.SelectedItem.ToString();
            spArduino.Open();
            timerArduino.Start();
            cbArduino.Visible = false;
            lblGarbageName.Visible = true;
            lblGarbageStatus.Visible = true;
            pbGarbage.Visible = true;
            spArduino.WriteLine("garbage");
        }

        private void timerArduino_Tick(object sender, EventArgs e)
        {
            string line = spArduino.ReadExisting();
            if (Int32.TryParse(line, out int pbValue))
            {
                pbGarbage.Value = pbValue;
                if (pbGarbage.Value == 0) NameSwap();
            }
        }
        private void NameSwap()
        {
            if (garbageCounter < (Residents.Count() - 1))
            {
                lblGarbageName.Text = Residents[garbageCounter].GetFirstName();
                garbageCounter++;
            }
            else if (garbageCounter >= (Residents.Count() - 1))
            {
                garbageCounter = 0;
                lblGarbageName.Text = Residents[Residents.Count() - 1].GetFirstName();
            }
        }
    }
}

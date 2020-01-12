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
    public partial class SchedulePopup : Form
    {
        User loggedInUser;
        HouseUnit tenantUnit;
        SettingsHandler settingsHandler;

        public static DateTime GetNextWeekday(DateTime start, DayOfWeek day)
        {
            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;
            return start.AddDays(daysToAdd);
        }

        public SchedulePopup()
        {
            InitializeComponent();
            loggedInUser = new User(formLogin.userKey);
            tenantUnit = new HouseUnit(loggedInUser.GetHouseID());
            settingsHandler = new SettingsHandler(tenantUnit);
            tbCommonRooms.Value = settingsHandler.CommonValue;
            tbKitchen.Value = settingsHandler.KitchenValue;
            tbBathroom.Value = settingsHandler.BathroomValue;
        }

        private void tbBathroom_ValueChanged(object sender, EventArgs e)
        {
            lblBathroomValue.Text = tbBathroom.Value.ToString();
        }

        private void tbKitchen_ValueChanged(object sender, EventArgs e)
        {
            lblKitchenValue.Text = tbKitchen.Value.ToString();
        }

        private void tbCommonRooms_ValueChanged(object sender, EventArgs e)
        {
            lblCRoomsValue.Text = tbCommonRooms.Value.ToString();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            //TO DO: Add limits
            User orderUser;
            EventColorHandler colorHandler = new EventColorHandler();
            OrderScheduler scheduler = new OrderScheduler(tenantUnit);
            DateTime startDate = GetNextWeekday(DateTime.Today, DayOfWeek.Monday);
            DateTime iterator;
            DateTime endDate = startDate.AddDays(7);
            MessageBox.Show(endDate.ToString());
            //Cleaning Common Rooms
            if (tbCommonRooms.Value > 0)
            {
                iterator = scheduler.GetLastDate(EventType.CommonRoom);
                if (iterator.Date != startDate.Date) iterator = iterator.AddDays(tbCommonRooms.Value);
                while (iterator < endDate)
                {
                    scheduler.SetLastDate(EventType.CommonRoom, iterator);
                    colorHandler = EventColorHandler.GetColorHandler(EventType.CommonRoom);
                    orderUser = scheduler.GetNextUser(EventType.CommonRoom);
                    CalendarItem.AddEventToDB(iterator, colorHandler.BackColor, colorHandler.TextColor, orderUser.GetFirstName(),
                                              $"On this day:\n{orderUser.GetName()} should clean all shared facilities.", Properties.Resources.CommonRoom);
                    iterator = iterator.AddDays(tbCommonRooms.Value);
                }
            }
            //Cleaning Kitchen
            if (tbKitchen.Value > 0)
            {
                iterator = scheduler.GetLastDate(EventType.Kitchen);
                if (iterator.Date != startDate.Date) iterator = iterator.AddDays(tbKitchen.Value);
                while (iterator < endDate)
                {
                    scheduler.SetLastDate(EventType.Kitchen, iterator);
                    colorHandler = EventColorHandler.GetColorHandler(EventType.Kitchen);
                    orderUser = scheduler.GetNextUser(EventType.Kitchen);
                    CalendarItem.AddEventToDB(iterator, colorHandler.BackColor, colorHandler.TextColor, orderUser.GetFirstName(),
                                              $"On this day:\n{orderUser.GetName()} should clean the kitchen.", Properties.Resources.Cleaning);
                    iterator = iterator.AddDays(tbKitchen.Value);
                }
            }
            //Cleaning Bathroom/Toilet
            if (tbBathroom.Value > 0)
            {
                iterator = scheduler.GetLastDate(EventType.Bathroom);
                if (iterator.Date != startDate.Date) iterator = iterator.AddDays(tbBathroom.Value);
                while (iterator < endDate)
                {
                    scheduler.SetLastDate(EventType.Bathroom, iterator);
                    colorHandler = EventColorHandler.GetColorHandler(EventType.Bathroom);
                    orderUser = scheduler.GetNextUser(EventType.Bathroom);
                    CalendarItem.AddEventToDB(iterator, colorHandler.BackColor, colorHandler.TextColor, orderUser.GetFirstName(),
                                              $"On this day:\n{orderUser.GetName()} should clean the bathroom and toilet facilities.", Properties.Resources.Toilet);
                    iterator = iterator.AddDays(tbBathroom.Value);
                }
            }
            settingsHandler.CommonValue = tbCommonRooms.Value;
            settingsHandler.KitchenValue = tbKitchen.Value;
            settingsHandler.BathroomValue = tbBathroom.Value;
            settingsHandler.SaveSettings();
            this.Close();
        }
    }
}

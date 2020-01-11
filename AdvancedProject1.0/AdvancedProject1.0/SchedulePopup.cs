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
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //TO DO: Add limits
            int order = 0;
            EventColorHandler colorHandler = new EventColorHandler();
            DateTime startDate = GetNextWeekday(DateTime.Today, DayOfWeek.Monday);
            DateTime iterator = startDate;
            DateTime endDate = startDate.AddDays(7);
            MessageBox.Show(endDate.ToString());
            //Cleaning Common Rooms
            if(tbCommonRooms.Value > 0)
            {
                while (iterator <= endDate)
                {
                    colorHandler = EventColorHandler.GetColorHandler(EventType.CommonRoom);
                    CalendarItem.AddEventToDB(iterator, colorHandler.BackColor, colorHandler.TextColor, "Temporary", "No event description", Properties.Resources.CommonRoom);
                    iterator = iterator.AddDays(tbCommonRooms.Value);
                }
            }
            this.Close();
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
    }
}

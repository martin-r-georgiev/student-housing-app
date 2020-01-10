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

        private void tbGarbage_ValueChanged(object sender, EventArgs e)
        {
            lblGarbageValue.Text = tbGarbage.Value.ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //TO DO: Add limits
            int order = 0;
            DateTime nextMonday = GetNextWeekday(DateTime.Today, DayOfWeek.Monday);
            MessageBox.Show(GetNextWeekday(nextMonday, DayOfWeek.Wednesday).ToString());
            for(int i = 0; i < 7; i++)
            {
                CalendarItem.AddEventToDB(nextMonday, Color.DarkBlue, Color.White, "Temporary", "No event description", Properties.Resources.Cleaning);
                nextMonday = nextMonday.AddDays(tbGarbage.Value);
            }
            this.Close();
        }
    }
}

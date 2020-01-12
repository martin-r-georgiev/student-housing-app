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
            settingsHandler.CommonValue = tbCommonRooms.Value;
            settingsHandler.KitchenValue = tbKitchen.Value;
            settingsHandler.BathroomValue = tbBathroom.Value;
            settingsHandler.SaveSettings();
            this.Close();
        }
    }
}

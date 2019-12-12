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
    public partial class TenantMain : Form
    {

        HouseRulesInfo houseRules;
        User loggedInUser;

        public TenantMain()
        {
            InitializeComponent();
            houseRules = new HouseRulesInfo();
            loggedInUser = new User(formLogin.userKey);
            lblWelcome.Text = $"Welcome, {loggedInUser.GetFirstName()}!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            formLogin loginScreen = new formLogin();
            loginScreen.Show();
            this.Close();
        }

        private void btnCleaning_Click(object sender, EventArgs e)
        {
            CleaningSchedule cleaningScheduleScreen = new CleaningSchedule();
            cleaningScheduleScreen.Show();
            this.Close();
        }

        private void btnGroceries_Click(object sender, EventArgs e)
        {
            Groceries groceriesScreen = new Groceries();
            groceriesScreen.Show();
            this.Close();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            Events eventScreen = new Events();
            eventScreen.Show();
            this.Close();
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            Social socialScreen = new Social(this);
            socialScreen.Show();
            this.Close();
        }

        private void btnHouseRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(houseRules.GetRules());
        }
    }
}

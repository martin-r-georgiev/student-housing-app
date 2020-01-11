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
            /* (Example) How to use the HouseUnit class to iterate through tenants
            HouseUnit newUnit = new HouseUnit(loggedInUser.GetHouseID());
            string test = "";
            foreach(User tenant in newUnit.Tenants())
            {
                test += $"{tenant.GetFirstName()},";
            }
            MessageBox.Show(test);
            */
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

        private void TenantMain_Load(object sender, EventArgs e)
        {

        }
    }
}

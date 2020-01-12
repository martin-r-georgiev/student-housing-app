using System;
using System.Diagnostics;
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
    public partial class AdminMain : Form
    {
        User loggedInUser;

        public AdminMain()
        {
            InitializeComponent();
            loggedInUser = new User(formLogin.userKey);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            formLogin loginScreen = new formLogin();
            loginScreen.Show();
            this.Close();  //h
        }

        private void btnHouseRules_Click(object sender, EventArgs e)
        {
            HouseRules houseRulesScreen = new HouseRules();
            houseRulesScreen.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reportsScreen = new Reports();
            reportsScreen.Show();
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AdminAdd addScreen = new AdminAdd();
            addScreen.Show();
            this.Close();
        }

        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close")) { }
            else Application.Exit();
        }
    }
}

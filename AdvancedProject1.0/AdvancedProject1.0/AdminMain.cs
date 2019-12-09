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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            formLogin loginScreen = new formLogin();
            loginScreen.Show();
            this.Hide();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            Events eventScreen = new Events();
            eventScreen.Show();
            this.Hide();
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
            this.Hide();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AdminAdd addScreen = new AdminAdd();
            addScreen.Show();
            this.Hide();
        }
    }
}

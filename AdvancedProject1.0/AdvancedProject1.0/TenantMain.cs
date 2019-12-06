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
        public TenantMain()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            formLogin loginScreen = new formLogin();
            loginScreen.Show();
            this.Hide();
        }

        private void btnCleaning_Click(object sender, EventArgs e)
        {
            CleaningSchedule cleaningScheduleScreen = new CleaningSchedule();
            cleaningScheduleScreen.Show();
            this.Hide();
        }

        private void btnGroceries_Click(object sender, EventArgs e)
        {
            Groceries groceriesScreen = new Groceries();
            groceriesScreen.Show();
            this.Hide();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            Events eventScreen = new Events();
            eventScreen.Show();
            this.Hide();
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            Social socialScreen = new Social();
            socialScreen.Show();
            this.Hide();
        }
    }
}

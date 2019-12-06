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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            EventsPopup eventsPopupScreen = new EventsPopup();
            eventsPopupScreen.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (rbTenant.Checked)
            {
                TenantMain tenantMainScreen = new TenantMain();
                tenantMainScreen.Show();
                this.Hide();
            } else
            {
                AdminMain adminMainScreen = new AdminMain();
                adminMainScreen.Show();
                this.Hide();
            }
        }
    }
}

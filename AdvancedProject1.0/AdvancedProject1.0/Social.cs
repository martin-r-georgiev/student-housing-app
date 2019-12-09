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
    public partial class Social : Form
    {
        private TenantMain mainForm = null;

        public Social(TenantMain calledForm)
        {
            InitializeComponent();
            mainForm = calledForm as TenantMain;
        }

        private void Social_Load(object sender, EventArgs e)
        {
            MessageBox.Show(mainForm.studentID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TenantMain tenantMainScreen = new TenantMain();
            tenantMainScreen.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportPopup reportPopupScreen = new ReportPopup();
            reportPopupScreen.Show();
        }

    }
}

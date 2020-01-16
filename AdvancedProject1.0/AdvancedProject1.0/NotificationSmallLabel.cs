using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedProject1._0
{
    public partial class NotificationSmallLabel : UserControl
    {
        private Notifications notification;

        public Notifications Notification
        {
            get { return notification; }
            set { notification = value; lblTitle.Text = notification.Title; lblDesc.Text = notification.Description; }
        }

        public NotificationSmallLabel(Notifications notif)
        {
            InitializeComponent();
            this.Notification = notif;
        }
        public NotificationSmallLabel()
        {
            InitializeComponent();
            
        }

        private void NotificationSmallLabel_MouseEnter(object sender, EventArgs e)
        {
            this.Size = new Size(148, 120);
            this.lblDesc.Size = new Size(118, 87);
        }

        private void NotificationSmallLabel_MouseLeave(object sender, EventArgs e)
        {
            this.Size = new Size(148, 60);
            this.lblDesc.Size = new Size(118, 27);
            this.BackColor = Color.White;
        }
        private void NotificationSmallLabel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notification.Complete();
            TenantMain pForm = (TenantMain)this.ParentForm;
            pForm.RefreshPanel();
        }

        private void NotificationSmallLabel_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}

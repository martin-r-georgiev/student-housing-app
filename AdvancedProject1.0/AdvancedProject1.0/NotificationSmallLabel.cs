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
            set { notification = value; lblTitle.Text = notification.Title; lblDesc.Text = notification.Description; tbDesc.Text = notification.Description; }
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
            this.Size = new Size(132, 120);
            this.tbDesc.Visible = true;
            this.lblDesc.Visible = false;
            this.tbDesc.Size = new Size(113, 87);
        }

        private void NotificationSmallLabel_MouseLeave(object sender, EventArgs e)
        {
            this.Size = new Size(132, 60);
            this.tbDesc.Visible = false;
            this.lblDesc.Visible = true;
            this.tbDesc.Size = new Size(113, 27);
            this.BackColor = Color.White;
        }
        private void NotificationSmallLabel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (notification.Title.Contains("Reply")) 
            notification.RemoveFromDatabase();
        }

        private void NotificationSmallLabel_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Silver;
        }
    }
}

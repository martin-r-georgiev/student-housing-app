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
    public partial class EventsPopup : Form
    {
        EventColorHandler colorHandler = new EventColorHandler();
        bool emptyTitle = false;

        public EventsPopup()
        {
            InitializeComponent();
            pbEventImage.Image = Properties.Resources.QuestionMark;
            dtpEvent.Value = DateTime.Now;
            if (new User(formLogin.userKey).IsAdmin) cbGlobalEvent.Visible = true;
        }

        private void cbImageList_DropDown(object sender, EventArgs e)
        {
            cbImageList.Items.Clear();
            foreach(EventType item in Enum.GetValues(typeof(EventType)))
            {
                cbImageList.Items.Add(item);
            }
        }

        private void cbImageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorHandler = EventColorHandler.GetColorHandler((EventType)cbImageList.SelectedIndex);
            switch(cbImageList.SelectedIndex)
            {
                case 0: pbEventImage.Image = Properties.Resources.Gaming; break;
                case 1: pbEventImage.Image = Properties.Resources.Study; break;
                case 2: pbEventImage.Image = Properties.Resources.Party; break;
                case 3: pbEventImage.Image = Properties.Resources.Garbage; break;
                case 4: pbEventImage.Image = Properties.Resources.CommonRoom; break;
                case 5: pbEventImage.Image = Properties.Resources.Dishes; break;
                case 6: pbEventImage.Image = Properties.Resources.Cleaning; break;
                case 7: pbEventImage.Image = Properties.Resources.Groceries; break;
                default: pbEventImage.Image = null; break;
            }
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            if(cbImageList.SelectedIndex != -1)
            {
                if (!string.IsNullOrEmpty(tbTitle.Text) && emptyTitle)
                {
                    if (cbGlobalEvent.Checked) CalendarItem.unitID = -1;
                    CalendarItem.AddEventToDB(dtpEvent.Value, colorHandler.BackColor, colorHandler.TextColor, tbTitle.Text, tbDescription.Text, pbEventImage.Image);
                    this.Close();
                }
                else MessageBox.Show("You need to specify a title to create an event.");
            } 
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbTitle_Enter(object sender, EventArgs e)
        {
            if (tbTitle.Text == "Title")
            {
                tbTitle.Text = "";
                tbTitle.ForeColor = Color.FromArgb(36, 42, 86);
                emptyTitle = true;
            }
        }

        private void TbTitle_Leave(object sender, EventArgs e)
        {
            if (tbTitle.Text == "")
            {
                tbTitle.Text = "Title";
                tbTitle.ForeColor = Color.DarkGray;
                emptyTitle = false;
            }
        }
    }
}

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
        private Color backColor = SystemColors.Control;
        private Color textColor = SystemColors.InfoText;

        public EventsPopup()
        {
            InitializeComponent();
            dtpEvent.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
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
            switch(cbImageList.SelectedIndex)
            {
                case 0: 
                    pbEventImage.Image = Properties.Resources.Gaming;
                    backColor = Color.Black;
                    textColor = Color.White;
                    break;
                case 1: 
                    pbEventImage.Image = Properties.Resources.Study;
                    backColor = Color.MidnightBlue;
                    textColor = Color.White;
                    break;
                case 2: 
                    pbEventImage.Image = Properties.Resources.Party;
                    backColor = Color.Purple;
                    textColor = Color.White;
                    break;
                case 3: 
                    pbEventImage.Image = Properties.Resources.Garbage;
                    backColor = Color.Peru;
                    textColor = Color.Black;
                    break;
                case 4: 
                    pbEventImage.Image = Properties.Resources.Dishes;
                    backColor = Color.LimeGreen;
                    textColor = Color.Black;
                    break;
                case 5: 
                    pbEventImage.Image = Properties.Resources.Washing;
                    backColor = Color.DarkSlateBlue;
                    textColor = Color.White;
                    break;
                case 6: 
                    pbEventImage.Image = Properties.Resources.Cleaning;
                    backColor = Color.DarkRed;
                    textColor = Color.White;
                    break;
                default: 
                    pbEventImage.Image = null; 
                    break;
            }
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTitle.Text))
            {
                CalendarItem.AddEventToDB(dtpEvent.Value, backColor, textColor, tbTitle.Text, tbDescription.Text, pbEventImage.Image);
                this.Close();
            }
            else MessageBox.Show("You need to specify a title to create an event.");
        }
    }
}

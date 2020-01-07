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
    public partial class calendarEventItem : UserControl
    {
        FlowLayoutPanel parentPanel = new FlowLayoutPanel();
        public calendarEventItem(FlowLayoutPanel passedPanel)
        {
            InitializeComponent();
            parentPanel = passedPanel;
            this.Dock = DockStyle.Top;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private Color _panelColor;
        private Color _textColor;
        private string _title;

        public Color Color
        {
            get { return _panelColor; }
            set { _panelColor = value; this.BackColor = _panelColor; }
        }

        public Color TextColor
        {
            get { return _textColor; }
            set { _textColor = value; lblTitle.ForeColor = _textColor; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = _title; }
        }

        private void lblTitle_MouseEnter(object sender, EventArgs e)
        {
            //Changing background color on mouse hover
            this.BackColor = ControlPaint.Light(this.BackColor, 0.25f);
        }

        private void lblTitle_MouseLeave(object sender, EventArgs e)
        {
            //Changing background color back to normal
            this.BackColor = _panelColor;
        }

        private void lblTitle_DoubleClick(object sender, EventArgs e)
        {
            //Double-clicking item to mark it as complete
            _panelColor = Color.LawnGreen;
            _textColor = Color.Black;
            this.BackColor = _panelColor;
            lblTitle.ForeColor = _textColor;
            parentPanel.Controls.Remove(this);
        }
    }
}

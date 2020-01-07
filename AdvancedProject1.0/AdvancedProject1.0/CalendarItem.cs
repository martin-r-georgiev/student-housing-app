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
    public partial class CalendarItem : UserControl
    {
        public CalendarItem()
        {
            InitializeComponent();
        }

        private string _date;
        private string _dayofweek;

        public string Date
        {
            get { return _date; }
            set { _date = value; lblDate.Text = _date; }
        }

        public string DayOfWeek
        {
            get { return _dayofweek; }
            set { _dayofweek = value; lblWeekDay.Text = _dayofweek; }
        }

        public void AddEvent(string title, Color eventColor, Color textColor)
        {
            calendarEventItem newEvent = new calendarEventItem(calendarEventList);
            newEvent.Title = title;
            newEvent.Color = eventColor;
            newEvent.TextColor = textColor;
            calendarEventList.Controls.Add(newEvent);
        }

        public void AddEvent(string title, Color eventColor)
        {
            calendarEventItem newEvent = new calendarEventItem(calendarEventList);
            newEvent.Title = title;
            newEvent.Color = eventColor;
            calendarEventList.Controls.Add(newEvent);
        }
        
        public void IsToday()
        {
            calendarDateBackground.BackColor = Color.BlueViolet;
            eventTablePanel.BackColor = SystemColors.ControlLight;
            WeekDayPanel.BackColor = SystemColors.ControlLight;
        }

        public void IsToday(Color barColor)
        {
            calendarDateBackground.BackColor = barColor;
            eventTablePanel.BackColor = SystemColors.ControlLight;
            WeekDayPanel.BackColor = SystemColors.ControlLight;
        }

        public void IsToday(Color barColor, Color backColor)
        {
            calendarDateBackground.BackColor = barColor;
            eventTablePanel.BackColor = backColor;
            WeekDayPanel.BackColor = backColor;
        }

        private void calendarEventList_ControlRemoved(object sender, ControlEventArgs e)
        {
            //Resetting scrollbar on control(control) removal
            //eventTablePanel.VerticalScroll.Value = eventTablePanel.VerticalScroll.Maximum;
            //eventTablePanel.PerformLayout();
            //Not working properly = To be fixed()
        }

    }
}

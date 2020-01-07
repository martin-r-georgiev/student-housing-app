using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdvancedProject1._0
{
    public partial class CalendarItem : UserControl
    {
        public CalendarItem()
        {
            InitializeComponent();
        }

        private string _date;
        private DateTime _rawdate;
        private string _dayofweek;
        public static int unitID;

        public string Date
        {
            get { return _date; }
            set { _date = value; lblDate.Text = _date; }
        }

        public DateTime RawDate
        {
            get { return _rawdate; }
            set { _rawdate = value; }
        }

        public string DayOfWeek
        {
            get { return _dayofweek; }
            set { _dayofweek = value; lblWeekDay.Text = _dayofweek; }
        }

        private void AddEventToDB(DateTime date, Color eventColor, Color titleColor, string title)
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"INSERT INTO CalendarEvents (date, eventColor, eventTitle, titleColor, houseUnit) VALUES (@date, @color, @title, @tcolor, @unit)", con))
            {
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@color", ColorTranslator.ToHtml(eventColor));
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@tcolor", ColorTranslator.ToHtml(titleColor));
                cmd.Parameters.AddWithValue("@unit", unitID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }

            
            con.Close();
        }

        private string ReturnCurrentID()
        {
            string return_id;
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"SELECT IDENT_CURRENT('CalendarEvents')", con))
            {
                return_id = (Convert.ToInt32(cmd.ExecuteScalar())+1).ToString();
                cmd.Dispose();
            }
            con.Close();

            return return_id;
        }

        public void AddEvent(string title, Color eventColor, Color textColor)
        {
            calendarEventItem newEvent = new calendarEventItem(calendarEventList);
            newEvent.Title = title;
            newEvent.Color = eventColor;
            newEvent.TextColor = textColor;
            newEvent.Id = ReturnCurrentID();
            calendarEventList.Controls.Add(newEvent);
            AddEventToDB(this._rawdate, eventColor, textColor, title);
        }

        public void AddEvent(string title, Color eventColor)
        {
            calendarEventItem newEvent = new calendarEventItem(calendarEventList);
            newEvent.Title = title;
            newEvent.Color = eventColor;
            newEvent.Id = ReturnCurrentID();
            MessageBox.Show($"{newEvent.Id}");
            calendarEventList.Controls.Add(newEvent);
            AddEventToDB(this._rawdate, eventColor, Color.Black, title);
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

        public void LoadEvents()
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;

            cmd = new SqlCommand($"SELECT date, eventColor, eventTitle, titleColor, Id FROM CalendarEvents WHERE date=@samedate AND houseUnit=@unit", con);
            cmd.Parameters.AddWithValue("@samedate", this._rawdate);
            cmd.Parameters.AddWithValue("@unit", unitID);
            dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                while(dataReader.Read())
                {
                    calendarEventItem newEvent = new calendarEventItem(calendarEventList);
                    newEvent.Title = dataReader.GetString(2);
                    newEvent.TextColor = ColorTranslator.FromHtml(dataReader.GetString(3));
                    newEvent.Color = ColorTranslator.FromHtml(dataReader.GetString(1));
                    newEvent.Id = dataReader.GetInt32(4).ToString();
                    calendarEventList.Controls.Add(newEvent);
                }
            }
            con.Close();
        }

    }
}

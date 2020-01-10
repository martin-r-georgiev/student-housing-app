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

        private string _id;
        private Color _panelColor;
        private Color _textColor;
        private string _title;
        private string description;
        private bool completed;
        private Image _image;

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

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public bool Completed
        {
            get { return completed; }
            set { completed = value; }
        }

        public Image Image
        {
            get { return _image; }
            set { _image = value; }
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

        private void RemoveEventFromDB()
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"DELETE CalendarEvents WHERE Id=@eventID", con))
            {
                cmd.Parameters.AddWithValue("@eventID", this.Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }

        private void lblTitle_DoubleClick(object sender, EventArgs e)
        {
            //Double-clicking item to mark it as complete
            _panelColor = Color.LawnGreen;
            _textColor = Color.Black;
            this.BackColor = _panelColor;
            this.Completed = true;
            lblTitle.ForeColor = _textColor;

            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"UPDATE CalendarEvents SET completed=@Completed WHERE Id=@elemID", con))
            {
                cmd.Parameters.AddWithValue("@Completed", this.Completed);
                cmd.Parameters.AddWithValue("@elemID", this.Id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();

            //In case we decide to start deleting elements once completed:
            //RemoveEventFromDB();
            //parentPanel.Controls.Remove(this);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            //Show Event info(description, image, title, etc.)
            CleaningSchedule pForm = (CleaningSchedule)this.ParentForm;
            pForm.ChangeDescription(this.description);
            pForm.ChangePicture(this.Image);
        }
    }
}

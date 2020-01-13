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
        FlowLayoutPanel parentPanel;
        public calendarEventItem(FlowLayoutPanel passedPanel)
        {
            InitializeComponent();
            parentPanel = passedPanel;
            this.Dock = DockStyle.Top;
            this.lblTitle.MouseDown += new MouseEventHandler(this.lblTitle_MouseDown);
        }

        private static User loggedInUser = new User(formLogin.userKey);
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
            set
            {
                completed = value;
                if (value)
                {
                    this.BackColor = Color.Green;
                    this.lblTitle.ForeColor = Color.Green;

                }
                else
                {
                    this.BackColor = _panelColor;
                    this.lblTitle.ForeColor = _textColor;
                }
            }
        }

        public Image Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public void SetHeight(int newHeight)
        {
            this.Height = newHeight;
        }

        public static float NewFontSize(Label label)
        {
            Size size = label.Size;
            SizeF stringSize = TextRenderer.MeasureText(label.Text, label.Font);
            float wRatio = label.Size.Width / (stringSize.Width+20);
            float hRatio = size.Height / (stringSize.Height+20);
            float ratio = Math.Min(hRatio, wRatio);
            return label.Font.Size * ratio;

        }

        private void lblTitle_MouseEnter(object sender, EventArgs e)
        {
            //Changing background color on mouse hover
            this.BackColor = ControlPaint.Light(this.BackColor, 0.75f);
        }

        private void lblTitle_MouseLeave(object sender, EventArgs e)
        {
            //Changing background color back to normal
            if (!this.Completed) this.BackColor = _panelColor;
            else this.BackColor = Color.Green;
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
            this.Completed = !this.Completed;

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
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            //Show Event info(description, image, title, etc.)
            CleaningSchedule pForm = (CleaningSchedule)this.ParentForm;
            pForm.ChangeDescription(this.description);
            pForm.ChangePicture(this.Image);  
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rightClickMenu.Show(this, new Point(e.X, e.Y));
            }
        }

        private void calendarEventItem_SizeChanged(object sender, EventArgs e)
        {
            lblPlaceholder.ForeColor = lblTitle.ForeColor;
            if (lblTitle.Font.Size < 6)
            {
                lblTitle.Visible = false;
                lblPlaceholder.Visible = true;
            }
            else
            {
                lblTitle.Visible = true;
                lblPlaceholder.Visible = false;
                if(NewFontSize(lblTitle) > 0) lblTitle.Font = new Font(lblTitle.Font.FontFamily, NewFontSize(lblTitle));
            }
        }

        private void rightClickMenu_Opening(object sender, CancelEventArgs e)
        {
            string createdBy = null;
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"SELECT createdBy FROM CalendarEvents WHERE Id=@eventID", con))
            {
                cmd.Parameters.AddWithValue("@eventID", this.Id);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read()) createdBy = dataReader[0] as string;
                dataReader.Close();
                cmd.Dispose();
            }
            con.Close();

            if (loggedInUser.GetUserID() == createdBy) rightClickMenuItem2.Visible = true;
            else rightClickMenuItem2.Visible = false;
        }

        private void rightClickMenuItem2_Click(object sender, EventArgs e)
        {
            //Delete 'event' event handler
            RemoveEventFromDB();
            parentPanel.Controls.Remove(this);
        }

        private void rightClickMenuItem1_Click(object sender, EventArgs e)
        {
            //Mark as (in)complete
            if (this.Completed) rightClickMenuItem1.Text = "Mark as completed";
            else rightClickMenuItem1.Text = "Mark as incomplete";
            lblTitle_DoubleClick(lblTitle, e);
        }
    }
}

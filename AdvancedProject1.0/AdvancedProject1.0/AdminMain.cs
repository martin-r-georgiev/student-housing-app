using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace AdvancedProject1._0
{
    public partial class AdminMain : Form
    {
        User loggedInUser;
        List<HouseUnit> unitList = new List<HouseUnit>();
        public AdminMain()
        {
            InitializeComponent();
            loggedInUser = new User(formLogin.userKey);
            PopulateCBAnnouncements();
        }
        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            formLogin loginScreen = new formLogin();
            loginScreen.Show();
            this.Close();  //h
        }

        private void btnHouseRules_Click(object sender, EventArgs e)
        {
            HouseRules houseRulesScreen = new HouseRules();
            houseRulesScreen.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reportsScreen = new Reports();
            reportsScreen.Show();
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AdminAdd addScreen = new AdminAdd();
            addScreen.Show();
            this.Close();
        }

        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close")) { }
            else Application.Exit();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            AdminCalendar calendarForm = new AdminCalendar();
            calendarForm.Show();
            this.Close();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            if (btnAnnouncements.Text == "Make Announcement")
            {
                btnAnnouncements.Text = "Send";
                tbAnnouncement.Visible = true;
                cbAnnouncementUnits.Visible = true;
                cbAnnouncementUnits.SelectedIndex = 0;

            } else if (btnAnnouncements.Text == "Send")
            {
                SendAnnouncement();
                btnAnnouncements.Text = "Make Announcement";
                tbAnnouncement.Visible = false;
                cbAnnouncementUnits.Visible = false;
            }
        }
        private void PopulateUnitList()
        {
            unitList.Clear();

            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand($"SELECT unitID FROM HUnitTable", con);
            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                HouseUnit newUnit = new HouseUnit(dataReader.GetInt32(0));
                unitList.Add(newUnit);
            }
            con.Close();
        }
        private void SendAnnouncement()
        {
            if (tbAnnouncement.Text.Length > 0)
            {
                if (cbAnnouncementUnits.SelectedIndex == 0)
                {
                    NotificationsGatherer.Anounce(tbAnnouncement.Text);
                }
                else
                {
                    NotificationsGatherer.Anounce(tbAnnouncement.Text, Convert.ToInt32(cbAnnouncementUnits.SelectedItem));
                }
            }
            else MessageBox.Show("Write an announcement first!");
        }
        private void PopulateCBAnnouncements()
        {
            PopulateUnitList();
            cbAnnouncementUnits.Items.Clear();
            cbAnnouncementUnits.Items.Add("All");
            foreach (HouseUnit h in unitList)
                cbAnnouncementUnits.Items.Add(h.GetUnitID());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace AdvancedProject1._0
{
    public class Report
    {
        private User reporter;
        private string reportText;
        private bool isReport;
        private int reportId;

        public int ReportId
        {
            get { return reportId; }
            private set { reportId = value; }
        }

        public bool IsReport
        {
            get { return isReport; }
            private set { isReport = value; }
        }

        public string ReportText
        {
            get { return reportText; }
            private set { reportText = value; }
        }

        public User Reporter
        {
            get { return reporter; }
            private set { reporter = value; }
        }
        public Report(User reportSender, string report)
        {
            this.Reporter = reportSender;
            this.ReportText = report;
            this.IsReport = true;
            InsertReportToDatabase();
        }
        public Report(int reportId)
        {
            //Creating & opening SQL Connection to database
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;

            cmd = new SqlCommand($"SELECT ReporterID, Report, Type FROM Reports WHERE Id=@reportId", con);
            cmd.Parameters.AddWithValue(@"reportId", reportId);
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                string reporterId = dataReader.GetString(0);
                this.Reporter = new User(reporterId);
                this.ReportText = dataReader.GetString(1);
                string type = dataReader.GetString(2);
                if (type == "Report") this.isReport = true;
                else if (type == "Reply") this.isReport = false;
                this.ReportId = reportId;
            }
            con.Close();
        }
        public void InsertReportToDatabase()
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"INSERT INTO Reports (ReporterID, Report, Type) VALUES (@reporterId, @reportText, @type)", con))
            {
                cmd.Parameters.AddWithValue("@reporterId", this.Reporter.GetUserID());
                cmd.Parameters.AddWithValue("@reportText", this.ReportText);
                cmd.Parameters.AddWithValue("@type", "Report");
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
            SetReportID();
        }
        public void SetReportID()
        {
            //Creating & opening SQL Connection to database
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;

            cmd = new SqlCommand($"SELECT MAX(Id) FROM Reports", con);
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                this.ReportId = dataReader.GetInt32(0);
            }
            con.Close();
        }
        public void RemoveFromDatabase()
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"DELETE Reports WHERE Id=@reportID", con))
            {
                cmd.Parameters.AddWithValue("@reportID", this.ReportId);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }
        public void Reply(string replyMsg)
        {
            this.IsReport = false;
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();
            using (SqlCommand cmd = new SqlCommand($"UPDATE Reports SET Report = @reportText, Type = @type WHERE Id = @reportId", con))
            {
                cmd.Parameters.AddWithValue("@reportText", replyMsg);
                cmd.Parameters.AddWithValue("@type", "Reply");
                cmd.Parameters.AddWithValue("@reportId", this.ReportId);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();

        }
    }
}

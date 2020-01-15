using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace AdvancedProject1._0
{
    class ReportsList
    {
        List<Report> reportsList;

		public ReportsList()
		{
			reportsList = new List<Report>();
			//Creating & opening SQL Connection to database
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT Id FROM Reports", con);
			dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				int reportId = dataReader.GetInt32(0);
				Report newReport = new Report(reportId);
				reportsList.Add(newReport);
			}
			con.Close();
		}
		public static List<Report> GetReports()
		{
			List<Report> reportList = new List<Report>();
			//Creating & opening SQL Connection to database
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT Id FROM Reports WHERE Type=@type", con);
			cmd.Parameters.AddWithValue(@"type", "Report");
			dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				int reportId = dataReader.GetInt32(0);
				Report newReport = new Report(reportId);
				reportList.Add(newReport);
			}
			con.Close();
			return reportList;
		}
		public static List<Report> GetReplies(string userId)
		{
			List<Report> replyList = new List<Report>();
			//Creating & opening SQL Connection to database
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT Id FROM Reports WHERE Type=@type AND ReporterID=@reporterId", con);
			cmd.Parameters.AddWithValue(@"type", "Reply");
			cmd.Parameters.AddWithValue(@"reporterId", userId);
			dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				int reportId = dataReader.GetInt32(0);
				Report newReport = new Report(reportId);
				replyList.Add(newReport);
			}
			con.Close();
			return replyList;
		}

		public void ReplyTo(int reportId, string reply)
		{
			foreach (Report r in reportsList)
			{
				if (r.ReportId == reportId)
					r.Reply(reply);
			}
		}
		public void DeleteEntry(int reportId)
		{
			foreach(Report r in reportsList)
			{
				if (r.ReportId == reportId)
					r.RemoveFromDatabase();
			}
		}
	}
}

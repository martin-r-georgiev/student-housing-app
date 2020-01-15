using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject1._0
{
    public class Notifications
	{ 
		private string title;
		private string description;
		private User notifiedUser;
		private int notificationId;
		private bool isComplete;
		public bool IsComplete
		{
			get { return isComplete; }
			set { isComplete = value; }
		}
		public int NotificationId
		{
			get { return notificationId; }
			set { notificationId = value; }
		}

		public User NotifiedUser
		{
			get { return notifiedUser; }
			set { notifiedUser = value; }
		}
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		public string Title
		{
			get { return title; }
			set { title = value; }
		}
		public Notifications(string userID, string title, string description)
		{
				this.NotifiedUser = new User(userID);
				this.Title = title;
				this.Description = description;
			this.IsComplete = false;
				InsertToDB();
		}
		public Notifications(int notificationNum)
		{
			//Creating & opening SQL Connection to database
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT Title, Notification, UserID, Status FROM Notifications WHERE Id=@notificationId", con);
			cmd.Parameters.AddWithValue(@"notificationId", notificationNum);
			dataReader = cmd.ExecuteReader();

			if (dataReader.Read())
			{
				this.NotificationId = notificationNum;
				this.Title = dataReader.GetString(0);
				this.Description = dataReader.GetString(1);
				this.notifiedUser = new User(dataReader.GetString(2));
				if (dataReader.GetString(3).Contains("Sent")) this.IsComplete = false;
				else if (dataReader.GetString(3).Contains("Complete")) this.IsComplete = true;
			}
			con.Close();
		}
		public void InsertToDB()
		{
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			using (SqlCommand cmd = new SqlCommand($"INSERT INTO Notifications (Title, Notification, UserID, Status) VALUES (@title, @notificationText, @userid, @status)", con))
			{
				cmd.Parameters.AddWithValue("@title", this.Title);
				cmd.Parameters.AddWithValue("@notificationText", this.Description);
				cmd.Parameters.AddWithValue("@userid", this.NotifiedUser.GetUserID());
				cmd.Parameters.AddWithValue("@status", "Sent");
				cmd.ExecuteNonQuery();
				cmd.Dispose();
			}
			con.Close();
			SetID();
		}
		public void SetID()
		{
			//Creating & opening SQL Connection to database
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT MAX(Id) FROM Notifications", con);
			dataReader = cmd.ExecuteReader();

			if (dataReader.Read())
			{
				this.NotificationId = dataReader.GetInt32(0);
			}
			con.Close();
		}
		public void RemoveFromDatabase()
		{
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			using (SqlCommand cmd = new SqlCommand($"DELETE Notifications WHERE Id=@notificationId", con))
			{
				cmd.Parameters.AddWithValue("@reportID", this.NotificationId);
				cmd.ExecuteNonQuery();
				cmd.Dispose();
			}
			con.Close();
		}
		public static bool IsSingleEntry(string title, string desc, string userid)
		{
			//Creating & opening SQL Connection to database
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT Id FROM Notifications WHERE Title=@title AND Notification=@notification AND UserID=@userid", con);
			cmd.Parameters.AddWithValue("@title", title);
			cmd.Parameters.AddWithValue("@notification", desc);
			cmd.Parameters.AddWithValue("@userid", userid);
			dataReader = cmd.ExecuteReader();

			if (dataReader.Read())
			{
				return false;
			}
			con.Close();
			return true;
		}
		public void Complete()
		{
			this.IsComplete = true;
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();
			using (SqlCommand cmd = new SqlCommand($"UPDATE Notifications SET Status = @statusText WHERE Id = @notificationId", con))
			{
				cmd.Parameters.AddWithValue("@notificationid", this.NotificationId);
				cmd.Parameters.AddWithValue("@statusText", "Complete");
				cmd.ExecuteNonQuery();
				cmd.Dispose();
			}
			con.Close();

		}
	}
}

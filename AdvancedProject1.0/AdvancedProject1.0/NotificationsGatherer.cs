using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject1._0
{
    class NotificationsGatherer
    {
        List<Notifications> notificationList;
        User loggedUser;

        public NotificationsGatherer(string userId)
        {
            this.loggedUser = new User(userId);
            notificationList = new List<Notifications>();
			//Creating & opening SQL Connection to database
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT Id FROM Notifications WHERE UserID = @userid", con);
			cmd.Parameters.AddWithValue("@userid", userId);
			dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				int notifID = dataReader.GetInt32(0);
				Notifications newNotification = new Notifications(notifID);
				notificationList.Add(newNotification);
			}
			con.Close();
			GetPaymentHistory();
			GetReportReplies();
			GetOrder();
		}
		public void GetPaymentHistory()
		{
			//Creating & opening SQL Connection to database
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT Receiver, Amount FROM PaymentHistory WHERE Sender = @userid", con);
			cmd.Parameters.AddWithValue("@userid", loggedUser.GetUserID());
			dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{	
				string receiverid = dataReader.GetString(0);
				User receiveUser = new User(receiverid);
				double amount = Convert.ToDouble(dataReader.GetString(1));
				string desc = "You owe " + receiveUser.GetFirstName() + "$ " + amount;
				if (Notifications.IsSingleEntry("Groceries", desc, loggedUser.GetUserID()))
				{
					Notifications newNotification = new Notifications(loggedUser.GetUserID(), "Groceries", desc);
					notificationList.Add(newNotification);
				}
			}
			con.Close();
		}
		public void GetReportReplies()
		{
			List<Report> reports = ReportsList.GetReplies(loggedUser.GetUserID());
			foreach (Report r in reports)
			{
				string title = "Report response";
				string desc = r.ReportText;
				if (Notifications.IsSingleEntry(title, desc, loggedUser.GetUserID()))
				{
					Notifications newNotification = new Notifications(loggedUser.GetUserID(), title, desc);
					notificationList.Add(newNotification);
				}
			}
		}
		public void GetOrder()
		{
			OrderScheduler newSched = new OrderScheduler(new HouseUnit(loggedUser.GetHouseID()));
			if (loggedUser.GetUserID() == newSched.CurrentIDGarbage)
			{
				string title = "Garbage takeout";
				string desc = "It's your turn to take the trash out";
				if (Notifications.IsSingleEntry(title, desc, loggedUser.GetUserID()))
				{
					Notifications newNotification = new Notifications(loggedUser.GetUserID(), title, desc);
					notificationList.Add(newNotification);
				}
			}
			if (loggedUser.GetUserID() == newSched.CurrentIDGroceries)
			{
				string title = "Groceries";
				string desc = "It's your turn to go shopping";
				if (Notifications.IsSingleEntry(title, desc, loggedUser.GetUserID()))
				{
					Notifications newNotification = new Notifications(loggedUser.GetUserID(), title, desc);
					notificationList.Add(newNotification);
				}
			}
		}
		public int GetNumberOfNotifications()
		{
			return notificationList.Count;
		}
		public List<Notifications> GetAllNotifications()
		{
			return notificationList;
		}
		public List<Notifications> GetAllIncompleteNotifications()
		{
			List<Notifications> toSend = new List<Notifications>();
			foreach (Notifications n in notificationList)
			{
				if (!n.IsComplete)
					toSend.Add(n);
			}
			return toSend;
		}
		public static void Anounce(string replyMsg)
		{
			List<User> allUsers = new List<User>();
			//Creating & opening SQL Connection to database
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT userID FROM Users", con);
			dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				string userID = dataReader.GetString(0);
				User newUser = new User(userID);
				if (!newUser.IsUserAdmin())
					allUsers.Add(newUser);
			}
			con.Close();
			foreach(User u in allUsers)
			{
				Notifications newNotification = new Notifications(u.GetUserID(), "Announcement", replyMsg);
			}
		}
		public static void Anounce(string replyMsg, int UnitID)
		{
			List<User> allUsers = new List<User>();
			//Creating & opening SQL Connection to database
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT userID FROM Users WHERE houseID = @unitid", con);
			cmd.Parameters.AddWithValue("@unitid", UnitID);
			dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				string userID = dataReader.GetString(0);
				User newUser = new User(userID);
				if (!newUser.IsUserAdmin())
					allUsers.Add(newUser);
			}
			con.Close();
			foreach (User u in allUsers)
			{
				Notifications newNotification = new Notifications(u.GetUserID(), "Announcement", replyMsg);
			}
		}
		public static void DeleteAllCompleted()
		{
		    SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			using (SqlCommand cmd = new SqlCommand($"DELETE Notifications WHERE Status=@statusText", con))
			{
				cmd.Parameters.AddWithValue("@statusText", "Complete");
				cmd.ExecuteNonQuery();
				cmd.Dispose();
			}
			con.Close();
		}
    }
}

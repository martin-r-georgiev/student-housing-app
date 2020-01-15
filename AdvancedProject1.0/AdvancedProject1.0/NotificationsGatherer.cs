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
			//Creating & opening SQL Connection to database
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT garbageCurrentID,groceriesCurrentID FROM SchedulerOrder WHERE unitID = @userunitid", con);
			cmd.Parameters.AddWithValue("@userunitid", loggedUser.GetHouseID());
			dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				string garbageId = dataReader.GetString(0);
				string groceriesId = dataReader.GetString(1);
				if (loggedUser.GetUserID() == garbageId)
				{
					string title = "Garbage takeout";
					string desc = "It's your turn to take the trash out";
					if (Notifications.IsSingleEntry(title, desc, loggedUser.GetUserID()))
					{
						Notifications newNotification = new Notifications(loggedUser.GetUserID(), title, desc);
						notificationList.Add(newNotification);
					}
				}
				if (loggedUser.GetUserID() == groceriesId)
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
			con.Close();
		}
		public int GetNumberOfNotifications()
		{
			return notificationList.Count;
		}
		public List<Notifications> GetAllNotifications()
		{
			return notificationList;
		}
		public static void Anounce()
		{
			
		}
    }
}

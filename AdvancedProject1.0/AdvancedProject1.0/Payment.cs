using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace AdvancedProject1._0
{
    class Payment
    {
		#region variables
		private int paymentID;
		private string sender;
		private string receiver;
		private double amount;
		private int unitID;
		
		#endregion

		#region properties
		public int UnitID
		{
			get { return unitID; }
			private set { unitID = value; }
		}

		public double Amount
		{
			get { return amount; }
			private set { amount = value; }
		}

		public string Receiver
		{
			get { return receiver; }
			private set { receiver = value; }
		}

		public string Sender
		{
			get { return sender; }
			private set { sender = value; }
		}

		public int PaymentID
		{
			get { return paymentID; }
			private set { paymentID = value; }
		}
		#endregion

		#region Methods
		public Payment(string sender, string receiver, double amount, int unitid)
		{
			this.Sender = sender;
			this.Receiver = receiver;
			this.Amount = amount;
			this.UnitID = unitid;
			InsertToDatabase();
		}
		public Payment(int paymentId)
		{
			//Creating & opening SQL Connection to database
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT Sender, Receiver, Amount, HouseUnitID FROM PaymentHistory WHERE Id=@paymentID", con);
			cmd.Parameters.AddWithValue(@"paymentId", paymentId);
			dataReader = cmd.ExecuteReader();

			if (dataReader.Read())
			{
				this.Sender = dataReader.GetString(0);
				this.Receiver = dataReader.GetString(1);
				this.Amount = Convert.ToDouble(dataReader.GetString(2));
				this.UnitID = dataReader.GetInt32(3);
				this.PaymentID = paymentId;
			}
			con.Close();
		}
		public void InsertToDatabase()
		{
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			using (SqlCommand cmd = new SqlCommand($"INSERT INTO PaymentHistory (Sender, Receiver, Amount, HouseUnitID) VALUES (@sender, @receiver, @amount, @houseunitid)", con))
			{
				cmd.Parameters.AddWithValue("@sender", this.Sender);
				cmd.Parameters.AddWithValue("@receiver", this.Receiver);
				cmd.Parameters.AddWithValue("@amount", this.Amount);
				cmd.Parameters.AddWithValue("@houseunitid", this.UnitID);
				cmd.ExecuteNonQuery();
				cmd.Dispose();
			}
			con.Close();
			SetPaymentID();
		}
		public void SetPaymentID()
		{
			//Creating & opening SQL Connection to database
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT MAX(Id) FROM PaymentHistory", con);
			dataReader = cmd.ExecuteReader();

			if (dataReader.Read())
			{
				int lastPay = dataReader.GetInt32(0);
			    this.PaymentID = lastPay;

			}
			con.Close();
		}
		public void RemoveFromDatabase()
		{
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			using (SqlCommand cmd = new SqlCommand($"DELETE PaymentHistory WHERE Id=@paymentID", con))
			{
				cmd.Parameters.AddWithValue("@paymentID", this.PaymentID);
				cmd.ExecuteNonQuery();
				cmd.Dispose();
			}
			con.Close();
		}

		#endregion
	}
}

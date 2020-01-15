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
		private User sender;
		private User receiver;
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

		public User Receiver
		{
			get { return receiver; }
			private set { receiver = value; }
		}

		public User Sender
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
		public Payment(string senderid, string receiverid, double amount, int unitid)
		{
			this.Sender = new User (senderid);
			this.Receiver = new User (receiverid);
			this.Amount = amount;
			this.UnitID = unitid;
			InsertToDatabase();
		}
		public Payment(int paymentId)
		{
			SqlConnection con = SqlConnectionHandler.GetSqlConnection();
			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT Sender, Receiver, Amount, HouseUnitID FROM PaymentHistory WHERE Id=@paymentID", con);
			cmd.Parameters.AddWithValue(@"paymentId", paymentId);
			dataReader = cmd.ExecuteReader();

			if (dataReader.Read())
			{
				string senderid = dataReader.GetString(0);
				this.Sender = new User(senderid);
				string receiverid = dataReader.GetString(1);
				this.Receiver = new User(receiverid);
				this.Amount = Convert.ToDouble(dataReader.GetString(2));
				this.UnitID = dataReader.GetInt32(3);
				this.PaymentID = paymentId;
			}
			con.Close();
		}
		public void InsertToDatabase()
		{
			SqlConnection con = SqlConnectionHandler.GetSqlConnection();
			using (SqlCommand cmd = new SqlCommand($"INSERT INTO PaymentHistory (Sender, Receiver, Amount, HouseUnitID) VALUES (@sender, @receiver, @amount, @houseunitid)", con))
			{
				cmd.Parameters.AddWithValue("@sender", this.Sender.UserID);
				cmd.Parameters.AddWithValue("@receiver", this.Receiver.UserID);
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
			SqlConnection con = SqlConnectionHandler.GetSqlConnection();
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
			SqlConnection con = SqlConnectionHandler.GetSqlConnection();
			using (SqlCommand cmd = new SqlCommand($"DELETE PaymentHistory WHERE Id=@paymentID ORDER BY Id LIMIT 1", con))
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

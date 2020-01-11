using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace AdvancedProject1._0
{
    class Payments
    {
        List<Payment> payments;

        public Payments()
        {
			payments = new List<Payment>();
			//Creating & opening SQL Connection to database
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT Id FROM PaymentHistory", con);
			dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				int paymentId = dataReader.GetInt32(0);
				Payment newPayment = new Payment(paymentId);
				payments.Add(newPayment);
			}
			con.Close();
		}
		public static List<string> GetPaymentsOfUnit(int currentHouseUnitID)
		{
			List<string> paymentList = new List<string>();
			//Creating & opening SQL Connection to database
			SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
			con.Open();

			SqlCommand cmd;
			SqlDataReader dataReader;

			cmd = new SqlCommand($"SELECT Sender, Receiver, Amount FROM PaymentHistory WHERE HouseUnitID=@unitID", con);
			cmd.Parameters.AddWithValue(@"unitID", currentHouseUnitID);
			dataReader = cmd.ExecuteReader();

			while (dataReader.Read())
			{
				string sender = dataReader.GetString(0);
				string receiver = dataReader.GetString(1);
				double amount = Convert.ToDouble(dataReader.GetString(2));
				string paymentLine = $"{sender}\t has to pay {amount}$ to {receiver}";
				paymentList.Add(paymentLine);
			}
			con.Close();
			return paymentList;
		}
		public void RemovePayment(string paymentMsg)
		{
			foreach (Payment p in payments)
			{
				if (paymentMsg.Contains(p.Receiver) && paymentMsg.Contains(p.Sender) && paymentMsg.Contains(p.Amount.ToString()))
				{
					SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
					con.Open();

					using (SqlCommand cmd = new SqlCommand($"DELETE PaymentHistory WHERE Id=@paymentID", con))
					{
						cmd.Parameters.AddWithValue("@paymentID", p.PaymentID);
						cmd.ExecuteNonQuery();
						cmd.Dispose();
					}
					con.Close();
				}
			}
		}
	}
}

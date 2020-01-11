using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdvancedProject1._0
{
    class OrderScheduler
    {
        private HouseUnit unit;
        private int unitID;
        private string currentID_common;
        private string currentID_kitchen;
        private string currentID_bathroom;
        private string currentID_garbage;
        private string currentID_groceries;

        public string CurrentIDCommon
        {
            get { return this.currentID_common; }
            private set { this.currentID_common = value; }
        }

        public string CurrentIDKitchen
        {
            get { return this.currentID_kitchen; }
            private set { this.currentID_kitchen = value; }
        }

        public string CurrentIDBathroom
        {
            get { return this.currentID_bathroom; }
            private set { this.currentID_bathroom = value; }
        }

        public string CurrentIDGarbage
        {
            get { return this.currentID_garbage; }
            private set { this.currentID_garbage = value; }
        }
        public string CurrentIDGroceries
        {
            get { return this.currentID_groceries; }
            private set { this.currentID_groceries = value; }
        }


        public OrderScheduler(HouseUnit newUnit)
        {
            this.unit = newUnit;

            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;

            cmd = new SqlCommand($"SELECT * FROM SchedulerOrder unitID=@Id", con);
            cmd.Parameters.AddWithValue("@Id", newUnit.GetUnitID());
            dataReader = cmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                this.unitID = dataReader.GetInt32(0);
                this.currentID_common = dataReader.GetString(1);
                this.currentID_kitchen = dataReader.GetString(2);
                this.currentID_bathroom = dataReader.GetString(3);
                this.currentID_garbage = dataReader.GetString(4);
                this.currentID_groceries = dataReader.GetString(5);
                cmd.Dispose();
            }
            con.Close();
        }

        public void AddToDatabase()
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"INSERT INTO SchedulerOrder (unitID, cmCurrentID, kitchenCurrentID, bathroomCurrentID, garbageCurrentID, groceriesCurrentID) VALUES (@one, @two, @three, @four, @five, @six)", con))
            {
                cmd.Parameters.AddWithValue("@one", this.unitID);
                cmd.Parameters.AddWithValue("@two", this.currentID_common);
                cmd.Parameters.AddWithValue("@three", this.currentID_kitchen);
                cmd.Parameters.AddWithValue("@four", this.currentID_bathroom);
                cmd.Parameters.AddWithValue("@five", this.currentID_garbage);
                cmd.Parameters.AddWithValue("@six", this.currentID_groceries);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }

        public void AddToDatabase(string uID, string commonID, string kitchenID, string bathID, string garbID, string grocerID)
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"INSERT INTO SchedulerOrder (unitID, cmCurrentID, kitchenCurrentID, bathroomCurrentID, garbageCurrentID, groceriesCurrentID) VALUES (@one, @two, @three, @four, @five, @six)", con))
            {
                cmd.Parameters.AddWithValue("@one", uID);
                cmd.Parameters.AddWithValue("@two", commonID);
                cmd.Parameters.AddWithValue("@three", kitchenID);
                cmd.Parameters.AddWithValue("@four", bathID);
                cmd.Parameters.AddWithValue("@five", garbID);
                cmd.Parameters.AddWithValue("@six", grocerID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }

        private User GetNextUser(EventType type)
        {
            User returnUser = null;
            if (unit.Tenants().Count > 0)
            {
                List<User> users = unit.Tenants();
                int index = -1;
                switch (type)
                {
                    case EventType.CommonRoom:
                        index = users.IndexOf(new User(CurrentIDCommon));
                        break;
                    case EventType.Kitchen:
                        index = users.IndexOf(new User(CurrentIDKitchen));
                        break;
                    case EventType.Garbage:
                        index = users.IndexOf(new User(CurrentIDGarbage));
                        break;
                    case EventType.Groceries:
                        index = users.IndexOf(new User(CurrentIDGroceries));
                        break;
                    case EventType.Bathroom:
                        index = users.IndexOf(new User(CurrentIDBathroom));
                        break;
                }
                if (index >= 0)
                {
                    if (index == users.Count - 1) returnUser = users[0];
                    else returnUser = users[++index];
                }
            }
            return returnUser;
        }

        private void UpdateToDB(EventType type, User targetUser)
        {
            /*switch (type)
            {
                case EventType.CommonRoom:
                    index = users.IndexOf(new User(CurrentIDCommon));
                    break;
                case EventType.Kitchen:
                    index = users.IndexOf(new User(CurrentIDKitchen));
                    break;
                case EventType.Garbage:
                    index = users.IndexOf(new User(CurrentIDGarbage));
                    break;
                case EventType.Groceries:
                    index = users.IndexOf(new User(CurrentIDGroceries));
                    break;
                case EventType.Bathroom:
                    index = users.IndexOf(new User(CurrentIDBathroom));
                    break;
            }
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"UPDATE SchedulerOrder SET Password=@password WHERE userID=@userID", con))
            {
                cmd.Parameters.AddWithValue("@password", this.password);
                cmd.Parameters.AddWithValue("@userID", this.userID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();*/
        }
    }
}

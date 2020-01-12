using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdvancedProject1._0
{
    class User
    {
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private string userID;
        private int houseID;
        private bool userAdmin;
        
        public User(string user, string pass, string fname, string lname, bool isAdmin)
        {
            this.username = user;
            this.password = pass;
            this.firstName = fname;
            this.lastName = lname;
            this.houseID = 0;
            this.userAdmin = isAdmin;

            //Creating and opening SQL Connection to database
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dataReader;
            con.Open();

            //Checking if generated userID already exists in database
            do
            {
                this.userID = GenerateUserID();
                cmd = new SqlCommand($"SELECT userID FROM Users WHERE userID=@user", con);
                cmd.Parameters.AddWithValue("@user", this.userID);
                dataReader = cmd.ExecuteReader();
            }
            while (dataReader.Read());
            con.Close();
        }
        public User(string userIdentifier)
        {
            //Creating & opening SQL Connection to database
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;

            cmd = new SqlCommand($"SELECT username, password, firstName, lastName, houseID, isAdmin FROM Users WHERE userID=@user", con);
            cmd.Parameters.AddWithValue("@user", userIdentifier);
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                this.username = dataReader.GetString(0);
                this.password = dataReader.GetString(1);
                this.firstName = dataReader.GetString(2);
                this.lastName = dataReader.GetString(3);
                this.houseID = dataReader.GetInt32(4);
                this.userAdmin = dataReader.GetBoolean(5);
                this.userID = userIdentifier;
            }
            con.Close();
        }

        private string GenerateUserID()
        {
            Guid key = Guid.NewGuid();
            string GuidString = Convert.ToBase64String(key.ToByteArray());
            GuidString = GuidString.Replace("=", "");
            GuidString = GuidString.Replace("+", "");
            GuidString = GuidString.Replace("/", "");

            return GuidString;
        }

        public void SetUsername(string newUsername)
        {
            this.username = newUsername;

            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"UPDATE Users SET Username=@username WHERE userID=@userID", con))
            {
                cmd.Parameters.AddWithValue("@username", this.username);
                cmd.Parameters.AddWithValue("@userID", this.userID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }

        public void SetPassword(string newPassword)
        {
            this.password = newPassword;

            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"UPDATE Users SET Password=@password WHERE userID=@userID", con))
            {
                cmd.Parameters.AddWithValue("@password", this.password);
                cmd.Parameters.AddWithValue("@userID", this.userID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }

        public void SetHouseID(int newHouseID)
        {
            this.houseID = newHouseID;

            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"UPDATE Users SET houseID=@houseID WHERE userID=@userID", con))
            {
                cmd.Parameters.AddWithValue("@houseID", this.houseID);
                cmd.Parameters.AddWithValue("@userID", this.userID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }

        public int GetHouseID()
        {
            return this.houseID;
        }

        private void SetUserID(string newUserID)
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"UPDATE Users SET userID=@newUserID WHERE userID=@oldUserID", con))
            {
                cmd.Parameters.AddWithValue("@newUserID", newUserID);
                cmd.Parameters.AddWithValue("@oldUserid", this.userID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();

            this.userID = newUserID;
        }

        public string GetUsername()
        {
            return this.username;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public string GetName()
        {
            return $"{this.firstName} {this.lastName}";
        }

        public string GetUserID()
        {
            return this.userID;
        }

        public bool IsUserAdmin()
        {
            return this.userAdmin;
        }

        public User GetUser(string userIdentifier)
        {
            //Creating & opening SQL Connection to database
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;

            cmd = new SqlCommand($"SELECT username, password, firstName, lastName, houseID, isAdmin FROM Users WHERE userID=@user", con);
            cmd.Parameters.AddWithValue("@user", userIdentifier);
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                User newUser = new User(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetBoolean(5));
                newUser.SetHouseID(dataReader.GetInt32(4));
                newUser.SetUserID(userIdentifier);
                con.Close();
                return newUser;
            }
            con.Close();
            return null;
        }

        public void InsertToDatabase()
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"INSERT INTO Users (username, password, firstName, lastName, houseID, userID, isAdmin) VALUES (@user, @pass, @fname, @lname, @hnum, @sID, @Access)", con))
            {
                cmd.Parameters.AddWithValue("@user", this.username);
                cmd.Parameters.AddWithValue("@pass", this.password);
                cmd.Parameters.AddWithValue("@fname", this.firstName);
                cmd.Parameters.AddWithValue("@lname", this.lastName);
                cmd.Parameters.AddWithValue("@hnum", this.houseID);
                cmd.Parameters.AddWithValue("@sID", this.userID);
                cmd.Parameters.AddWithValue("@Access", this.userAdmin);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            } 
            con.Close();
        }

        public void RemoveFromDatabase()
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"DELETE Users WHERE userID=@userID", con))
            {
                cmd.Parameters.AddWithValue("@userid", this.userID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }
    }
}

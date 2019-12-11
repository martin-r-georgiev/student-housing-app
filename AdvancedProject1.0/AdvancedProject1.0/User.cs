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
        
        public User(string user, string pass, string fname, string lname)
        {
            this.username = user;
            this.password = pass;
            this.firstName = fname;
            this.lastName = lname;
            this.houseID = 0;

            Guid key = Guid.NewGuid();
            string GuidString = Convert.ToBase64String(key.ToByteArray());
            GuidString = GuidString.Replace("=", "");
            GuidString = GuidString.Replace("+", "");
            GuidString = GuidString.Replace("/", "");

            this.userID = GuidString;
        }
        public User(string userIdentifier)
        {
            //Creating & opening SQL Connection to database
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;

            cmd = new SqlCommand($"SELECT username, password, firstName, lastName, houseID FROM Users WHERE userID=@user", con);
            cmd.Parameters.AddWithValue("@user", userIdentifier);
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                this.username = dataReader.GetString(0);
                this.password = dataReader.GetString(1);
                this.firstName = dataReader.GetString(2);
                this.lastName = dataReader.GetString(3);
                this.houseID = dataReader.GetInt32(4);
                this.userID = userIdentifier;
            }
            con.Close();
        }

        public void SetUsername(string newUsername)
        {
            this.username = newUsername;
        }

        public void SetPassword(string newPassword)
        {
            this.password = newPassword;
        }

        public void SetHouseID(int newHouseID)
        {
            this.houseID = newHouseID;
        }

        private void SetUserID(string newUserID)
        {
            this.userID = newUserID;
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

        public User GetUser(string userIdentifier)
        {
            //Creating & opening SQL Connection to database
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;

            cmd = new SqlCommand($"SELECT username, password, firstName, lastName, houseID FROM Users WHERE userID=@user", con);
            cmd.Parameters.AddWithValue("@user", userIdentifier);
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                User newUser = new User(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3));
                newUser.SetHouseID(dataReader.GetInt32(4));
                newUser.SetUserID(userIdentifier);
                con.Close();
                return newUser;
            }
            con.Close();
            return null;
        }

        public void InsertToDB(bool isAdmin)
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
                cmd.Parameters.AddWithValue("@Access", isAdmin);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            } 
            con.Close();
        }

        public void UpdateInDB()
        {
            //Method to update User information in database
            //|!| Work in progress -> To be implemented
        }

        public void RemoveFromDB()
        {
            //Method to remove user information from database
            //|!| Work in progress -> To be implemented
        }
    }
}

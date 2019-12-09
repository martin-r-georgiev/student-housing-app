using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdvancedProject1._0
{
    class User
    {
        private int studentNum;
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private int houseNum;
        private string studentID;

        public User(int num, string user, string pass, string fname, string lname, int houseNr)
        {
            this.studentNum = num;
            this.username = user;
            this.password = pass;
            this.firstName = fname;
            this.lastName = lname;
            this.houseNum = houseNr;
            string student_id = $"{houseNr}_{num}_{fname}_{lname}";
            this.studentID = student_id;
        }

        public void LoadFromDB(string userID)
        {

        }

        public void AddToDB()
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Environment.CurrentDirectory}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();

            using (SqlCommand cmd = new SqlCommand($"INSERT INTO Users (username, password, firstName, lastName, houseID, studentID)" +
            $" values (@user, @pass, @fname, @lname, @hnum, @sID)", con))
            {
                cmd.Parameters.AddWithValue("@user", this.username);
                cmd.Parameters.AddWithValue("@pass", this.password);
                cmd.Parameters.AddWithValue("@fname", this.firstName);
                cmd.Parameters.AddWithValue("@lname", this.lastName);
                cmd.Parameters.AddWithValue("@hnum", this.houseNum);
                cmd.Parameters.AddWithValue("@sID", this.studentID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            } 
            con.Close();
        }
    }
}

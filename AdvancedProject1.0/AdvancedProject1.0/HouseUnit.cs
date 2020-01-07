using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AdvancedProject1._0
{
    class HouseUnit
    {
        private int unitID;
        private List<User> tenantList;
        private string address;
        private int people;
        private int capacity;

        public HouseUnit(int newUnitID, string newAddress, int newCapacity)
        {
            //TO DO: Check if UnitID is unique
            this.unitID = newUnitID;
            this.tenantList = new List<User>();
            this.address = newAddress;
            this.capacity = newCapacity;
            this.people = 0;
        }

        public HouseUnit(int unitIdentifier)
        {
            //Creating & opening SQL Connection to database
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            SqlCommand cmd;
            SqlDataReader dataReader;

            con.Open();

            cmd = new SqlCommand($"SELECT unitID, Address, Capacity FROM HUnitTable WHERE unitID=@unitID", con);
            cmd.Parameters.AddWithValue("@unitID", unitIdentifier);
            dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                this.unitID = dataReader.GetInt32(0);
                this.address = dataReader.GetString(1);
                this.capacity = dataReader.GetInt32(2);
            }
            cmd.Dispose();
            dataReader.Close();
            
            cmd = new SqlCommand($"SELECT userID, unitID FROM UnitUserList WHERE unitID=@unitID", con);
            cmd.Parameters.AddWithValue("@unitID", unitIdentifier);
            dataReader = cmd.ExecuteReader();

            this.people = 0;
            this.tenantList = new List<User>();

            while(dataReader.Read())
            {
                User newUser = new User(dataReader.GetString(0));
                tenantList.Add(newUser);
                this.people++;
            }
            con.Close();
        }

        public void SetCapacity(int newCapacity)
        {
            if (newCapacity >= this.people) this.capacity = newCapacity;
            else this.capacity = this.people;
        }

        public int GetUnitID()
        {
            return this.unitID;
        }

        public string GetInfo()
        {
            return $"House Unit [{this.unitID}]: {this.people}/{this.capacity}";
        }

        public bool IsAtCapacity()
        {
            if (this.people >= this.capacity) return true;
            else return false;
        }

        public List<User> Tenants()
        {
            return this.tenantList;
        }

        public void AddTenant(User newTenant)
        {
            bool isUnique = true;
            foreach(User tenant in tenantList)
            {
                if(newTenant.GetUserID() == tenant.GetUserID())
                {
                    isUnique = false;
                    break;
                }
            }

            if(isUnique && !IsAtCapacity())
            {
                SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"INSERT INTO UnitUserList (userID, unitID) VALUES (@userID, @unitID)", con))
                {
                    cmd.Parameters.AddWithValue("@userID", newTenant.GetUserID());
                    cmd.Parameters.AddWithValue("@unitID", this.unitID);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                con.Close();

                tenantList.Add(newTenant);
            }
        }

        public void RemoveTenant(string userID)
        {
            bool removedTenant = false;
            int index = 0;
            for(int i = 0; i< tenantList.Count; i++)
            {
                if(tenantList[i].GetUserID() == userID)
                {
                    index = i;
                    removedTenant = true;
                    break;
                }
            }

            if(removedTenant)
            {
                SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"DELETE UnitUserList WHERE userID=@userID", con))
                {
                    cmd.Parameters.AddWithValue("@userid", tenantList[index].GetUserID());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                con.Close();

                tenantList.RemoveAt(index);
                this.people--;
            }
        }

        public void RemoveAt(int index)
        {
            if(index >= 0 && index < tenantList.Count)
            {
                SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"DELETE UnitUserList WHERE userID=@userID", con))
                {
                    cmd.Parameters.AddWithValue("@userid", tenantList[index].GetUserID());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                con.Close();

                tenantList.RemoveAt(index);
                this.people--;
            }        
        }

        public void InsertToDatabase()
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"INSERT INTO HUnitTable (unitID, Address, Capacity) VALUES (@unitID, @address, @capacity)", con))
            {
                cmd.Parameters.AddWithValue("@unitID", this.unitID);
                cmd.Parameters.AddWithValue("@address", this.address);
                cmd.Parameters.AddWithValue("@capacity", this.capacity);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }

        public void RemoveFromDatabase()
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"DELETE HUnitTable WHERE unitID=@unitID", con))
            {
                cmd.Parameters.AddWithValue("@unitid", this.unitID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }

    }
}

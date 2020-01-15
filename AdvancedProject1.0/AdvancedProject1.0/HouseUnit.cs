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
        //Instance variables
        private int unitID;
        private List<User> tenantList;
        private string address;
        private int people;
        private int capacity;

        //Properties
        public int UnitID
        {
            get { return this.unitID; }
        }
        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value >= this.people) this.capacity = value;
                else this.capacity = this.people;
            }
        }
        public List<User> Tenants
        {
            get { return this.tenantList; }
        }

        //Constructors
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
            SqlConnection con = SqlConnectionHandler.GetSqlConnection();
            SqlCommand cmd;
            SqlDataReader dataReader;

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

        //Methods

        public string GetInfo()
        {
            return $"House Unit [{this.unitID}]: {this.people}/{this.capacity}";
        }

        public bool IsAtCapacity()
        {
            if (this.people >= this.capacity) return true;
            else return false;
        }

        public void AddTenant(User newTenant)
        {
            bool isUnique = true;
            foreach(User tenant in tenantList)
            {
                if(newTenant.UserID == tenant.UserID)
                {
                    isUnique = false;
                    break;
                }
            }

            if(isUnique && !IsAtCapacity())
            {
                SqlConnection con = SqlConnectionHandler.GetSqlConnection();
                using (SqlCommand cmd = new SqlCommand($"INSERT INTO UnitUserList (userID, unitID) VALUES (@userID, @unitID)", con))
                {
                    cmd.Parameters.AddWithValue("@userID", newTenant.UserID);
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
                if(tenantList[i].UserID == userID)
                {
                    index = i;
                    removedTenant = true;
                    break;
                }
            }

            if(removedTenant)
            {
                SqlConnection con = SqlConnectionHandler.GetSqlConnection();
                using (SqlCommand cmd = new SqlCommand($"DELETE UnitUserList WHERE userID=@userID", con))
                {
                    cmd.Parameters.AddWithValue("@userid", tenantList[index].UserID);
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
                SqlConnection con = SqlConnectionHandler.GetSqlConnection();
                using (SqlCommand cmd = new SqlCommand($"DELETE UnitUserList WHERE userID=@userID", con))
                {
                    cmd.Parameters.AddWithValue("@userid", tenantList[index].UserID);
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
            SqlConnection con = SqlConnectionHandler.GetSqlConnection();
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
            SqlConnection con = SqlConnectionHandler.GetSqlConnection();
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

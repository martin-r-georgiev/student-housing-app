using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.unitID = newUnitID;
            this.address = newAddress;
            this.capacity = newCapacity;
        }

        public void SetCapacity(int newCapacity)
        {
            if (newCapacity >= this.people) this.capacity = newCapacity;
            else this.capacity = this.people;
        }

        public void AddTenant(User newTenant)
        {
            bool isUnique = true, atCapacity = false;
            foreach(User tenant in tenantList)
            {
                if(newTenant.GetUserID() == tenant.GetUserID())
                {
                    isUnique = false;
                    break;
                }
            }

            if (this.people + 1 > this.capacity) atCapacity = true;

            if(isUnique && !atCapacity)
            {
                SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
                con.Open();

                using (SqlCommand cmd = new SqlCommand($"INSERT INTO HUnitTable (userID, Address, People, Capacity, unitID) VALUES (@userID, @people, @address, @capacity, @unitID)", con))
                {
                    cmd.Parameters.AddWithValue("@userID", newTenant.GetUserID());
                    cmd.Parameters.AddWithValue("@address", this.address);
                    cmd.Parameters.AddWithValue("@capacity", this.people);
                    cmd.Parameters.AddWithValue("@capacity", this.capacity);
                    cmd.Parameters.AddWithValue("@unitID", this.unitID);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                con.Close();
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

                using (SqlCommand cmd = new SqlCommand($"DELETE HUnitTable WHERE userID=@userID", con))
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

                using (SqlCommand cmd = new SqlCommand($"DELETE HUnitTable WHERE userID=@userID", con))
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
            //TO BE IMPLEMENTED?
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

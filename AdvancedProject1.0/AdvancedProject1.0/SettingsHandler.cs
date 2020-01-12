using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdvancedProject1._0
{
    class SettingsHandler
    {
        private HouseUnit unit;
        private int _commonValue;
        private int _kitchenValue;
        private int _bathroomValue;

        public int CommonValue
        {
            get { return _commonValue; }
            set { _commonValue = value; }
        }
        public int KitchenValue
        {
            get { return _kitchenValue; }
            set { _kitchenValue = value; }
        }
        public int BathroomValue
        {
            get { return _bathroomValue; }
            set { _bathroomValue = value; }
        }

        public SettingsHandler(HouseUnit newUnit)
        {
            this.unit = newUnit;
            bool newRow = false;

            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Settings WHERE unitID=@Id", con))
            {
                cmd.Parameters.AddWithValue("@Id", newUnit.GetUnitID());
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    this.CommonValue = dataReader.GetInt16(1);
                    this.KitchenValue = dataReader.GetInt16(2);
                    this.BathroomValue = dataReader.GetInt16(3);
                }
                else newRow = true;
                dataReader.Close();
                cmd.Dispose();
            }

            if (newRow)
            {
                using (SqlCommand cmd = new SqlCommand($"INSERT INTO Settings (unitID, commonValue, kitchenValue, bathroomValue) VALUES (@unitID, @commonV, @kitchenV, @bathroomV)", con))
                {
                    cmd.Parameters.AddWithValue("@unitID", newUnit.GetUnitID());
                    cmd.Parameters.AddWithValue("@commonV", 0);
                    cmd.Parameters.AddWithValue("@kitchenV", 0);
                    cmd.Parameters.AddWithValue("@bathroomV", 0);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            con.Close();
        }

        public void SaveSettings()
        {
            SqlConnection con = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
            con.Open();

            using (SqlCommand cmd = new SqlCommand($"UPDATE Settings SET commonValue=@common, kitchenValue=@kitchen, bathroomValue=@bathroom WHERE unitID=@ID", con))
            {
                cmd.Parameters.AddWithValue("@common", this.CommonValue);
                cmd.Parameters.AddWithValue("@kitchen", this.KitchenValue);
                cmd.Parameters.AddWithValue("@bathroom", this.BathroomValue);
                cmd.Parameters.AddWithValue("@ID", this.unit.GetUnitID());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            con.Close();
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdvancedProject1._0
{
    class SqlConnectionHandler
    {
        public static SqlConnection GetSqlConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\\HousingDB.mdf;Integrated Security=True");
                connection.Open();

                return connection;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }
            return null;
        }
    }
}

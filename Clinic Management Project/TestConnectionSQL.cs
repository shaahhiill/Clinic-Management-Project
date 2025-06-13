using System;
using MySql.Data.MySqlClient; // Ensure you have MySql.Data package installed
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project
{
    class TestConnectionSQL
    {
        public static void TestConnection()
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("✅ Connection successful!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Connection failed: " + ex.Message);
                }
            }
        }
    }
}

using Clinic_Management_Project.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem.Data
{
    public class UserDb
    {
        public static bool ValidateLogin(string username, string password)
        {
            var conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int count = System.Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch { return false; }
            finally { conn.Close(); }
        }
    }
}
using Clinic_Management_Project.Models;
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
        private readonly string _connString;
        public UserDb(string connString) => _connString = connString;

        public User ValidateUser(string username, string password)
        {
            using var conn = new MySqlConnection(_connString);
            conn.Open();
            var cmd = new MySqlCommand(
                "SELECT UserId, Username, Role FROM Users WHERE Username = @u AND PasswordHash = @p", conn);
            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", password);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    UserId = reader.GetInt32("UserId"),
                    Username = reader.GetString("Username"),
                    Role = reader.GetString("Role")
                };
            }
            return null;
        }
    }
}
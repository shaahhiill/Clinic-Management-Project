using Clinic_Management_Project.Domain;
using ClinicManagementSystem;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project.Data_DB
{
   public class NotificationDB
    {
        public static bool AddNotification(Notification notification)
        {
            var conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "INSERT INTO notifications (recipient, message, sendDate) VALUES (@recipient, @message, @sendDate)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@recipient", notification.Recipient);
                cmd.Parameters.AddWithValue("@message", notification.Message);
                cmd.Parameters.AddWithValue("@sendDate", notification.SendDate);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static DataTable GetNotifications()
        {
            var conn = DatabaseConnection.GetConnection();
            var dt = new DataTable();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM notifications";
                var adapter = new MySqlDataAdapter(sql, conn);
                adapter.Fill(dt);
            }
            finally { conn.Close(); }
            return dt;
        }
    }
}

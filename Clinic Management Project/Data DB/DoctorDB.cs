using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic_Management_Project.Domain;
using ClinicManagementSystem;
using MySql.Data.MySqlClient;
using System.Data;

namespace Clinic_Management_Project.DB_classes
{
    public class DoctorDB
    {
        public static bool AddDoctor(Doctor doctor)
        {
            var conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "INSERT INTO doctors (name, specialty, schedule) VALUES (@name, @specialty, @schedule)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", doctor.Name);
                cmd.Parameters.AddWithValue("@specialty", doctor.Specialization);
                cmd.Parameters.AddWithValue("@schedule", doctor.Schedule);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static DataTable GetDoctors()
        {
            var conn = DatabaseConnection.GetConnection();
            var dt = new DataTable();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM doctors";
                var adapter = new MySqlDataAdapter(sql, conn);
                adapter.Fill(dt);
            }
            finally { conn.Close(); }
            return dt;
        }

        public static bool UpdateDoctor(Doctor doctor)
        {
            var conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = @"UPDATE doctors SET schedule = @schedule WHERE doctorID = @doctorID";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@schedule", doctor.Schedule);
                cmd.Parameters.AddWithValue("@doctorID", doctor.DoctorID);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
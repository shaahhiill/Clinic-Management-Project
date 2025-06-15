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
    public class AppointmentDB
    {
        public static bool AddAppointment(Appointment appointment)
        {
            var conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = @"INSERT INTO appointments (patient_id, doctor_id, appointment_date, status)
                               VALUES (@patient_id, @doctor_id, @date, @status)";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@patient_id", appointment.PatientID);
                cmd.Parameters.AddWithValue("@doctor_id", appointment.DoctorID);
                cmd.Parameters.AddWithValue("@date", appointment.DateTime);
                cmd.Parameters.AddWithValue("@status", appointment.Status);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static bool UpdateAppointment(Appointment appointment)
        {
            var conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = @"UPDATE appointments SET patient_id=@patient_id, doctor_id=@doctor_id,
                               appointment_date=@date, status=@status WHERE id=@id";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", appointment.AppointmentID);
                cmd.Parameters.AddWithValue("@patient_id", appointment.PatientID);
                cmd.Parameters.AddWithValue("@doctor_id", appointment.DoctorID);
                cmd.Parameters.AddWithValue("@date", appointment.DateTime);
                cmd.Parameters.AddWithValue("@status", appointment.Status);
                ;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static bool DeleteAppointment(int id)
        {
            var conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "DELETE FROM appointments WHERE id=@id";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { conn.Close(); }
        }

        public static DataTable GetAppointments()
        {
            var conn = DatabaseConnection.GetConnection();
            var dt = new DataTable();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM appointments";
                var adapter = new MySqlDataAdapter(sql, conn);
                adapter.Fill(dt);
            }
            finally { conn.Close(); }
            return dt;
        }
    }
}

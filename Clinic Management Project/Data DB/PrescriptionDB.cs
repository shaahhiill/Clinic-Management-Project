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
    public class PrescriptionDB
    {
       
            public static bool AddPrescription(Prescription prescription)
            {
                var conn = DatabaseConnection.GetConnection();
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO prescriptions (appointment_id, details, dateIssued) VALUES (@appointment_id, @details, @dateIssued)";
                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@appointment_id", prescription.Appointment.AppointmentID);
                    cmd.Parameters.AddWithValue("@details", prescription.Medication);
                    cmd.Parameters.AddWithValue("@dateIssued", prescription.DateIssued);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch { return false; }
                finally { conn.Close(); }
            }

            public static DataTable GetPrescriptions()
            {
                var conn = DatabaseConnection.GetConnection();
                var dt = new DataTable();
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM prescriptions";
                    var adapter = new MySqlDataAdapter(sql, conn);
                    adapter.Fill(dt);
                }
                finally { conn.Close(); }
                return dt;
            }
        
    }
}

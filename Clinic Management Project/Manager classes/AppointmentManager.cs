using Clinic_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project.Manager_classes
{
    public class AppointmentManager
    {
        private string connStr = DatabaseConfig.ConnectionString;

        public List<Appointment> GetAppointments()
        {
            List<Appointment> list = new List<Appointment>();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Appointments", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Appointment
                    {
                        AppointmentID = (int)reader["AppointmentID"],
                        DateTime = (DateTime)reader["DateTime"],
                        Status = reader["Status"].ToString(),
                        PatientName = reader["PatientName"].ToString(),
                        DoctorID = (int)reader["DoctorID"],
                        NotificationSent = (bool)reader["NotificationSent"]
                    });
                }
            }
            return list;
        }
    }
}

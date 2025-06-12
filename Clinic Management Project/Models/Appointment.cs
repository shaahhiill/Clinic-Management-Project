using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project.Models
{
    public class Appointment
    {
        public int AppointmentID;
        public DateTime DateTime;
        public string Status;
        public string PatientName;
        public int DoctorID;
        public bool NotificationSent;

        // create
        public void Book(string connStr)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Appointments (DateTime, Status, PatientName, DoctorID, NotificationSent) VALUES (@dt, 'Booked', @p, @d, 0)", conn);
                cmd.Parameters.AddWithValue("@dt", DateTime);
                cmd.Parameters.AddWithValue("@p", PatientName);
                cmd.Parameters.AddWithValue("@d", DoctorID);
                cmd.ExecuteNonQuery();
            }
        }

        // delete

        public void Cancel(string connStr)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Appointments SET Status='Canceled' WHERE AppointmentID=@id", conn);
                cmd.Parameters.AddWithValue("@id", AppointmentID);
                cmd.ExecuteNonQuery();
            }
        }

        // update
        public void Reschedule(string connStr, DateTime newTime)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Appointments SET DateTime=@dt WHERE AppointmentID=@id", conn);
                cmd.Parameters.AddWithValue("@dt", newTime);
                cmd.Parameters.AddWithValue("@id", AppointmentID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

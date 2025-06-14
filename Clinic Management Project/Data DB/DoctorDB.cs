using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic_Management_Project.Models;

namespace Clinic_Management_Project.DB_classes
{
    public class DoctorDB
    {
        private string connStr = DatabaseConfig.ConnectionString;

        public bool InsertDoctor(Doctor doctor)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, Password, Role) OUTPUT INSERTED.UserID VALUES (@u, @p, 'Doctor')", conn);
                    cmd.Parameters.AddWithValue("@u", doctor.Username);
                    cmd.Parameters.AddWithValue("@p", doctor.Password);
                    int userId = (int)cmd.ExecuteScalar();

                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Doctors (UserID, Name, Specialization, Schedule) VALUES (@id, @n, @s, @sch)", conn);
                    cmd2.Parameters.AddWithValue("@id", userId);
                    cmd2.Parameters.AddWithValue("@n", doctor.Name);
                    cmd2.Parameters.AddWithValue("@s", doctor.Specialization);
                    cmd2.Parameters.AddWithValue("@sch", doctor.Schedule);
                    cmd2.ExecuteNonQuery();

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateDoctorProfile(int userId, string spec, string schedule)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Doctors SET Specialization=@s, Schedule=@sch WHERE UserID=@id", conn);
                cmd.Parameters.AddWithValue("@s", spec);
                cmd.Parameters.AddWithValue("@sch", schedule);
                cmd.Parameters.AddWithValue("@id", userId);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public Doctor GetDoctor(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT d.Name, d.Specialization, d.Schedule, u.Username FROM Doctors d JOIN Users u ON d.UserID = u.UserID WHERE d.UserID = @id", conn);
                cmd.Parameters.AddWithValue("@id", userId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Doctor
                    {
                        UserID = userId,
                        Username = reader["Username"].ToString(),
                        Name = reader["Name"].ToString(),
                        Specialization = reader["Specialization"].ToString(),
                        Schedule = reader["Schedule"].ToString()
                    };
                }
                return null;
            }
        }

        public List<Doctor> FetchAllDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT d.UserID, d.Name, d.Specialization, d.Schedule, u.Username FROM Doctors d JOIN Users u ON d.UserID = u.UserID", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    doctors.Add(new Doctor
                    {
                        UserID = (int)reader["UserID"],
                        Username = reader["Username"].ToString(),
                        Name = reader["Name"].ToString(),
                        Specialization = reader["Specialization"].ToString(),
                        Schedule = reader["Schedule"].ToString()
                    });
                }
            }
            return doctors;
        }
    }
}
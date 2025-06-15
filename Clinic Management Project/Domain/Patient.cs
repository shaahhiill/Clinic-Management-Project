using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project.Domain
{
    public class Patient : User
    {

        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public string Gender;
        public string ContactNumber;
        public string MedicalHistory; 



        // Method to register patient into the database
        public void RegisterPatient()
        {
            string connectionString = "Server=localhost;Database=ClinicDB;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, ContactNumber, MedicalHistory) " +
                                   "VALUES (@FirstName, @LastName, @DOB, @Gender, @Contact, @History)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@DOB", DateOfBirth);
                        cmd.Parameters.AddWithValue("@Gender", Gender);
                        cmd.Parameters.AddWithValue("@Contact", ContactNumber);
                        cmd.Parameters.AddWithValue("@History", MedicalHistory);

                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Patient registered successfully!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }

}


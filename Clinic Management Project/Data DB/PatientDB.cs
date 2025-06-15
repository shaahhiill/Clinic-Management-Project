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
    public class PatientDB
    {
        public static bool RegisterPatient(Patient patient)
        {
            var conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string query = @"INSERT INTO Patients (FirstName, LastName, DateOfBirth, Gender, ContactNumber, MedicalHistory) 
                                 VALUES (@FirstName, @LastName, @DOB, @Gender, @Contact, @History)";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", patient.FirstName);
                cmd.Parameters.AddWithValue("@LastName", patient.LastName);
                cmd.Parameters.AddWithValue("@DOB", patient.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                cmd.Parameters.AddWithValue("@Contact", patient.ContactNumber);
                cmd.Parameters.AddWithValue("@History", patient.MedicalHistory);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally { conn.Close(); }
        }
    }
}

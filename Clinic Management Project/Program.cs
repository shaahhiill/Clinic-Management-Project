using Clinic_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();

            // Get patient details
            Console.Write("Enter First Name: ");
            p.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            p.LastName = Console.ReadLine();

            Console.Write("Enter Date of Birth (yyyy-mm-dd): ");
            p.DateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Gender: ");
            p.Gender = Console.ReadLine();

            Console.Write("Enter Contact Number: ");
            p.ContactNumber = Console.ReadLine();

            Console.Write("Enter Medical History: ");
            p.MedicalHistory = Console.ReadLine();

            // Register the patient
            p.RegisterPatient();
        }
    }
}

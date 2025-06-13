using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;


namespace Clinic_Management_Project.Models
{
    internal class Prescription
    {
        public string PrescriptionID;
        public string PatientID;
        public string DoctorID;
        public string Medication;
        public string Diagnosis;
        public DateTime DateIssued;

        public Prescription(string prescriptionID, string PatientID, string DoctorID, string Medication, string Diagnosis, DateTime DateIssued)
        {
            PrescriptionID = prescriptionId;
            PatientID = patientId;
            DoctorID = doctorId;
            Medication = medication;
            Dosage = dosage;
            DateIssued = DateTime.Now;
        }
    }
}
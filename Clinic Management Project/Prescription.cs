using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project
{
    internal class Prescription
    {
        public string PrescriptionID;
        public string PatientID;
        public string DoctorID;
        public string Medication;
        public string Dosage;
        public DateTime DateIssued;

        public Prescription(string prescriptionID, string patientID, string doctorID, string medication, string dosage, DateTime dateIssued)
        {
            PrescriptionID = prescriptionID;
            PatientID = patientID;
            DoctorID = doctorID;
            Medication = medication;
            Dosage = dosage;
            DateIssued = dateIssued;
        }
    }
}

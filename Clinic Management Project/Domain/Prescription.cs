using Clinic_Management_Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project.Domain
{
    public class Prescription
    {
        public string PrescriptionID;
        public string PatientID;
        public string DoctorID;
        public string Medication;
        public string Dosage;

        public Appointment Appointment;
        public DateTime DateIssued;
        public Prescription(string prescriptionID, string patientID, string doctorID, string medication, string dosage)
        {
            PrescriptionID = prescriptionID;
            PatientID = patientID;
            DoctorID = doctorID;
            Medication = medication;
            Dosage = dosage;
        }

        public override string ToString()
        {
            return $"Prescription ID: {PrescriptionID}, Patient ID: {PatientID}, Doctor ID: {DoctorID}, Medication: {Medication}, Dosage: {Dosage}";
        }


    }
}

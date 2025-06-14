using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project
{
    internal class Prescription
    {
        private int PrescriptionID;
        private int PatientID;
        private int DoctorID;
        private string Medication;
        private string Dosage;
        
        // COnsttructor with parameters
        public Prescription(int PrescriptionID, int PatientID, int DoctorID, string Medication, string Dosage)
        {
            this.PrescriptionID = PrescriptionID;
            this.PatientID = PatientID;
            this.DoctorID = DoctorID;
            this.Medication = Medication;
            this.Dosage = Dosage;
        }



        // Getters and setters for each property
        public int prescriptionid
        {
            get { return PrescriptionID; }
            set { PrescriptionID = value; }
        }

        public int patientid
        {
            get { return PatientID; }
            set { PatientID = value; }
        }

        public int doctorid
        {
            get { return DoctorID; }
            set { DoctorID = value; }
        }

        public string medication
        {
            get { return Medication; }
            set { Medication = value; }
        }

        public string dosage
        {
            get { return Dosage; }
            set { Dosage = value; }
        }

        public override string ToString()
        {
            return $"Prescription ID: {PrescriptionID}, Patient ID: {PatientID}, Doctor ID: {DoctorID}, Medication: {Medication}, Dosage: {Dosage}";
        }


    }
}

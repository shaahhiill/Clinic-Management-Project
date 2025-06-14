using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project
{
    internal class PrescriptionManager
    {
        private List<Prescription> prescriptions = new List<Prescription>();
        public void AddPrescription(Prescription p)
        {
            prescriptions.Add(p);
        }

        public List<Prescription> GetAll()
        {
            return prescriptions;
        }

        public Prescription GetByID(string id)
        {
            return prescriptions.FirstOrDefault(p => p.PrescriptionID == id);
        }

        public bool EditPrescription(string id, string med, string dosage)
        {
            var p = GetByID(id);
            if (p != null)
            {
                p.Medication = med;
                p.Dosage = dosage;
                return true;
            }
            return false;
        }

        public List<Prescription> GetPrescriptionsByPatient(string patientID)
        {
            return prescriptions.Where(p => p.PatientID == patientID).ToList();
        }



    }
}

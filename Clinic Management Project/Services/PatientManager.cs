using Clinic_Management_Project.Data_DB;
using Clinic_Management_Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project.Services
{
    public class PatientManager
    {
        public bool RegisterPatient(Patient patient)
        {
            return PatientDB.AddPatient(patient);
        }

        public bool RemovePatient(int patientId)
        {
            return PatientDB.DeletePatient(patientId);
        }
    }
}

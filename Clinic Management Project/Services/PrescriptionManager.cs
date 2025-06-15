using Clinic_Management_Project.Data_DB;
using Clinic_Management_Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project
{
    public class PrescriptionManager
    {
        public bool CreatePrescription(Prescription prescription)
        {
            return PrescriptionDB.AddPrescription(prescription);
        }



    }
}

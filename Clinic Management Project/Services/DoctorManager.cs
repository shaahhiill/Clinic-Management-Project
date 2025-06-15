using Clinic_Management_Project.DB_classes;
using Clinic_Management_Project.Domain;
using Clinic_Management_Project.Data_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project
{
    public class DoctorManager
    {
        public bool RegisterDoctor(Doctor doctor)
        {
            return DoctorDB.AddDoctor(doctor);
        }

        public bool UpdateDoctorSchedule(int doctorId, string newSchedule)
        {
            var doctor = new Doctor
            {
                DoctorID = doctorId,
                Schedule = newSchedule
            };
            return DoctorDB.UpdateDoctor(doctor);
        }
    }
}

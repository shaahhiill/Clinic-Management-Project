using Clinic_Management_Project.DB_classes;
using Clinic_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project
{
    public class DoctorManager
    {
        private DoctorDB doctorDB = new DoctorDB();

        public bool RegisterDoctor(Doctor doctor)
        {
            return doctorDB.InsertDoctor(doctor);
        }

        public bool UpdateDoctorProfile(int userId, string newSpec, string newSchedule)
        {
            return doctorDB.UpdateDoctorProfile(userId, newSpec, newSchedule);
        }

        public List<Doctor> GetAllDoctors()
        {
            return doctorDB.FetchAllDoctors();
        }

        public Doctor GetDoctorByUserId(int userId)
        {
            return doctorDB.GetDoctor(userId);
        }
    }
}

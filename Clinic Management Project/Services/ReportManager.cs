using Clinic_Management_Project.Data_DB;
using Clinic_Management_Project.DB_classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project.Services
{
    public class ReportManager
    {
        public DataTable GenerateAppointmentReport()
        {
            return AppointmentDB.GetAppointments();
        }

        public DataTable GenerateDoctorReport()
        {
            return DoctorDB.GetDoctors();
        }
    }
}

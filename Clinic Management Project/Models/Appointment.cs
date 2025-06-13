using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project.Models
{
    public class Appointment
    {
        public int AppointmentID;
        public DateTime DateTime;
        public string Status;
        public string PatientName;
        public int DoctorID;
        public bool NotificationSent;

        
    }
}

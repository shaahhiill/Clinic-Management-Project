using Clinic_Management_Project.Domain;
using Clinic_Management_Project.Data_DB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project.Services
{
    public class AppointmentManager
    {
        public bool BookAppointment(Appointment appointment)
        {
            return AppointmentDB.AddAppointment(appointment);
        }

        public bool CancelAppointment(int appointmentId)
        {
            return AppointmentDB.DeleteAppointment(appointmentId);
        }

        public bool RescheduleAppointment(int appointmentId, DateTime newDate)
        {
            var appointment = new Appointment
            {
                AppointmentID = appointmentId,
                DateTime = newDate
            };
            return AppointmentDB.UpdateAppointment(appointment);
        }
    }
}

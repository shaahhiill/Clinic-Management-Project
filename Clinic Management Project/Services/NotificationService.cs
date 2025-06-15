using Clinic_Management_Project.Data_DB;
using Clinic_Management_Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project.Services
{
    public class NotificationService
    {
        public bool SendNotification(Notification notification)
        {
            return NotificationDB.AddNotification(notification);
        }
    }
}

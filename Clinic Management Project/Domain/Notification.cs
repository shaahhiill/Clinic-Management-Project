using Clinic_Management_Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project.Domain
{
   public class Notification
    {
        public int NotificationID;
        public string Recipient;
        public string Message;
        public DateTime SendDate;

        // linked appointment
        public Appointment Appointment;

        public Notification(int notificationID, string recipient, string message, DateTime sendDate, Appointment appointment)
        {
            NotificationID = notificationID;
            Recipient = recipient;
            Message = message;
            SendDate = sendDate;
            Appointment = appointment;
        }

        public bool Send()
        {
            try
            {
                Console.WriteLine($"Sending notification to {Recipient}: {Message}");
                SendDate = DateTime.Now;
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }
    }
}

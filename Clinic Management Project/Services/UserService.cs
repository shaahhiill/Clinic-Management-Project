using ClinicManagementSystem.Data;
using Clinic_Management_Project.Data_DB;
using Clinic_Management_Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project.Services
{
    public class UserService
    {
        public bool Login(string username, string password)
        {
            return UserDb.ValidateLogin(username, password);
        }
    }
}

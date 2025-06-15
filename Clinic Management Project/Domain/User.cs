using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project.Domain
{
    public abstract class User
    {
        public int UserID;
        public string Username;
        public string Password;
        public string Role;
        public virtual void Login() { }
        public virtual void Logout() { }


    }


}

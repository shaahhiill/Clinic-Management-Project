using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Management_Project
{
    internal class Person
    {
        public int Id;
        public string Name;
        public string ContactNumber;
        public string Gender;
        public Person(int id, string name, string contact, string gender)
        {
            Id = id;
            Name = name;
            ContactNumber = contact;
            Gender = gender;
        }
    }
}

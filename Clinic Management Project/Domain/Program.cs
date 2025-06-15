using Clinic_Management_Project.Domain;
using System;
using System.Windows.Forms;
using Clinic_Management_Project.GUI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagementSystem;

namespace Clinic_Management_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start with LoginForm
            Application.Run(new FormLogin());

            // If you prefer to skip login, comment above line and uncomment below
            // Application.Run(new MainForm());
        }
    }
}

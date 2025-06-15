using Clinic_Management_Project.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_Project.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            // Open the patient management form

            FormPatient form = new FormPatient();
            form.ShowDialog();

            // Optionally, hide the current Menu form
            this.Hide();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            FormDoctor form = new FormDoctor();
            form.ShowDialog();

            // Optionally, hide the current Menu form
            this.Hide();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            FormAppointment form = new FormAppointment();
            form.ShowDialog();

            // Optionally, hide the current Menu form
            this.Hide();
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            FormPrescription form = new FormPrescription();
            form.ShowDialog();

            // Optionally, hide the current Menu form
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            FormReports form = new FormReports();
            form.ShowDialog();

            // Optionally, hide the current Menu form
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

            // Optionally, hide the current Menu form
            this.Hide();
        }
    }
}

using Clinic_Management_Project.GUI;
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
            FormPatient form = new FormPatient();
            form.ShowDialog();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            FormDoctor form = new FormDoctor();
            form.ShowDialog();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            FormAppointment form = new FormAppointment();
            form.ShowDialog();
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            FormPrescription form = new FormPrescription();
            form.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            FormReports form = new FormReports();
            form.ShowDialog();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            FormNotification form = new FormNotification();
            form.ShowDialog();
        }

        private void btnPatientHistory_Click(object sender, EventArgs e)
        {
            FormPatientHistory form = new FormPatientHistory();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

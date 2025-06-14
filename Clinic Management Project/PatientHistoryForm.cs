using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_Project
{
    public partial class PatientHistoryForm: Form
    {
        PrescriptionManager manager = new PrescriptionManager();
        public PatientHistoryForm()
        {
            InitializeComponent();
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            string patientID = txtHistoryPatientID.Text.Trim();
            var history = manager.GetPrescriptionsByPatient(patientID);

            if (history.Count == 0)
            {
                MessageBox.Show("No prescription history found for this patient.");
                dgvPatientHistory.DataSource = null; // clear
                return;
            }

            // Bind the list of prescriptions to DataGridView
            dgvPatientHistory.DataSource = null; // Reset
            dgvPatientHistory.DataSource = history;
        }
    }
}

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
    public partial class PrescriptionForm: Form
    {
        public PrescriptionForm()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                Prescription p = new Prescription(
                    txtPrescriptionID.Text,
                    txtPatientID.Text,
                    txtDoctorID.Text,
                    txtMedication.Text,
                    txtDosage.Text
                );

                manager.AddPrescription(p);
                MessageBox.Show("Prescription Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

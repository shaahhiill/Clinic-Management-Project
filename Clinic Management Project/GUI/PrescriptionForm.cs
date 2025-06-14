using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_Project
{
    public partial class PrescriptionForm: Form
    {
        PrescriptionManager manager = new PrescriptionManager();
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var p in manager.GetAll())
            {
                dataGridView1.Rows.Add(p.PrescriptionID, p.PatientID, p.DoctorID, p.Medication, p.Dosage);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (manager.EditPrescription(txtPrescriptionID.Text, txtMedication.Text, txtDosage.Text))
                MessageBox.Show("Prescription updated successfully.");
            else
                MessageBox.Show("Prescription not found.");
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            var p = manager.GetByID(txtPrescriptionID.Text);
            if (p != null)
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Prescription_{p.PrescriptionID}.txt");
                File.WriteAllText(filePath, p.ToString());
                MessageBox.Show($"Prescription saved to:\n{filePath}");
            }
            else
            {
                MessageBox.Show("Prescription not found.");
            }
        }
    }
}

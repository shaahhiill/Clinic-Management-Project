using ClinicManagementSystem;
using MySql.Data.MySqlClient;
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
    public partial class FormPatientHistory : Form
    {
        public FormPatientHistory()
        {
            InitializeComponent();
            LoadPatients();
        }

        private void LoadPatients()
        {
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "SELECT id, name FROM patients";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbPatient.DataSource = dt;
                cmbPatient.DisplayMember = "name";
                cmbPatient.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            
            {
                conn.Close();
            }
        }


        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a patient.");
                return;
            }

            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = @"
                    SELECT a.id AS appointment_id, a.appointment_date, a.status, p.details AS prescription_details
                    FROM appointments a
                    LEFT JOIN prescriptions p ON a.id = p.appointment_id
                    WHERE a.patient_id = @patient_id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@patient_id", cmbPatient.SelectedValue);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvHistory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbPatient.SelectedIndex = -1;
            dgvHistory.DataSource = null;
        }
    }
}

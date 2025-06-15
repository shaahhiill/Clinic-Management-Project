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
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
            LoadReportTypes();
        }

        private void LoadReportTypes()
        {
            cmbReportType.Items.Add("Appointments");
            cmbReportType.Items.Add("Doctor Schedules");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a report type.");
                return;
            }

            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "";
                if (cmbReportType.SelectedItem.ToString() == "Appointments")
                {
                    sql = @"SELECT a.id, p.name AS patient, d.name AS doctor, a.appointment_date, a.status
                            FROM appointments a
                            JOIN patients p ON a.patient_id = p.id
                            JOIN doctors d ON a.doctor_id = d.id";
                }
                else if (cmbReportType.SelectedItem.ToString() == "Doctor Schedules")
                {
                    sql = "SELECT id, name, specialty, schedule FROM doctors";
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvReports.DataSource = dt;
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
            cmbReportType.SelectedIndex = -1;
            dgvReports.DataSource = null;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementSystem;
using MySql.Data.MySqlClient;

namespace Clinic_Management_Project.GUI
{
    public partial class FormAppointment : Form
    {
        public FormAppointment()
        {
            InitializeComponent();
            LoadAppointments();
            LoadPatients();
            LoadDoctors();
        }

        private void LoadAppointments()
        {
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "SELECT a.id, p.name AS patient, d.name AS doctor, a.appointment_date, a.status " +
                             "FROM appointments a " +
                             "JOIN patients p ON a.patient_id = p.id " +
                             "JOIN doctors d ON a.doctor_id = d.id";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvAppointments.DataSource = dt;
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

        private void LoadDoctors()
        {
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "SELECT id, name FROM doctors";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbDoctor.DataSource = dt;
                cmbDoctor.DisplayMember = "name";
                cmbDoctor.ValueMember = "id";
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

        private void btnBook_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "INSERT INTO appointments (patient_id, doctor_id, appointment_date, status) VALUES (@patient_id, @doctor_id, @date, 'Scheduled')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@patient_id", cmbPatient.SelectedValue);
                cmd.Parameters.AddWithValue("@doctor_id", cmbDoctor.SelectedValue);
                cmd.Parameters.AddWithValue("@date", dtpAppointment.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment booked successfully!");
                LoadAppointments();
                ClearFields();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null) return;

            string id = dgvAppointments.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "UPDATE appointments SET patient_id=@patient_id, doctor_id=@doctor_id, appointment_date=@date WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@patient_id", cmbPatient.SelectedValue);
                cmd.Parameters.AddWithValue("@doctor_id", cmbDoctor.SelectedValue);
                cmd.Parameters.AddWithValue("@date", dtpAppointment.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment updated successfully!");
                LoadAppointments();
                ClearFields();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null) return;

            string id = dgvAppointments.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "UPDATE appointments SET status='Cancelled' WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment cancelled successfully!");
                LoadAppointments();
                ClearFields();
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
            ClearFields();
        }

        private void ClearFields()
        {
            cmbPatient.SelectedIndex = -1;
            cmbDoctor.SelectedIndex = -1;
            dtpAppointment.Value = DateTime.Now;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpApptDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBookAppt_Click(object sender, EventArgs e)
        {

        }

        private void lblApptDateTime_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //nothing here
        }
    }
}

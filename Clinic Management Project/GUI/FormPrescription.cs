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
    public partial class FormPrescription : Form
    {
        public FormPrescription()
        {
            InitializeComponent();
            LoadPrescriptions();
            LoadAppointments();
        }

        private void LoadPrescriptions()
        {
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "SELECT p.id, a.id AS appointment_id, p.details FROM prescriptions p JOIN appointments a ON p.appointment_id = a.id";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvPrescriptions.DataSource = dt;
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

        private void LoadAppointments()
        {
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "SELECT id FROM appointments";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbAppointment.DataSource = dt;
                cmbAppointment.DisplayMember = "id";
                cmbAppointment.ValueMember = "id";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "INSERT INTO prescriptions (appointment_id, details) VALUES (@appointment_id, @details)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@appointment_id", cmbAppointment.SelectedValue);
                cmd.Parameters.AddWithValue("@details", txtDetails.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Prescription added successfully!");
                LoadPrescriptions();
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
            if (dgvPrescriptions.CurrentRow == null) return;

            string id = dgvPrescriptions.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "UPDATE prescriptions SET appointment_id=@appointment_id, details=@details WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@appointment_id", cmbAppointment.SelectedValue);
                cmd.Parameters.AddWithValue("@details", txtDetails.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Prescription updated successfully!");
                LoadPrescriptions();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPrescriptions.CurrentRow == null) return;

            string id = dgvPrescriptions.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "DELETE FROM prescriptions WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Prescription deleted successfully!");
                LoadPrescriptions();
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

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (dgvPrescriptions.CurrentRow == null)
            {
                MessageBox.Show("Please select a prescription to download.");
                return;
            }

            string id = dgvPrescriptions.CurrentRow.Cells["id"].Value.ToString();
            string appointmentId = dgvPrescriptions.CurrentRow.Cells["appointment_id"].Value.ToString();
            string details = dgvPrescriptions.CurrentRow.Cells["details"].Value.ToString();

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                FileName = $"Prescription_{id}.txt"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName,
                    $"Prescription ID: {id}\nAppointment ID: {appointmentId}\nDetails:\n{details}");
                MessageBox.Show("Prescription downloaded successfully!");
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            cmbAppointment.SelectedIndex = -1;
            txtDetails.Clear();
            if (dgvPrescriptions.CurrentRow != null)
            {
                dgvPrescriptions.ClearSelection();
            }
        }
    }
}

    
     

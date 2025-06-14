using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementSystem;

namespace Clinic_Management_Project.GUI
{
    public partial class FormPatient : Form
    {
        public FormPatient()
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
                string sql = "SELECT id, name, date_of_birth, gender, address, phone FROM patients";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvPatients.DataSource = dt;
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DatabaseConnection.GetConnection();

            try
            {
                conn.Open();
                string sql = "INSERT INTO patients (name, date_of_birth, gender, address, phone) VALUES (@name, @dob, @gender, @address, @phone)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient added successfully!");
                LoadPatients();
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
            if (dgvPatients.CurrentRow == null) return;

            string id = dgvPatients.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection conn = DatabaseConnection.GetConnection();

            try
            {
                conn.Open();
                string sql = "UPDATE patients SET name=@name, date_of_birth=@dob, gender=@gender, address=@address, phone=@phone WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient updated successfully!");
                LoadPatients();
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
            if (dgvPatients.CurrentRow == null) return;

            string id = dgvPatients.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection conn = DatabaseConnection.GetConnection();

            try
            {
                conn.Open();
                string sql = "DELETE FROM patients WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient deleted successfully!");
                LoadPatients();
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
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            cmbGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Today;
        }
    }
}

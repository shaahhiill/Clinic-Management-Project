using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementSystem;
using MySql.Data.MySqlClient;

namespace Clinic_Management_Project.GUI
{
    public partial class FormDoctor : Form
    {
        public FormDoctor()
        {
            InitializeComponent();
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "SELECT id, name, specialty, schedule FROM doctors";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDoctors.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "INSERT INTO doctors (name, specialty, schedule) VALUES (@name, @specialty, @schedule)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@specialty", txtSpecialty.Text);
                cmd.Parameters.AddWithValue("@schedule", txtSchedule.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor added successfully!");
                LoadDoctors();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow == null) return;
            string id = dgvDoctors.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "UPDATE doctors SET name=@name, specialty=@specialty, schedule=@schedule WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@specialty", txtSpecialty.Text);
                cmd.Parameters.AddWithValue("@schedule", txtSchedule.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor updated successfully!");
                LoadDoctors();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow == null) return;
            string id = dgvDoctors.CurrentRow.Cells[0].Value.ToString();
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "DELETE FROM doctors WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor deleted successfully!");
                LoadDoctors();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtSpecialty.Clear();
            txtSchedule.Clear();
        }
    }
}
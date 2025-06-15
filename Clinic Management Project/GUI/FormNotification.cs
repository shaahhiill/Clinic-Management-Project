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
    public partial class FormNotification : Form
    {
        public FormNotification()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRecipient.Text) || string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Please enter recipient and message.");
                return;
            }

            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "INSERT INTO notifications (recipient, message, sendDate) VALUES (@recipient, @message, @sendDate)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@recipient", txtRecipient.Text);
                cmd.Parameters.AddWithValue("@message", txtMessage.Text);
                cmd.Parameters.AddWithValue("@sendDate", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Notification sent and logged successfully!");
                LoadNotifications();
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
            txtRecipient.Clear();
            txtMessage.Clear();
        }

        private void LoadNotifications()
        {
            MySqlConnection conn = DatabaseConnection.GetConnection();
            try
            {
                conn.Open();
                string sql = "SELECT id, recipient, message, sendDate FROM notifications";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                var dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvNotifications.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notifications: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

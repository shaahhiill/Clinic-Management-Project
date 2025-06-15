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

        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (dgvReports.Rows.Count == 0)
            {
                MessageBox.Show("No report data to email.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                FileName = $"Report_{DateTime.Now:yyyyMMddHHmmss}.csv"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Export to CSV (comma seperated values)
                using (var writer = new System.IO.StreamWriter(sfd.FileName))
                {
                    // Write headers
                    for (int i = 0; i < dgvReports.Columns.Count; i++)
                    {
                        writer.Write(dgvReports.Columns[i].HeaderText);
                        if (i < dgvReports.Columns.Count - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();

                    // Write data
                    foreach (DataGridViewRow row in dgvReports.Rows)
                    {
                        for (int i = 0; i < dgvReports.Columns.Count; i++)
                        {
                            writer.Write(row.Cells[i].Value?.ToString());
                            if (i < dgvReports.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }

                // Send email 
                try
                {
                    var mail = new System.Net.Mail.MailMessage();
                    mail.From = new System.Net.Mail.MailAddress("youremail@example.com");
                    mail.To.Add("recipient@example.com");
                    mail.Subject = "Clinic Report";
                    mail.Body = "Please find the attached report.";
                    mail.Attachments.Add(new System.Net.Mail.Attachment(sfd.FileName));

                    var smtp = new System.Net.Mail.SmtpClient("smtp.yourprovider.com")
                    {
                        Port = 587,
                        Credentials = new System.Net.NetworkCredential("youremail@example.com", "yourpassword"),
                        EnableSsl = true
                    };

                    smtp.Send(mail);
                    MessageBox.Show("Report emailed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending email: " + ex.Message);
                }
            }
        }
    }
}

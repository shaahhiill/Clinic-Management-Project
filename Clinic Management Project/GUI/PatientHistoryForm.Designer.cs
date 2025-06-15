using System.Windows.Forms;

namespace Clinic_Management_Project
{
    public partial class PatientHistoryForm : Form
    {
        public PatientHistoryForm()
        {
            InitializeComponent();
        }
        private void btnViewHistory_Click(object sender, System.EventArgs e)
        {
            // Logic to fetch and display patient history based on the provided Patient ID
            string patientId = txtHistoryPatientID.Text;
            if (!string.IsNullOrEmpty(patientId))
            {
                // Fetch history from database and bind to dgvPatientHistory
                // Example: dgvPatientHistory.DataSource = GetPatientHistory(patientId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Patient ID.");
            }
        }
    }
}

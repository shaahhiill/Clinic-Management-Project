namespace Clinic_Management_Project.GUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnPrescription;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Button btnPatientHistory;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnPrescription = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnPatientHistory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPatient
            // 
            this.btnPatient.Location = new System.Drawing.Point(50, 35);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(182, 36);
            this.btnPatient.TabIndex = 0;
            this.btnPatient.Text = "Manage Patients";
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.Location = new System.Drawing.Point(50, 77);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(182, 32);
            this.btnDoctor.TabIndex = 1;
            this.btnDoctor.Text = "Manage Doctors";
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Location = new System.Drawing.Point(50, 115);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(182, 34);
            this.btnAppointment.TabIndex = 2;
            this.btnAppointment.Text = "Manage Appointments";
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnPrescription
            // 
            this.btnPrescription.Location = new System.Drawing.Point(50, 155);
            this.btnPrescription.Name = "btnPrescription";
            this.btnPrescription.Size = new System.Drawing.Size(182, 34);
            this.btnPrescription.TabIndex = 3;
            this.btnPrescription.Text = "Manage Prescriptions";
            this.btnPrescription.Click += new System.EventHandler(this.btnPrescription_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(50, 195);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(182, 34);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "View Reports";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.Location = new System.Drawing.Point(50, 235);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(182, 34);
            this.btnNotification.TabIndex = 5;
            this.btnNotification.Text = "Manage Notifications";
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // btnPatientHistory
            // 
            this.btnPatientHistory.Location = new System.Drawing.Point(50, 275);
            this.btnPatientHistory.Name = "btnPatientHistory";
            this.btnPatientHistory.Size = new System.Drawing.Size(182, 34);
            this.btnPatientHistory.TabIndex = 6;
            this.btnPatientHistory.Text = "View Patient History";
            this.btnPatientHistory.Click += new System.EventHandler(this.btnPatientHistory_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(50, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(182, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.btnPatient);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnAppointment);
            this.Controls.Add(this.btnPrescription);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnNotification);
            this.Controls.Add(this.btnPatientHistory);
            this.Controls.Add(this.btnExit);
            this.Name = "MainForm";
            this.Text = "Clinic Management - Main";
            this.ResumeLayout(false);

        }
    }
}
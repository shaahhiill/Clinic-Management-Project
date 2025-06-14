namespace Clinic_Management_Project.GUI
{
    partial class FormAppointment
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.DateTimePicker dtpAppointment;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvAppointments;

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
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.dtpAppointment = new System.Windows.Forms.DateTimePicker();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();

            this.lblPatient.Text = "Patient";
            this.lblPatient.Location = new System.Drawing.Point(30, 30);
            this.cmbPatient.Location = new System.Drawing.Point(120, 30);
            this.cmbPatient.Size = new System.Drawing.Size(200, 23);

            this.lblDoctor.Text = "Doctor";
            this.lblDoctor.Location = new System.Drawing.Point(30, 70);
            this.cmbDoctor.Location = new System.Drawing.Point(120, 70);
            this.cmbDoctor.Size = new System.Drawing.Size(200, 23);

            this.lblDate.Text = "Date/Time";
            this.lblDate.Location = new System.Drawing.Point(30, 110);
            this.dtpAppointment.Location = new System.Drawing.Point(120, 110);
            this.dtpAppointment.Size = new System.Drawing.Size(200, 23);

            this.btnBook.Text = "Book";
            this.btnBook.Location = new System.Drawing.Point(30, 150);
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);

            this.btnEdit.Text = "Edit";
            this.btnEdit.Location = new System.Drawing.Point(110, 150);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(190, 150);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(270, 150);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.dgvAppointments.Location = new System.Drawing.Point(30, 190);
            this.dgvAppointments.Size = new System.Drawing.Size(500, 200);

            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpAppointment);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvAppointments);
            this.Text = "Appointment Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
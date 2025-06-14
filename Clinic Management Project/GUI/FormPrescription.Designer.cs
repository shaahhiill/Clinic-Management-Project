namespace Clinic_Management_Project.GUI
{
    partial class FormPrescription
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAppointment;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.ComboBox cmbAppointment;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvPrescriptions;

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
            this.lblAppointment = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.cmbAppointment = new System.Windows.Forms.ComboBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvPrescriptions = new System.Windows.Forms.DataGridView();
            this.btnDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppointment
            // 
            this.lblAppointment.Location = new System.Drawing.Point(30, 30);
            this.lblAppointment.Name = "lblAppointment";
            this.lblAppointment.Size = new System.Drawing.Size(100, 23);
            this.lblAppointment.TabIndex = 0;
            this.lblAppointment.Text = "Appointment";
            // 
            // lblDetails
            // 
            this.lblDetails.Location = new System.Drawing.Point(30, 70);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(100, 23);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "Details";
            // 
            // cmbAppointment
            // 
            this.cmbAppointment.Location = new System.Drawing.Point(120, 30);
            this.cmbAppointment.Name = "cmbAppointment";
            this.cmbAppointment.Size = new System.Drawing.Size(200, 28);
            this.cmbAppointment.TabIndex = 1;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(120, 70);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(300, 60);
            this.txtDetails.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(110, 150);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(190, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(270, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvPrescriptions
            // 
            this.dgvPrescriptions.ColumnHeadersHeight = 34;
            this.dgvPrescriptions.Location = new System.Drawing.Point(30, 190);
            this.dgvPrescriptions.Name = "dgvPrescriptions";
            this.dgvPrescriptions.RowHeadersWidth = 62;
            this.dgvPrescriptions.Size = new System.Drawing.Size(500, 200);
            this.dgvPrescriptions.TabIndex = 8;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(350, 150);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // FormPrescription
            // 
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblAppointment);
            this.Controls.Add(this.cmbAppointment);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvPrescriptions);
            this.Name = "FormPrescription";
            this.Text = "Prescription Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnDownload;
    }
}
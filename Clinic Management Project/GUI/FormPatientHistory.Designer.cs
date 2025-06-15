namespace Clinic_Management_Project.GUI
{
    partial class FormPatientHistory
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvHistory;

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
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvHistory = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();

            this.lblPatient.Text = "Patient";
            this.lblPatient.Location = new System.Drawing.Point(30, 30);
            this.cmbPatient.Location = new System.Drawing.Point(120, 30);
            this.cmbPatient.Size = new System.Drawing.Size(200, 23);

            this.btnViewHistory.Text = "View History";
            this.btnViewHistory.Location = new System.Drawing.Point(30, 70);
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(150, 70);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.dgvHistory.Location = new System.Drawing.Point(30, 110);
            this.dgvHistory.Size = new System.Drawing.Size(500, 250);

            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvHistory);
            this.Text = "Patient History";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
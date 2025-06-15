namespace Clinic_Management_Project.GUI
{
    partial class FormReports
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvReports;

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
            this.lblReportType = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();

            this.lblReportType.Text = "Report Type";
            this.lblReportType.Location = new System.Drawing.Point(30, 30);
            this.cmbReportType.Location = new System.Drawing.Point(120, 30);
            this.cmbReportType.Size = new System.Drawing.Size(200, 23);

            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Location = new System.Drawing.Point(30, 70);
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(150, 70);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.dgvReports.Location = new System.Drawing.Point(30, 110);
            this.dgvReports.Size = new System.Drawing.Size(500, 250);

            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.cmbReportType);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvReports);
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
using System.Windows.Forms;

namespace Clinic_Management_Project.GUI
{
    public partial class FormDoctor : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.TextBox txtSchedule;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvDoctors;

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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.txtSchedule = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.SuspendLayout();

            this.lblName.Text = "Name";
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.txtName.Location = new System.Drawing.Point(120, 30);
            this.txtName.Size = new System.Drawing.Size(200, 23);

            this.lblSpecialty.Text = "Specialty";
            this.lblSpecialty.Location = new System.Drawing.Point(30, 70);
            this.txtSpecialty.Location = new System.Drawing.Point(120, 70);
            this.txtSpecialty.Size = new System.Drawing.Size(200, 23);

            this.lblSchedule.Text = "Schedule";
            this.lblSchedule.Location = new System.Drawing.Point(30, 110);
            this.txtSchedule.Location = new System.Drawing.Point(120, 110);
            this.txtSchedule.Size = new System.Drawing.Size(200, 23);

            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(30, 150);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnEdit.Text = "Edit";
            this.btnEdit.Location = new System.Drawing.Point(110, 150);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(190, 150);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(270, 150);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.dgvDoctors.Location = new System.Drawing.Point(30, 190);
            this.dgvDoctors.Size = new System.Drawing.Size(400, 200);

            this.ClientSize = new System.Drawing.Size(480, 420);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSpecialty);
            this.Controls.Add(this.txtSpecialty);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.txtSchedule);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvDoctors);
            this.Text = "Doctor Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
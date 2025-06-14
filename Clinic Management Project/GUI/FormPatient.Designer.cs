namespace Clinic_Management_Project.GUI
{
    partial class FormPatient
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblName, lblDOB, lblGender, lblAddress, lblPhone;
        private System.Windows.Forms.TextBox txtName, txtAddress, txtPhone;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnSave, btnNew, btnEdit, btnDelete, btnClear;
        private System.Windows.Forms.DataGridView dgvPatients;

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
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvPatients = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();

            // lblName
            this.lblName.Text = "Name";
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Size = new System.Drawing.Size(100, 23);

            // txtName
            this.txtName.Location = new System.Drawing.Point(140, 30);
            this.txtName.Size = new System.Drawing.Size(200, 23);

            // lblDOB
            this.lblDOB.Text = "Date of Birth";
            this.lblDOB.Location = new System.Drawing.Point(30, 70);
            this.lblDOB.Size = new System.Drawing.Size(100, 23);

            // dtpDOB
            this.dtpDOB.Location = new System.Drawing.Point(140, 70);
            this.dtpDOB.Size = new System.Drawing.Size(200, 23);

            // lblGender
            this.lblGender.Text = "Gender";
            this.lblGender.Location = new System.Drawing.Point(30, 110);
            this.lblGender.Size = new System.Drawing.Size(100, 23);

            // cmbGender
            this.cmbGender.Location = new System.Drawing.Point(140, 110);
            this.cmbGender.Size = new System.Drawing.Size(200, 23);
            this.cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });

            // lblAddress
            this.lblAddress.Text = "Address";
            this.lblAddress.Location = new System.Drawing.Point(30, 150);
            this.lblAddress.Size = new System.Drawing.Size(100, 23);

            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(140, 150);
            this.txtAddress.Size = new System.Drawing.Size(200, 23);

            // lblPhone
            this.lblPhone.Text = "Phone";
            this.lblPhone.Location = new System.Drawing.Point(30, 190);
            this.lblPhone.Size = new System.Drawing.Size(100, 23);

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(140, 190);
            this.txtPhone.Size = new System.Drawing.Size(200, 23);

            // btnSave
            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(30, 230);
           // this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnNew
            this.btnNew.Text = "New";
            this.btnNew.Location = new System.Drawing.Point(110, 230);
           // this.btnNew.Click += new System.EventHandler(this.btnNew_Click);

            // btnEdit
            this.btnEdit.Text = "Edit";
            this.btnEdit.Location = new System.Drawing.Point(190, 230);
           // this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnDelete
            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(270, 230);
           // this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(350, 230);
            //this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // dgvPatients
            this.dgvPatients.Location = new System.Drawing.Point(30, 270);
            this.dgvPatients.Size = new System.Drawing.Size(500, 150);

            // Form
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvPatients);
            this.Text = "Patient Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
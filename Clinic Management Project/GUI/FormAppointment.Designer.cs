namespace Clinic_Management_Project.GUI
{
    partial class FormAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblSelectDoctor = new System.Windows.Forms.Label();
            this.LblApptDateTime = new System.Windows.Forms.Label();
            this.CboDoctors = new System.Windows.Forms.ComboBox();
            this.DtpApptDateTime = new System.Windows.Forms.DateTimePicker();
            this.BtnBookAppt = new System.Windows.Forms.Button();
            this.dgvAppointments = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCancelAppt = new System.Windows.Forms.Button();
            this.BtnRescheduleAppt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.dgvAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBookAppt);
            this.groupBox1.Controls.Add(this.DtpApptDateTime);
            this.groupBox1.Controls.Add(this.CboDoctors);
            this.groupBox1.Controls.Add(this.LblApptDateTime);
            this.groupBox1.Controls.Add(this.LblSelectDoctor);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Appointment";
            // 
            // LblSelectDoctor
            // 
            this.LblSelectDoctor.AutoSize = true;
            this.LblSelectDoctor.Location = new System.Drawing.Point(18, 37);
            this.LblSelectDoctor.Name = "LblSelectDoctor";
            this.LblSelectDoctor.Size = new System.Drawing.Size(57, 20);
            this.LblSelectDoctor.TabIndex = 0;
            this.LblSelectDoctor.Text = "Doctor";
            this.LblSelectDoctor.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblApptDateTime
            // 
            this.LblApptDateTime.AutoSize = true;
            this.LblApptDateTime.Location = new System.Drawing.Point(18, 87);
            this.LblApptDateTime.Name = "LblApptDateTime";
            this.LblApptDateTime.Size = new System.Drawing.Size(86, 20);
            this.LblApptDateTime.TabIndex = 1;
            this.LblApptDateTime.Text = "Date & Time";
            this.LblApptDateTime.Click += new System.EventHandler(this.lblApptDateTime_Click);
            // 
            // CboDoctors
            // 
            this.CboDoctors.FormattingEnabled = true;
            this.CboDoctors.Location = new System.Drawing.Point(125, 37);
            this.CboDoctors.Name = "CboDoctors";
            this.CboDoctors.Size = new System.Drawing.Size(276, 28);
            this.CboDoctors.TabIndex = 2;
            this.CboDoctors.SelectedIndexChanged += new System.EventHandler(this.cboDoctors_SelectedIndexChanged);
            // 
            // DtpApptDateTime
            // 
            this.DtpApptDateTime.Location = new System.Drawing.Point(125, 87);
            this.DtpApptDateTime.Name = "DtpApptDateTime";
            this.DtpApptDateTime.Size = new System.Drawing.Size(276, 26);
            this.DtpApptDateTime.TabIndex = 3;
            this.DtpApptDateTime.ValueChanged += new System.EventHandler(this.dtpApptDateTime_ValueChanged);
            // 
            // BtnBookAppt
            // 
            this.BtnBookAppt.Location = new System.Drawing.Point(251, 135);
            this.BtnBookAppt.Name = "BtnBookAppt";
            this.BtnBookAppt.Size = new System.Drawing.Size(150, 29);
            this.BtnBookAppt.TabIndex = 4;
            this.BtnBookAppt.Text = "Book Appointment";
            this.BtnBookAppt.UseVisualStyleBackColor = true;
            this.BtnBookAppt.Click += new System.EventHandler(this.btnBookAppt_Click);
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.Controls.Add(this.BtnRescheduleAppt);
            this.dgvAppointments.Controls.Add(this.BtnCancelAppt);
            this.dgvAppointments.Controls.Add(this.dataGridView1);
            this.dgvAppointments.Location = new System.Drawing.Point(13, 378);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.Size = new System.Drawing.Size(533, 313);
            this.dgvAppointments.TabIndex = 1;
            this.dgvAppointments.TabStop = false;
            this.dgvAppointments.Text = "My Appointments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(489, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnCancelAppt
            // 
            this.BtnCancelAppt.Location = new System.Drawing.Point(21, 263);
            this.BtnCancelAppt.Name = "BtnCancelAppt";
            this.BtnCancelAppt.Size = new System.Drawing.Size(98, 30);
            this.BtnCancelAppt.TabIndex = 1;
            this.BtnCancelAppt.Text = "Cancel";
            this.BtnCancelAppt.UseVisualStyleBackColor = true;
            this.BtnCancelAppt.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnRescheduleAppt
            // 
            this.BtnRescheduleAppt.Location = new System.Drawing.Point(407, 263);
            this.BtnRescheduleAppt.Name = "BtnRescheduleAppt";
            this.BtnRescheduleAppt.Size = new System.Drawing.Size(103, 30);
            this.BtnRescheduleAppt.TabIndex = 2;
            this.BtnRescheduleAppt.Text = "Reschedule";
            this.BtnRescheduleAppt.UseVisualStyleBackColor = true;
            // 
            // FormAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 843);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAppointment";
            this.Text = "FormAppointment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dgvAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtpApptDateTime;
        private System.Windows.Forms.ComboBox CboDoctors;
        private System.Windows.Forms.Label LblApptDateTime;
        private System.Windows.Forms.Label LblSelectDoctor;
        private System.Windows.Forms.Button BtnBookAppt;
        private System.Windows.Forms.GroupBox dgvAppointments;
        private System.Windows.Forms.Button BtnRescheduleAppt;
        private System.Windows.Forms.Button BtnCancelAppt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
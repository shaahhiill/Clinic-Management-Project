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
            this.lblSelectDoctor = new System.Windows.Forms.Label();
            this.lblApptDateTime = new System.Windows.Forms.Label();
            this.cboDoctors = new System.Windows.Forms.ComboBox();
            this.dtpApptDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnBookAppt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBookAppt);
            this.groupBox1.Controls.Add(this.dtpApptDateTime);
            this.groupBox1.Controls.Add(this.cboDoctors);
            this.groupBox1.Controls.Add(this.lblApptDateTime);
            this.groupBox1.Controls.Add(this.lblSelectDoctor);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Appointment";
            // 
            // lblSelectDoctor
            // 
            this.lblSelectDoctor.AutoSize = true;
            this.lblSelectDoctor.Location = new System.Drawing.Point(18, 37);
            this.lblSelectDoctor.Name = "lblSelectDoctor";
            this.lblSelectDoctor.Size = new System.Drawing.Size(57, 20);
            this.lblSelectDoctor.TabIndex = 0;
            this.lblSelectDoctor.Text = "Doctor";
            this.lblSelectDoctor.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblApptDateTime
            // 
            this.lblApptDateTime.AutoSize = true;
            this.lblApptDateTime.Location = new System.Drawing.Point(18, 87);
            this.lblApptDateTime.Name = "lblApptDateTime";
            this.lblApptDateTime.Size = new System.Drawing.Size(86, 20);
            this.lblApptDateTime.TabIndex = 1;
            this.lblApptDateTime.Text = "Date & Time";
            this.lblApptDateTime.Click += new System.EventHandler(this.lblApptDateTime_Click);
            // 
            // cboDoctors
            // 
            this.cboDoctors.FormattingEnabled = true;
            this.cboDoctors.Location = new System.Drawing.Point(125, 37);
            this.cboDoctors.Name = "cboDoctors";
            this.cboDoctors.Size = new System.Drawing.Size(276, 28);
            this.cboDoctors.TabIndex = 2;
            this.cboDoctors.SelectedIndexChanged += new System.EventHandler(this.cboDoctors_SelectedIndexChanged);
            // 
            // dtpApptDateTime
            // 
            this.dtpApptDateTime.Location = new System.Drawing.Point(125, 87);
            this.dtpApptDateTime.Name = "dtpApptDateTime";
            this.dtpApptDateTime.Size = new System.Drawing.Size(276, 26);
            this.dtpApptDateTime.TabIndex = 3;
            this.dtpApptDateTime.ValueChanged += new System.EventHandler(this.dtpApptDateTime_ValueChanged);
            // 
            // btnBookAppt
            // 
            this.btnBookAppt.Location = new System.Drawing.Point(251, 135);
            this.btnBookAppt.Name = "btnBookAppt";
            this.btnBookAppt.Size = new System.Drawing.Size(150, 29);
            this.btnBookAppt.TabIndex = 4;
            this.btnBookAppt.Text = "Book Appointment";
            this.btnBookAppt.UseVisualStyleBackColor = true;
            this.btnBookAppt.Click += new System.EventHandler(this.btnBookAppt_Click);
            // 
            // FormAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 511);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAppointment";
            this.Text = "FormAppointment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpApptDateTime;
        private System.Windows.Forms.ComboBox cboDoctors;
        private System.Windows.Forms.Label lblApptDateTime;
        private System.Windows.Forms.Label lblSelectDoctor;
        private System.Windows.Forms.Button btnBookAppt;
    }
}
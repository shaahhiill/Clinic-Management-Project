namespace Clinic_Management_Project.GUI
{
    partial class FormManageAppointments
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
            this.LblFilterPatient = new System.Windows.Forms.Label();
            this.LblFilterDoctor = new System.Windows.Forms.Label();
            this.LblFilterFrom = new System.Windows.Forms.Label();
            this.LblFilterTo = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BtnApplyFilter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnApprove = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnReschedule = new System.Windows.Forms.Button();
            this.BtnSendNotification = new System.Windows.Forms.Button();
            this.DtpNewApptTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpNewApptTime);
            this.groupBox1.Controls.Add(this.BtnSendNotification);
            this.groupBox1.Controls.Add(this.BtnReschedule);
            this.groupBox1.Controls.Add(this.BtnCancel);
            this.groupBox1.Controls.Add(this.BtnApprove);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.BtnApplyFilter);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.LblFilterTo);
            this.groupBox1.Controls.Add(this.LblFilterFrom);
            this.groupBox1.Controls.Add(this.LblFilterDoctor);
            this.groupBox1.Controls.Add(this.LblFilterPatient);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 472);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Appointments";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LblFilterPatient
            // 
            this.LblFilterPatient.AutoSize = true;
            this.LblFilterPatient.Location = new System.Drawing.Point(15, 34);
            this.LblFilterPatient.Name = "LblFilterPatient";
            this.LblFilterPatient.Size = new System.Drawing.Size(59, 20);
            this.LblFilterPatient.TabIndex = 0;
            this.LblFilterPatient.Text = "Patient";
            this.LblFilterPatient.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblFilterDoctor
            // 
            this.LblFilterDoctor.AutoSize = true;
            this.LblFilterDoctor.Location = new System.Drawing.Point(15, 83);
            this.LblFilterDoctor.Name = "LblFilterDoctor";
            this.LblFilterDoctor.Size = new System.Drawing.Size(57, 20);
            this.LblFilterDoctor.TabIndex = 1;
            this.LblFilterDoctor.Text = "Doctor";
            // 
            // LblFilterFrom
            // 
            this.LblFilterFrom.AutoSize = true;
            this.LblFilterFrom.Location = new System.Drawing.Point(324, 34);
            this.LblFilterFrom.Name = "LblFilterFrom";
            this.LblFilterFrom.Size = new System.Drawing.Size(46, 20);
            this.LblFilterFrom.TabIndex = 2;
            this.LblFilterFrom.Text = "From";
            // 
            // LblFilterTo
            // 
            this.LblFilterTo.AutoSize = true;
            this.LblFilterTo.Location = new System.Drawing.Point(324, 83);
            this.LblFilterTo.Name = "LblFilterTo";
            this.LblFilterTo.Size = new System.Drawing.Size(27, 20);
            this.LblFilterTo.TabIndex = 3;
            this.LblFilterTo.Text = "To";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(95, 26);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 28);
            this.comboBox.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(95, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(438, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(438, 77);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // BtnApplyFilter
            // 
            this.BtnApplyFilter.Location = new System.Drawing.Point(759, 50);
            this.BtnApplyFilter.Name = "BtnApplyFilter";
            this.BtnApplyFilter.Size = new System.Drawing.Size(137, 33);
            this.BtnApplyFilter.TabIndex = 8;
            this.BtnApplyFilter.Text = "Filter";
            this.BtnApplyFilter.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(19, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(966, 78);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "dgvAppointments";
            // 
            // BtnApprove
            // 
            this.BtnApprove.Location = new System.Drawing.Point(19, 269);
            this.BtnApprove.Name = "BtnApprove";
            this.BtnApprove.Size = new System.Drawing.Size(95, 33);
            this.BtnApprove.TabIndex = 11;
            this.BtnApprove.Text = "Approve";
            this.BtnApprove.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(141, 269);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(86, 33);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnReschedule
            // 
            this.BtnReschedule.Location = new System.Drawing.Point(265, 271);
            this.BtnReschedule.Name = "BtnReschedule";
            this.BtnReschedule.Size = new System.Drawing.Size(105, 31);
            this.BtnReschedule.TabIndex = 13;
            this.BtnReschedule.Text = "Reschedule";
            this.BtnReschedule.UseVisualStyleBackColor = true;
            // 
            // BtnSendNotification
            // 
            this.BtnSendNotification.Location = new System.Drawing.Point(863, 271);
            this.BtnSendNotification.Name = "BtnSendNotification";
            this.BtnSendNotification.Size = new System.Drawing.Size(122, 48);
            this.BtnSendNotification.TabIndex = 14;
            this.BtnSendNotification.Text = "Send Notification";
            this.BtnSendNotification.UseVisualStyleBackColor = true;
            this.BtnSendNotification.Click += new System.EventHandler(this.button4_Click);
            // 
            // DtpNewApptTime
            // 
            this.DtpNewApptTime.Location = new System.Drawing.Point(265, 308);
            this.DtpNewApptTime.Name = "DtpNewApptTime";
            this.DtpNewApptTime.Size = new System.Drawing.Size(200, 26);
            this.DtpNewApptTime.TabIndex = 15;
            // 
            // FormManageAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 637);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormManageAppointments";
            this.Text = "FormManageAppointments";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblFilterTo;
        private System.Windows.Forms.Label LblFilterFrom;
        private System.Windows.Forms.Label LblFilterDoctor;
        private System.Windows.Forms.Label LblFilterPatient;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button BtnApplyFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnApprove;
        private System.Windows.Forms.Button BtnSendNotification;
        private System.Windows.Forms.Button BtnReschedule;
        private System.Windows.Forms.DateTimePicker DtpNewApptTime;
    }
}
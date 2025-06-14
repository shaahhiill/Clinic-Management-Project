namespace Clinic_Management_Project.GUI
{
    partial class FormReports
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
            this.LblFromDate = new System.Windows.Forms.Label();
            this.LblToDate = new System.Windows.Forms.Label();
            this.LblDoctorFilter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpReportFrom = new System.Windows.Forms.DateTimePicker();
            this.DtpReportTo = new System.Windows.Forms.DateTimePicker();
            this.CboReportDoctor = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LblReportType = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblReportType);
            this.groupBox1.Controls.Add(this.BtnGenerate);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.CboReportDoctor);
            this.groupBox1.Controls.Add(this.DtpReportTo);
            this.groupBox1.Controls.Add(this.DtpReportFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblDoctorFilter);
            this.groupBox1.Controls.Add(this.LblToDate);
            this.groupBox1.Controls.Add(this.LblFromDate);
            this.groupBox1.Location = new System.Drawing.Point(50, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Criteria";
            // 
            // LblFromDate
            // 
            this.LblFromDate.AutoSize = true;
            this.LblFromDate.Location = new System.Drawing.Point(36, 43);
            this.LblFromDate.Name = "LblFromDate";
            this.LblFromDate.Size = new System.Drawing.Size(46, 20);
            this.LblFromDate.TabIndex = 0;
            this.LblFromDate.Text = "From";
            // 
            // LblToDate
            // 
            this.LblToDate.AutoSize = true;
            this.LblToDate.Location = new System.Drawing.Point(36, 111);
            this.LblToDate.Name = "LblToDate";
            this.LblToDate.Size = new System.Drawing.Size(27, 20);
            this.LblToDate.TabIndex = 1;
            this.LblToDate.Text = "To";
            // 
            // LblDoctorFilter
            // 
            this.LblDoctorFilter.AutoSize = true;
            this.LblDoctorFilter.Location = new System.Drawing.Point(36, 179);
            this.LblDoctorFilter.Name = "LblDoctorFilter";
            this.LblDoctorFilter.Size = new System.Drawing.Size(94, 20);
            this.LblDoctorFilter.TabIndex = 2;
            this.LblDoctorFilter.Text = "Doctor (opt)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 3;
            // 
            // DtpReportFrom
            // 
            this.DtpReportFrom.Location = new System.Drawing.Point(185, 43);
            this.DtpReportFrom.Name = "DtpReportFrom";
            this.DtpReportFrom.Size = new System.Drawing.Size(316, 26);
            this.DtpReportFrom.TabIndex = 4;
            // 
            // DtpReportTo
            // 
            this.DtpReportTo.Location = new System.Drawing.Point(185, 111);
            this.DtpReportTo.Name = "DtpReportTo";
            this.DtpReportTo.Size = new System.Drawing.Size(316, 26);
            this.DtpReportTo.TabIndex = 5;
            // 
            // CboReportDoctor
            // 
            this.CboReportDoctor.FormattingEnabled = true;
            this.CboReportDoctor.Location = new System.Drawing.Point(185, 179);
            this.CboReportDoctor.Name = "CboReportDoctor";
            this.CboReportDoctor.Size = new System.Drawing.Size(316, 28);
            this.CboReportDoctor.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(185, 242);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(316, 28);
            this.comboBox2.TabIndex = 7;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(404, 307);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(97, 39);
            this.BtnGenerate.TabIndex = 8;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            // 
            // LblReportType
            // 
            this.LblReportType.AutoSize = true;
            this.LblReportType.Location = new System.Drawing.Point(40, 249);
            this.LblReportType.Name = "LblReportType";
            this.LblReportType.Size = new System.Drawing.Size(96, 20);
            this.LblReportType.TabIndex = 9;
            this.LblReportType.Text = "Report Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(50, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report ";
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 884);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReports";
            this.Text = "FormReports";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox CboReportDoctor;
        private System.Windows.Forms.DateTimePicker DtpReportTo;
        private System.Windows.Forms.DateTimePicker DtpReportFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDoctorFilter;
        private System.Windows.Forms.Label LblToDate;
        private System.Windows.Forms.Label LblFromDate;
        private System.Windows.Forms.Label LblReportType;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
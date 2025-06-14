namespace Clinic_Management_Project.GUI
{
    partial class FormPrescription
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
            this.BtnDownloadPrescription = new System.Windows.Forms.Button();
            this.BtnSavePrescription = new System.Windows.Forms.Button();
            this.BtnCreatePrescription = new System.Windows.Forms.Button();
            this.TxtMedication = new System.Windows.Forms.TextBox();
            this.TxtDiagnosis = new System.Windows.Forms.TextBox();
            this.LblMedication = new System.Windows.Forms.Label();
            this.LblDiagnosis = new System.Windows.Forms.Label();
            this.DtpDateIssued = new System.Windows.Forms.DateTimePicker();
            this.LblDateIssued = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvPrescriptions = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrescriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDownloadPrescription);
            this.groupBox1.Controls.Add(this.BtnSavePrescription);
            this.groupBox1.Controls.Add(this.BtnCreatePrescription);
            this.groupBox1.Controls.Add(this.TxtMedication);
            this.groupBox1.Controls.Add(this.TxtDiagnosis);
            this.groupBox1.Controls.Add(this.LblMedication);
            this.groupBox1.Controls.Add(this.LblDiagnosis);
            this.groupBox1.Controls.Add(this.DtpDateIssued);
            this.groupBox1.Controls.Add(this.LblDateIssued);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prescription Details";
            // 
            // BtnDownloadPrescription
            // 
            this.BtnDownloadPrescription.Location = new System.Drawing.Point(368, 184);
            this.BtnDownloadPrescription.Name = "BtnDownloadPrescription";
            this.BtnDownloadPrescription.Size = new System.Drawing.Size(89, 32);
            this.BtnDownloadPrescription.TabIndex = 8;
            this.BtnDownloadPrescription.Text = "Download";
            this.BtnDownloadPrescription.UseVisualStyleBackColor = true;
            // 
            // BtnSavePrescription
            // 
            this.BtnSavePrescription.Location = new System.Drawing.Point(242, 184);
            this.BtnSavePrescription.Name = "BtnSavePrescription";
            this.BtnSavePrescription.Size = new System.Drawing.Size(89, 32);
            this.BtnSavePrescription.TabIndex = 7;
            this.BtnSavePrescription.Text = "Save";
            this.BtnSavePrescription.UseVisualStyleBackColor = true;
            // 
            // BtnCreatePrescription
            // 
            this.BtnCreatePrescription.Location = new System.Drawing.Point(142, 184);
            this.BtnCreatePrescription.Name = "BtnCreatePrescription";
            this.BtnCreatePrescription.Size = new System.Drawing.Size(74, 32);
            this.BtnCreatePrescription.TabIndex = 6;
            this.BtnCreatePrescription.Text = "Create";
            this.BtnCreatePrescription.UseVisualStyleBackColor = true;
            // 
            // TxtMedication
            // 
            this.TxtMedication.Location = new System.Drawing.Point(142, 134);
            this.TxtMedication.Name = "TxtMedication";
            this.TxtMedication.Size = new System.Drawing.Size(315, 26);
            this.TxtMedication.TabIndex = 5;
            // 
            // TxtDiagnosis
            // 
            this.TxtDiagnosis.Location = new System.Drawing.Point(142, 83);
            this.TxtDiagnosis.Name = "TxtDiagnosis";
            this.TxtDiagnosis.Size = new System.Drawing.Size(315, 26);
            this.TxtDiagnosis.TabIndex = 4;
            // 
            // LblMedication
            // 
            this.LblMedication.AutoSize = true;
            this.LblMedication.Location = new System.Drawing.Point(18, 140);
            this.LblMedication.Name = "LblMedication";
            this.LblMedication.Size = new System.Drawing.Size(86, 20);
            this.LblMedication.TabIndex = 3;
            this.LblMedication.Text = "Medication";
            // 
            // LblDiagnosis
            // 
            this.LblDiagnosis.AutoSize = true;
            this.LblDiagnosis.Location = new System.Drawing.Point(18, 83);
            this.LblDiagnosis.Name = "LblDiagnosis";
            this.LblDiagnosis.Size = new System.Drawing.Size(79, 20);
            this.LblDiagnosis.TabIndex = 2;
            this.LblDiagnosis.Text = "Diagnosis";
            // 
            // DtpDateIssued
            // 
            this.DtpDateIssued.Location = new System.Drawing.Point(142, 38);
            this.DtpDateIssued.Name = "DtpDateIssued";
            this.DtpDateIssued.Size = new System.Drawing.Size(315, 26);
            this.DtpDateIssued.TabIndex = 1;
            // 
            // LblDateIssued
            // 
            this.LblDateIssued.AutoSize = true;
            this.LblDateIssued.Location = new System.Drawing.Point(18, 38);
            this.LblDateIssued.Name = "LblDateIssued";
            this.LblDateIssued.Size = new System.Drawing.Size(96, 20);
            this.LblDateIssued.TabIndex = 0;
            this.LblDateIssued.Text = "Date Issued";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DataGridView";
            // 
            // DgvPrescriptions
            // 
            this.DgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPrescriptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DgvPrescriptions.Location = new System.Drawing.Point(12, 416);
            this.DgvPrescriptions.Name = "DgvPrescriptions";
            this.DgvPrescriptions.RowHeadersWidth = 62;
            this.DgvPrescriptions.RowTemplate.Height = 28;
            this.DgvPrescriptions.Size = new System.Drawing.Size(365, 58);
            this.DgvPrescriptions.TabIndex = 2;
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
            // FormPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 814);
            this.Controls.Add(this.DgvPrescriptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrescription";
            this.Text = "FormPrescription";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrescriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDownloadPrescription;
        private System.Windows.Forms.Button BtnSavePrescription;
        private System.Windows.Forms.Button BtnCreatePrescription;
        private System.Windows.Forms.TextBox TxtMedication;
        private System.Windows.Forms.TextBox TxtDiagnosis;
        private System.Windows.Forms.Label LblMedication;
        private System.Windows.Forms.Label LblDiagnosis;
        private System.Windows.Forms.DateTimePicker DtpDateIssued;
        private System.Windows.Forms.Label LblDateIssued;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvPrescriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
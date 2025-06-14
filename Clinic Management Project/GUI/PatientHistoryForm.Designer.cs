namespace Clinic_Management_Project
{
    partial class PatientHistoryForm
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
            this.txtHistoryPatientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewHistory = new System.Windows.Forms.Button();
            this.dgvPatientHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHistoryPatientID
            // 
            this.txtHistoryPatientID.Location = new System.Drawing.Point(189, 235);
            this.txtHistoryPatientID.Name = "txtHistoryPatientID";
            this.txtHistoryPatientID.Size = new System.Drawing.Size(152, 22);
            this.txtHistoryPatientID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient ID";
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.Location = new System.Drawing.Point(100, 300);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(120, 53);
            this.btnViewHistory.TabIndex = 2;
            this.btnViewHistory.Text = "View History";
            this.btnViewHistory.UseVisualStyleBackColor = true;
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
            // 
            // dgvPatientHistory
            // 
            this.dgvPatientHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientHistory.Location = new System.Drawing.Point(12, 2);
            this.dgvPatientHistory.Name = "dgvPatientHistory";
            this.dgvPatientHistory.RowHeadersWidth = 51;
            this.dgvPatientHistory.RowTemplate.Height = 24;
            this.dgvPatientHistory.Size = new System.Drawing.Size(681, 191);
            this.dgvPatientHistory.TabIndex = 3;
            // 
            // PatientHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPatientHistory);
            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHistoryPatientID);
            this.Name = "PatientHistoryForm";
            this.Text = "PatientHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHistoryPatientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewHistory;
        private System.Windows.Forms.DataGridView dgvPatientHistory;
    }
}
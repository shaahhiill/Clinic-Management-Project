namespace Clinic_Management_Project.GUI
{
    partial class FormPatientHistory
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
            this.LblPatientName = new System.Windows.Forms.Label();
            this.DgvHistory = new System.Windows.Forms.DataGridView();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPatientName
            // 
            this.LblPatientName.AutoSize = true;
            this.LblPatientName.Location = new System.Drawing.Point(50, 57);
            this.LblPatientName.Name = "LblPatientName";
            this.LblPatientName.Size = new System.Drawing.Size(59, 20);
            this.LblPatientName.TabIndex = 0;
            this.LblPatientName.Text = "Patient";
            // 
            // DgvHistory
            // 
            this.DgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistory.Location = new System.Drawing.Point(54, 99);
            this.DgvHistory.Name = "DgvHistory";
            this.DgvHistory.RowHeadersWidth = 62;
            this.DgvHistory.RowTemplate.Height = 28;
            this.DgvHistory.Size = new System.Drawing.Size(381, 224);
            this.DgvHistory.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(347, 341);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(88, 34);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // FormPatientHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.DgvHistory);
            this.Controls.Add(this.LblPatientName);
            this.Name = "FormPatientHistory";
            this.Text = "FormPatientHistory";
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPatientName;
        private System.Windows.Forms.DataGridView DgvHistory;
        private System.Windows.Forms.Button BtnClose;
    }
}
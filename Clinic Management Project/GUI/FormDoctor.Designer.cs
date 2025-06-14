namespace Clinic_Management_Project.GUI
{
    partial class FormDoctor
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
            this.LblUsername = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LbltxtSpecialty = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblDay = new System.Windows.Forms.Label();
            this.LblStart = new System.Windows.Forms.Label();
            this.LblEnd = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.btnRemoveSchedule = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Location = new System.Drawing.Point(15, 36);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(83, 20);
            this.LblUsername.TabIndex = 0;
            this.LblUsername.Text = "Username";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(15, 82);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(78, 20);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password";
            // 
            // LbltxtSpecialty
            // 
            this.LbltxtSpecialty.AutoSize = true;
            this.LbltxtSpecialty.Location = new System.Drawing.Point(15, 125);
            this.LbltxtSpecialty.Name = "LbltxtSpecialty";
            this.LbltxtSpecialty.Size = new System.Drawing.Size(90, 20);
            this.LbltxtSpecialty.TabIndex = 2;
            this.LbltxtSpecialty.Text = "txtSpecialty";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(135, 30);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(296, 26);
            this.Username.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(135, 79);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(296, 26);
            this.Password.TabIndex = 4;
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Location = new System.Drawing.Point(135, 125);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(296, 26);
            this.txtSpecialty.TabIndex = 5;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(359, 176);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(72, 29);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblUsername);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.LblPassword);
            this.groupBox1.Controls.Add(this.txtSpecialty);
            this.groupBox1.Controls.Add(this.LbltxtSpecialty);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 232);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveSchedule);
            this.groupBox2.Controls.Add(this.btnAddSchedule);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.LblEnd);
            this.groupBox2.Controls.Add(this.LblStart);
            this.groupBox2.Controls.Add(this.LblDay);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 320);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schedule";
            // 
            // LblDay
            // 
            this.LblDay.AutoSize = true;
            this.LblDay.Location = new System.Drawing.Point(19, 36);
            this.LblDay.Name = "LblDay";
            this.LblDay.Size = new System.Drawing.Size(100, 20);
            this.LblDay.TabIndex = 0;
            this.LblDay.Text = "Day of Week";
            this.LblDay.Click += new System.EventHandler(this.LblDay_Click);
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.Location = new System.Drawing.Point(19, 75);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(82, 20);
            this.LblStart.TabIndex = 1;
            this.LblStart.Text = "Start Time";
            this.LblStart.Click += new System.EventHandler(this.LblStart_Click);
            // 
            // LblEnd
            // 
            this.LblEnd.AutoSize = true;
            this.LblEnd.Location = new System.Drawing.Point(19, 111);
            this.LblEnd.Name = "LblEnd";
            this.LblEnd.Size = new System.Drawing.Size(76, 20);
            this.LblEnd.TabIndex = 2;
            this.LblEnd.Text = "End Time";
            this.LblEnd.Click += new System.EventHandler(this.LblEnd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(191, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(295, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 26);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(191, 111);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(295, 26);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(316, 172);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(170, 27);
            this.btnAddSchedule.TabIndex = 6;
            this.btnAddSchedule.Text = "btnAddSchedule";
            this.btnAddSchedule.UseVisualStyleBackColor = true;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // btnRemoveSchedule
            // 
            this.btnRemoveSchedule.Location = new System.Drawing.Point(316, 217);
            this.btnRemoveSchedule.Name = "btnRemoveSchedule";
            this.btnRemoveSchedule.Size = new System.Drawing.Size(170, 26);
            this.btnRemoveSchedule.TabIndex = 7;
            this.btnRemoveSchedule.Text = "btnRemoveSchedule";
            this.btnRemoveSchedule.UseVisualStyleBackColor = true;
            this.btnRemoveSchedule.Click += new System.EventHandler(this.btnRemoveSchedule_Click);
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 689);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDoctor";
            this.Text = "FormDoctor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LbltxtSpecialty;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LblEnd;
        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.Label LblDay;
        private System.Windows.Forms.Button btnRemoveSchedule;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
namespace Clinic_Management_Project.GUI
{
    partial class FormNotification
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvNotifications;

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
            this.lblRecipient = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvNotifications = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).BeginInit();
            this.SuspendLayout();

            this.lblRecipient.Text = "Recipient";
            this.lblRecipient.Location = new System.Drawing.Point(30, 30);
            this.txtRecipient.Location = new System.Drawing.Point(120, 30);
            this.txtRecipient.Size = new System.Drawing.Size(200, 23);

            this.lblMessage.Text = "Message";
            this.lblMessage.Location = new System.Drawing.Point(30, 70);
            this.txtMessage.Location = new System.Drawing.Point(120, 70);
            this.txtMessage.Size = new System.Drawing.Size(300, 60);
            this.txtMessage.Multiline = true;

            this.btnSend.Text = "Send";
            this.btnSend.Location = new System.Drawing.Point(30, 150);
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(110, 150);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.dgvNotifications.Location = new System.Drawing.Point(30, 190);
            this.dgvNotifications.Size = new System.Drawing.Size(500, 200);

            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.lblRecipient);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvNotifications);
            this.Text = "Notification Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
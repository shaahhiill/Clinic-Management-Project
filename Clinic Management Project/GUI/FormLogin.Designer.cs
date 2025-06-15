namespace ClinicManagementSystem
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;

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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.lblUsername.Text = "Username";
            this.lblUsername.Location = new System.Drawing.Point(30, 30);
            this.txtUsername.Location = new System.Drawing.Point(120, 30);
            this.txtUsername.Size = new System.Drawing.Size(150, 23);

            this.lblPassword.Text = "Password";
            this.lblPassword.Location = new System.Drawing.Point(30, 70);
            this.txtPassword.Location = new System.Drawing.Point(120, 70);
            this.txtPassword.Size = new System.Drawing.Size(150, 23);
            this.txtPassword.UseSystemPasswordChar = true;

            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(30, 110);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.btnExit.Text = "Exit";
            this.btnExit.Location = new System.Drawing.Point(120, 110);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            this.ClientSize = new System.Drawing.Size(300, 170);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Text = "Login";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_Project.UI
{
    public partial class FormReports : Form
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormReports
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "FormReports";
            this.Load += new System.EventHandler(this.FormReports_Load);
            this.ResumeLayout(false);

        }

        private void FormReports_Load(object sender, EventArgs e)
        {

        }
    }
}

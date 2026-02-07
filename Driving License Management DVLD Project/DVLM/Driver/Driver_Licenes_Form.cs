using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLM.Driver
{
    public partial class Driver_Licenes_Form : Form
    {

        public int LicenseID {  get; set; }

        public Driver_Licenes_Form()
        {
            InitializeComponent();
        }

        private void Driver_Licenes_Form_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfo1.GetLicenseInfo(LicenseID);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

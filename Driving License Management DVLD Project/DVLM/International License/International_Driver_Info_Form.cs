using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLM.International_License
{
    public partial class International_Driver_Info_Form : Form
    {
        public International_Driver_Info_Form()
        {
            InitializeComponent();
        }

        public int InternationalLicenseID { get; set; }

        private void International_Driver_Info_Form_Load(object sender, EventArgs e)
        {
            ctrlInternationalDriverInfo1.GetDriverInternationalLicenseInfo(InternationalLicenseID);
        }
    }
}

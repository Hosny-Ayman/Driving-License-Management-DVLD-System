using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLM.Local_Driving_License_Applications
{
    public partial class Application_Details_Form : Form
    {
        public Application_Details_Form()
        {
            InitializeComponent();
        }

        public int LDLAID { get; set; }

        private void Application_Details_Form_Load(object sender, EventArgs e)
        {
            ctrlApplicationDetails1.GetApplicationDetails(LDLAID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

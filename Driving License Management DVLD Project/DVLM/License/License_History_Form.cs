using DVLM.International_License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLM.License
{
    public partial class License_History_Form : Form
    {
        public License_History_Form()
        {
            InitializeComponent();
        }

        public int PersonID { get; set; }


        private void License_History_Form_Load(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter1.SearchUserFilter = PersonID.ToString();
            ctrlPersonCardWithFilter1.btnFindPerson_Click_1(sender, e);
            ctrlPersonCardWithFilter1.FilterGroupBox.Enabled = false;

            ctrlLicenseHistory1.GetLocalLicenseHistory(PersonID);
            ctrlLicenseHistory1.GetInternationalLicenseHistory(PersonID);

        }

        

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      
    }
}

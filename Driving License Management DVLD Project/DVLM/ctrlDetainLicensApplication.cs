using DVLD___Business_Layer;
using ShairdClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLM
{
    public partial class ctrlDetainLicensApplication : UserControl
    {
        public ctrlDetainLicensApplication()
        {
            InitializeComponent();
        }

        private int LicenseID {  get; set; }

        public void DetainInfo()
        {
            lblDetainDate.Text = DateTime.Now.ToString("dd / MMM / yyyy");
            lblCreatedBy.Text = clsCurrentUser.CurrentUserName;
           
        }

        private void txtSearchUserFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void GetLicenesID(int LicenseID)
        {
            lblLicenseID.Text = LicenseID.ToString();
            this.LicenseID = LicenseID;
        }

        public int AddNewDetainedLicenses()
        {

            if (string.IsNullOrEmpty(txtFineFees.Text))
                return -2;


            clsDetainedLicenseBSL DetainedLicense = new clsDetainedLicenseBSL();

            DetainedLicense.LicenseID = LicenseID;
            DetainedLicense.DetainDate = DateTime.Now;
            DetainedLicense.FineFees = decimal.Parse(txtFineFees.Text);
            DetainedLicense.CreatedByUserID = clsCurrentUser.CurrentID;
            DetainedLicense.IsReleased = false;
            DetainedLicense.ReleaseDate = null;
            DetainedLicense.ReleasedByUserID = null;
            DetainedLicense.ReleaseApplicationID = null;

            if(DetainedLicense.Save())
            {
                lblDetainID.Text = DetainedLicense.DetainID.ToString();
                return DetainedLicense.DetainID;
            }
                
            else
                return -1;


        }

    }
}

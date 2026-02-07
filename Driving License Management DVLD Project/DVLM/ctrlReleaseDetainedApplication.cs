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
    public partial class ctrlReleaseDetainedApplication : UserControl
    {
        public ctrlReleaseDetainedApplication()
        {
            InitializeComponent();
        }

        private clsDetainedLicenseBSL _DetainedLicense;
       

        public void GetDetainInfo(int DetainID, int LicenseID)
        {
           

            lblLicenseID.Text = LicenseID.ToString();
            _DetainedLicense = clsDetainedLicenseBSL.FindDetainLicenseWithLicenseID(DetainID);

            if (_DetainedLicense != null )
            {
                lblDetainID.Text = _DetainedLicense.DetainID.ToString();
                lblDetainDate.Text= _DetainedLicense.DetainDate.ToString("dd / MMM / yyyy");
                lblApplicationFees.Text = clsApplicationTypeBSL.FindApplicationType((int)enApplicationType.ReleaseDetaind).ApplicationFees.ToString();
                lblLicenseID.Text = _DetainedLicense.LicenseID.ToString();
                lblCreatedBy.Text = clsUserBSL.FindUserByID(_DetainedLicense.CreatedByUserID).UserName;
                lblFineFees.Text = _DetainedLicense.FineFees.ToString();

                lblTotalFees.Text = (decimal.Parse(lblApplicationFees.Text) + decimal.Parse(lblFineFees.Text)).ToString();

            }

        }

        public bool ReleaseDetainedLicenses(int PersonID)
        {
            int ApplicationID = -1;

            if((ApplicationID = clsDetainedLicenseBSL.ReleaseDetainedLicenses(_DetainedLicense.DetainID, PersonID))!=-1)
            {
                lblApplicationID.Text = ApplicationID.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }





    }
}

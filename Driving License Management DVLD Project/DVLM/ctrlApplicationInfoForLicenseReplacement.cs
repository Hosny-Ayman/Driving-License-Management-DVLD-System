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

using static DVLM.ctrlInternationalAppInfoLicense;

namespace DVLM
{
    public partial class ctrlApplicationInfoForLicenseReplacement : UserControl
    {
        public ctrlApplicationInfoForLicenseReplacement()
        {
            InitializeComponent();
        }

        public clsLicenseBSL OldLicense {  get; set; }
        public int PersonID { get; set; }
        public enApplicationType Type;
        public enIssueReason IssueReason;
        private clsLicenseBSL NewLicenseRorD;

        public void GetApplicationInfo()
        {
            lblApplicationDate.Text = DateTime.Now.ToString("dd / MMM / yyyy");
            lblApplicationFees.Text = clsApplicationTypeBSL.FindApplicationType((int)IssueReason).ApplicationFees.ToString();
           
            lblCreatedBy.Text = clsCurrentUser.CurrentUserName;
        }

        public void OldLicenseID(int OlLicenseID)
        {
            
            lblOldLicenseID.Text = OlLicenseID.ToString();
        }

        public int CreatRplacementLicense()
        {
            NewLicenseRorD = clsLicenseBSL.CreateNewLicense(PersonID, Type, IssueReason, OldLicense);
            if (NewLicenseRorD == null)
            {
                return -1;
            }
            else
            {
                return NewLicenseRorD.LicenseID;
                lblReplacedLicenseID.Text = NewLicenseRorD.LicenseID.ToString();
            }
        }

    }
}

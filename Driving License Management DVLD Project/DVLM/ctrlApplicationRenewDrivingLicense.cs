using DVLD___Business_Layer;
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
using ShairdClass;
using System.Transactions;


namespace DVLM
{
    public partial class ctrlApplicationRenewDrivingLicense : UserControl
    {
        public ctrlApplicationRenewDrivingLicense()
        {
            InitializeComponent();
        }

        private int _PersonID;
        public clsLicenseBSL _OldLicense;
       

       public void SetApplicationInfo()
        {
            lblApplicationDate.Text = DateTime.Now.ToString("dd / MMM / yyyy");
            lblIssueDate.Text = DateTime.Now.ToString("dd / MMM / yyyy");
            lblApplicationFees.Text = clsApplicationTypeBSL.FindApplicationType((int)ShairdClass.enApplicationType.Renew).ApplicationFees.ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(5).ToString("dd / MMM / yyyy");
            lblCreatedBy.Text = clsCurrentUser.CurrentUserName;



        }


        public void GetLicenseFeesAndtTotalAndOldLicenseIDAndPerosnID(clsLicenseBSL OldLicense, int PersonID)
        {
            lblLicenseFees.Text = clsLicenseBSL.FindLicenseClasses(OldLicense.LicenseClass).ClassFees.ToString();
            lblTotalFees.Text = (decimal.Parse(lblApplicationFees.Text) + decimal.Parse(lblLicenseFees.Text)).ToString();
            lblOldLicense.Text = OldLicense.LicenseID.ToString();
            _PersonID = PersonID;
            _OldLicense = OldLicense;
        }


        public clsLicenseBSL CreateNewRenewLicense()
        {

            clsLicenseBSL NewLicenseID ;
            NewLicenseID = clsLicenseBSL.CreateNewLicense(_PersonID, ShairdClass.enApplicationType.Renew, ShairdClass.enIssueReason.Renew, _OldLicense, txtNote.Text);

            if(NewLicenseID!=null)
            {
                lblRenewLicenseID.Text = NewLicenseID.LicenseID.ToString();
                lblRLApplicationID.Text = NewLicenseID.ApplicationID.ToString();
            }

                return NewLicenseID;
            
        }



    }
}

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
    public partial class ctrlApplicationDetails : UserControl
    {
        public ctrlApplicationDetails()
        {
            InitializeComponent();
        }

        public void GetApplicationDetails(int LDLAID)
        {
            clsLocalDrivingLicenseApplications_View LDLA = clsLDLABSL.FindLDLAToTest(LDLAID);
            if(LDLA!=null)
            {
                lblLDLAID.Text = LDLA.LocalDrivingLicenseApplicationID.ToString();
                lblApplicationDate.Text = LDLA.ApplicationDate.ToString("dd MMM yyyy");
                lblPersonNationalNo.Text = LDLA.NationalNo;
                lblClass.Text = LDLA.ClassName;
                lblPersonName.Text = LDLA.FullName;
                lblApplicationStatus.Text = LDLA.Status;
                lblPassedTestNumber.Text = LDLA.PassedTestCount.ToString();
            }
           

        }

    }
}

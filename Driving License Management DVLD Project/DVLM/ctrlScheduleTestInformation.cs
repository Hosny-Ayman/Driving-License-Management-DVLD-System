using DVLD___Business_Layer;
using DVLM.Driver;
using DVLM.People;
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
using static System.Net.Mime.MediaTypeNames;

namespace DVLM
{
    public partial class ctrlScheduleTestInformation : UserControl
    {
        public ctrlScheduleTestInformation()
        {
            InitializeComponent();
        }

        public int PersonID { set; get; }

        DrivingLicenseApplicationInfo_Shard LDLA;
        ApplicationBasicInfo_Shard Application;

        public bool EnabledLable
        {
            get
            {
                return lblShowLicenseInfo.Enabled;
            }
            set
            {
                lblShowLicenseInfo.Enabled = value;
            }
        }

        public void GetDrivingLicenseApplicationInfo(int LDLAID)
        {
             LDLA = clsLDLABSL.DrivingLicenseApplicationInfo(LDLAID);

            if(LDLA != null)
            {
                lblLDLAID.Text= LDLA.DLAppID.ToString();
                lblLicencseClass.Text = LDLA.ClassName;
                lblPassedTestNumber.Text = LDLA.PassedTest.ToString();
            }
            else
            {
                MessageBox.Show("LDLA Can not Found", "LDLA Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        public void ApplicationBasicInfo(int ApplicationID)
        {
            Application = clsApplicationBSL.ShowApplicationBasicInfo(ApplicationID);

            if (Application != null)
            {
                lblApplicationID.Text= Application.ApplicationID.ToString();
                lblApplicationStatus.Text = Application.StatusName;
                lblApplicationFees.Text = Application.ApplicationFees.ToString();
                lblApplicationType.Text = Application.ApplicationTypeTitle;
                lblApplicationApplicant.Text = Application.Applicant;
                lblApplicationDate.Text = Application.ApplicationDate.ToString("d MMM yyyy");
                lblApplicationStatusDate.Text = Application.LastStatusDate.ToString("d MMM yyyy");

                lblApplicationCreatedBy.Text = clsCurrentUser.CurrentUserName;

                PersonID = Application.PersonID;

            }
            else
            {
                MessageBox.Show("Application Can not Found", "Application Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
           

        }

        private void lblViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

            Person_Details_Form frm = new Person_Details_Form(Application.PersonID);
            frm.ShowDialog();
        }

        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Driver_Licenes_Form frm = new Driver_Licenes_Form();


            frm.LicenseID = LDLA.DLAppID;

            frm.ShowDialog();
        }
    }
}

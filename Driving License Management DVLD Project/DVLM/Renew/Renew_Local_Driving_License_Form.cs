using DVLD___Business_Layer;
using DVLM.Driver;
using DVLM.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLM.Renew
{
    public partial class Renew_Local_Driving_License_Form : Form
    {
        public Renew_Local_Driving_License_Form()
        {
            InitializeComponent();
        }

        clsLicenseBSL NewLicense ;

        private int LDLAID {get;set;}

        private void Renew_Local_Driving_License_Form_Load(object sender, EventArgs e)
        {
            ctrlApplicationRenewDrivingLicense1.SetApplicationInfo();
        }


        private void ctrlLicenseCardWithFilter1_LoudData()
        {
            clsLicenseBSL Lcense = clsLicenseBSL.FindLicenseByLicenseID(ctrlLicenseCardWithFilter1.LicenseID);

            if (Lcense != null)
            {
                ctrlApplicationRenewDrivingLicense1.GetLicenseFeesAndtTotalAndOldLicenseIDAndPerosnID(Lcense, ctrlLicenseCardWithFilter1.PersonID);
                btnRenewLicense.Enabled = true;
                
                lblShowLicenseHistory.Enabled = true;
            }
           
        }


        private void CreateRenewLicense()
        {

          

            if(!ctrlLicenseCardWithFilter1.IsExpired)
            {
                MessageBox.Show($"Selected License Is Not Yet Expired, it will expire On : {ctrlApplicationRenewDrivingLicense1._OldLicense.ExpirationDate.ToString("dd/MMM/yyyy")}"
                    , "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((NewLicense = ctrlApplicationRenewDrivingLicense1.CreateNewRenewLicense())!=null)
            {
                MessageBox.Show($"Licensed Renewed Successfully With ID = {NewLicense.LicenseID}", "Successfully Renewed", MessageBoxButtons.OK, MessageBoxIcon.Question);
                lblShowLicenseInfo.Enabled = true;
            }
            else
            {
                MessageBox.Show($"Licensed Renewed Failed", "Failed Renewed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRenewLicense_Click(object sender, EventArgs e)
        {
            CreateRenewLicense();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlLicenseCardWithFilter1_LocalLicenseID(int obj)
        {
            LDLAID = obj;
        }

        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Driver_Licenes_Form frm = new Driver_Licenes_Form();
            frm.LicenseID = NewLicense.LicenseID;
            frm.ShowDialog();

        }

        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            License_History_Form frm = new License_History_Form();
            frm.PersonID = ctrlLicenseCardWithFilter1.PersonID;
            frm.ShowDialog();
        }

        
    }
}

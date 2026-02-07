using DVLD___Business_Layer;
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

namespace DVLM.International_License
{
    public partial class New_International_License_Application_Form : Form
    {
        public New_International_License_Application_Form()
        {
            InitializeComponent();
        }

        public int InternationalID {  get; set; }

        private void New_International_License_Application_Form_Load(object sender, EventArgs e)
        {
            ctrlInternationalAppInfoLicense1.GetDefaultApplicationData();
        }

        private void ctrlLicenseCardWithFilter1_LocalLicenseID(int obj)
        {
            ctrlInternationalAppInfoLicense1.GetLocalLicenseID(obj);
            lblShowLicenseHistory.Enabled = true;
            lblShowLicenseInfo.Enabled = false;
            btnIssueIntDriverLicense.Enabled = true;
        }

        private void SaveInternationalLicense()
        {


            if(!clsLicenseBSL.IsLicenseIDFromThisClass(ctrlLicenseCardWithFilter1.LicenseID, 3))
            {
                MessageBox.Show("The License Is Not Allowed Becasue Is Not From Class 3 ", "Not Allowed License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if(clsInternationalLicenseBSL.IsDriverHasInternationalLicenseAndItsActive(ctrlLicenseCardWithFilter1.DriverID))
            {
                MessageBox.Show("You cannot issue a license because you already have an international license.", "cannot issue a license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if(!ctrlLicenseCardWithFilter1.IsActive)
            {
                MessageBox.Show("The Local License Is Not Active", "Not Active", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (ctrlLicenseCardWithFilter1.IsExpired)
            {
                MessageBox.Show("The Local License Is Expired", "Expired License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
           
            if(MessageBox.Show("Are You Sure You Want To Issue the License ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
               if (ctrlInternationalAppInfoLicense1.SaveInternationalLicenseData(ctrlLicenseCardWithFilter1.PersonID, ctrlLicenseCardWithFilter1.DriverID))
                {
                    MessageBox.Show($"International License Issued Successfully With ID = {ctrlInternationalAppInfoLicense1.InternationalID}", "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InternationalID = ctrlInternationalAppInfoLicense1.InternationalID;
                    lblShowLicenseInfo.Enabled = true;
                }
               else
                {
                    MessageBox.Show("International License Issued Failed", "Issued Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            License_History_Form frm = new License_History_Form();

            frm.PersonID = ctrlLicenseCardWithFilter1.PersonID;
            frm.ShowDialog();
        }

        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            International_Driver_Info_Form frm = new International_Driver_Info_Form();
            frm.InternationalLicenseID = InternationalID;
            frm.ShowDialog();
        }

        private void btnSaveApplication_Click(object sender, EventArgs e)
        {
            SaveInternationalLicense();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

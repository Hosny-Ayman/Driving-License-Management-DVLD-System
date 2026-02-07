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

namespace DVLM.Detain_License
{
    public partial class Released_Detained_License_Form : Form
    {
        public Released_Detained_License_Form()
        {
            InitializeComponent();
        }

        private int _LicenseID {  get; set; }
        private int DetainID { get; set; }

        private void ctrlLicenseCardWithFilter1_LocalLicenseID(int obj)
        {

            _LicenseID = obj;
            DetainID = clsDetainedLicenseBSL.IsLicenseIDIsDetainedAndGetTheDetainID(obj);
            if (DetainID==-1)
            {
                MessageBox.Show("Select License Is Not Detained Select a nother One", "Not Allwod", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblShowLicenseHistory.Enabled = true;
            }
            else
            {
                ctrlReleaseDetainedApplication1.GetDetainInfo(DetainID, obj);
                btnRelease.Enabled = true;
                lblShowLicenseHistory.Enabled = true;
            }
        }


        public void SetGroupBoxVisibilityAndTextSearch(bool isVisible, int LicenseID, object sender, EventArgs e)
        {
            ctrlLicenseCardWithFilter1.SetGroupBoxVisibilityAndTextSearch(isVisible, LicenseID);
            ctrlLicenseCardWithFilter1.guna2ImageButton1_Click(sender, e);
        }


        private void ReleaseDetainedLicenses()
        {

            if (MessageBox.Show("Are You Sure You Want Release This License", "Release License", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (DetainID==-1)
                {
                    MessageBox.Show("Select License Is Not Detained Select a nother One", "Not Allwod", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (ctrlReleaseDetainedApplication1.ReleaseDetainedLicenses(ctrlLicenseCardWithFilter1.PersonID))
                {
                    MessageBox.Show("Detained License Released Successfully", "Released Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblShowLicenseInfo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Detained License Released Failed", "Released Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblShowLicenseInfo.Enabled = false;
                }
            }

        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenses();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Driver_Licenes_Form frm = new Driver_Licenes_Form();
            frm.LicenseID = _LicenseID;
            frm.ShowDialog();
        }

        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            License_History_Form form = new License_History_Form();
            form.PersonID = ctrlLicenseCardWithFilter1.PersonID;
            form.ShowDialog();
        }
    }
}

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
    public partial class Detain_License_Form : Form
    {
        public Detain_License_Form()
        {
            InitializeComponent();
        }

        private int _LicenseID;

        private void Detain_License_Form_Load(object sender, EventArgs e)
        {
            ctrlDetainLicensApplication1.DetainInfo();
        }

        private void ctrlLicenseCardWithFilter1_LocalLicenseID(int obj)
        {
            _LicenseID = obj;
            ctrlDetainLicensApplication1.GetLicenesID(obj);
            lblShowLicenseHistory.Enabled = true;
            btnDetain.Enabled = true;

        }

        private void CreateNewDetainLciense()
        {
            int DetainID = -1;


            if(clsDetainedLicenseBSL.IsLicenseIDIsDetained(_LicenseID))
            {
                MessageBox.Show("Selected License Is already Detained, Choose another One", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if((DetainID=ctrlDetainLicensApplication1.AddNewDetainedLicenses())!=-1)
            {
                if(DetainID==-2)
                {
                    MessageBox.Show("Please Enter A Fees", "No Fees", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show($"License Detained Successfully With the ID = {DetainID}", "Detained Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblShowLicenseInfo.Enabled = true;
                }

               
            }
            else
            {
                MessageBox.Show("License Detained Failed", "Detained Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Driver_Licenes_Form frm = new Driver_Licenes_Form();
            frm.LicenseID = _LicenseID;
            frm.ShowDialog();
        }

        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            License_History_Form frm = new License_History_Form();
            frm.PersonID = ctrlLicenseCardWithFilter1.PersonID;
            frm.ShowDialog();
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            CreateNewDetainLciense();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

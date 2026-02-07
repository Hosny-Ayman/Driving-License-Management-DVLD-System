using DVLD___Business_Layer;
using DVLM.Driver;
using DVLM.License;
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

namespace DVLM.Renew
{
    public partial class Replacement_For_Lost_or_Damaged_License_Form : Form
    {
        public Replacement_For_Lost_or_Damaged_License_Form()
        {
            InitializeComponent();
        }

        public enApplicationType ApplicationType;
        public clsLicenseBSL OldLicense {  get; set; }
        public int NewLicenseID {  get; set; }

        private void Replacement_For_Lost_or_Damaged_License_Form_Load(object sender, EventArgs e)
        {
            rbDamagedLicense.Checked = true;
            GetFillAllLicenseType();


        }

        private void ctrlLicenseCardWithFilter1_LocalLicenseID(int obj)
        {
            if(obj!=-1)
            {
                OldLicense = clsLicenseBSL.FindLicenseByLicenseID(obj);
                ctrlApplicationInfoForLicenseReplacement1.OldLicenseID(OldLicense.LicenseID);
                ctrlApplicationInfoForLicenseReplacement1.PersonID = ctrlLicenseCardWithFilter1.PersonID;
                ctrlApplicationInfoForLicenseReplacement1.OldLicense = OldLicense;
            }
           
        }

        private void GetFillAllLicenseType()
        {
            cbAllApplicationsType.DataSource = clsLicenseBSL.GetAllLicenseClasses();
            cbAllApplicationsType.DisplayMember = "ClassName";
            cbAllApplicationsType.ValueMember = "LicenseClassID";
            cbAllApplicationsType.SelectedIndex = 0;
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblHeader.Text = "Replacement For Damaged License";
            ctrlApplicationInfoForLicenseReplacement1.Type = enApplicationType.ReplacementForDamaged;
            ctrlApplicationInfoForLicenseReplacement1.IssueReason = enIssueReason.ReplacementForDamaged;
            ctrlApplicationInfoForLicenseReplacement1.GetApplicationInfo();
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblHeader.Text = "Replacement For Lost License";
            ctrlApplicationInfoForLicenseReplacement1.Type = enApplicationType.ReplacementForLost;
            ctrlApplicationInfoForLicenseReplacement1.IssueReason = enIssueReason.ReplacementForLost;
            ctrlApplicationInfoForLicenseReplacement1.GetApplicationInfo();
        }

        private void CreateNewLicenseForReplacementOrDamaged()
        {
            if(!OldLicense.IsActive)
            {
                MessageBox.Show("Selected License Is Not Active , Choose an Active License", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(MessageBox.Show("Are You Sure You Want To Replacement", "Are You Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
            {
                if ((NewLicenseID = ctrlApplicationInfoForLicenseReplacement1.CreatRplacementLicense()) != -1)
                {
                    MessageBox.Show($"License Replacement Successfully With ID = {NewLicenseID}","License Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblShowLicenseInfo.Enabled = true;

                }
                else
                {
                    MessageBox.Show($"License Replacement Failed", "License Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            CreateNewLicenseForReplacementOrDamaged();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchNationalNo_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNationalNo.Text))
            {
                int LicenseID = clsLicenseBSL.GetLicenseIDWithNationalNo(txtNationalNo.Text, (int)cbAllApplicationsType.SelectedValue, true);
                if (LicenseID != -1)
                {
                    ctrlLicenseCardWithFilter1.stringSearchFilter = LicenseID.ToString();
                    ctrlLicenseCardWithFilter1.guna2ImageButton1_Click(sender, e);
                    gbReplacementFor.Enabled = true;
                    btnIssueReplacement.Enabled = true;
                    lblShowLicenseHistory.Enabled = true;
                }
                else
                {
                    MessageBox.Show("There is No License", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    gbReplacementFor.Enabled = false;
                    btnIssueReplacement.Enabled = false;
                    lblShowLicenseHistory.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please Enter National ID First", "No National ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void lblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Driver_Licenes_Form frm = new Driver_Licenes_Form();
            frm.LicenseID = NewLicenseID;
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

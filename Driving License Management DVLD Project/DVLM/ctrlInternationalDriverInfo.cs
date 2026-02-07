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
    public partial class ctrlInternationalDriverInfo : UserControl
    {
        public ctrlInternationalDriverInfo()
        {
            InitializeComponent();
        }

        public void GetDriverInternationalLicenseInfo(int InternationalLicenseID)
        {
            DriverInternationalLicenseInfo_Shard DriverInternationalLicense = clsInternationalLicenseBSL.DriverInternationalLicenseInfo(InternationalLicenseID);


            if (DriverInternationalLicense != null)
            {

                lblPersonName.Text = DriverInternationalLicense.FullName;
                lblIntLicenseID.Text = DriverInternationalLicense.InternationalLicenseID.ToString();
                lblLocalLicenseID.Text= DriverInternationalLicense.IssuedUsingLocalLicenseID.ToString();
                lblPersonNationalNo.Text = DriverInternationalLicense.NationalNo;


                if (DriverInternationalLicense.Gendor == 0)
                {
                    lblPersonGendor.Text = "Male";
                }
                else
                    lblPersonGendor.Text = "False";

                lblIssueDate.Text = DriverInternationalLicense.IssueDate.ToString("dd / MMM / yyyy");
                lblApplicationID.Text= DriverInternationalLicense.ApplicationID.ToString();

                if (DriverInternationalLicense.IsActive)
                    pbIsActive.Image = Properties.Resources.yes;
                else
                    pbIsActive.Image = Properties.Resources.No;

                lblDataOfBirth.Text = DriverInternationalLicense.DateOfBirth.ToString("dd / MMM / yyyy");
                lblDriverID.Text = DriverInternationalLicense.DriverID.ToString();
                lblExpirationDate.Text = DriverInternationalLicense.ExpirationDate.ToString("dd / MMM / yyyy");

                


                if (!string.IsNullOrEmpty(DriverInternationalLicense.ImagePath))
                {
                    pbPersonPic.Image = Image.FromFile(DriverInternationalLicense.ImagePath);
                }
                else
                {
                    if (DriverInternationalLicense.Gendor == 0)
                        pbPersonPic.Image = Properties.Resources.male;
                    else
                        pbPersonPic.Image = Properties.Resources.woman;
                }


            }
            else
            {
                MessageBox.Show("Ther Is No License With This ID", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

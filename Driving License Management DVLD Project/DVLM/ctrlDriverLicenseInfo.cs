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
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }


        public event Action<int,int> GetPersonIDAndDriverID;
        public event Action<bool, bool> IsActiveLicenseAndIsNotExpired;

        public event Action<int> GetLicenseID;

        protected virtual void OnGetPersonIDAndDriverID(int personID,int Driver)
        {
            GetPersonIDAndDriverID?.Invoke(personID, Driver);
        }

        protected virtual void OnIsActiveLicenseAndIsNotExpired(bool IsActiveLicense,bool IsExpired)
        {
            IsActiveLicenseAndIsNotExpired?.Invoke(IsActiveLicense, IsExpired);
        }

        protected virtual void OnLicenseID(int LicenseID)
        {
            GetLicenseID?.Invoke(LicenseID);
        }


        public void GetLicenseInfo(int LicenseID)
        {
            DriverLicenseInfo_Shard DriverLicense = clsDriverBSL.DriverLicenseInfo(LicenseID);

            if(DriverLicense!=null)
            {
                lblClass.Text = DriverLicense.ClassName;
                lblPersonName.Text = DriverLicense.FullName;
                lblLicenseID.Text = DriverLicense.LicenseID.ToString();
                lblPersonNationalNo.Text= DriverLicense.NationalNo;

                if(DriverLicense.Gendor==0)
                {
                    lblPersonGendor.Text = "Male";
                }
                else
                    lblPersonGendor.Text = "False";

                lblIssueDate.Text = DriverLicense.IssueDate.ToString("dd / MMM / yyyy");

                switch(DriverLicense.IssueReason)
                {
                    case 1:
                        lblIssueReason.Text = "New";
                        break;
                    case 2:
                        lblIssueReason.Text = "Renew";
                        break;
                    case 3:
                        lblIssueReason.Text = "Replacement For a Lost";
                        break;
                    case 4:
                        lblIssueReason.Text = "Replacement For a Damaged";
                        break;
                    case 5:
                        lblIssueReason.Text = "Release Detained";
                        break;
                    case 6:
                        lblIssueReason.Text = "New International";
                        break;
                }

                if(string.IsNullOrEmpty(DriverLicense.Notes))
                lblNotes.Text ="No Notes";
                else
                lblNotes.Text = DriverLicense.Notes;


                if (DriverLicense.IsActive)
                    pbIsActive.Image = Properties.Resources.yes;
                else
                    pbIsActive.Image = Properties.Resources.No;

                lblDataOfBirth.Text = DriverLicense.DateOfBirth.ToString("dd / MMM / yyyy");

                lblDriverID.Text = DriverLicense.DriverID.ToString();

                lblExpirationDate.Text = DriverLicense.ExpirationDate.ToString("dd / MMM / yyyy");

                //if (DateTime.Now.Date <= DriverLicense.ExpirationDate )
                //{
                //    pbIsDetainEnd.Image = Properties.Resources.No;
                //    OnIsActiveLicenseAndIsNotExpired(DriverLicense.IsActive, false);
                //}

                //else
                //    pbIsDetainEnd.Image = Properties.Resources.yes;

                bool isLicenseExpired = (DateTime.Now.Date > DriverLicense.ExpirationDate);

                
                OnIsActiveLicenseAndIsNotExpired(DriverLicense.IsActive, isLicenseExpired);

                
                if (clsDetainedLicenseBSL.IsLicenseIDIsDetained(LicenseID))
                {
                   
                    pbIsDetainEnd.Image = Properties.Resources.yes;
                }
                else
                {
                    
                    pbIsDetainEnd.Image = Properties.Resources.No;
                }

                if (!string.IsNullOrEmpty(DriverLicense.ImagePath))
                {
                    pbPersonPic.Image = Image.FromFile(DriverLicense.ImagePath);
                }
                else
                {
                    if(DriverLicense.Gendor == 0)
                        pbPersonPic.Image= Properties.Resources.male;
                    else
                        pbPersonPic.Image = Properties.Resources.woman;
                }

                OnGetPersonIDAndDriverID(DriverLicense.PersonID, DriverLicense.DriverID);

                OnLicenseID(DriverLicense.LicenseID);

            }
            else
            {
                MessageBox.Show("Ther Is No License With This ID", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        
    }
}

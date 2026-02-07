using DVLD___Business_Layer;
using ShairdClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace DVLM
{
    public partial class ctrlInternationalAppInfoLicense : UserControl
    {
        public ctrlInternationalAppInfoLicense()
        {
            InitializeComponent();
        }

        public enum ApplicationTypes { NewLicense = 1, RenewLicense = 2, InternationalLicense = 6 }
        public enum ApplicationStatus { New = 1, Cancelled = 2, Completed = 3 }


        public int InternationalID {  get; set; }

        public void GetLocalLicenseID(int LocalLicenseID)
        {
            lblLocalLicenseID.Text = LocalLicenseID.ToString();
        }

        public void GetDefaultApplicationData()
        {
            lblApplicationDate.Text = DateTime.Now.ToString("dd / MMM / yyyy");
            lblIssueDate.Text = DateTime.Now.ToString("dd / MMM / yyyy");
            lblFees.Text = clsApplicationTypeBSL.FindApplicationType(6).ApplicationFees.ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToString("dd / MMM / yyyy");
            lblCreatedBy.Text = clsCurrentUser.CurrentUserName;
        }

        public int CreateApplication(int PersonID)
        {
            clsApplicationBSL Application = new clsApplicationBSL();


            Application.ApplicantPersonID= PersonID;
            Application.ApplicationDate = DateTime.ParseExact(lblApplicationDate.Text.Trim(), "dd / MMM / yyyy", CultureInfo.InvariantCulture);
            Application.ApplicationTypeID = (int)ApplicationTypes.InternationalLicense;
            Application.ApplicationStatus = (int)ApplicationStatus.Completed;
            Application.LastStatusDate= DateTime.ParseExact(lblApplicationDate.Text.Trim(), "dd / MMM / yyyy", CultureInfo.InvariantCulture);
            Application.PaidFees = decimal.Parse(lblFees.Text);
            Application.CreatedByUserID = clsCurrentUser.CurrentID;

            if (Application.Save())
                return Application.ApplicationID;
            else
                return -1;

        }

        public bool SaveInternationalLicenseData(int PersonID,int DriverID)
        {
           

            using (TransactionScope Scope = new TransactionScope())
            {
                try
                {
                    int ApplicationID = CreateApplication(PersonID);

                    if (ApplicationID == -1)
                    {

                        throw new Exception("No Application");

                        
                    }

                    clsInternationalLicenseBSL internationalLicense = new clsInternationalLicenseBSL();

                    internationalLicense.ApplicationID = ApplicationID;
                    internationalLicense.DriverID = DriverID;
                    internationalLicense.IssuedUsingLocalLicenseID = int.Parse(lblLocalLicenseID.Text);
                    internationalLicense.IssueDate = DateTime.ParseExact(lblIssueDate.Text, "dd / MMM / yyyy", CultureInfo.InvariantCulture);
                    internationalLicense.ExpirationDate = DateTime.ParseExact(lblExpirationDate.Text, "dd / MMM / yyyy", CultureInfo.InvariantCulture);
                    internationalLicense.IsActive = true;
                    internationalLicense.CreatedByUserID = clsCurrentUser.CurrentID;

                    if (!internationalLicense.Save())
                    {
                        throw new Exception("internationalLicense Save Failed");

                        

                        
                    }
                    else
                    {
                        Scope.Complete();
                        lblInternationalAppID.Text = internationalLicense.ApplicationID.ToString();
                        lblinternationalLicense.Text = internationalLicense.InternationalLicenseID.ToString();
                        InternationalID = internationalLicense.InternationalLicenseID;
                        return true;
                    }
                       
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                    return false;
                }
            }


               


        }


    }
}

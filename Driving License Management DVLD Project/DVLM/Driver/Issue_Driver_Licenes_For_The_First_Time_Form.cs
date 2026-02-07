using DVLD___Business_Layer;
using ShairdClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;


namespace DVLM.Driver
{
    public partial class Issue_Driver_Licenes_For_The_First_Time_Form : Form
    {
       
        public clsLDLABSL LDLApp {  get; set; }
        public int _PersonID { get; set; }


       

        public Issue_Driver_Licenes_For_The_First_Time_Form()
        {
            InitializeComponent();
        }

        private void Issue_Driver_Licenes_For_The_First_Time_Form_Load(object sender, EventArgs e)
        {
            ctrlScheduleTestInformation1.GetDrivingLicenseApplicationInfo(LDLApp.LDLAID);
            ctrlScheduleTestInformation1.ApplicationBasicInfo(LDLApp.ApplicationID);

            _PersonID = ctrlScheduleTestInformation1.PersonID;
        }

        private void IssueDriverLicence()
        {
            using(TransactionScope Scop = new TransactionScope())
            {
                try
                {

                    int driverID = -1;

                    if (!clsDriverBSL.IsDriverExistByPersonID(_PersonID))
                    {
                        clsDriverBSL Driver = new clsDriverBSL();

                        Driver.PersonID = _PersonID;
                        Driver.CreatedByUserID = clsCurrentUser.CurrentID;
                        Driver.CreatedDate = DateTime.Now;



                        if (!Driver.Save())
                        {


                            throw new Exception("Driver Add Failed");
                        }

                        driverID = Driver.DriverID;
                    }
                    else
                    {
                        
                        driverID = clsDriverBSL.GetDriverIDByPersonID(_PersonID);
                    }

                    if (driverID == -1)
                    {
                        throw new Exception("Could not find or create a driver.");
                    }



                    clsLicenseBSL License = new clsLicenseBSL();

                    clsFindLicenseClasses licenseClassInfo = clsLicenseBSL.FindLicenseClasses(LDLApp.LicenesClassID);

                    if (licenseClassInfo == null)
                    {
                       
                        throw new Exception($"The License Class with ID {LDLApp.LicenesClassID} is not found.");
                    }

                    License.ApplicationID = LDLApp.ApplicationID;
                    License.DriverID = driverID;
                    License.LicenseClass = LDLApp.LicenesClassID;
                    License.IssueDate = DateTime.Now;
                    License.ExpirationDate = DateTime.Now.AddYears(licenseClassInfo.DefaultValidityLength);
                    License.Notes = txtNotes.Text;
                    License.PaidFees = licenseClassInfo.ClassFees;
                    License.IsActive = true;
                    License.IssueReason = 1;
                    License.CreatedByUserID = clsCurrentUser.CurrentID;

                    if (!License.Save())
                    {
                        throw new Exception("License Add Failed");
                        
                    }

                    if (!clsApplicationBSL.UpdateApplicationStatusToCompleted(LDLApp.ApplicationID))
                    {
                        
                        throw new Exception("Failed to update application status.");
                    }

                    Scop.Complete();

                    
                    MessageBox.Show($"License Add Successfully with License ID = {License.LicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlScheduleTestInformation1.EnabledLable = true;

                    btnSave.Enabled = false;
                    txtNotes.Enabled = false;

                    //this.Close();
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Operation Failed. No data was saved.\nError: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

  

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            IssueDriverLicence();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

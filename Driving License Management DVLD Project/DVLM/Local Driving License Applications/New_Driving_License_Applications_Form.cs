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
using static System.Net.Mime.MediaTypeNames;

namespace DVLM.Local_Driving_License_Applications
{
    public partial class New_Driving_License_Applications_Form : Form
    {
        public New_Driving_License_Applications_Form(enMode mode)
        {
            InitializeComponent();
            _Mode = mode;
        }

       public enum enMode {AddNew=1,Update=2 };
       private enMode _Mode;

        public clsLDLABSL LDLA;

        private string _NationalNo;

        private int _LocalApplicationID = -1;

        public int _PersonID = 0;

        private DateTime _PersonDate;

        clsApplicationTypeBSL ApplicationType;

        ApplicationBasicInfo_Shard ApplicationBasicInfo;

        private void FillCbClassComboBox()
        {
            DataTable classLDLP = clsLicenseBSL.GetAllLicenseClasses();

            cbClassLDLA.DataSource = classLDLP;
            cbClassLDLA.DisplayMember = "ClassName";
            cbClassLDLA.SelectedIndex = 0;
            cbClassLDLA.ValueMember = "LicenseClassID";
        }

        private void New_Driving_License_Applications_Form_Load(object sender, EventArgs e)
        {
            LoadData(sender, e);
        }

        private void SettingsBeforStart()
        {
            FillCbClassComboBox();

            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            ApplicationTypes();
            lblApplicationFees.Text = ApplicationType.ApplicationFees.ToString();

            lblUserName.Text = clsCurrentUser.CurrentUserName;
        }

        private void ctrlPersonCardWithFilter1_PersonSelectNationalNo(string obj)
        {
            _NationalNo = obj;
        }

        private void ctrlPersonCardWithFilter1_PersonSelect(int obj)
        {
            _PersonID = obj;

            if (_PersonID != 0)
                btnNext.Enabled = true;
        }

        private bool ApplicationTypes()
        {
             ApplicationType = clsApplicationTypeBSL.FindApplicationType(1);

            if(ApplicationType!=null)
            {
                return true;
            }
       
            else
            {
                return false;
            }

        }

        private void LoadData(object sender, EventArgs e)
        {
            if(_Mode==enMode.AddNew)
            {
                SettingsBeforStart();

                LDLA = new clsLDLABSL();

                return;
            }

            if(LDLA!=null)
            {
                FillCbClassComboBox();
                ctrlPersonCardWithFilter1.SearchUserFilter = _PersonID.ToString();
                ctrlPersonCardWithFilter1.FilterGroupBox.Enabled = false;
                ctrlPersonCardWithFilter1.btnFindPerson_Click_1(sender, e);

                lblLDLAID.Text = LDLA.LDLAID.ToString();

                 ApplicationBasicInfo = clsApplicationBSL.ShowApplicationBasicInfo(LDLA.ApplicationID);

                if(ApplicationBasicInfo.ApplicationID!=-1)
                {
                    lblDate.Text = ApplicationBasicInfo.ApplicationDate.ToString();
                    cbClassLDLA.SelectedValue = LDLA.LicenesClassID;
                    lblApplicationFees.Text = ApplicationBasicInfo.ApplicationFees.ToString();
                    lblUserName.Text = ApplicationBasicInfo.UserName.ToString();
                }

            }

            
        }


        private int AddNewApplication()
        {
            

            clsApplicationBSL Application = new clsApplicationBSL();

            Application.ApplicantPersonID = _PersonID;
            Application.ApplicationDate = DateTime.Now;

            if (ApplicationTypes())
            Application.ApplicationTypeID = ApplicationType.ApplicationTypeID;
            else
                return -1;

            Application.ApplicationStatus = 1;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = ApplicationType.ApplicationFees;
            Application.CreatedByUserID = clsCurrentUser.CurrentID;

            if (Application.Save())
                return Application.ApplicationID;
            else
                return -1;

        }

        private bool IsPersonHasApplicationAlready()
        {
            string ClassName = cbClassLDLA.Text;

            if ((int)cbClassLDLA.SelectedValue == LDLA.LicenesClassID)
                return false;


            return ((_LocalApplicationID = clsLDLABSL.IsPersonHasApplication(_NationalNo, ClassName, "New")) != -1);
               
        }

        private bool IsPersonHasLicensFromThisClass(int PersonID, int LicenseClass)
        {
            return clsDriverBSL.IsDriverHasALicenseFromThisClassOrNot(PersonID, LicenseClass);
        }

        private void ctrlPersonCardWithFilter1_PersonDate(DateTime obj)
        {
            _PersonDate = obj;
        }

        private bool IsPersonHasTheAgeToCreatApplication(DateTime _PersonDate)
        {
            int Age = DateTime.Today.Year - _PersonDate.Year;
           
            if(_PersonDate.Date > DateTime.Today.AddYears(-Age))
            {
                --Age;
            }

            return Age >= clsLicenseBSL.FindLicenseClasses((int)cbClassLDLA.SelectedValue).MinimumAllowedAge;


           
        }






        private void btnSaveApplication_Click(object sender, EventArgs e)
        {

            int ApplicationID;

            if(IsPersonHasApplicationAlready())
            {
                MessageBox.Show($"Choose Another License Class , the Selected Person Has an Active application for the Selected Class With ID = {_LocalApplicationID}","Save Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if(IsPersonHasLicensFromThisClass( _PersonID, (int)cbClassLDLA.SelectedValue))
            {
                MessageBox.Show($"Person already have a license with the same applied driving class , Choose diffrent driving Class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!IsPersonHasTheAgeToCreatApplication(_PersonDate))
            {
                MessageBox.Show($"You Don't have The Minimum Age", "Minimum Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_NationalNo == null || _PersonID==0)
            {
                MessageBox.Show($"Please Chose Person First", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if(_Mode==enMode.AddNew)
            {
                if ((ApplicationID = AddNewApplication()) == -1)
                {
                    MessageBox.Show($"Failed to create the main application object", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                LDLA.ApplicationID = ApplicationID;
                LDLA.LicenesClassID = (int)cbClassLDLA.SelectedValue;

                if (LDLA.Save())
                {
                    lblLDLAID.Text = LDLA.LDLAID.ToString();
                    MessageBox.Show($"Application Data Successfully", "Save Successfully", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
                else
                {
                    MessageBox.Show($"Application Data Failed", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
               
                LDLA.LicenesClassID = (int)cbClassLDLA.SelectedValue;

                if (LDLA.Save())
                {
                    lblLDLAID.Text = LDLA.LDLAID.ToString();
                    MessageBox.Show($"Application Data  Successfully", "Save Successfully", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
                else
                {
                    MessageBox.Show($"Application Data  Failed", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabctPerson_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(e.TabPageIndex==1)
            {

                if(_PersonID==0)
                {

                    MessageBox.Show($"You Should Choose A Person First", "No Person", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    e.Cancel = true;
                }

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabctApplication.SelectedTab = tabPage2;
        }

       
    }
}

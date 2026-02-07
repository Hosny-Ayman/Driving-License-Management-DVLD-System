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

namespace DVLM.Test
{
    public partial class Schedule_Test_Form : Form
    {

        private int _LDLAID;

        public enum enTestType {VisionTest=1,WrittenTest=2,PracrticalTest=3 };
        public enTestType TestType;


        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode;

        clsApplicationBSL Application = new clsApplicationBSL();

        clsRetestServiceBSL RetestService = new clsRetestServiceBSL();

        clsTestAppointmentBSL TestAppointment;

        public int AppointmenID {  get; set; }

        private int _PersonID;

        private bool _isRetest = false;

        private int _RetestID {set;get;}

        public DateTime? LasAppintmentsDate = null;

        public Schedule_Test_Form(int lDLAID, bool isRetest,int PersonID) 
        {
            InitializeComponent();
            dtpScheduleTest.MinDate = DateTime.Today;
            
          

            _LDLAID = lDLAID;
            _isRetest = isRetest;
            _PersonID = PersonID;
        }

        private void TestAppointmentType()
        {
            switch(TestType)
            {
                case enTestType.VisionTest:
                    pbScheduleTest.Image = Properties.Resources.eye_scan;
                    gbScheduleTest.Text = "Vision Test";
                    GetTestFees(TestType);
                    break;
                case enTestType.WrittenTest:
                    pbScheduleTest.Image = Properties.Resources.notes;
                    gbScheduleTest.Text = "Written Test";
                    GetTestFees(TestType);
                    break;
                case enTestType.PracrticalTest:
                    pbScheduleTest.Image = Properties.Resources.driving_test;
                    gbScheduleTest.Text = "Pracrtical Test";
                    GetTestFees(TestType);
                    break;

            }
        }



        private decimal GetTestFees(enTestType TestType)
        {
             return clsTestTypeBSL.FindApplicationType((int)TestType).TestTypeFees;

        }

        private void _LoadData()
        {

            clsLocalDrivingLicenseApplications_View LDLA = clsLDLABSL.FindLDLAToTest(_LDLAID);

            if (LDLA.LocalDrivingLicenseApplicationID != -1)
            {
                lblLDLAID.Text = LDLA.LocalDrivingLicenseApplicationID.ToString();
                lblLicencseClass.Text = LDLA.ClassName;
                lblName.Text = LDLA.FullName;
                lblTrail.Text= Convert.ToString(clsTestAppointmentBSL.TrailTest((int)TestType, _LDLAID));
                

               
            }
            else
            {
                MessageBox.Show($"Can not Find This ID = {_LDLAID}", "Not Find", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Mode == enMode.AddNew)
            {
                TestAppointment = new clsTestAppointmentBSL();

                lblApplicationFees.Text = Convert.ToString(GetTestFees(TestType));

                decimal applicationFees = 0;
                decimal retakeAppFees = 0;

                if(_isRetest)
                {
                   
                    dtpScheduleTest.MinDate = LasAppintmentsDate.Value;

                }

                
                decimal.TryParse(lblApplicationFees.Text, out applicationFees);


                decimal.TryParse(lblRAppFess.Text, out retakeAppFees);


                lblTotalmoneyFees.Text = (applicationFees + retakeAppFees).ToString();

                return;
            }

            TestAppointment = clsTestAppointmentBSL.FindAppointmentByAppointmentID(AppointmenID);

            if (TestAppointment!=null)
            {
                
                dtpScheduleTest.Value = TestAppointment.AppointmentDate;
                lblApplicationFees.Text = TestAppointment.PaidFees.ToString();

                if(_isRetest)
                {
                    clsRetestServiceBSL RetestService = clsRetestServiceBSL.FindRetestService(TestAppointment.TestAppointmentID);
                    if (RetestService!=null)
                    {
                        lblRTestAppID.Text = RetestService.ApplicationID.ToString();
                        lblRAppFess.Text = lblRAppFess.Text = clsApplicationTypeBSL.FindApplicationType(10).ApplicationFees.ToString();

                        
                    }
                }
                decimal applicationFees = 0;
                decimal retakeAppFees = 0;


                decimal.TryParse(lblApplicationFees.Text, out applicationFees);


                decimal.TryParse(lblRAppFess.Text, out retakeAppFees);

                lblTotalmoneyFees.Text = (applicationFees + retakeAppFees).ToString();

            }



        }


        private bool AddRetestServiceData()
        {
            RetestService.TestAppointmentID = TestAppointment.TestAppointmentID;
            RetestService.ApplicationID = Application.ApplicationID;
            RetestService.CreatedByUserID = clsCurrentUser.CurrentID;

            if(RetestService.Save())
            {
                _RetestID = RetestService.ApplicationID;
                return true;
            }
               
            else
                return false;
        }

        private void Schedule_Test_Form_Load(object sender, EventArgs e)
        {
            TestAppointmentType();
            _LoadData();
            if (_isRetest && Mode == enMode.AddNew)
            {
                gbRetakeTestInfo.Enabled = true;
                lblRAppFess.Text = clsApplicationTypeBSL.FindApplicationType(10).ApplicationFees.ToString();

                gbScheduleTest.Text = "Retake " + gbScheduleTest.Text;
                lblModer.Text = "Schedule Retake Test";

                decimal applicationFees = 0;
                decimal retakeAppFees = 0;
                decimal.TryParse(lblApplicationFees.Text, out applicationFees);
                decimal.TryParse(lblRAppFess.Text, out retakeAppFees);

                lblTotalmoneyFees.Text = (applicationFees + retakeAppFees).ToString();


            }
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            

            TestAppointment.TestTypeID = (int)TestType;
            TestAppointment.LocalDrivingLicenseApplicationID = _LDLAID;
            TestAppointment.AppointmentDate = dtpScheduleTest.Value;
            TestAppointment.PaidFees = decimal.Parse(lblApplicationFees.Text);
            TestAppointment.CreatedByUserID = clsCurrentUser.CurrentID;
            TestAppointment.IsLocked = false;

           if(Mode == enMode.AddNew)
            {
                if (_isRetest)
                {
                    Application.ApplicantPersonID = _PersonID;
                    Application.ApplicationDate = DateTime.Now;
                    Application.ApplicationTypeID = 10;
                    Application.ApplicationStatus = 3;
                    Application.LastStatusDate = DateTime.Now;
                    Application.PaidFees = clsApplicationTypeBSL.FindApplicationType(10).ApplicationFees;
                    Application.CreatedByUserID = clsCurrentUser.CurrentID;

                    if (!Application.Save())
                    {
                        MessageBox.Show($"TestAppointment Add Failed Because Add Retest Service Application ", "TestAppointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        return;
                    }


                   


                }
            }
                
            
            

            if (TestAppointment.Save() )
            {
                MessageBox.Show($"TestAppointment Data Add Successfully", "TestAppointment", MessageBoxButtons.OK, MessageBoxIcon.Question);

                if (Mode == enMode.AddNew)
                {
                    if (_isRetest)
                    {
                        AddRetestServiceData();
                    }
                }

                lblRTestAppID.Text = _RetestID.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show($"TestAppointment Add Failed ", "TestAppointment", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class Take_Test_Form : Form
    {

       public int _LDLAID { get; set; }

        public enum enTestType { VisionTest = 1, WrittenTest = 2, PracrticalTest = 3 };
        public enTestType TestType;


        public int TestAppointmentID {  get; set; }

        public bool TestPassed { get; private set; } = false;

        public Take_Test_Form()
        {
            InitializeComponent();
        }

        private void TestAppointmentType()
        {
            switch (TestType)
            {
                case enTestType.VisionTest:
                    pbScheduleTest.Image = Properties.Resources.eye_scan;
                    gbTest.Text = "Vision Test";
                    break;
                case enTestType.WrittenTest:
                    pbScheduleTest.Image = Properties.Resources.notes;
                    gbTest.Text = "Written Test";
                    break;
                case enTestType.PracrticalTest:
                    pbScheduleTest.Image = Properties.Resources.driving_test;
                    gbTest.Text = "Pracrtical Test";
                    break;

            }
        }


        private void GetTestInfo()
        {
            clsLocalDrivingLicenseApplications_View LDLA = clsLDLABSL.FindLDLAToTest(_LDLAID);

            if (LDLA.LocalDrivingLicenseApplicationID != -1)
            {
                lblLDLAID.Text = LDLA.LocalDrivingLicenseApplicationID.ToString();
                lblLicencseClass.Text = LDLA.ClassName;
                lblName.Text = LDLA.FullName;
                lblTrail.Text = Convert.ToString(clsTestAppointmentBSL.TrailTest((int)TestType, _LDLAID));
            }
            else
            {
                MessageBox.Show($"Can not Find This ID = {_LDLAID}", "Not Find", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsTestAppointmentBSL TestAppointment = clsTestAppointmentBSL.FindAppointmentByAppointmentID(TestAppointmentID);
            if(TestAppointment!=null)
            {
                lblDate.Text= TestAppointment.AppointmentDate.ToString();
                lblApplicationFees.Text= TestAppointment.PaidFees.ToString();
            }
           
        }

        private void Take_Test_Form_Load(object sender, EventArgs e)
        {
            TestAppointmentType();
            GetTestInfo();
        }

        private bool UpdateAppointmentToLockTrue()
        {
            clsTestAppointmentBSL Appoinment = clsTestAppointmentBSL.FindAppointmentByAppointmentID(TestAppointmentID);

            if(Appoinment!=null)
            {
                Appoinment.IsLocked = true;
            }
            else
                return false;


                return Appoinment.Save();
        }

        private void SaveData()
        {
            clsTestBSL Test = new clsTestBSL();

            Test.TestAppointmentID = TestAppointmentID;


            if(rbFail.Checked)
                 Test.TestResult = false;
            else if(rbPass.Checked)
                 Test.TestResult = true;
            else
            {
                 MessageBox.Show($"Please Choose Result Pass Or Failed", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
            }

            Test.Notes = txtNotes.Text;
            Test.CreatedByUserID = clsCurrentUser.CurrentID;

            

            if (Test.Save()&& UpdateAppointmentToLockTrue())
            {
                MessageBox.Show($"Data Save Successfully", "Test", MessageBoxButtons.OK, MessageBoxIcon.Question);
                lblTestID.Text = Test.TestID.ToString();


                if (rbPass.Checked)
                {
                    this.TestPassed = true;
                }
                this.Close();
                
            }
            else
            {
                MessageBox.Show($"Data Save Failed", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

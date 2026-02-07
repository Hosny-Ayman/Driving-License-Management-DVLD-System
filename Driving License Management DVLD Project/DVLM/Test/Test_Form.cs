using DVLD___Business_Layer;
using Guna.UI2.WinForms;
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
    public partial class Test_Form : Form
    {

        public enum enTestType { VisionTest = 1, WrittenTest = 2, PracticalTest = 3 };

        public enTestType Type;

        public bool IsHePassTheTestToDisplayAddAppointment { get; set; } = false;

        private DateTime? LasAppintmentsDate { get; set; } = null;

        public int PersondID {get; set; }

        public Test_Form()
        {
            InitializeComponent();
        }

        public int LDLAID { get; set; }
        public int ApplicationID { get; set; }

        private void Test_Form_Load(object sender, EventArgs e)
        {
            ctrlScheduleTestInformation1.GetDrivingLicenseApplicationInfo(LDLAID);
            ctrlScheduleTestInformation1.ApplicationBasicInfo(ApplicationID);

             PersondID = ctrlScheduleTestInformation1.PersonID;


            TestType(Type);

            LastAppointmentsDate();





        }


        private void LastAppointmentsDate()
        {
            if(dgvalllTestAppointments.Rows.Count>0)
            {
                try
                {
                    int LastRowIndex = dgvalllTestAppointments.Rows.Count - 2;

                    if(!dgvalllTestAppointments.AllowUserToAddRows)
                    {
                        LastRowIndex = dgvalllTestAppointments.Rows.Count - 1;
                    }

                    if(LastRowIndex>=0)
                    {
                        DataGridViewRow LastRow = dgvalllTestAppointments.Rows[LastRowIndex];

                        object cellvalue = LastRow.Cells["AppointmentDate"].Value;

                        if(cellvalue!=null&& cellvalue!=DBNull.Value)
                        {
                            LasAppintmentsDate = Convert.ToDateTime(cellvalue);
                        }
                    }

                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void TestType(enTestType Type)
        {


            switch (Type)
            {

                case enTestType.VisionTest:
                    dgvalllTestAppointments.DataSource = clsTestAppointmentBSL.Appointments((int)enTestType.VisionTest, LDLAID);
                    pbTest.Image = Properties.Resources.eye_scan;
                    lblTestName.Text = "Vision Test Appointments";
                    lblTestName.ForeColor = Color.Green;
                    break;
                case enTestType.WrittenTest:
                    dgvalllTestAppointments.DataSource = clsTestAppointmentBSL.Appointments((int)enTestType.WrittenTest, LDLAID);
                    pbTest.Image = Properties.Resources.notes;
                    lblTestName.Text = "Written Test Appointments";
                    lblTestName.ForeColor = Color.Blue;
                    break;
                case enTestType.PracticalTest:
                    dgvalllTestAppointments.DataSource = clsTestAppointmentBSL.Appointments((int)enTestType.PracticalTest, LDLAID);
                    pbTest.Image = Properties.Resources.driving_test;
                    lblTestName.Text = "Practical Test Appointments";
                    lblTestName.ForeColor = Color.Red;
                    break;

            }
        }

        private bool CanHeCreateAnewTestAppointment()
        {
            if(dgvalllTestAppointments.Rows.Count==0)
            {
                return true;
            }

           

            try
            {

                foreach(DataGridViewRow row in dgvalllTestAppointments.Rows)
                {
                    if (row.IsNewRow) continue;


                    if (row.Cells["IsLocked"].Value==null)
                    {
                        return false;   
                    }

                    bool IsLocked = Convert.ToBoolean(row.Cells["IsLocked"].Value);

                    if(!IsLocked)
                    {
                        return false;
                    }
                }

                return true;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Wrong" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if(!CanHeCreateAnewTestAppointment())
            {
                MessageBox.Show("You Have Already Test Appointment You Can't Add One More", "Test Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsHePassTheTestToDisplayAddAppointment)
            {
                MessageBox.Show("He alreadey Pass the Test You Can not Add Appointment", "Add Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool isRetest = (dgvalllTestAppointments.Rows.Count > 0);


                Schedule_Test_Form Schedule = new Schedule_Test_Form(LDLAID, isRetest, PersondID);

                LastAppointmentsDate();

                Schedule.LasAppintmentsDate = LasAppintmentsDate;

                Schedule.TestType = (Schedule_Test_Form.enTestType)Type;
                Schedule.Mode = Schedule_Test_Form.enMode.AddNew;

               
               


                Schedule.ShowDialog();

                TestType(Type);
               

            }
        }

        private void cmsEditTestAppointment_Click(object sender, EventArgs e)
        {


            if (dgvalllTestAppointments.CurrentRow != null && !Convert.ToBoolean(dgvalllTestAppointments.CurrentRow.Cells["IsLocked"].Value))
            {
                string AppointmentID_Test = dgvalllTestAppointments.CurrentRow.Cells["TestAppointmentID"].Value.ToString();

                if(int.TryParse(AppointmentID_Test,out int AppointmentID))
                {
                    bool isRetest = (dgvalllTestAppointments.Rows.Count > 0);

                  
                    Schedule_Test_Form Schedule = new Schedule_Test_Form(LDLAID, isRetest, PersondID);
                    Schedule.Mode = Schedule_Test_Form.enMode.Update;
                    Schedule.AppointmenID = AppointmentID;

                    Schedule.TestType = (Schedule_Test_Form.enTestType)Type;

                    Schedule.ShowDialog();

                    TestType(Type);
                }
                else
                    MessageBox.Show("AppointmentID_Test TryParse Failed", "Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("You Cant Update Locked Appointment", "Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void cmsTakeTest_Click(object sender, EventArgs e)
        {

            if (dgvalllTestAppointments.CurrentRow != null && !Convert.ToBoolean(dgvalllTestAppointments.CurrentRow.Cells["IsLocked"].Value))
            {
                string AppointmentID_Test = dgvalllTestAppointments.CurrentRow.Cells["TestAppointmentID"].Value.ToString();

                if (int.TryParse(AppointmentID_Test, out int AppointmentID))
                {
                    Take_Test_Form frm = new Take_Test_Form();

                    

                    frm.TestAppointmentID = AppointmentID;
                    frm._LDLAID = LDLAID;
                    frm.TestType = (Take_Test_Form.enTestType)this.Type;
                    frm.ShowDialog();

                    if (frm.TestPassed)
                    {
                       
                        IsHePassTheTestToDisplayAddAppointment = true;
                    }

                    TestType(Type);
                    ctrlScheduleTestInformation1.GetDrivingLicenseApplicationInfo(LDLAID);

                   

                }

            }
            else
            {
                MessageBox.Show("You Cant Update Locked Appointment", "Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        
    }
}

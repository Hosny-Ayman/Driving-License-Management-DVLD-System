using DVLD___Business_Layer;
using DVLM.Driver;
using DVLM.License;
using DVLM.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLM.Local_Driving_License_Applications
{
    public partial class Local_Driving_License_Applications_Form : Form
    {
        public Local_Driving_License_Applications_Form()
        {
            InitializeComponent();
        }

        private int _rightClickedRowIndex = -1;



        DataTable OrginalData = new DataTable();

        public void GetAllData()
        {
            OrginalData = clsLDLABSL.GetAllLocalDrivingLicenseApplications();
            gridvLDLA.DataSource = OrginalData;

            lblNumberOfLDLA.Text = gridvLDLA.Rows.Count.ToString();
        }

        private void GrideViewSetting()
        {
            gridvLDLA.Columns["LocalDrivingLicenseApplicationID"].HeaderText = "Local Driving License Application ID";
            gridvLDLA.Columns["ClassName"].HeaderText = "Class Name";
            gridvLDLA.Columns["NationalNo"].HeaderText = "National No";
            gridvLDLA.Columns["FullName"].HeaderText = "Full Name";
            gridvLDLA.Columns["ApplicationDate"].HeaderText = "Application Date";
            gridvLDLA.Columns["PassedTestCount"].HeaderText = "Passed Test Count";
            gridvLDLA.Columns["Status"].HeaderText = "Status";

            gridvLDLA.Columns["ClassName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gridvLDLA.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            this.gridvLDLA.Columns["ApplicationDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }


        private void LDLASettings()
        {
            GetAllData();

            GrideViewSetting();

            GetDataToFilter();

        }

        private void Local_Driving_License_Applications_Form_Load(object sender, EventArgs e)
        {
            LDLASettings();
        }

        private void GetDataToFilter()
        {
            cbFilterLDLA.Items.Clear();

            cbFilterLDLA.Items.Add("None");

            foreach(DataColumn column in OrginalData.Columns)
            {
                if (column.ColumnName != "ApplicationDate")
                    cbFilterLDLA.Items.Add(column.ColumnName);
            }

            cbFilterLDLA.SelectedIndex = 0;
        }

        private void txtSearchLDLA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterLDLA.Text== "LocalDrivingLicenseApplicationID"|| cbFilterLDLA.Text== "PassedTestCount")
            {
                if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cbFilterLDLA_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilterLDLA.Text == "None")
                txtSearchLDLA.Visible = false;
            else
                txtSearchLDLA.Visible = true;


                txtSearchLDLA.Text = "";

        }

        private void FilterDate()
        {
            if (cbFilterLDLA.SelectedItem == null)
            {

                return;
            }
            

            DataView dv = OrginalData.DefaultView;

            if (cbFilterLDLA.SelectedItem.ToString() == "None" || String.IsNullOrEmpty(txtSearchLDLA.Text))
            {
                dv.RowFilter = "";
                return;
            }


            string SelectedItem = cbFilterLDLA.SelectedItem.ToString();

            string SearchValue = txtSearchLDLA.Text;


            Type type = OrginalData.Columns[SelectedItem].DataType;

            if(type==typeof(string))
            {
                dv.RowFilter = string.Format("[{0}] Like '%{1}%'", SelectedItem, SearchValue);
            }
            else

            {
                dv.RowFilter = string.Format("Convert([{0}],'System.String') Like '%{1}%'", SelectedItem, SearchValue);
            }

        }

        private void txtSearchLDLA_TextChanged(object sender, EventArgs e)
        {
            FilterDate();
        }

       
        private void _UpdateContextMenuItemsState(int passedTestCount, string status)
        {
            cmsEditApplication.Enabled = false;
            cmsDeleteApplication.Enabled = false;
            cmsCancelApplication.Enabled = false;
            cmsIssueDrivingLicenseFirstTime.Enabled = false;
            cmsShowLicense.Enabled = false;

           
            cmsscheduletest.Enabled = false;
            tsmScheduleVisionTest.Enabled = false;
            tsmScheduleWrittenTest.Enabled = false;
            tsmScheduleStreetTest.Enabled = false;

            switch(status)
            {
                case "New":
                    
                    cmsCancelApplication.Enabled = true;
                    cmsscheduletest.Enabled = true;
                    
                    switch(passedTestCount)
                    {
                        case 0:
                            cmsDeleteApplication.Enabled = true; 
                            tsmScheduleVisionTest.Enabled = true;
                            cmsEditApplication.Enabled = true;
                            break;
                        case 1:
                            tsmScheduleWrittenTest.Enabled = true;
                            break;
                        case 2:
                            tsmScheduleStreetTest.Enabled = true;
                            break;
                            case 3:
                            cmsIssueDrivingLicenseFirstTime.Enabled = true;
                            cmsscheduletest.Enabled = false; 
                            break;
                    }
                    break;
                case "Completed":
                    cmsShowLicense.Enabled = true;
                    break;
            }

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (_rightClickedRowIndex == -1)
            {
                e.Cancel = true; 
                return;
            }



            string status = Convert.ToString(gridvLDLA.Rows[_rightClickedRowIndex].Cells[6].Value);
            string PssedTest_Text = Convert.ToString(gridvLDLA.Rows[_rightClickedRowIndex].Cells[5].Value);

            if (int.TryParse(PssedTest_Text,out int PassetTest))
            {
                _UpdateContextMenuItemsState(PassetTest, status);
            }

        }

        private void gridvLDLA_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                if(e.RowIndex>-1)
                {
                    _rightClickedRowIndex = e.RowIndex;
                    gridvLDLA.ClearSelection();
                    gridvLDLA.Rows[e.RowIndex].Selected = true;
                }
                else
                {
                    _rightClickedRowIndex = -1;
                }
            }
        }

        private void ScheduleTest(Test_Form.enTestType testType)
        {
           
            if (gridvLDLA.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

           
            string LDLA_Text = gridvLDLA.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value.ToString();
            if (!int.TryParse(LDLA_Text, out int localApplicationID))
            {
                MessageBox.Show("The selected application has an invalid ID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

           
            clsLDLABSL LDLA = clsLDLABSL.FindLDLA(localApplicationID);
            if (LDLA == null)
            {
                MessageBox.Show("Can not Find The Application", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            
            Test_Form frm = new Test_Form();
            frm.LDLAID = LDLA.LDLAID;
            frm.ApplicationID = LDLA.ApplicationID;

            
            frm.Type = testType;

            frm.ShowDialog();

            
            GetAllData();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleTest(Test_Form.enTestType.VisionTest);
        }


        private void tsmScheduleWrittenTest_Click(object sender, EventArgs e)
        {
            ScheduleTest(Test_Form.enTestType.WrittenTest);
        }

       

        private void tsmScheduleStreetTest_Click(object sender, EventArgs e)
        {
            ScheduleTest(Test_Form.enTestType.PracticalTest);
        }


        private void cmsCancelApplication_Click(object sender, EventArgs e)
        {
            if (gridvLDLA.CurrentRow != null)
            {
                string LDLAID_Test = gridvLDLA.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value.ToString();

                if (int.TryParse(LDLAID_Test, out int LocalApplication))
                {
                    clsLDLABSL LDLA = clsLDLABSL.FindLDLA(LocalApplication);

                    if (LDLA != null)
                    {
                        if (MessageBox.Show($"Are You Sure You Want To Cancell This Application With ID = {LocalApplication}", "Application Cancell", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (clsApplicationBSL.UpdateApplicationStatusToCancelled(LDLA.ApplicationID))
                            {
                                MessageBox.Show("Application Canclled Successfully", "Application Canclled", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                GetAllData();
                            }
                            else
                            {
                                MessageBox.Show("Application Canclled Failed", "Application Canclled", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can not Find The Application", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("The selected application has an invalid ID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Please Choose A Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void cmsIssueDrivingLicenseFirstTime_Click(object sender, EventArgs e)
        {
            if (gridvLDLA.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string LDLA_Text = gridvLDLA.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value.ToString();
            if (!int.TryParse(LDLA_Text, out int localApplicationID))
            {
                MessageBox.Show("The selected application has an invalid ID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            clsLDLABSL LDLA = clsLDLABSL.FindLDLA(localApplicationID);
            if (LDLA == null)
            {
                MessageBox.Show("Can not Find The Application", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Issue_Driver_Licenes_For_The_First_Time_Form frm = new Issue_Driver_Licenes_For_The_First_Time_Form();
            

            frm.LDLApp = LDLA;

            frm.ShowDialog();

            GetAllData();

        }

        private void cmsShowLicense_Click(object sender, EventArgs e)
        {
            if (gridvLDLA.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string LDLA_Text = gridvLDLA.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value.ToString();
            if (!int.TryParse(LDLA_Text, out int localApplicationID))
            {
                MessageBox.Show("The selected application has an invalid ID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int LicesneID = clsLicenseBSL.GetLicenseIDByLDLAID(localApplicationID);
            if (LicesneID == -1)
            {
                MessageBox.Show("Can not Find The Application", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Driver_Licenes_Form frm = new Driver_Licenes_Form();


            frm.LicenseID = LicesneID;

            frm.ShowDialog();
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridvLDLA.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string NationalNo_Text = gridvLDLA.CurrentRow.Cells["NationalNo"].Value.ToString();
            


            clsPersonBSL Person = clsPersonBSL.FindPersonByNationalNo(NationalNo_Text);
            if (Person == null)
            {
                MessageBox.Show("Can not Find The Application", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            License_History_Form frm = new License_History_Form();


            frm.PersonID = Person.ID;

            frm.ShowDialog();
        }

        private void btnAddNewLDLA_Click(object sender, EventArgs e)
        {

            New_Driving_License_Applications_Form frm6 = new New_Driving_License_Applications_Form(New_Driving_License_Applications_Form.enMode.AddNew);

            frm6.ShowDialog();
            GetAllData();


        }

        private void cmsEditApplication_Click(object sender, EventArgs e)
        {
            if (gridvLDLA.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string NationalNo_Text = gridvLDLA.CurrentRow.Cells["NationalNo"].Value.ToString();


            clsPersonBSL Person = clsPersonBSL.FindPersonByNationalNo(NationalNo_Text);

            if (Person == null)
            {
                MessageBox.Show("Can not Find The Application", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string LDLA_Text = gridvLDLA.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value.ToString();

            if (!int.TryParse(LDLA_Text, out int localApplicationID))
            {
                MessageBox.Show("The selected application has an invalid ID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsLDLABSL LDLA = clsLDLABSL.FindLDLA(localApplicationID);

            if (LDLA == null)
            {
                MessageBox.Show("Can not Find The Application", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            New_Driving_License_Applications_Form frm = new New_Driving_License_Applications_Form(New_Driving_License_Applications_Form.enMode.Update);

            frm._PersonID = Person.ID;
            frm.LDLA = LDLA;

            frm.ShowDialog();

            GetAllData();
        }

        private void cmsDeleteApplication_Click(object sender, EventArgs e)
        {
            if (gridvLDLA.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string LDLA_Text = gridvLDLA.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value.ToString();
            if (!int.TryParse(LDLA_Text, out int localApplicationID))
            {
                MessageBox.Show("The selected application has an invalid ID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            clsLDLABSL LDLA = clsLDLABSL.FindLDLA(localApplicationID);
            if (LDLA == null)
            {
                MessageBox.Show("Can not Find The Application", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(MessageBox.Show($"Are You Sure You Want To Delete This Application With ID = {LDLA.LDLAID}","Delete Application",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                if(clsLDLABSL.DeleteApplication(LDLA.LDLAID, LDLA.ApplicationID))
                {
                    MessageBox.Show("Delete Application Successfully", "Delete Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Application Failed", "Delete Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

            GetAllData();
        }

        private void cmsShowApplicationDetails_Click(object sender, EventArgs e)
        {
            if (gridvLDLA.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string LDLA_Text = gridvLDLA.CurrentRow.Cells["LocalDrivingLicenseApplicationID"].Value.ToString();
            if (!int.TryParse(LDLA_Text, out int localApplicationID))
            {
                MessageBox.Show("The selected application has an invalid ID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            clsLDLABSL LDLA = clsLDLABSL.FindLDLA(localApplicationID);
            if (LDLA == null)
            {
                MessageBox.Show("Can not Find The Application", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Application_Details_Form frm = new Application_Details_Form();


            frm.LDLAID = LDLA.LDLAID;

            frm.ShowDialog();
        }
    }
}

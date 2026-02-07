using DVLD___Business_Layer;
using DVLM.Driver;
using DVLM.International_License;
using DVLM.License;
using DVLM.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLM.Detain_License
{
    public partial class List_Detained_License_Form : Form
    {
        public List_Detained_License_Form()
        {
            InitializeComponent();
        }

        DataTable OrginalData = new DataTable();

        DataView dv;

        private void GteListDetainData()
        {
            OrginalData = clsDetainedLicenseBSL.GetAllDetainLicense();
            gridvListDetainLicense.DataSource = OrginalData;

            gridvListDetainLicense.Columns["DetainID"].HeaderText = "Detain ID";
            gridvListDetainLicense.Columns["LicenseID"].HeaderText = "License ID";
            gridvListDetainLicense.Columns["DetainDate"].HeaderText = "Detain Date";
            gridvListDetainLicense.Columns["IsReleased"].HeaderText = "Is Released";
            gridvListDetainLicense.Columns["FineFees"].HeaderText = "Fine Fees";
            gridvListDetainLicense.Columns["ReleaseDate"].HeaderText = "Release Date";
            gridvListDetainLicense.Columns["NationalNo"].HeaderText = "National No";
            gridvListDetainLicense.Columns["FullName"].HeaderText = "Fullname";
            gridvListDetainLicense.Columns["ReleaseApplicationID"].HeaderText = "ReleaseApplication ID";




            gridvListDetainLicense.Columns["ReleaseApplicationID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

           


            gridvListDetainLicense.Columns["DetainDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            gridvListDetainLicense.Columns["ReleaseDate"].DefaultCellStyle.Format = "dd/MM/yyyy";

            gridvListDetainLicense.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            lblLocalNumber.Text = gridvListDetainLicense.Rows.Count.ToString();


        }

        private void List_Detained_License_Form_Load(object sender, EventArgs e)
        {
            GteListDetainData();
            FillcbFilterData();
        }

        private void FillcbFilterData()
        {
            cbFilter.Items.Clear();

            cbFilter.Items.Add("None");

            foreach(DataColumn Column in OrginalData.Columns)
            {
                cbFilter.Items.Add(Column.ColumnName);
            }

            cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "None")
            {
                txtSearch.Visible = false;
            }
            else
            {
                txtSearch.Visible = true;
            }

            if(cbFilter.Text== "IsReleased")
            {
                cbIsActive.SelectedIndex = 0;
                cbIsActive.Visible = true;
                txtSearch.Visible = false;

            }
            else
            {
                dv = OrginalData.DefaultView;
                dv.RowFilter = "";
                cbIsActive.Visible = false;
            }

                txtSearch.Text = "";
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.Text== "DetainID"|| cbFilter.Text == "LicenseID" || cbFilter.Text == "FineFees" || cbFilter.Text == "ReleaseApplicationID")
            {
                if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(cbFilter.SelectedItem==null)
            {
                return;
            }

            dv = OrginalData.DefaultView;

            if(cbFilter.SelectedItem.ToString()=="None"||string.IsNullOrEmpty(txtSearch.Text))
            {
                dv.RowFilter = "";
                return;
            }

            string selectedColumn = cbFilter.SelectedItem.ToString();
            string SearchText = txtSearch.Text;

            Type type = OrginalData.Columns[selectedColumn].DataType;

            if(type==typeof(string))
            {
                dv.RowFilter = string.Format("[{0}] Like '%{1}%' ", selectedColumn, SearchText);

            }
            else
            {
                dv.RowFilter = string.Format("CONVERT([{0}], 'System.String') LIKE '%{1}%'", selectedColumn, SearchText);
            }

        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            dv = OrginalData.DefaultView;

            if(cbIsActive.Text=="All")
            {
                dv.RowFilter = "";
            }
            else if(cbIsActive.Text == "Yes")
            {
                dv.RowFilter = "[IsReleased]=true";
            }
            else if(cbIsActive.Text == "No")
            {
                dv.RowFilter = "[IsReleased]=false";
            }
           
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            Detain_License_Form frm = new Detain_License_Form();
            frm.ShowDialog();
            GteListDetainData();
        }

        private void btnReleas_Click(object sender, EventArgs e)
        {
            Released_Detained_License_Form frm = new Released_Detained_License_Form();
            frm.ShowDialog();
            GteListDetainData();
        }

        private void csmShowPersonDetails_Click(object sender, EventArgs e)
        {
            if(gridvListDetainLicense.CurrentRow==null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string NationalNo_Text = gridvListDetainLicense.CurrentRow.Cells["NationalNo"].Value.ToString();

            int PersonID = clsPersonBSL.FindPersonByNationalNo(NationalNo_Text).ID;

            if (PersonID == -1)
            {
                MessageBox.Show("Can not Find The PersonID", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Person_Details_Form frm = new Person_Details_Form(PersonID);




            frm.ShowDialog();
        }

        private void cmsShowLicenseDetails_Click(object sender, EventArgs e)
        {
            if (gridvListDetainLicense.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string LicenseID_Text = gridvListDetainLicense.CurrentRow.Cells["LicenseID"].Value.ToString();
            if (!int.TryParse(LicenseID_Text, out int LicenseID))
            {
                MessageBox.Show("The selected application has an invalid ID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Driver_Licenes_Form frm = new Driver_Licenes_Form();


            frm.LicenseID = LicenseID;

            frm.ShowDialog();
        }

        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            if (gridvListDetainLicense.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string NationalNo_Text = gridvListDetainLicense.CurrentRow.Cells["NationalNo"].Value.ToString();

            int PersonID = clsPersonBSL.FindPersonByNationalNo(NationalNo_Text).ID;

            if (PersonID == -1)
            {
                MessageBox.Show("Can not Find The PersonID", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            License_History_Form frm = new License_History_Form();


            frm.PersonID = PersonID;

            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (gridvListDetainLicense.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string LicenseID_Text = gridvListDetainLicense.CurrentRow.Cells["LicenseID"].Value.ToString();

            if (!int.TryParse(LicenseID_Text, out int LicenseID))
            {
                MessageBox.Show("The selected application has an invalid ID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(clsDetainedLicenseBSL.IsLicenseIDIsDetained(LicenseID))
            {
                cmsReleaseDetainedLicense.Enabled = true;
            }
            else
            {
                cmsReleaseDetainedLicense.Enabled = false;
            }
        }

        private void cmsReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            if (gridvListDetainLicense.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string LicenseID_Text = gridvListDetainLicense.CurrentRow.Cells["LicenseID"].Value.ToString();

            if (!int.TryParse(LicenseID_Text, out int LicenseID))
            {
                MessageBox.Show("The selected application has an invalid ID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Released_Detained_License_Form frm = new Released_Detained_License_Form();

            frm.SetGroupBoxVisibilityAndTextSearch(false, LicenseID, sender,e);

            frm.ShowDialog();

            GteListDetainData();

        }
    }
}

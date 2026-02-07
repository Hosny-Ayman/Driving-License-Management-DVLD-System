using DVLD___Business_Layer;
using DVLM.License;
using DVLM.Local_Driving_License_Applications;
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
using static System.Net.Mime.MediaTypeNames;

namespace DVLM.International_License
{
    public partial class International_License_Applications_Form : Form
    {
        public International_License_Applications_Form()
        {
            InitializeComponent();
        }

        DataTable OrojinalData = new DataTable();

        public void GetAllInternational()
        {
            OrojinalData = clsInternationalLicenseBSL.GetAlllInternationLicense();
            gridvInternationalLicense.DataSource = OrojinalData;

            gridvInternationalLicense.Columns["InternationalLicenseID"].HeaderText = "International License ID";
            gridvInternationalLicense.Columns["ApplicationID"].HeaderText = "Application ID";
            gridvInternationalLicense.Columns["DriverID"].HeaderText = "Driver ID";
            gridvInternationalLicense.Columns["IssuedUsingLocalLicenseID"].HeaderText = "Local License ID";
            gridvInternationalLicense.Columns["IssueDate"].HeaderText = "Issue Date";
            gridvInternationalLicense.Columns["ExpirationDate"].HeaderText = "Expiration Date";
            gridvInternationalLicense.Columns["IsActive"].HeaderText = "Is Active";

            gridvInternationalLicense.Columns["IssuedUsingLocalLicenseID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            gridvInternationalLicense.Columns["InternationalLicenseID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;



            gridvInternationalLicense.Columns["IssueDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            gridvInternationalLicense.Columns["ExpirationDate"].DefaultCellStyle.Format = "dd/MM/yyyy";


           

        }

        private void International_License_Applications_Form_Load(object sender, EventArgs e)
        {
            GetAllInternational();
            FillDatacbFilter();
            cbIsActive.SelectedIndex = 0;
        }


        //private string AddSpacesToWords(string text)
        //{
        //    if (string.IsNullOrEmpty(text))
        //        return "";

        //    StringBuilder newText = new StringBuilder();

        //    newText.Append(text[0]);

        //    for (int i = 1; i < text.Length; i++)
        //    {
        //        if (char.IsUpper(text[i])&&)
        //        {
        //            newText.Append(' ');
        //        }

        //        newText.Append(text[i]);
        //    }

        //    return newText.ToString();

        //}


        private void FillDatacbFilter()
        {
            cbFilter.Items.Clear();

            cbFilter.Items.Add("None");

            foreach(DataColumn Column in OrojinalData.Columns)
            {
                if (Column.ColumnName == "IssuedUsingLocalLicenseID")
                    cbFilter.Items.Add("Local License ID");
                else
                    cbFilter.Items.Add(Column.ColumnName);

            }

            cbFilter.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          if(cbFilter.SelectedItem==null)
            {
                return;
            }


            DataView dv = OrojinalData.DefaultView;

            if(cbFilter.SelectedItem.ToString()=="None"||string.IsNullOrEmpty(txtSearch.Text))
            {
                dv.RowFilter = "";
                return;
            }

            string searchValue = txtSearch.Text.Trim();
            string selectedColumnDisplayName = cbFilter.SelectedItem.ToString();
            string actualColumnName = selectedColumnDisplayName; 
           
            if (actualColumnName == "Local License ID")
            {
                actualColumnName = "IssuedUsingLocalLicenseID";
            }

            
            Type columnType = OrojinalData.Columns[actualColumnName].DataType;

            if (columnType == typeof(string))
            {
                dv.RowFilter = string.Format("[{0}] LIKE '%{1}%'", actualColumnName, searchValue);
            }
            else
            {
                dv.RowFilter = string.Format("CONVERT([{0}], 'System.String') LIKE '%{1}%'", actualColumnName, searchValue);
            }

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "None")
                txtSearch.Visible = false;
            else
                txtSearch.Visible = true;


            txtSearch.Text = "";

            if(cbFilter.Text == "IsActive")
            {
                cbIsActive.Visible = true;
                txtSearch.Visible = false;
            }
            else
            {
                cbIsActive.Visible = false;
               
            }
               

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string selectedColumnDisplayName = cbFilter.SelectedItem.ToString();
            string actualColumnName = (selectedColumnDisplayName == "Local License ID")? "IssuedUsingLocalLicenseID": selectedColumnDisplayName;

           
            if (actualColumnName == "InternationalLicenseID" || actualColumnName == "ApplicationID"
             || actualColumnName == "DriverID" || actualColumnName == "IssuedUsingLocalLicenseID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void IsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dataView = OrojinalData.DefaultView;

            if(cbIsActive.Text=="All")
            {
                dataView.RowFilter = "";
            }
            else if(cbIsActive.Text == "Yes")
            {
                dataView.RowFilter = "[IsActive]=true";
            }
            else if (cbIsActive.Text == "No")
            {
                dataView.RowFilter = "[IsActive]=false";
            }
        }

        private void btnAddNewInternationalApplicationLicense_Click(object sender, EventArgs e)
        {
            New_International_License_Application_Form frm = new New_International_License_Application_Form();
            frm.ShowDialog();
            GetAllInternational();
        }

        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            if (gridvInternationalLicense.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string InternationalID_Text = gridvInternationalLicense.CurrentRow.Cells["InternationalLicenseID"].Value.ToString();
            if (!int.TryParse(InternationalID_Text, out int InternationalID))
            {
                MessageBox.Show("The selected application has an invalid ID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int PersonID = clsInternationalLicenseBSL.GetPerosnIDByInternationalID(InternationalID);
            if (PersonID == -1)
            {
                MessageBox.Show("Can not Find The PersonID", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            License_History_Form frm = new License_History_Form();


            frm.PersonID = PersonID;

            frm.ShowDialog();
        }

        private void cmsShowLicenseDetails_Click(object sender, EventArgs e)
        {
            if (gridvInternationalLicense.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string InternationalID_Text = gridvInternationalLicense.CurrentRow.Cells["InternationalLicenseID"].Value.ToString();
            if (!int.TryParse(InternationalID_Text, out int InternationalID))
            {
                MessageBox.Show("The selected application has an invalid ID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            International_Driver_Info_Form frm = new International_Driver_Info_Form();


            frm.InternationalLicenseID = InternationalID;

            frm.ShowDialog();

        }

        private void csmShowPersonDetails_Click(object sender, EventArgs e)
        {
            if (gridvInternationalLicense.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string InternationalID_Text = gridvInternationalLicense.CurrentRow.Cells["InternationalLicenseID"].Value.ToString();
            if (!int.TryParse(InternationalID_Text, out int InternationalID))
            {
                MessageBox.Show("The selected application has an invalid ID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int PersonID = clsInternationalLicenseBSL.GetPerosnIDByInternationalID(InternationalID);
            if (PersonID == -1)
            {
                MessageBox.Show("Can not Find The PersonID", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Person_Details_Form frm = new Person_Details_Form(PersonID);


            

            frm.ShowDialog();
        }
    }
}

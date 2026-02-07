using DVLD___Business_Layer;
using DVLM.Driver;
using DVLM.International_License;
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
    public partial class ctrlLicenseHistory : UserControl
    {
        public ctrlLicenseHistory()
        {
            InitializeComponent();

            
            this.dgvLocls.ThemeStyle.HeaderStyle.Height = 35;

            
            this.dgvLocls.ThemeStyle.RowsStyle.Height = 28;

            
            this.dgvInternationale.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvInternationale.ThemeStyle.RowsStyle.Height = 28;
        }

       public void GetLocalLicenseHistory(int PersonID)
        {
            dgvLocls.DataSource = clsLDLABSL.LocalLicensesHistory(PersonID);

            if (dgvLocls != null && dgvLocls.Rows.Count > 0)
            {


                dgvLocls.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvLocls.Columns["ClassName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;




                dgvLocls.Columns["LicenseID"].HeaderText = "License ID";
                dgvLocls.Columns["ApplicationID"].HeaderText = "Application ID";
                dgvLocls.Columns["ClassName"].HeaderText = "Class Name";
                dgvLocls.Columns["IssueDate"].HeaderText = "Issue Date";
                dgvLocls.Columns["ExpirationDate"].HeaderText = "Expiration Date";
                dgvLocls.Columns["IsActive"].HeaderText = "Is Active";

                dgvLocls.Columns["ExpirationDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvLocls.Columns["IssueDate"].DefaultCellStyle.Format = "dd/MM/yyyy";




                lblLocalNumber.Text = dgvLocls.Rows.Count.ToString();
            }
            else
            {
                dgvLocls.DataSource = null;
                lblLocalRecord.Text = "0";
            }




        }


        public void GetInternationalLicenseHistory(int PersonID)
        {
            dgvInternationale.DataSource = clsInternationalLicenseBSL.InternationalLicensesHistory(PersonID);

            if (dgvInternationale != null && dgvInternationale.Rows.Count > 0)
            {



                dgvInternationale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvInternationale.Columns["InternationalLicenseID"].HeaderText = "InternationalLicense ID";
                dgvInternationale.Columns["ApplicationID"].HeaderText = "Application ID";
                dgvInternationale.Columns["IssuedUsingLocalLicenseID"].HeaderText = "Local License ID";
                dgvInternationale.Columns["IssueDate"].HeaderText = "Issue Date";
                dgvInternationale.Columns["ExpirationDate"].HeaderText = "Expiration Date";
                dgvInternationale.Columns["IsActive"].HeaderText = "Is Active";

                dgvInternationale.Columns["InternationalLicenseID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dgvInternationale.Columns["IssuedUsingLocalLicenseID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                dgvInternationale.Columns["ExpirationDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvInternationale.Columns["IssueDate"].DefaultCellStyle.Format = "dd/MM/yyyy";



                lblInternationalRecord.Text = dgvInternationale.Rows.Count.ToString();
            }
            else
            {

                dgvInternationale.DataSource = null;
                lblInternationalRecord.Text = "0";
            }



        }

        private void cmsShowLicenseDetails_Click(object sender, EventArgs e)
        {
            if (dgvLocls.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string LocalLicenseID_Text = dgvLocls.CurrentRow.Cells["LicenseID"].Value.ToString();
            if (!int.TryParse(LocalLicenseID_Text, out int LocalLicenseID))
            {
                MessageBox.Show("The selected application has an invalid ID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Driver_Licenes_Form frm = new Driver_Licenes_Form();


            frm.LicenseID = LocalLicenseID;

            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvInternationale.CurrentRow == null)
            {
                MessageBox.Show("Please Choose An Application First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string InternationalID_Text = dgvInternationale.CurrentRow.Cells["InternationalLicenseID"].Value.ToString();
            if (!int.TryParse(InternationalID_Text, out int InternationalID))
            {
                MessageBox.Show("The selected application has an invalid ID.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            International_Driver_Info_Form frm = new International_Driver_Info_Form();


            frm.InternationalLicenseID = InternationalID;

            frm.ShowDialog();
        }
    }
}

using DVLD___Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLM.Mange_Application_Type
{
    public partial class Edit_Application_Type_Form : Form
    {

        

        public Edit_Application_Type_Form()
        {
            InitializeComponent();
        }

        public int ApplicationTypeID;
        clsApplicationTypeBSL ApplicationType;

        private void GetApplicationTypeInformation()
        {
            ApplicationType = clsApplicationTypeBSL.FindApplicationType(ApplicationTypeID);

            if (ApplicationType != null)
            {
                lblID.Text = ApplicationType.ApplicationTypeID.ToString();
                txtTitle.Text = ApplicationType.ApplicationTypeTitle;
                txtFees.Text = ApplicationType.ApplicationFees.ToString();


            }
            else
                MessageBox.Show("Application Type Not Found", "Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Edit_Application_Type_Form_Load(object sender, EventArgs e)
        {
            GetApplicationTypeInformation();
        }

        private bool CheckEmptyTextBox()
        {
            if (!string.IsNullOrEmpty(txtTitle.Text) && !string.IsNullOrEmpty(txtFees.Text))
                return true;
            else
                return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyTextBox())
            {
                MessageBox.Show("Please Enter All Data", "Data Miss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
               

            ApplicationType.ApplicationTypeTitle = txtTitle.Text;

            if(decimal.TryParse(txtFees.Text,out decimal Fees))
            {
                ApplicationType.ApplicationFees = Fees;
            }
            else
            {
                MessageBox.Show("Application Type Saved Failed", "Application Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (ApplicationType.Save())
            {
                MessageBox.Show("Application Type Saved Successfully", "Application Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
                MessageBox.Show("Application Type Saved Failed", "Application Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

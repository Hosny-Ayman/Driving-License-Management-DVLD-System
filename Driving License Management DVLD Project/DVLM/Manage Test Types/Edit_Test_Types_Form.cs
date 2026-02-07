using DVLD___Business_Layer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLM.Manage_Test_Types
{
    public partial class Edit_Test_Types_Form : Form
    {
        public Edit_Test_Types_Form()
        {
            InitializeComponent();
        }

        public int TestTypeID;
        clsTestTypeBSL TestType;

        private void GetTestTypeInformation()
        {
            TestType = clsTestTypeBSL.FindApplicationType(TestTypeID);

            if (TestType != null)
            {
                lblID.Text = TestType.TestTypeID.ToString();
                txtTitle.Text = TestType.TestTypeTitle;
                guna2TextBox1.Text = TestType.TestTypeDescription;
                txtFees.Text = TestType.TestTypeFees.ToString();


            }
            else
                MessageBox.Show("Test Type Not Found", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Edit_Test_Types_Form_Load(object sender, EventArgs e)
        {
            GetTestTypeInformation();
        }

        private bool CheckEmptyTextBox()
        {
            if (!string.IsNullOrEmpty(txtTitle.Text) && !string.IsNullOrEmpty(txtFees.Text) && !string.IsNullOrEmpty(guna2TextBox1.Text))
                return true;
            else
                return false;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!CheckEmptyTextBox())
            {
                MessageBox.Show("Please Enter All Data", "Data Miss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            TestType.TestTypeTitle = txtTitle.Text;
            TestType.TestTypeDescription = guna2TextBox1.Text;

            if (decimal.TryParse(txtFees.Text, out decimal Fees))
            {
                TestType.TestTypeFees = Fees;
            }
            else
            {
                MessageBox.Show("Test Type Saved Failed", "Test Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (TestType.Save())
            {
                MessageBox.Show("Test Type Saved Successfully", "Application Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
                MessageBox.Show("Test Type Saved Failed", "Application Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFees_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

using DVLD___Business_Layer;
using DVLM.Mange_Application_Type;
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
    public partial class Manage_Test_Types_Form : Form
    {
        public Manage_Test_Types_Form()
        {
            InitializeComponent();
        }

        private void TestTypeSettings()
        {
            gridvTestTypes.DataSource = clsTestTypeBSL.GetAllTestType();


            gridvTestTypes.Columns["TestTypeID"].HeaderText = "Test Type ID";
            gridvTestTypes.Columns["TestTypeTitle"].HeaderText = "Application Type Title";
            gridvTestTypes.Columns["TestTypeDescription"].HeaderText = "Test Type Description";
            gridvTestTypes.Columns["TestTypeFees"].HeaderText = "Test Type Fees";

            

            lblNumberOfTestTypes.Text = gridvTestTypes.Rows.Count.ToString();
        }
        private void Manage_Test_Types_Form_Load(object sender, EventArgs e)
        {
            TestTypeSettings();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void smAddNewUser_Click(object sender, EventArgs e)
        {
            if (gridvTestTypes.CurrentRow != null)
            {
                string TestTypeID_Txt = gridvTestTypes.CurrentRow.Cells["TestTypeID"].Value.ToString();


                if (int.TryParse(TestTypeID_Txt, out int TestTypeID))
                {
                    Edit_Test_Types_Form frm = new Edit_Test_Types_Form();
                    frm.TestTypeID = TestTypeID;
                    frm.ShowDialog();
                    TestTypeSettings();

                }
            }
        }


    }
}

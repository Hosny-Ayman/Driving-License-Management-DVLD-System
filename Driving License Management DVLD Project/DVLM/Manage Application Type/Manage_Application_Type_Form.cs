using DVLD___Business_Layer;
using DVLM.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLM.Mange_Application_Type
{
    public partial class Manage_Application_Type_Form : Form
    {
        public Manage_Application_Type_Form()
        {
            InitializeComponent();
        }

        private void ApplicationTypeSettings()
        {
            gridvApplicationType.DataSource = clsApplicationTypeBSL.GetAllAplicationsType();


            gridvApplicationType.Columns["ApplicationTypeID"].HeaderText = "Application Type ID";
            gridvApplicationType.Columns["ApplicationTypeTitle"].HeaderText = "Application Type Title";
            gridvApplicationType.Columns["ApplicationFees"].HeaderText = "Application Fees";

            lblNumberOfApplications.Text = gridvApplicationType.Rows.Count.ToString();
        }


        private void Mange_Application_Type_Form_Load(object sender, EventArgs e)
        {
            ApplicationTypeSettings();

           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void smAddNewUser_Click(object sender, EventArgs e)
        {
            if (gridvApplicationType.CurrentRow != null)
            {
                string ApplicationTypeID_Txt = gridvApplicationType.CurrentRow.Cells["ApplicationTypeID"].Value.ToString();


                if (int.TryParse(ApplicationTypeID_Txt, out int ApplicationTypeID))
                {
                    Edit_Application_Type_Form frm = new Edit_Application_Type_Form();
                    frm.ApplicationTypeID = ApplicationTypeID;
                    frm.ShowDialog();
                    ApplicationTypeSettings();

                }
            }
        }
    }



}

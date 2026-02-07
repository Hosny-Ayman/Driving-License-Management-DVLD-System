using DVLD___Business_Layer;
using DVLM.Detain_License;
using DVLM.Driver;
using DVLM.International_License;
using DVLM.Local_Driving_License_Applications;
using DVLM.Manage_Test_Types;
using DVLM.Mange_Application_Type;
using DVLM.People;
using DVLM.Renew;
using DVLM.Users;
using ShairdClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DVLM.DVLMS
{
    public partial class DVLMS_FORM : Form
    {


       
        New_Driving_License_Applications_Form frm6 = null;
       


        private Dictionary<Type, Form> openForms = new Dictionary<Type, Form>();

        private void ShowForm<T>() where T : Form, new()
        {
            
            Type formType = typeof(T);
            Form frm;

            
            if (!openForms.ContainsKey(formType) || openForms[formType].IsDisposed)
            {
                
                frm = new T();
                frm.MdiParent = this;
                openForms[formType] = frm;
            }
            else
            {
               
                frm = openForms[formType];
            }

            
            frm.Show();
            frm.BringToFront();
        }


        public DVLMS_FORM()
        {
            InitializeComponent();

            MdiClient mdclient = this.Controls.OfType<MdiClient>().FirstOrDefault();



            if(mdclient!=null)
            {
                mdclient.BackgroundImage = Properties.Resources.driver;
                mdclient.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }

       

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowForm<Mange_People_Form>();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowForm<Mange_Users_Form>();


        }

        private void mangeApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            ShowForm<Manage_Application_Type_Form>();

        }

        private void mangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowForm<Manage_Test_Types_Form>();

           
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowForm<Local_Driving_License_Applications_Form>();

           
        }

        private void localToolStripMenuItem1_Click(object sender, EventArgs e)
        {

           

            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new New_Driving_License_Applications_Form(New_Driving_License_Applications_Form.enMode.AddNew);

                frm6.MdiParent = this;


            }

            frm6.Show();

            frm6.BringToFront();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ShowForm<Drivers_Form>();


            
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            ShowForm<New_International_License_Application_Form>();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<International_License_Applications_Form>();
            
        }

        private void rewnewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<Renew_Local_Driving_License_Form>();
        }

        private void replacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<Replacement_For_Lost_or_Damaged_License_Form>();
            
        }

        private void tsmDetainLicense_Click(object sender, EventArgs e)
        {

            ShowForm<Detain_License_Form>();
            
        }

        private void tsmReleaseDetainLicense_Click(object sender, EventArgs e)
        {
            ShowForm<Released_Detained_License_Form>();
            
        }

        private void tsmManageDetainedLicenses_Click(object sender, EventArgs e)
        {
            ShowForm<List_Detained_License_Form>();
            
        }

        private void relaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<Released_Detained_License_Form>();
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<Local_Driving_License_Applications_Form>();
        }

        private void currentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            User_Details_Form frm = new User_Details_Form();
            frm.PersonID = clsCurrentUser.CurrentPersonID;
            frm.UserID=clsCurrentUser.CurrentID;

            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password_User_Form frm = new Change_Password_User_Form();
            frm.PersonID = clsCurrentUser.CurrentPersonID;
            frm.UserID = clsCurrentUser.CurrentID;

            frm.Change_Password_User_Form_Load(sender,e);
            frm.ShowDialog();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

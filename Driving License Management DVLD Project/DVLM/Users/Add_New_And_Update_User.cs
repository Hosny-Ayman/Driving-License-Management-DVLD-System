using DVLD___Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLM.Users
{
    public partial class Add_New_And_Update_User : Form
    {
        private int _UserID;



        clsUserBSL _User;

        public Add_New_And_Update_User(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;

            if (_UserID == -1)
                Mode = enMode.AddNew;
            else
                Mode = enMode.Update;

            //tabPage2.Enabled = false;

        }

        public enum enMode {AddNew=0,Update=1}
        private enMode Mode;

        public int PersonID {  get; set; }


        private void ctrlPersonCardWithFilter1_PersonSelect(int obj)
        {
            PersonID = obj;
            if (PersonID != -1)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            {
                if (!clsUserBSL.IsUserExistsByPersonID(PersonID))
                {

                    tabctPerson.SelectedTab = tabPage2;
                    

                }
                else
                {
                    MessageBox.Show("Selected Person already has a user, choose another one", "Select User Person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
                
                   
            
            
            
        }

        private void tabctPerson_Selecting(object sender, TabControlCancelEventArgs e)
        {
           
            if(Mode==enMode.AddNew)
            {

                if (e.TabPage == tabPage2)
                {
                    if (clsUserBSL.IsUserExistsByPersonID(PersonID))
                    {
                        MessageBox.Show("Selected Person already has a user, choose another one", "Select User Person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                        // tabPage2.Enabled = false;
                    }

                }
            }

        }

        private void Add_New_And_Update_User_Load(object sender, EventArgs e)
        {
           
            _LoadData(sender, e);
        }

        private void _LoadData(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            {
                lblUserFrom.Text = "Add New User";
                ctrlPersonCardWithFilter1.FilterGroupBox.Enabled = true;
                _User = new clsUserBSL();
                chkIsActivee.Checked = true;
                return;
            }

            lblUserFrom.Text = "Update User";
            ctrlPersonCardWithFilter1.FilterGroupBox.Enabled = false;
            ctrlPersonCardWithFilter1.SearchUserFilter = PersonID.ToString();
            ctrlPersonCardWithFilter1.btnFindPerson_Click_1(sender, e);


            _User = clsUserBSL.FindUserByID(_UserID);

            if (_User != null)
            {
                lblUserid.Text          = _User.UserID.ToString();
                txtUsername.Text        = _User.UserName;
                //txtpassword.Text        = _User.Password;
                //txtconfrimpassword.Text = _User.Password;

                if (_User.IsActive)
                    chkIsActivee.Checked = true;
                else
                    chkIsActivee.Checked = false;

            }
            else
            {
                MessageBox.Show($"User With User ID Not Found{_UserID}", "Not Found User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool cheeckTextBoxInfo()
        {
            if(!string.IsNullOrEmpty(txtUsername.Text)&& !string.IsNullOrEmpty(txtpassword.Text) && !string.IsNullOrEmpty(txtconfrimpassword.Text))
            {
                return true;
            }
            return false;
        }

        private void SaveUser()
        {


            if(Mode==enMode.Update)
            {
                if (txtpassword.Text != txtconfrimpassword.Text)
                {
                    MessageBox.Show($"Password And Confirm Password Not Match", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrEmpty(txtpassword.Text)&&! string.IsNullOrEmpty(txtconfrimpassword.Text))
                {
                    _User.Password = clsUserBSL.HashPassword(txtpassword.Text);
                }
                _User.UserName = txtUsername.Text;

                if (chkIsActivee.Checked == true)
                    _User.IsActive = true;
                else
                    _User.IsActive = false;
            }
            else
            {
                if (!cheeckTextBoxInfo())
                {
                    MessageBox.Show($"Please Enter All Data", "Data Forget", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtpassword.Text != txtconfrimpassword.Text)
                {
                    MessageBox.Show($"Password And Confirm Password Not Match", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _User.UserName = txtUsername.Text;
                _User.Password = clsUserBSL.HashPassword(txtpassword.Text);
                _User.PersonID = PersonID;

                if (chkIsActivee.Checked == true)
                    _User.IsActive = true;
                else
                    _User.IsActive = false;
            }

           

            if (_User.Save())
            {
                lblUserid.Text = _User.UserID.ToString();
                lblUserFrom.Text = "Update User";

                if(Mode==enMode.AddNew)
                    ctrlPersonCardWithFilter1.FilterGroupBox.Enabled = false;

                Mode = enMode.Update;
                MessageBox.Show($"User Save Successfully", "User Save", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show($"User Save Failed", "User Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void txtconfrimpassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtpassword.Text != txtconfrimpassword.Text)
            {
                errorProvider1.SetError(txtconfrimpassword, "Password dose Not Match");
                
            }
            else
            {
                errorProvider1.SetError(txtconfrimpassword, null);
               
            }

        }

        private void btnHideAndShowPasswordd_Click(object sender, EventArgs e)
        {
            if(txtpassword.UseSystemPasswordChar==true)
            {
                txtpassword.UseSystemPasswordChar = false;
                btnHideAndShowPasswordd.Image=Properties.Resources.show;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
                btnHideAndShowPasswordd.Image = Properties.Resources.hidden;
            }

        }

        private void btnHideAndShowConfirmPasswordd_Click(object sender, EventArgs e)
        {
            if (txtconfrimpassword.UseSystemPasswordChar == true)
            {
                txtconfrimpassword.UseSystemPasswordChar = false;
                btnHideAndShowConfirmPasswordd.Image = Properties.Resources.show;
            }
            else
            {
                txtconfrimpassword.UseSystemPasswordChar = true;
                btnHideAndShowConfirmPasswordd.Image = Properties.Resources.hidden;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SaveUser();
            

        }

        private void tabctPerson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblUserFrom_Click(object sender, EventArgs e)
        {

        }
    }
}

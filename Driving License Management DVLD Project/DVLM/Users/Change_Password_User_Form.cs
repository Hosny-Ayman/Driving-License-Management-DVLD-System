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
using static System.Net.Mime.MediaTypeNames;

namespace DVLM.Users
{
    public partial class Change_Password_User_Form : Form
    {
        public int PersonID { get; set; }
        public int UserID { get; set; }

        private bool IsPasswordRight=false;
        clsUserBSL _User;
        public Change_Password_User_Form()
        {
            InitializeComponent();
        }

        public void Change_Password_User_Form_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.GetPersonInformation(PersonID);
            ctrlUserCard1.GetUserInforMation(UserID);
            _User = clsUserBSL.FindUserByID(UserID);
        }

        private bool comparisonPassowrd()
        {
            if (_User != null)
            {
                string EnterPassword = clsUserBSL.HashPassword(txtCurrentPassword.Text);

                if(_User.Password== EnterPassword)
                    IsPasswordRight = true;
                else
                    IsPasswordRight = false;

            }
            return IsPasswordRight;

           
           
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if(!comparisonPassowrd())
            {
                errorProvider1.SetError(txtCurrentPassword, "Current Password Is Wrong");
            }
            else
                errorProvider1.SetError(txtCurrentPassword, null);
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtNewPassword.Text!=txtConfirmPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password does Not match the New Password");
            }
            else
                errorProvider1.SetError(txtConfirmPassword, null);
        }

        private void HideAndShowPassword(Guna2TextBox txt,Guna2ImageButton btn)
        {
            if (txt.UseSystemPasswordChar == true)
            {
                btn.Image = Properties.Resources.show;
                txt.UseSystemPasswordChar = false;
            }
            else
            {
                btn.Image = Properties.Resources.hidden;
                txt.UseSystemPasswordChar = true;
            }
        }


        private void btnHideShowCurrentPassword_Click(object sender, EventArgs e)
        {

            HideAndShowPassword(txtCurrentPassword, btnHideShowCurrentPassword);

            
        }

        private void btnHideShowNewPassword_Click(object sender, EventArgs e)
        {
            HideAndShowPassword(txtNewPassword, btnHideShowNewPassword);

            
        }

        private void btnHideShowConfirmPassword_Click(object sender, EventArgs e)
        {
            HideAndShowPassword(txtConfirmPassword, btnHideShowConfirmPassword);

            
        }

        private bool CheckEmptyTextbox()
        {
            if(!string.IsNullOrEmpty(txtCurrentPassword.Text)&& !string.IsNullOrEmpty(txtNewPassword.Text) && !string.IsNullOrEmpty(txtConfirmPassword.Text))
                return true;
            else
                return false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(IsPasswordRight==false)
            {
                MessageBox.Show("The Current Password Is Wrong Save Failed", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("The New Password does Not Match the Confirm Password Wrong Save Failed", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!CheckEmptyTextbox())
            {
                MessageBox.Show("Empty Data Please Enter All Data Save Failed", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = clsUserBSL.HashPassword( txtNewPassword.Text);

            if(_User.Save())
            {
                MessageBox.Show("Password Save Successfully", "Save Successfully", MessageBoxButtons.OK, MessageBoxIcon.Question);
                _User = clsUserBSL.FindUserByID(UserID);
            }
            else
            {
                MessageBox.Show("Password Save Failed", "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

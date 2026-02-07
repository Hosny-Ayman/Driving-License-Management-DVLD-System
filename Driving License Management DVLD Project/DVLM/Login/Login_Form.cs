using DVLD___Business_Layer;
using ShairdClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DVLM.Login
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

       



        private void CheeckUserToEnter()
        {
            string CheckUserToEnter = clsUserBSL.HashPassword(txtLoginPassword.Text);

            clsUserBSL User = clsUserBSL.FindUserByUserNameAndPassword(txtLoginUserName.Text, CheckUserToEnter);

            if (User == null)
            {
                MessageBox.Show("Invalid UserName / Password", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!User.IsActive)
            {
                MessageBox.Show("User Is Not Active", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsCurrentUser.CurrentID = User.UserID;
            clsCurrentUser.CurrentUserName = User.UserName;
            clsCurrentUser.CurrentPersonID = User.PersonID;

            if (cbRememberMe.Checked)
            {
               
                Properties.Settings.Default.Username = txtLoginUserName.Text;
                
                Properties.Settings.Default.Password = clsUserBSL.Encrypt(txtLoginPassword.Text);
                Properties.Settings.Default.RememberMe = true;
            }
            else
            {
                
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberMe = false;
            }

            Properties.Settings.Default.Save();



            this.DialogResult = DialogResult.OK;

            this.Close();


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheeckUserToEnter();
        }

        private void btnshowHidePass_Click(object sender, EventArgs e)
        {
            if (txtLoginPassword.UseSystemPasswordChar)
            {
                txtLoginPassword.UseSystemPasswordChar = false;
                btnshowHidePass.Image = Properties.Resources.show;
            }
            else
            {
                txtLoginPassword.UseSystemPasswordChar = true;
                btnshowHidePass.Image = Properties.Resources.hidden;
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.RememberMe)
            {
                txtLoginUserName.Text = Properties.Settings.Default.Username;
                txtLoginPassword.Text = clsUserBSL.Decrypt(Properties.Settings.Default.Password);
                cbRememberMe.Checked = true;
            }


        }
    }
}

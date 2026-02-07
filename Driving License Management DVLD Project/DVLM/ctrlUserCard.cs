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

namespace DVLM
{
    public partial class ctrlUserCard : UserControl
    {
        public ctrlUserCard()
        {
            InitializeComponent();
        }


        public void GetPersonInformation(int PersonID)
        {
            ctrlPersonCard1.GetPersonInformationByID(PersonID);
        }

        public void GetUserInforMation(int UserID)
        {
            clsUserBSL User = clsUserBSL.FindUserByID(UserID);
            if (User != null)
            {
                lblUserID.Text = User.UserID.ToString();
                lblUsername.Text = User.UserName;

                if(User.IsActive==true)
                    chkIsActive.Checked = true;
                else
                    chkIsActive.Checked = false;

            }
        }
    }
}

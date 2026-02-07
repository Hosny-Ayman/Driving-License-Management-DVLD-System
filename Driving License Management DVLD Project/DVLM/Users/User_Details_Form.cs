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
    public partial class User_Details_Form : Form
    {

        public int PersonID { get; set; }
        public int UserID { get; set; }


        public User_Details_Form()
        {
            InitializeComponent();
        }

        private void User_Details_Form_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.GetPersonInformation(PersonID);
            ctrlUserCard1.GetUserInforMation(UserID);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

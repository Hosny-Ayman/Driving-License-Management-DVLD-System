using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLM.People
{
    public partial class Person_Details_Form : Form
    {
        private int _PersonID;

        public event EventHandler PersonInfoUpdated;

        public Person_Details_Form(int personID)
        {
            InitializeComponent();
            _PersonID = personID;


            CtrlPersonCard.OnPersonUpdated += (sender, e) => {
               
                PersonInfoUpdated?.Invoke(this, EventArgs.Empty);
            };


            
        }

        private void Person_Details_Form_Load(object sender, EventArgs e)
        {

            CtrlPersonCard.GetPersonInformationByID(_PersonID) ;
        }
    }
}

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
    public partial class Add_New_Person_Form : Form
    {

        public string PersonModeText {  get; set; }

        public int PersonID { get; set; }

        public int GetPersonID { get; private set; } = -1;

        public delegate void UpdatePersonInfo(int PersonID);

        public event UpdatePersonInfo Info;

        public Add_New_Person_Form()
        {
            InitializeComponent();

            ctrlAddNewPerson1.OnDataSaved += CtrlAddNewPerson1_OnDataSaved;
        }

        private void Add_New_Person_Form_Load(object sender, EventArgs e)
        {
            lblModer.Text = PersonModeText;
            ctrlAddNewPerson1.PersonID = PersonID;

            if (PersonID == -1)
                ctrlAddNewPerson1._Mode = ctrlAddNewPerson.enMode.AddNew; 
            else
                ctrlAddNewPerson1._Mode = ctrlAddNewPerson.enMode.Update; 

            ctrlAddNewPerson1._LoadData();



           
        }

        private void CtrlAddNewPerson1_OnDataSaved(object sender, int PersonID)
        {
            
            Info?.Invoke(PersonID);

           
           // this.Close();
        }

        private void ctrlAddNewPerson1_GetPersonID(int obj)
        {
            GetPersonID = obj;
        }
    }
}

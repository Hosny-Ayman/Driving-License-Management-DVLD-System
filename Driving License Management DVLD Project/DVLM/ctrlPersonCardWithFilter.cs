using DVLD___Business_Layer;
using DVLM.People;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLM
{
    public partial class ctrlPersonCardWithFilter : UserControl
    {
       
        

        public ctrlPersonCardWithFilter()
        {
            InitializeComponent();
          
        }

        public string SearchUserFilter
        {
            get { return txtSearchUserFilter.Text; }
            set { txtSearchUserFilter.Text = value; }
        }

        public Guna2GroupBox FilterGroupBox
        {
            get { return gbctrlFilter; }
        }


        public event Action<int> PersonSelect;

        public event Action<string> PersonSelectNationalNo;

        public event Action<DateTime> PersonDate;

        protected virtual void OnPersonDate(DateTime date)
        {
            PersonDate?.Invoke(date);
        }

        protected virtual void OnPersonSelect(int person)
        {
            PersonSelect?.Invoke(person);
        }

        protected virtual void OnPersonSelectNationalNo(string NationalNo)
        {
            PersonSelectNationalNo?.Invoke(NationalNo);
        }


        public void settingForm()
        {
            cbFilter.SelectedIndex = 0;
           
        }

        private void ctrlFilter_Load(object sender, EventArgs e)
        {
            settingForm();
        }

        

        private void txtSearchUserFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchUserFilter.Text = "";
        }

        

        public void btnFindPerson_Click_1(object sender, EventArgs e)
        {


            if(string.IsNullOrEmpty(txtSearchUserFilter.Text))
            {
                MessageBox.Show($"No ID ", "ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbFilter.SelectedIndex == 0)
            {
                int Result = -1;


                int personid = int.Parse(txtSearchUserFilter.Text);
                clsPersonBSL Person = clsPersonBSL.FindPersonByID(personid);
                if (Person != null)
                {
                    Result = Person.ID;

                    OnPersonSelectNationalNo(Person.NationalNo);

                    ctrlPersonCard1.GetPersonInformationByID(Person.ID);
                    
                }
                else
                {

                    MessageBox.Show($"No Person With This ID = {txtSearchUserFilter.Text}", "Person ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                   

                OnPersonSelect(Result);

                OnPersonDate(Person.DateOfBirth);
            }
            else
            {
                int Result = -1;
                clsPersonBSL Person = clsPersonBSL.FindPersonByNationalNo(txtSearchUserFilter.Text);
                if (Person != null)
                {
                    Result = Person.ID;

                    OnPersonSelectNationalNo(Person.NationalNo);

                    ctrlPersonCard1.GetPersonInformationByID(Person.ID);
                  
                }
                else
                {
                    MessageBox.Show($"No Person With This NationalNo = {txtSearchUserFilter.Text}", "Person NationalNo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                OnPersonSelect(Result);

                OnPersonDate(Person.DateOfBirth);
            }

            
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            Add_New_Person_Form NewPerson = new Add_New_Person_Form();
            NewPerson.PersonModeText = "Add New Person";
            NewPerson.PersonID = -1;
            NewPerson.ShowDialog();


            if (NewPerson.GetPersonID == -1)
                return;

            txtSearchUserFilter.Text= NewPerson.GetPersonID.ToString();
            btnFindPerson_Click_1( sender,  e);



        }

        
    }
}

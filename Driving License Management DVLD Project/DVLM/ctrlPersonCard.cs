using DVLD___Business_Layer;
using DVLM.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShairdClass;
namespace DVLM
{
    public partial class ctrlPersonCard : UserControl
    {

      

        public ctrlPersonCard()
        {
            InitializeComponent();
           
        }
        
        public event EventHandler OnPersonUpdated;

        private System.Drawing.Image LoadImageWithoutLock(string filePath)
        {
            try
            {
                byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(fileBytes))
                {
                    return new System.Drawing.Bitmap(ms);
                }
            }
            catch
            {
                return null;
            }
        }

        

        public void GetPersonInformationByID(int PersonID)
        {

            

            clsPersonBSL Person = clsPersonBSL.FindPersonByID(PersonID);

            if(Person!=null)
            {

                linkLabel1.Visible = true;

                lblPersonID.Text = Person.ID.ToString();
                lblPersonName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
                lblPersonNationalNo.Text = Person.NationalNo;

                if (Person.Gendor == 0)
                    lblPersonGendor.Text = "Male";
                else
                    lblPersonGendor.Text = "Female";

                lblPersonEmail.Text = Person.Email;
                lblPersonAddress.Text = Person.Address;
                lblPersonDateOfBirth.Text = Person.DateOfBirth.ToString("dd MMM yyyy");
                lblPersonPhone.Text = Person.Phone;
                lblPersonCountryName.Text = clsPersonBSL.FindCountryByID(Person.NationalityCountryID);


                if(!string.IsNullOrEmpty(Person.ImagePath)&&System.IO.File.Exists(Person.ImagePath))
                {

                    if (pbPerson.Image != null)
                    {
                        pbPerson.Image.Dispose();
                    }
                    pbPerson.Image = LoadImageWithoutLock(Person.ImagePath);
                }
                else
                {
                    if (Person.Gendor == 0)
                    {
                        pbPerson.Image = Properties.Resources.male;
                    }
                    else
                        pbPerson.Image = Properties.Resources.woman;
                }

                

            }


           

            OnPersonUpdated?.Invoke(this, EventArgs.Empty);
        }

        


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            Add_New_Person_Form NewPerson = new Add_New_Person_Form();

            NewPerson.Info += GetPersonInformationByID;

            NewPerson.PersonModeText = "Update Person";
            NewPerson.PersonID = int.Parse(lblPersonID.Text);
            NewPerson.ShowDialog();

  

            

           
        }
    }
}

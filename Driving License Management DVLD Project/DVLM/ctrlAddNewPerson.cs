using DVLD___Business_Layer;
using Guna.UI2.WinForms;
using ShairdClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLM
{
    public partial class ctrlAddNewPerson : UserControl
    {
        private string _selectedImagePath = "";

        public enum enMode {AddNew = 0,Update = 1 };
        public enMode _Mode;

        clsPersonBSL _Person;


        public int PersonID { get; set; }

        private string _OldImage;

        public delegate void DataSavedEventHandler(object sender, int PersonID);

        
        public event DataSavedEventHandler OnDataSaved;


        public event Action<int> GetPersonID;

        protected virtual void OngetPersonID(int Result)
        {
            GetPersonID?.Invoke(Result);
        }


        public ctrlAddNewPerson()
        {
            InitializeComponent();
            SettingsBeforProjectStart();



        }

        private void SettingsBeforProjectStart()
        {
            SettingDateOfBirth18Years();
            FillCountriesComboBox();

            
           
        }

        private Image LoadImageWithoutLock(string filePath)
        {
            try
            {
               
                byte[] fileBytes = File.ReadAllBytes(filePath);

               
                using (MemoryStream ms = new MemoryStream(fileBytes))
                {
                    return new Bitmap(ms); 
                }
            }
            catch
            {
                return null;
            }
        }

        private void _DeleteOldImage(string imagePath)
        {
            
            if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
            {
                return;
            }

            try
            {
                File.Delete(imagePath);
            }
            catch (IOException ex)
            {
                
                MessageBox.Show($"Could not delete old image file: {ex.Message}");
            }
        }


        public void txtSearchClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void txtNationalNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetterOrDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        public void SettingDateOfBirth18Years()
        {
            timeDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
            timeDateOfBirth.Value = timeDateOfBirth.MaxDate;
        }

        public void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FillCountriesComboBox()
        {
            List<Countrys_Shard> Countrys = clsPersonBSL.GettAllCountrys();

            cbCountry.DataSource = Countrys;
            cbCountry.SelectedIndex = 50;
            cbCountry.DisplayMember= "CountryName";
            cbCountry.ValueMember = "CountryID";
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtNationalNo, "");

           



            if (_Mode == enMode.AddNew)
            {
                if (clsPersonBSL.IsPersonExistsByNationalNo(txtNationalNo.Text))
                {
                    errorProvider1.SetError(txtNationalNo, "The National No Is Alrady Taked");
                }
                else
                    errorProvider1.SetError(txtNationalNo, "");
            }
            else
            {
                if (txtNationalNo.Text.ToLower() != _Person.NationalNo.ToLower())
                {
                    if (clsPersonBSL.IsPersonExistsByNationalNo(txtNationalNo.Text))
                    {
                        errorProvider1.SetError(txtNationalNo, "The National No Is Alrady Taked");
                    }
                    else
                        errorProvider1.SetError(txtNationalNo, "");
                }
            }
        }

        private void LinkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.Title = "Select Person Image";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                _selectedImagePath = openFileDialog1.FileName;
                pbPersonImage.Load(_selectedImagePath); 
                linkremoveimage.Visible = true;
                
                pbPersonImage.Tag = null;
            }
        }

        private string _CopyImageToProjectFolder(ref string sourceImagePath)
        {
            if (string.IsNullOrEmpty(sourceImagePath))
            {
                return "";
            }

            string destinationFolder = Path.Combine(Application.StartupPath, "PeoplePic");

            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(sourceImagePath);
            string destinationPath = Path.Combine(destinationFolder, newFileName);

            try
            {
                File.Copy(sourceImagePath, destinationPath);
                return destinationPath;
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Could not copy image file: {ex.Message}");
                return "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            if (MessageBox.Show("Are you sure you want to remove this image?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                
                pbPersonImage.Image = rbMale.Checked ? Properties.Resources.male : Properties.Resources.woman;
                _selectedImagePath = ""; 
                linkremoveimage.Visible = false;
               
                pbPersonImage.Tag = "removed";
            }



        }



        public bool CheeckedTextBox()
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtSecondName.Text) && !string.IsNullOrEmpty(txtThirdName.Text)
                && !string.IsNullOrEmpty(txtNationalNo.Text) && !string.IsNullOrEmpty(txtPhoneNumber.Text)
                && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtAddress.Text))
                return true;

            else
                return false;
               
        }

        public void MessagePersonIsAlreadyExists(string NationalNo)
        {
            MessageBox.Show("Person Is Already Exists", "Person Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MessageTextBoxIsEmty()
        {
            MessageBox.Show("Please don’t forget to fill in this field ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MessageSaveSuccessfully()
        {
            MessageBox.Show("Data Saved Successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MessageSaveFailed()
        {
            MessageBox.Show("Data Saved Failed ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MessageIsNoPerson()
        {
            MessageBox.Show($"No Person With ID {PersonID} ", "Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MessageValidateEmail(Guna2TextBox txtEmail)
        {
            errorProvider1.SetError(txtEmail, "Please Enter Email Like name@example.com");
        }



        public void _LoadData()
        {
            FillCountriesComboBox();

            if (_Mode == enMode.AddNew)
            {
                _Person = new clsPersonBSL();
                rbMale.Checked = true;
                return;
            }

            _Person = clsPersonBSL.FindPersonByID(PersonID);

            if (_Person != null)
            {
                lblPersonID.Text = _Person.ID.ToString();
                txtFirstName.Text = _Person.FirstName;
                txtSecondName.Text = _Person.SecondName;
                txtThirdName.Text = _Person.ThirdName;
                txtLastName.Text = _Person.LastName;
                txtNationalNo.Text = _Person.NationalNo;
                timeDateOfBirth.Value = _Person.DateOfBirth;

                if (_Person.Gendor == 0)
                {
                    rbMale.Checked = true;
                    rbFemal.Checked = false;
                }
                else
                {
                    rbFemal.Checked = true;
                    rbMale.Checked = false;
                }





                txtPhoneNumber.Text = _Person.Phone;
                txtEmail.Text = _Person.Email;


                cbCountry.SelectedIndex = cbCountry.FindStringExact(clsPersonBSL.FindCountryByID(_Person.NationalityCountryID));


                txtAddress.Text = _Person.Address;

                if (!string.IsNullOrEmpty(_Person.ImagePath))
                {

                    if (File.Exists(_Person.ImagePath))
                    {



                        if (pbPersonImage.Image != null)
                        {
                            pbPersonImage.Image.Dispose();
                            pbPersonImage.Image = null;
                        }

                        pbPersonImage.Image = LoadImageWithoutLock(_Person.ImagePath);

                        if (pbPersonImage.Image != null)
                        {
                            linkremoveimage.Visible = true;
                            _OldImage = _Person.ImagePath;
                        }

                        

                    }

                }
                else
                {
                    if (_Person.Gendor == 0)
                    {
                        rbMale.Checked = true;
                        pbPersonImage.Image = Properties.Resources.male;
                    }
                    else
                    {
                        rbFemal.Checked = true;
                        pbPersonImage.Image = Properties.Resources.woman;
                    }



                    linkremoveimage.Visible = false;
                }


            }

            else
            {
                MessageIsNoPerson();
                return;
            }

        }


        private void SavePerson()
        {
            if (_Mode == enMode.AddNew)
            {
                if (clsPersonBSL.IsPersonExistsByNationalNo(txtNationalNo.Text))
                {
                    MessagePersonIsAlreadyExists(txtNationalNo.Text);
                    return;
                }
            }
            else
            {
                if (txtNationalNo.Text.ToLower() != _Person.NationalNo.ToLower())
                {
                    if (clsPersonBSL.IsPersonExistsByNationalNo(txtNationalNo.Text))
                    {
                        MessagePersonIsAlreadyExists(txtNationalNo.Text);
                        return;
                    }
                }
            }




            _Person.NationalNo = txtNationalNo.Text;
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = txtThirdName.Text;
            _Person.LastName = txtLastName.Text;


            if (rbMale.Checked)
                _Person.Gendor = 0;
            else
                _Person.Gendor = 1;


            _Person.Address = txtAddress.Text;
            _Person.DateOfBirth = timeDateOfBirth.Value;
            _Person.Phone = txtPhoneNumber.Text;
            _Person.Email = txtEmail.Text;
            _Person.NationalityCountryID = (int)cbCountry.SelectedValue;

            bool isNewImageSelected = !string.IsNullOrEmpty(_selectedImagePath);
            bool wasImageRemoved = pbPersonImage.Tag?.ToString() == "removed";
            bool hasOldImage = !string.IsNullOrEmpty(_OldImage);


            if (isNewImageSelected)
            {
                
                if (hasOldImage)
                {
                    _DeleteOldImage(_OldImage);
                }

               
                string newImagePath = _CopyImageToProjectFolder(ref _selectedImagePath);
                if (!string.IsNullOrEmpty(newImagePath))
                {
                    _Person.ImagePath = newImagePath;
                }
                else
                {
                    
                    MessageBox.Show("Failed to save the new image.", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
           
            else if (wasImageRemoved && hasOldImage)
            {
                _DeleteOldImage(_OldImage);
                _Person.ImagePath = null;
            }


            if (_Person.Save())
            {
                MessageSaveSuccessfully();
                lblPersonID.Text = _Person.ID.ToString();
                OngetPersonID(_Person.ID);

                
                _Mode = enMode.Update; 
                _OldImage = _Person.ImagePath; 
                _selectedImagePath = ""; 
                pbPersonImage.Tag = null; 
            }
            else
            {
                MessageSaveFailed();
            }





        }




        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            SavePerson();

            OnDataSaved?.Invoke(this, _Person.ID);
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(_selectedImagePath=="")
            pbPersonImage.Image = Properties.Resources.male;
        }

        private void rbFemal_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedImagePath == "")
                pbPersonImage.Image = Properties.Resources.woman;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form parentform = this.FindForm();

            if(parentform!=null)
            {
                parentform.Close();
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string Email = txtEmail.Text;

            if (string.IsNullOrEmpty(Email))
                return;

            try
            {
                MailAddress mail = new MailAddress(Email);
                errorProvider2.SetError(txtEmail, "");
            }
            catch(FormatException)
            {

                errorProvider2.SetError(txtEmail, "Please Enter Email Like name@example.com");
            }
        }

       
    }
}

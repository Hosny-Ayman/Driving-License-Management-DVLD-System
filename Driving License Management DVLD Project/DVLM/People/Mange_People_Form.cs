using DVLD___Business_Layer;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DVLM.People
{
    public partial class Mange_People_Form : Form
    {
       
        DataTable originalDataTable = new DataTable();
            


        public Mange_People_Form()
        {
            InitializeComponent();

            

            GetAllPeople();

            
        }

        public void FixGridView(DataGridView gridV)
        {
            if (gridV.Rows.Count > 0)
            {
                gridV.Columns["PersonID"].HeaderText = "Person ID";
                gridV.Columns["FirstName"].HeaderText = "First Name";
                gridV.Columns["SecondName"].HeaderText = "Second Name";
                gridV.Columns["ThirdName"].HeaderText = "Third Name";
                gridV.Columns["LastName"].HeaderText = "Last Name";
                gridV.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
                gridV.Columns["NationalNo"].HeaderText = "National No";

                
                gridV.Columns["PersonID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                gridV.Columns["FirstName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                gridV.Columns["SecondName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                gridV.Columns["ThirdName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                gridV.Columns["LastName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                gridV.Columns["NationalNo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                gridV.Columns["Gendor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                gridV.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                gridV.Columns["DateOfBirth"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                gridV.Columns["CountryName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                gridV.Columns["Phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

                gridV.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";


                gridV.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridV.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                gridV.Columns["Phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;




            }
        }

        public void NumberOfPeople()
        {
            lblNumberOfPeople.Text = gridvPeople.Rows.Count.ToString();
        }

        public void GetAllPeople()
        {
            
            originalDataTable = clsPersonBSL.GetAllPeople();

            
            peopleBindingSource.DataSource = originalDataTable;
           

            gridvPeople.DataSource = peopleBindingSource;

            
            NumberOfPeople();
            FixGridView(gridvPeople);
        }


        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            Add_New_Person_Form NewPerson = new Add_New_Person_Form();
            NewPerson.PersonModeText = "Add New Person";
            NewPerson.PersonID = -1;
            NewPerson.ShowDialog();

            GetAllPeople();
        }


        

        private void Mange_People_Form_Load(object sender, EventArgs e)
        {
            cbFilterSettings();
        }

        private void cbFilterSettings()
        {

            cbFilter.Items.Clear();


            cbFilter.Items.Add("None");


            foreach (DataColumn column in originalDataTable.Columns)
            {
                if (column.ColumnName != "Gendor")
                    cbFilter.Items.Add(column.ColumnName);
            }


            cbFilter.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            
            if (cbFilter.SelectedItem == null)
            {

               
                return;

                
            }

            
            DataView dv = originalDataTable.DefaultView;

            
            if (cbFilter.SelectedItem.ToString() == "None" || string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                dv.RowFilter = "";

                
                return;
            }

          

            string selectedColumn = cbFilter.SelectedItem.ToString();
            string searchValue = txtSearch.Text.Trim();

            Type columnType = originalDataTable.Columns[selectedColumn].DataType;


            if (columnType == typeof(string))
            {
                
                dv.RowFilter = string.Format("[{0}] LIKE '%{1}%'", selectedColumn, searchValue);
            }
            else
            {

                
                dv.RowFilter = string.Format("CONVERT([{0}], 'System.String') LIKE '%{1}%'", selectedColumn, searchValue);

            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged_1(sender, e);

           if(cbFilter.Text=="None")
                txtSearch.Visible = false;
           else
                txtSearch.Visible = true;
        }

        private void gridvPeople_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex== gridvPeople.Columns["Gendor"].Index&&e.Value!=null)
            {
                int TheValue = Convert.ToInt32(e.Value);

                try
                {
                    if (TheValue == 0)
                        e.Value = "Male";
                    else if (TheValue == 1)
                        e.Value = "Female";

                    e.FormattingApplied = true;
                }
                catch
                {
                    e.FormattingApplied =false;
                }
               
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(gridvPeople.CurrentRow!=null)
            {
                string PersinID_Text = gridvPeople.CurrentRow.Cells["PersonID"].Value.ToString();

                if(int.TryParse(PersinID_Text, out int PersinID))
                {
                    Add_New_Person_Form NewPerson = new Add_New_Person_Form();
                    NewPerson.PersonModeText = "Update Person";
                    NewPerson.PersonID = PersinID;
                    NewPerson.ShowDialog();

                    GetAllPeople();

                }
            }
            else
            {
                MessageBox.Show("Please Choose A Person First","Choose",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(gridvPeople.CurrentRow != null)
            {

                string Person_text = gridvPeople.CurrentRow.Cells["PersonID"].Value.ToString();

                if(int.TryParse(Person_text,out int PersonID))
                {
                    if(MessageBox.Show($"Are You Sure You Want To Delet This Person With ID = {PersonID}","Person Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
                    {

                        clsPersonBSL Person = clsPersonBSL.FindPersonByID(PersonID);

                        if (Person == null)
                        {
                            return;
                        }


                        if (clsPersonBSL.DeletePerson(PersonID))
                        {
                            MessageBox.Show($"Person Deleted Successfully", "Person Delete",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            if (!string.IsNullOrEmpty(Person.ImagePath) && File.Exists(Person.ImagePath))
                            {
                                File.Delete(Person.ImagePath);
                            }

                            GetAllPeople();
                        }
                        else
                        {
                            MessageBox.Show($"Person Deleted Failed", "Person Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }

        private void shoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(gridvPeople.CurrentRow!=null)
            {
                string Person_Text = gridvPeople.CurrentRow.Cells["PersonID"].Value.ToString();

                if(int.TryParse(Person_Text,out int PersonID))
                {
                    Person_Details_Form frm = new Person_Details_Form(PersonID);

                    frm.PersonInfoUpdated += (s, args) => {
                        GetAllPeople(); 
                    };


                    frm.ShowDialog();
                }
                
            }
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddNewUser_Click(sender, e);
        }
    }
}

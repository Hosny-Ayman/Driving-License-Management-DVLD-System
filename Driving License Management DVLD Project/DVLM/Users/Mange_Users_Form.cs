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

namespace DVLM.Users
{
    public partial class Mange_Users_Form : Form
    {

        DataTable OrginalDataTable = new DataTable();


        public Mange_Users_Form()
        {
            InitializeComponent();
        }

        private void RelodUser()
        {
            GetAllUsers();
            NumberOfUsers();
        }

        public void GetAllUsers()
        {
            OrginalDataTable = clsUserBSL.GetAllUsers();

            gridvUsers.DataSource = OrginalDataTable;

            if (gridvUsers.Rows.Count > 0)
            {
                gridvUsers.Columns["PersonID"].HeaderText = "Person ID";
                gridvUsers.Columns["UserID"].HeaderText = "User ID";
                gridvUsers.Columns["UserName"].HeaderText = "User Name";
                gridvUsers.Columns["IsActive"].HeaderText = "Is Active";
                gridvUsers.Columns["FullName"].HeaderText = "Full Name";


             
               gridvUsers.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


               
            }
        }

        public void UsersFormSetting()
        {
            GetAllUsers();
            NumberOfUsers();
            cbFilter();
        }


        private void Add_New_User_And_Update_Form_Load(object sender, EventArgs e)
        {
            UsersFormSetting();



        }

        private void NumberOfUsers()
        {
            lblNumberOfUsers.Text = gridvUsers.Rows.Count.ToString();
        }

        private void cbFilter()
        {
            cbFilterUsers.Items.Clear();

            cbFilterUsers.Items.Add("None");

            foreach(DataColumn Column in OrginalDataTable.Columns)
            {
                    cbFilterUsers.Items.Add(Column);
            }

            cbFilterUsers.SelectedIndex = 0;
        }

        private void cbFilterUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (cbFilterUsers.Text == "None")
            {
                txtSearchUsers.Visible = false;
                cbIsActive.Visible = false;
                OrginalDataTable.DefaultView.RowFilter = ""; 
            }
           else
            {
                txtSearchUsers.Visible = true;

            }

            if (cbFilterUsers.Text == "IsActive")
            {
                txtSearchUsers.Visible = false;
               
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                cbIsActive.Visible = false;
            }



        }

        private void txtSearchUsers_TextChanged(object sender, EventArgs e)
        {
            if(cbFilterUsers.SelectedItem==null)
            {
                return;
            }

            DataView dv = OrginalDataTable.DefaultView;

            if(cbFilterUsers.SelectedItem.ToString()=="None"||string.IsNullOrWhiteSpace(txtSearchUsers.Text))
            {
                dv.RowFilter = "";

                return;
            }





            string Selceteditem = cbFilterUsers.SelectedItem.ToString();
            string SearchValue = txtSearchUsers.Text;


            


            Type type = OrginalDataTable.Columns[Selceteditem].DataType;




            if(type==typeof(string))
            {
                dv.RowFilter = string.Format("[{0}] Like '%{1}%' ", Selceteditem, SearchValue);
            }
            else
            {
                dv.RowFilter = string.Format("Convert([{0}],'System.String') Like '%{1}%' ", Selceteditem, SearchValue);
            }

        }

        private void txtSearchUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterUsers.Text == "PersonID" || cbFilterUsers.Text == "UserID")
            {
               
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; 
                }
            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dataView = OrginalDataTable.DefaultView;

            string FilterValue = cbIsActive.Text;

            if(FilterValue=="All")
            {
                dataView.RowFilter = "";
            }

            else if(FilterValue=="Yes")
            {
                dataView.RowFilter = "[IsActive]=true";
            }

            else  
            {
                dataView.RowFilter = "[IsActive]=false";
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            Add_New_And_Update_User frm = new Add_New_And_Update_User(-1);
            frm.ShowDialog();
            RelodUser();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_New_And_Update_User frm = new Add_New_And_Update_User(-1);
            frm.ShowDialog();
            RelodUser();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(gridvUsers.CurrentRow!=null)
            {
                string UserID_Txt = gridvUsers.CurrentRow.Cells["UserID"].Value.ToString();
                string PersonID_Txt = gridvUsers.CurrentRow.Cells["PersonID"].Value.ToString();

                if (int.TryParse(UserID_Txt,out int UserID)&& int.TryParse(PersonID_Txt, out int PersonID))
                {
                    Add_New_And_Update_User frm = new Add_New_And_Update_User(UserID);
                    frm.PersonID = PersonID;
                    frm.ShowDialog();
                    GetAllUsers();
                   
                }
            }
            else
            {
                MessageBox.Show("Please Choose A User First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void shoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridvUsers.CurrentRow != null)
            {
                string UserID_Txt = gridvUsers.CurrentRow.Cells["UserID"].Value.ToString();
                string PersonID_Txt = gridvUsers.CurrentRow.Cells["PersonID"].Value.ToString();

                if (int.TryParse(UserID_Txt, out int UserID) && int.TryParse(PersonID_Txt, out int PersonID))
                {
                    User_Details_Form frm = new User_Details_Form();
                    frm.PersonID = PersonID;
                    frm.UserID = UserID;
                    frm.ShowDialog();
                   

                }
            }
            else
            {
                MessageBox.Show("Please Choose A User First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (gridvUsers.CurrentRow != null)
            {
                string UserID_Text = gridvUsers.CurrentRow.Cells["UserID"].Value.ToString();


                if (int.TryParse(UserID_Text, out int UserID))
                {
                    if (MessageBox.Show($"Are You Sure You Want To Delet This User With ID = {UserID}", "Person Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (clsUserBSL.DeleteUser(UserID))
                        {
                            MessageBox.Show($"User Deleted Successfully", "User Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RelodUser();
                        }
                        else
                        {
                            MessageBox.Show($"User Deleted Failed", "User Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("Please Choose A User First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void smChangePassword_Click(object sender, EventArgs e)
        {
            if (gridvUsers.CurrentRow != null)
            {
                string UserID_Txt = gridvUsers.CurrentRow.Cells["UserID"].Value.ToString();
                string PersonID_Txt = gridvUsers.CurrentRow.Cells["PersonID"].Value.ToString();

                if (int.TryParse(UserID_Txt, out int UserID) && int.TryParse(PersonID_Txt, out int PersonID))
                {
                    Change_Password_User_Form frm = new Change_Password_User_Form();
                    frm.PersonID = PersonID;
                    frm.UserID = UserID;
                    frm.ShowDialog();


                }
            }
            else
            {
                MessageBox.Show("Please Choose A User First", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

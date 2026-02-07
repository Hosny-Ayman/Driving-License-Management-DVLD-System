using DVLD___Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLM.Driver
{
    public partial class Drivers_Form : Form
    {
        public Drivers_Form()
        {
            InitializeComponent();
        }

        DataTable orginalData = new DataTable();

        private void GetAllDrivers()
        {
            
            orginalData = clsDriverBSL.GetAllDrivers();
            gridvDrivers.DataSource = orginalData;

            gridvDrivers.Columns["DriverID"].HeaderText = "Driver ID";
            gridvDrivers.Columns["PersonID"].HeaderText = "Person ID";
            gridvDrivers.Columns["NationalNo"].HeaderText = "National No";
            gridvDrivers.Columns["FullName"].HeaderText = "Full Name";
            gridvDrivers.Columns["CreatedDate"].HeaderText = "Date";
            gridvDrivers.Columns["NumberOfActiveLicenses"].HeaderText = "Active Licenses";

            gridvDrivers.Columns["NumberOfActiveLicenses"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            gridvDrivers.Columns["CreatedDate"].DefaultCellStyle.Format = "dd/MM/yyyy";


            gridvDrivers.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            lblDriverNumber.Text= gridvDrivers.Rows.Count.ToString();
        }

        private void Drivers_Form_Load(object sender, EventArgs e)
        {
            GetAllDrivers();
            FillComboxData();
        }

        private void FillComboxData()
        {
            cbFilter.Items.Clear();

            cbFilter.Items.Add("None");

            foreach(DataColumn Cloumn in orginalData.Columns)
            {
                if (Cloumn.ColumnName== "NumberOfActiveLicenses")
                {
                    cbFilter.Items.Add("Active Licenses");
                }
                else
                {
                    cbFilter.Items.Add(Cloumn.ColumnName);
                }
                   
            }

            cbFilter.SelectedIndex = 0;

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilter.SelectedItem.ToString()=="None")
            {
                txtSearchDriver.Visible = false;
            }
            else
            {
                
                txtSearchDriver.Visible = true;
            }

            txtSearchDriver.Text = "";
        }

        private void txtSearchDriver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "PersonID"|| cbFilter.Text == "DriverID"|| cbFilter.Text == "Active Licenses")
            {
                if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }


            }
        }

        private void txtSearchDriver_TextChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null)
            {
                return;
            }

            DataView dt = orginalData.DefaultView;
            string filterText = txtSearchDriver.Text.Trim();

            if (cbFilter.SelectedItem.ToString() == "None" || string.IsNullOrEmpty(filterText))
            {
                dt.RowFilter = "";
                
                return;
            }

           
            string realColumnName = cbFilter.SelectedItem.ToString();
            if (realColumnName == "Active Licenses")
            {
                realColumnName = "NumberOfActiveLicenses";
            }

            
            Type columnType = orginalData.Columns[realColumnName].DataType;

           
            if (columnType == typeof(string))
            {
              
                dt.RowFilter = string.Format("[{0}] LIKE '%{1}%'", realColumnName, filterText);
            }
            else
            {
                
                dt.RowFilter = string.Format("CONVERT([{0}], 'System.String') LIKE '%{1}%'", realColumnName, filterText);
            }

            


        }
    }
}

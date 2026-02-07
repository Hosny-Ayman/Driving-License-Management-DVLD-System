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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DVLM
{
    public partial class ctrlLicenseCardWithFilter : UserControl
    {
        public ctrlLicenseCardWithFilter()
        {
            InitializeComponent();
        }

        public int PersonID { get; set; }
        public int DriverID { get; set; }

        public bool IsActive {  get; set; }
        public bool IsExpired { get; set; }

        public int LicenseID { get; set; }

        public event Action<int> LocalLicenseID;

        public event Action LoudData;

        public string stringSearchFilter
        {
            get
            {
                return txtSearchUserFilter.Text;
            }
            set
            {
                txtSearchUserFilter.Text = value;
            }
        }

        public void SetGroupBoxVisibilityAndTextSearch(bool Enable,int LicenseID)
        {
           
            gbFilter.Enabled = Enable;

            txtSearchUserFilter.Text= LicenseID.ToString(); ;
        }


        protected virtual void OnLocalLicenseID(int Licenseid)
        {
            LocalLicenseID?.Invoke(Licenseid);
        }

        protected virtual void OnLoudData()
        {
            LoudData?.Invoke();
        }

        


        public void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            
            if(!string.IsNullOrEmpty(txtSearchUserFilter.Text))
            {
                ctrlDriverLicenseInfo1.GetLicenseInfo(int.Parse(txtSearchUserFilter.Text));
                OnLoudData();

            }
            else
            {
                MessageBox.Show("No License ID Please Enter One", "No License ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          


        }

        private void txtSearchUserFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ctrlDriverLicenseInfo1_GetPersonIDAndDriverID(int arg1, int arg2)
        {
            PersonID = arg1;
            DriverID = arg2;
        }

        private void ctrlDriverLicenseInfo1_IsActiveLicenseAndIsNotExpired(bool arg1, bool arg2)
        {
            IsActive = arg1;
            IsExpired = arg2;
        }

        private void ctrlDriverLicenseInfo1_GetLicenseID(int obj)
        {
            LicenseID = obj;
            OnLocalLicenseID(obj);
        }
    }
}

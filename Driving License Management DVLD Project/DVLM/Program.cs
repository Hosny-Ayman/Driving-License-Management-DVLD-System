using DVLM.Detain_License;
using DVLM.Driver;
using DVLM.DVLMS;
using DVLM.International_License;
using DVLM.License;
using DVLM.Local_Driving_License_Applications;
using DVLM.Login;
using DVLM.Manage_Test_Types;
using DVLM.Mange_Application_Type;
using DVLM.People;
using DVLM.Renew;
using DVLM.Test;
using DVLM.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DVLM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login_Form loginForm = new Login_Form();

            if(loginForm.ShowDialog()== DialogResult.OK)
            {
                Application.Run(new DVLMS_FORM());
            }

           



        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------------
using CloudDesktopApp.Helper;
using CloudDesktopApp.ApiOperations;



namespace CloudDesktopApp.Component.Profile
{
    public partial class ProfileManagement : Form
    {
        public ProfileManagement()
        {
            InitializeComponent();
        }
        private void ProfileManagement_Load(object sender, EventArgs e)
        {
        }
        

        private void profileCreate_Click(object sender, EventArgs e)
        {
            Form formExits = Application.OpenForms["CreateProfile"];
            if (formExits != null)
            {
                formExits.Close();
            }
            new CreateProfile().Show(this);
        }

      
    }
}

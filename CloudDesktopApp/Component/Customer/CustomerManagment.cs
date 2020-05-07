using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudDesktopApp.Component.Customer
{
    public partial class CustomerManagment : Form
    {
        public CustomerManagment()
        {
            InitializeComponent();
        }

        private void customerCreate_Click(object sender, EventArgs e)
        {
            Form formExits = Application.OpenForms["CustomerForm"];
            if (formExits != null)
            {
                formExits.Close();
            }
            new CustomerForm().Show(this);
        }

       
    }
}

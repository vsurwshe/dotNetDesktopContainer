using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------
using System.Windows.Forms;

namespace MySqlDesktopApp
{
    class UserService 
    {
        public void showSuccessMessage(String meassge)
        {
            MessageBox.Show(meassge);
        }

        public void showErrorMessage(String message)
        {
            MessageBox.Show(message);
        }
    }

}

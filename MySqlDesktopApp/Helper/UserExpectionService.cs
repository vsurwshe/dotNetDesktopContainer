using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------------------
using System.Windows.Forms;

namespace MySqlDesktopApp
{
    public class UserExpectionService: Exception
    {
        public UserExpectionService()
        {
        }
        public UserExpectionService(String message): base(message)
        {
            MessageBox.Show("Error : " + message);
        }

        public void showExceptions(String message){
            MessageBox.Show("Error : " + message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//-----
using System.Windows.Forms;


namespace HotelDashboard.Helper
{
    class UserExceptions
    {
        public void showExceptions(String message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

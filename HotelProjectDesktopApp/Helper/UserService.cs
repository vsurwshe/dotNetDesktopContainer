using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//---
using System.Windows.Forms;

namespace HotelDashboard.Helper
{
    class UserService
    {
        public void appExit()
        {
            DialogResult dr = MessageBox.Show("Are Sure want to Exit form Applications ? ", "Exit Applications", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

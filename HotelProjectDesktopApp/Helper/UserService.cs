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

        // This method take username and password calling Api and setting response of api in setting variables
        public void getAuthenticate(String username, String password)
        {
            try
            {
                if (Properties.Settings.Default.userToken == "")
                {
                    HotelDashboard.WpfClient.Models.TokenResponse user = new HotelDashboard.WpfClient.Operations.ApiOperations().AuthenticateUser(username,password);
                    Properties.Settings.Default.userToken = user.userToken;
                    Properties.Settings.Default.refreshToekn = user.userRefreshToken;
                }
            }
            catch (Exception msg)
            {
                new HotelDashboard.Helper.UserExceptions().showExceptions(msg.Message);
            }
        }
    }
}

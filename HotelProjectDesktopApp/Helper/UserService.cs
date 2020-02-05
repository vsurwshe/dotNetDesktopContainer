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
        // This method execute when user want quit form applications
        public void appExit()
        {
            DialogResult dr = MessageBox.Show("Are Sure want to Exit form Applications ? ", "Exit Applications", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // This mehod use for show warning message in applications
        public void showWarningMessage(String message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // This mehod use for show warning message in applications
        public void showErrorMessage(String message)
        {
            MessageBox.Show(message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        // This method take username and password calling Api and setting response of api in setting variables
        public String getAuthenticate(String username, String password)
        {
            try
            {
                if (Properties.Settings.Default.userToken == "")
                {
                    HotelDashboard.WpfClient.Models.TokenResponse user = new HotelDashboard.WpfClient.Operations.ApiOperations().AuthenticateUser(username,password);
                    Properties.Settings.Default.userToken = user.userToken;
                    Properties.Settings.Default.refreshToekn = user.userRefreshToken;
                }
                return Properties.Settings.Default.userToken;
            }
            catch (Exception msg)
            {
                new HotelDashboard.Helper.UserExceptions().showExceptions(msg.Message);
                return null;
            }
        }
    }
}

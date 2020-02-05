using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//---
using System.Windows.Forms;
using HotelDashboard.WpfClient.Models;
using HotelDashboard.WpfClient.Operations;
using HotelDashboard.Helper;

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
        public TokenResponse getAuthenticate(String username, String password)
        {
            TokenResponse user=null;
            try
            {
                if (Properties.Settings.Default.userToken == "")
                {
                    user = new ApiOperations().AuthenticateUser(username, password);
                    Properties.Settings.Default.userToken = user.userToken;
                    Properties.Settings.Default.refreshToekn = user.userRefreshToken;
                }
                else
                {
                    user=new TokenResponse();
                    user.userToken = Properties.Settings.Default.userToken;
                    user.userRefreshToken = Properties.Settings.Default.refreshToekn;
                }
                return user;
            }
            catch (Exception msg)
            {
                new UserExceptions().showExceptions(msg.Message);
                return user;
            }
        }
    }
}

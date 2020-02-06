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
    public class messageBoxHeader
    {
        public static String APP_EXIT { get { return "Exit Applications"; } }
        public static String APP_WARN { get { return "Applications Warning"; } }
        public static String APP_ERROR { get { return "Applications Error"; } }
        public static String APP_SUCCESS { get { return "Successfull"; } } 
    }
    class UserService
    {
       
        // This method execute when user want quit form applications
        public void appExit()
        {
            DialogResult dr = MessageBox.Show(CommonMessage.APP_EXIT_MSG, messageBoxHeader.APP_EXIT.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // This mehod use for show warning message in applications
        public void showWarningMessage(String message)
        {
            MessageBox.Show(message, messageBoxHeader.APP_WARN.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // This mehod use for show Error message in applications
        public void showErrorMessage(String message)
        {
            MessageBox.Show(message,messageBoxHeader.APP_ERROR.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // This mehod use for show Error message in applications
        public static void showSuccessMessage(String message)
        {
            MessageBox.Show(message, messageBoxHeader.APP_SUCCESS.ToString(), MessageBoxButtons.OK, MessageBoxIcon.None);
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

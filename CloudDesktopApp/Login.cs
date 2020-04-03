using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//------
using MaterialSkin.Controls;
using CloudDesktopApp.Helper;
using CloudDesktopApp.ApiOperations;
using Newtonsoft.Json;
using CloudDesktopApp.Component;

namespace CloudDesktopApp
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // This condtions checking username or password filed empty or null
            if (String.IsNullOrEmpty(username.Text) || String.IsNullOrEmpty(password.Text))
            {
                UserMessage.showWarningMessage(CommonMessage.LOGIN_USERPASS_VAILD);
            }
            else
            {
                this.setProgressBar(true);
                if (!bgWorker.IsBusy)
                {
                    loginButton.Enabled = false;
                    progressBar.Style = ProgressBarStyle.Marquee;
                    bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
                    bgWorker.RunWorkerAsync();
                }
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Properties.Settings.Default.userToken != "")
            {
                this.invokeDashboard();
            }
            else
            {
                this.loginUser();
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = false;
            loginButton.Enabled = true;
        }

        public void loginUser()
        {
            try
            {
                String userBodyData = JsonConvert.SerializeObject(new
                {
                    userEmail = username.Text,
                    userPassword = password.Text
                });
                TokenResponse result = new LoginRegsiter().loginUser(userBodyData);
                if (result != null)
                {
                    this.setUserToken(result);
                    this.invokeDashboard();
                }
                else
                {
                    throw new Exception(CommonMessage.LOGIN_USERPASS_WORNG);
                }
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        public Boolean setUserToken(TokenResponse user)
        {
            Properties.Settings.Default.userToken = user.userToken;
            Properties.Settings.Default.refreshToken = user.userRefreshToken;
            return true;
        }

        // This method seting values of progress bar
        private void setProgressBar(Boolean progressBarvalue)
        {
            if (progressBarvalue)
            {// This lines setting progress bar values 
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                progressBar.Value = 10;
                progressBar.Step = 10;
            }
            progressBar.Visible = progressBarvalue;
        }

        // This is the invoking the dashboard form
        public void invokeDashboard()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                this.Hide();
                new UserDashborad().Show();
            }));
        }

    }
}

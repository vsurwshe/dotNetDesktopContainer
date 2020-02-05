using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//---
using System.Windows.Forms;
using HotelDashboard.Helper;

namespace HotelDashboard
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.setProgressBar(false);
        }
        // This method calling when user click on login button
        private void loginButton_Click(object sender, EventArgs e)
        { // This condtions checking username or password filed empty or null
            if (String.IsNullOrEmpty(username.Text) || String.IsNullOrEmpty(password.Text))
            { new HotelDashboard.Helper.UserService().showWarningMessage(CommonMessage.LOGIN_USERPASS_VAILD); }
            else
            {
                this.setProgressBar(true);
                if (!bgWorker.IsBusy)
                {
                    loginButton.Enabled = false;
                    progressBar.Style = ProgressBarStyle.Continuous;
                    bgWorker.RunWorkerAsync();
                }
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new Register().Show();
            }
            catch (Exception msg)
            {
                new UserExceptions().showExceptions(msg.Message);
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            HotelDashboard.WpfClient.Models.TokenResponse res= new HotelDashboard.Helper.UserService().getAuthenticate(username.Text, password.Text);
            if (res.userToken != null && !res.userToken.Equals(CommonMessage.SYS_500_ERROR))
            {
                this.Invoke(new MethodInvoker(delegate(){
                    this.Hide();
                    new Dashboard().Show();
                }));
            }else{
                loginButton.Enabled = false;
                new UserService().showErrorMessage(CommonMessage.LOGIN_USERPASS_WORNG);
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = false;
            loginButton.Enabled = true;
        }

        //------- Custome Method Implementions
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
    }
}

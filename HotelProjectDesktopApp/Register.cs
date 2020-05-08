using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//---
using System.Windows.Forms;
using CloudDesktopApp.Helper;
using CloudDesktopApp.WpfClient.Models;
using CloudDesktopApp.WpfClient.Operations;

namespace CloudDesktopApp
{
    public partial class Register : Form
    {
        public Boolean loginSucess;
        public Register()
        {
            InitializeComponent();
            this.setProgressBar(false);
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new Login().Show();
            }
            catch (Exception msg)
            {
                new UserExceptions().showExceptions(msg.Message);
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(email.Text))
                {
                    throw new Exception(CommonMessage.APP_USER_CREATION_WARN);
                }
                else
                {
                    this.setProgressBar(true);
                    if (!bgWorker.IsBusy)
                    {
                        signUpButton.Enabled = false;
                        progressBar.Style = ProgressBarStyle.Marquee;
                        bgWorker.RunWorkerAsync();
                    }
                    
                }
            }
            catch (Exception msg)
            {
                new UserExceptions().showExceptions(msg.Message);
            }
            
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                User tempUser = new User();
                tempUser.name = name.Text;
                tempUser.userEmail = email.Text;
                tempUser.userPassword = password.Text;
                if (new AuthApiService().registerUser(tempUser) != null)
                {
                    UserService.showSuccessMessage(CommonMessage.APP_USER_CREATION.ToString());
                    this.sendEmailUser(tempUser);
                }
                else
                {
                    throw new Exception(CommonMessage.APP_USER_CREATION_FAIL);
                }
            }
            catch (Exception msg)
            {
                new UserExceptions().showExceptions(msg.Message);
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = false;
            signUpButton.Enabled = true;
            if (loginSucess)
            {
                this.Hide();
                this.succcessFull();
            }
           
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
            this.loginSucess = false;
            progressBar.Visible = progressBarvalue;
        }

        public void succcessFull()
        {
            new Dashboard().Show();
        }

        private void sendEmailUser(User user)
        {
            string res=new EmailService().sendEmailApi(user);
            if(res != null){
                this.loginSucess = true;                    
            }
        }
       
    }
}

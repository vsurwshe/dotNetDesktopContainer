using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------
using MaterialSkin.Controls;
using CloudDesktopApp.Helper;
using CloudDesktopApp.ApiOperations;

namespace CloudDesktopApp
{
    public partial class Regsiter : MaterialForm
    {
        public User resultUser;
        public Regsiter()
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            // This condtions checking username or password filed empty or null
            if (String.IsNullOrEmpty(name.Text) || String.IsNullOrEmpty(password.Text) || String.IsNullOrEmpty(email.Text))
            {
                UserMessage.showWarningMessage(CommonMessage.APP_USER_CREATION_WARN);
            }
            else
            {
                this.setProgressBar(true);
                if (!bgWorker.IsBusy)
                {
                    SignUp.Enabled = false;
                    progressBar.Style = ProgressBarStyle.Marquee;
                    bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
                    bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
                    bgWorker.RunWorkerAsync();
                }
            }
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                User tempUser = new User();
                tempUser.userName = name.Text;
                tempUser.userEmail = email.Text;
                tempUser.userPassword = password.Text;
                if (new LoginRegsiter().registerUser(tempUser) != null)
                {
                    resultUser = tempUser;
                    UserMessage.showSuccessMessage(CommonMessage.APP_USER_CREATION);
                }
                else
                {
                    throw new Exception(CommonMessage.APP_USER_CREATION_FAIL);
                }
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = false;
            SignUp.Enabled = true;
            this.resetFileds();
            if (resultUser != null)
            {
                this.Hide();
                new Login(resultUser.userEmail,resultUser.userPassword).Show();
            }
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

         // This method use for the clear the fileds 
        public Boolean resetFileds()
        {
            name.Text = "";
            email.Text = "";
            password.Text = "";
            return true;
        }
       
    }
}

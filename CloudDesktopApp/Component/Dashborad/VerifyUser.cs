using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//--------
using MaterialSkin.Controls;
using CloudDesktopApp.Helper;
using CloudDesktopApp.ApiOperations;


namespace CloudDesktopApp.Component.Dashborad
{
    public partial class VerifyUser : MaterialForm
    {
        BackgroundWorker verifyBackgroundWorker;
        public VerifyUser()
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            
            // This condtions checking username or password filed empty or null
            if (String.IsNullOrEmpty(verifyText.Text))
            {
                UserMessage.showWarningMessage(CommonMessage.PROFILE_VALID_MESSAGE);
            }
            else
            {
                this.verifyBackgroundWorker = new BackgroundWorker();
                this.setProgressBar(true);
                verifyButton.Enabled = false;
                progressBar.Style = ProgressBarStyle.Marquee;
                verifyBackgroundWorker.DoWork += new DoWorkEventHandler(verifyUser_bgWorker_DoWork);
                verifyBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(verifyUser_bgWorker_RunWorkerCompleted);
                verifyBackgroundWorker.RunWorkerAsync();
            }
        }

        private void verifyUser_bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                User result = new UserService().verifyUser(verifyText.Text);
                if (result != null)
                {
                    UserMessage.showSuccessMessage(CommonMessage.USER_VERIFIED_SUCCESS);
                    this.InvokeProfile(sender,e);
                }
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void verifyUser_bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = false;
            verifyButton.Enabled = true;
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
        // This method calling the main dashborad load profile method
        public void InvokeProfile(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                UserDashborad myParent = (UserDashborad)this.Owner;
                myParent.Dashboard_Click(sender, e);
                this.Dispose();
            }));
        }

    }
}

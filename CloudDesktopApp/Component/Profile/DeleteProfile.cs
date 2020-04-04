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
using CloudDesktopApp.ApiOperations;
using CloudDesktopApp.Helper;

namespace CloudDesktopApp.Component.Profile
{
    public partial class DeleteProfile : MaterialForm
    {
        ProfileModel userProfile;
        BackgroundWorker deleteProfileWorker;

        public DeleteProfile(ProfileModel tempPorfile)
        {
            InitializeComponent();
            this.userProfile = tempPorfile;
            this.profileName.Text = tempPorfile.profileName;
            this.profileType.Text = tempPorfile.type;
        }

        private void deleteProfileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(CommonMessage.PROFILE_DELETE_MESSAGE, "Profile Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                deleteProfileWorker = new BackgroundWorker();
                this.setProgressBar(true);
                deleteProfileButton.Enabled = false;
                progressBar.Style = ProgressBarStyle.Marquee;
                deleteProfileWorker.DoWork += new DoWorkEventHandler(deleteProfile_bgWorker_DoWork);
                deleteProfileWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(deleteProfile_bgWorker_RunWorkerCompleted);
                deleteProfileWorker.RunWorkerAsync();
            }
        }

        private void deleteProfile_bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                String result = new ProfileApiService().deleteProfile(this.userProfile);
                if (result != null)
                {
                    UserMessage.showSuccessMessage(CommonMessage.PROFILE_DELETE_SUCCESS_MESSAGE);
                    this.InvokeProfile();
                }
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void deleteProfile_bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = false;
            deleteProfileButton.Enabled = true;
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
        public void InvokeProfile()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                UserDashborad myParent = (UserDashborad)this.Owner;
                myParent.profileLoad();
                this.Dispose();
            }));
        }
    }
}

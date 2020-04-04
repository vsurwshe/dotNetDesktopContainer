using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//---------
using MaterialSkin.Controls;
using CloudDesktopApp.Helper;
using CloudDesktopApp.ApiOperations;
using Newtonsoft.Json;

namespace CloudDesktopApp.Component.Profile
{
    public partial class UpdateProfile : MaterialForm
    {
        ProfileModel userProfile;
        BackgroundWorker updateProfileWorker;

        public UpdateProfile(ProfileModel profile)
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
            this.userProfile = profile;
            this.profileType.Text = profile.type;
            this.profileName.Text = profile.profileName;
        }

        private void updateProfileButton_Click(object sender, EventArgs e)
        {
            // This condtions checking username or password filed empty or null
            if (String.IsNullOrEmpty(profileName.Text))
            {
                UserMessage.showWarningMessage(CommonMessage.LOGIN_USERPASS_VAILD);
            }
            else
            {
                updateProfileWorker = new BackgroundWorker();
                this.setProgressBar(true);
                updateProfileButton.Enabled = false;
                progressBar.Style = ProgressBarStyle.Marquee;
                updateProfileWorker.DoWork += new DoWorkEventHandler(updateProfile_bgWorker_DoWork);
                updateProfileWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(updateProfile_bgWorker_RunWorkerCompleted);
                updateProfileWorker.RunWorkerAsync();
            }
        }

        private void updateProfile_bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string userBodyData = JsonConvert.SerializeObject(new
                {
                    profileId = this.userProfile.profileId,
                    profileName = profileName.Text,
                    type = this.userProfile.type,
                    version=this.userProfile.version
                });
                ProfileModel result = new ProfileApiService().updateProfile(this.userProfile,userBodyData);
                if (result != null)
                {
                    UserMessage.showSuccessMessage(CommonMessage.PROFILE_UPDATE_SUCCESS);
                    this.InvokeProfile();
                }
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void updateProfile_bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = false;
            updateProfileButton.Enabled = true;
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

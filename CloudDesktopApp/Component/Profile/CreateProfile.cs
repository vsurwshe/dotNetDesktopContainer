using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----------
using MaterialSkin.Controls;
using CloudDesktopApp.Helper;
using CloudDesktopApp.ApiOperations;
using Newtonsoft.Json;

namespace CloudDesktopApp.Component.Profile
{
    public partial class CreateProfile : MaterialForm
    {
        BackgroundWorker createProfileWorker;
        public String ProfileTypeValue;

        public CreateProfile()
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
        }

        private void CreateProfile_Load(object sender, EventArgs e)
        {
            this.loadProfileTypes();
        }

        public void loadProfileTypes()
        {
            try
            {
                List<ProfileTypes> profileTypesResult = new ProfileApiService().getProfilesType();
                if (profileTypesResult.Any())
                {
                    infoProfileTabel.Visible = true;
                    this.setDataGridViewValues(profileTypesResult);
                    ProfileTypesComboBox.DisplayMember = "Text";
                    ProfileTypesComboBox.ValueMember="Value";
                    profilePayment.Text = GlobalClass.user.userBalance.ToString()+" /-";
                    profileTypesResult.ForEach(delegate(ProfileTypes profileType)
                    {
                        ProfileTypesComboBox.Items.Add(new { Text = "Select " + profileType.type.ToString().ToLower() + " profile and pay " + profileType.cost.ToString() + "/- monthly ", Value = profileType.type.ToString() });
                    });
                    ProfileTypesComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void setDataGridViewValues(List<ProfileTypes> profileTypeList)
        {
            infoProfileTabel.DataSource = profileTypeList;
            infoProfileTabel.Columns["id"].Visible = false;
            infoProfileTabel.Columns["version"].Visible = false;
            infoProfileTabel.Columns["name"].Visible = false;
            infoProfileTabel.Columns["cost"].Visible = false;
            // Resizing the name clounm
            infoProfileTabel.Columns["type"].HeaderText = "Profile Types";
            infoProfileTabel.Columns["type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            infoProfileTabel.Columns["type"].Width = 100;
            // Changing header text featuers clounm
            infoProfileTabel.Columns["features"].HeaderText = "Profile Featuers";
            // Resizing the cost clounm
            infoProfileTabel.Columns["cost"].HeaderText = "Cost /- Month";
            infoProfileTabel.Columns["cost"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            infoProfileTabel.Columns["cost"].Width = 80;
        }

        private void CreateProfileButton_Click(object sender, EventArgs e)
        {
            // This condtions checking username or password filed empty or null
            if (String.IsNullOrEmpty(ProfileName.Text))
            {
                UserMessage.showWarningMessage(CommonMessage.PROFILE_VALID_MESSAGE);
            }
            else
            {
                this.ProfileTypeValue = ProfileTypesComboBox.SelectedItem.ToString().Split(',')[1].Split('=')[1].Split('}')[0].Trim(' '); 
                createProfileWorker = new BackgroundWorker();
                this.setProgressBar(true);
                CreateProfileButton.Enabled = false;
                progressBar.Style = ProgressBarStyle.Marquee;
                createProfileWorker.DoWork += new DoWorkEventHandler(createProfile_bgWorker_DoWork);
                createProfileWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(createProfile_bgWorker_RunWorkerCompleted);
                createProfileWorker.RunWorkerAsync();
            }
        }

        private void createProfile_bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string userBodyData = JsonConvert.SerializeObject(new {
                    profileName = ProfileName.Text,
                    type = this.ProfileTypeValue
                });
                ProfileModel result = new ProfileApiService().createProfile(userBodyData);
                if (result != null)
                {
                    UserMessage.showSuccessMessage(CommonMessage.PROFILE_SUCCESS);
                    this.InvokeProfile();
                }
                else
                {
                    throw new Exception(CommonMessage.PROFILE_NOT_SAVE);
                }
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void createProfile_bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = false;
            CreateProfileButton.Enabled = true;
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

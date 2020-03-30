using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//----
using HotelDashboard.WpfClient.Models;
using HotelDashboard.Helper;
using HotelDashboard.WpfClient.Operations;


namespace HotelDashboard.UiScreen.Profile
{
    public partial class CreateProfile : Form
    {
        public CreateProfile()
        {
            InitializeComponent();
            this.setProfileTypes();
        }

        public void setProfileTypes(){
          List<ProfileTypes> result= new ProfileService().getProfileTypes();
          if (result.Any())
          {
              infoProfileTabel.Visible = true;
              this.setDataGridViewValues(result);
              result.ForEach(delegate(ProfileTypes profileType)
              {
                  profileTypeDrop.AddItem(profileType.type);
              });
          }
              
        }

        private void setDataGridViewValues(List<ProfileTypes> profileTypeList)
        {
            infoProfileTabel.DataSource = profileTypeList;
            infoProfileTabel.Columns["id"].Visible = false;
            infoProfileTabel.Columns["version"].Visible = false;
            infoProfileTabel.Columns["name"].Visible = false;
            // Resizing the name clounm
            infoProfileTabel.Columns["type"].HeaderText = "Profile Types";
            infoProfileTabel.Columns["type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            infoProfileTabel.Columns["type"].Width = 100;
            // Changing header text featuers clounm
            infoProfileTabel.Columns["features"].HeaderText = "Profile Featuers";
            // Resizing the cost clounm
            infoProfileTabel.Columns["cost"].HeaderText = "Cost PerMonth";
            infoProfileTabel.Columns["cost"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            infoProfileTabel.Columns["cost"].Width = 80;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                ProfileModel userProfile = new ProfileModel();
                userProfile.profileName = profileNameText.Text;
                userProfile.type = profileTypeDrop.selectedValue.ToString();
                ProfileModel tempResutl= new ProfileService().createProfile(userProfile);
                if (!tempResutl.Equals(null))
                {
                    UserService.showSuccessMessage(CommonMessage.PROFILE_SUCCESS);
                    Dashboard myParent = (Dashboard)this.Owner;
                    myParent.ProfileButton_Click(sender, e);
                    this.Close();
                }
            }
            catch (Exception msg)
            {
                new UserExceptions().showExceptions(msg.Message);
            }
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

    }
}

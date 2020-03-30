using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//-----
using HotelDashboard.WpfClient.Models;
using HotelDashboard.WpfClient.Operations;
using HotelDashboard.Helper;

namespace HotelDashboard.UiScreen.Profile
{
    public partial class UpdateProfile : Form
    {
        ProfileModel tempProfile;
        public UpdateProfile(ProfileModel userProfile)
        {
            InitializeComponent();
            tempProfile = userProfile;
            profileName.Text = userProfile.profileName;
            profileType.Text = userProfile.type;
        }

        private void updateProfileButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tempProfile != null)
                {
                    tempProfile.profileName = profileName.Text;
                   ProfileModel result= new ProfileService().updateProfile(tempProfile);
                   if (result != null)
                   {
                       UserService.showSuccessMessage(CommonMessage.PROFILE_UPDATE_SUCCESS);
                       Dashboard myParent = (Dashboard)this.Owner;
                       myParent.ProfileButton_Click(sender,e);
                       this.Dispose();
                   }
                }
                else
                {
                    throw new Exception(CommonMessage.PROFILE_NOT_FOUND);
                }
            }
            catch (Exception msg)
            {
                new UserExceptions().showExceptions(msg.Message);
            }

        }
    }
}

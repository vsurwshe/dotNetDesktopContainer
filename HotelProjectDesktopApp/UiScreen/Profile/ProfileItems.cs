using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//-------
using HotelDashboard.WpfClient.Models;
using HotelDashboard.WpfClient.Operations;
using HotelDashboard.Helper;

namespace HotelDashboard.UiScreen.Profile
{
    public partial class ProfileItems : UserControl
    {
        public ProfileModel tempProfile;
        public ProfileItems(ProfileModel userPorfile)
        {
            InitializeComponent();
            this.tempProfile = userPorfile;
            subject.Text = userPorfile.profileName;
            subtitle.Text = userPorfile.type;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            //UpdateProfile updateProfile = new UpdateProfile(this.tempProfile);
            //updateProfile.FormClosed += new FormClosedEventHandler(form_Close);
            //updateProfile.Show();
            new UpdateProfile(this.tempProfile).Show(this);
        }

        public void form_Close(object sender, EventArgs e)
        {
            new Profile().Profile_Activated(sender,e);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(CommonMessage.PROFILE_DELETE_MESSAGE, "Profile Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                   String apiResult = new ProfileService().deleteProfile(this.tempProfile);
                   if (apiResult.Equals(CommonMessage.PROFILE_DELETE_SUCCESS_MESSAGE))
                   {
                       UserService.showSuccessMessage(CommonMessage.PROFILE_DELETE_SUCCESS_MESSAGE);
                       new Dashboard().ProfileButton_Click(sender, e);
                       this.Dispose();
                   }
                }
                catch (Exception msg)
                {
                    new UserExceptions().showExceptions(msg.Message); 
                }
            }
        }
    }
}

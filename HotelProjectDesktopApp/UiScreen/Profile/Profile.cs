using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//------
using HotelDashboard.UiScreen;
using HotelDashboard.WpfClient.Operations;
using HotelDashboard.Helper;
using HotelDashboard.WpfClient.Models;

namespace HotelDashboard.UiScreen.Profile
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void createProfile_Click(object sender, EventArgs e)
        {
            new CreateProfile().Show(this);
        }


        private void loadProfiles()
        {
            try
            {
                List<ProfileModel> userProfiles = new ProfileService().getProfiles();
                profilePanel.Controls.Clear();
                userProfiles.ForEach(delegate(ProfileModel profile)
                {
                    ProfileItems setProfile = new ProfileItems(profile);
                    profilePanel.Controls.Add(setProfile);
                });
            }
            catch (Exception msg)
            {
                new UserExceptions().showExceptions(msg.Message);
            }

        }

        public void Profile_Activated(object sender, EventArgs e)
        {
            this.loadProfiles();
        }
    }
}

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
            new UpdateProfile(this.tempProfile).Show();
        }
    }
}

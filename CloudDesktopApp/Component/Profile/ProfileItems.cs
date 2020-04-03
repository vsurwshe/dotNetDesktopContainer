using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//-----
using CloudDesktopApp.ApiOperations;

namespace CloudDesktopApp.Component.Profile
{
    public partial class ProfileItems : UserControl
    {
        ProfileModel tempProfile;
        public ProfileItems(ProfileModel profile)
        {
            InitializeComponent();
            tempProfile = profile;
            this.profileName.Text = profile.profileName;
        }
    }
}

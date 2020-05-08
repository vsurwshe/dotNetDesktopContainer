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
using CloudDesktopApp.Helper;

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
            this.profileType.Text = profile.type;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Form formExits = Application.OpenForms["UpdateProfile"];
            if (formExits != null)
            {
                formExits.Close();
            }
            new UpdateProfile(this.tempProfile).Show(this);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Form formExits = Application.OpenForms["DeleteProfile"];
            if (formExits != null)
            {
                formExits.Close();
            }
            new DeleteProfile(this.tempProfile).Show(this);
        }

        private void setProfile_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.profileId = tempProfile.profileId.ToString();
            MessageBox.Show(tempProfile.profileName+CommonMessage.PROFILE_SELECTED_MESSAGE);
        }
    }
}

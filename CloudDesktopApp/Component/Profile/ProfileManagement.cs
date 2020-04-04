using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------------
using CloudDesktopApp.Helper;
using CloudDesktopApp.ApiOperations;



namespace CloudDesktopApp.Component.Profile
{
    public partial class ProfileManagement : Form
    {
        public ProfileManagement()
        {
            InitializeComponent();
        }
        private void ProfileManagement_Load(object sender, EventArgs e)
        {
            this.loadProfiles();
        }

        public void loadProfiles()
        {
            try
            {
              List<ProfileModel> profiles= new ProfileApiService().loadProfiles();
              if (profiles != null)
              {
                  profilePanel.Controls.Clear();
                  UserProfileLable.Visible = true;
                  profiles.ForEach(delegate(ProfileModel profile)
                  {
                      ProfileItems setProfile = new ProfileItems(profile);
                      profilePanel.Controls.Add(setProfile);
                  });
              }
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }
        

        private void profileCreate_Click(object sender, EventArgs e)
        {
            Form formExits = Application.OpenForms["CreateProfile"];
            if (formExits != null)
            {
                formExits.Close();
            }
            new CreateProfile().Show(this);
        }
    }
}

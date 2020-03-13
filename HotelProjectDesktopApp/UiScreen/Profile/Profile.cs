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
            new CreateProfile().Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            this.setProfileGird();
            this.loadProfiles();
        }

        private void loadProfiles()
        {
            ProfileItems pr = new ProfileItems();
            pr.subject.Text = "Free";
            pr.subtitle.Text = "Free";
            profilePanel.Controls.Add(pr);
            ProfileItems pr2 = new ProfileItems();
            pr2.subject.Text = "Free1";
            pr2.subtitle.Text = "Free1";
            profilePanel.Controls.Add(pr2);
        }


        private void setProfileGird()
        {
            try
            {
                new ProfileService().getProfiles();
            }
            catch (Exception msg)
            {
                new UserExceptions().showExceptions(msg.Message);
            }
        
        }

    }
}

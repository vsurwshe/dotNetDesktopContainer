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

namespace HotelDashboard.UiScreen
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelDashboard.UiScreen.Profile
{
    public partial class ProfileItems : UserControl
    {
        public ProfileItems()
        {
            InitializeComponent();
        }

        public void setCardDetails(string profileName, string profileType)
        {
            subject.Text = profileName;
            subtitle.Text = profileType;
        }


    }
}

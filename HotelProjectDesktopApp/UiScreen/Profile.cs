using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            new HotelDashboard.UiScreen.CreateProfile().Show();
        }
    }
}

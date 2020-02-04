﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelDashboard.UiScreen
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
           HotelDashboard.WpfClient.Models.TokenResponse user = new HotelDashboard.WpfClient.Operations.ApiOperations().AuthenticateUser("v@v.com", "123456");
           l2.Text = user.userToken;
        }
    }
}

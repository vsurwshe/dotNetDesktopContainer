using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//---
using System.Windows.Forms;
using HotelDashboard.Helper;

namespace HotelDashboard
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new Login().Show();
            }
            catch (Exception msg)
            {
                new UserExceptions().showExceptions(msg.Message);
            }
        }
    }
}

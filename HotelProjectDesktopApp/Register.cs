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
using HotelDashboard.WpfClient.Models;
using HotelDashboard.WpfClient.Operations;

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

        private void signUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(email.Text))
                {
                    throw new Exception(CommonMessage.APP_USER_CREATION_WARN);
                }
                else
                {
                    User tempUser = new User();
                    tempUser.name = name.Text;
                    tempUser.userEmail = email.Text;
                    tempUser.userPassword = password.Text;
                    User res= new ApiOperations().registerUser(tempUser);
                    if (res != null)
                    {
                        UserService.showSuccessMessage(CommonMessage.APP_USER_CREATION.ToString());
                    }
                    else
                    {
                        throw new Exception(CommonMessage.APP_USER_CREATION_FAIL);
                    }
                }
            }
            catch (Exception msg)
            {
                new UserExceptions().showExceptions(msg.Message);
            }
            
        }
    }
}

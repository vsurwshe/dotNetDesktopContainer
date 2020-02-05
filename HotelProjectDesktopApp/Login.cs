using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelDashboard
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.setProgressBar(false);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(username.Text) || String.IsNullOrEmpty(password.Text))
            { new HotelDashboard.Helper.UserService().showWarningMessage("Please Enter Vaild Username or Password !"); }
            else
            {
                this.setProgressBar(true);
                if (!bgWorker.IsBusy)
                {
                    loginButton.Enabled = false;
                    progressBar.Style = ProgressBarStyle.Continuous;
                    bgWorker.RunWorkerAsync();
                }
            }
        }

        private void signupButton_Click(object sender, EventArgs e)
        {

        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            String res= new HotelDashboard.Helper.UserService().getAuthenticate(username.Text, password.Text);
            if (res != null)
            {
                this.Invoke(new MethodInvoker(delegate(){
                    this.Hide();
                    new Dashboard().Show();
                }));
            }else{
                loginButton.Enabled = false;
                new HotelDashboard.Helper.UserService().showErrorMessage("You Provided Username and Password are Wrong !");
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = false;
            loginButton.Enabled = true;
        }


        //-------

        private void setProgressBar(Boolean progressBarvalue)
        {
            if (progressBarvalue)
            {// This lines setting progress bar values 
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                progressBar.Value = 10;
                progressBar.Step = 10;
            }
           progressBar.Visible = progressBarvalue;
        }
      

        

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//--------
using MaterialSkin.Controls;
using CloudDesktopApp.Helper;
using CloudDesktopApp.ApiOperations;
using Newtonsoft.Json;

namespace CloudDesktopApp.Component.Customer
{
    public partial class CustomerForm : MaterialForm
    {
        BackgroundWorker createCustomerWorker;
        public CustomerForm()
        {
            InitializeComponent();
            SkinClass.SetSkiner(this);
        }

        private void saveHotelTabelButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(customerAddress.Text) || String.IsNullOrEmpty(customerAddress.Text) || String.IsNullOrEmpty(customerName.Text) || String.IsNullOrEmpty(customerMobileNo.Text) || String.IsNullOrEmpty(customerEmail.Text))
                {
                    UserMessage.showWarningMessage(CommonMessage.CUSTOMER_INVALID_DATA_MESSAGE);
                }
                else
                {
                    createCustomerWorker = new BackgroundWorker();
                    this.setProgressBar(true);
                    saveCustomerButton.Enabled = false;
                    progressBar.Style = ProgressBarStyle.Marquee;
                    createCustomerWorker.DoWork += new DoWorkEventHandler(createCustomer_bgWorker_DoWork);
                    createCustomerWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(saveCustomer_bgWorker_RunWorkerCompleted);
                    createCustomerWorker.RunWorkerAsync();  
                }
}

        private void createCustomer_bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string customerBodyData = JsonConvert.SerializeObject(new {
                     customerName =customerName.Text,
                     customerMobileNo=customerMobileNo.Text,
                     customerEmail=customerEmail.Text,
                     customerAddress =customerAddress.Text
                });

                CustomerModel result = new CustomerApiServices().saveCustomer(customerBodyData);
                if (result != null)
                {
                    UserMessage.showSuccessMessage(CommonMessage.CUSTOMER_SAVED_SUCCESS_MESSAGE);
                    this.InvokeCustomer(sender,e);
                }
                else
                {
                    throw new Exception(CommonMessage.PROFILE_NOT_SAVE);
                }            
            }
            catch (Exception msg)
            {
                UserMessage.ShowExceptions(msg.Message);
            }
        }

        private void saveCustomer_bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Style = ProgressBarStyle.Blocks;
            progressBar.Visible = false;
            saveCustomerButton.Enabled = true;
        }

        // This method seting values of progress bar
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
        // This method calling the main dashborad load profile method
        public void InvokeCustomer(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                UserDashborad myParent = (UserDashborad)this.Owner;
                myParent.customer_Click(sender,e);
                this.Dispose();
            }));
        }
    }
}

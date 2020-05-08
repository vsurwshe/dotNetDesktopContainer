using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//----
using CloudDesktopApp.WpfClient.Models;
using CloudDesktopApp.Helper;
using Newtonsoft.Json;
using System.Net;

namespace CloudDesktopApp.WpfClient.Operations
{
    class EmailService
    {
        string commonUrl = null;
        
        public EmailService()
        {
            this.commonUrl = "email/";
        }

        public string sendEmailApi(User user)
        {
            string userBodyData = JsonConvert.SerializeObject(new
            {
                toAddress = user.userEmail,
                subject = CommonMessage.EMAIL_SUBJECT,
                body= new UserService().getEmailBody(user)
            });

            // This line calling api using access token and store result of api into res varilabel
            string res = new ApiOperations().callApi(this.commonUrl + "sendEmail", "POST", userBodyData, false);
            return res;
        }
    }
}

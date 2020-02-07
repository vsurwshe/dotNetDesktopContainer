using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
//------
using HotelDashboard.WpfClient.Models;
using HotelDashboard.Helper;
using Newtonsoft.Json;


namespace HotelDashboard.WpfClient.Operations
{
    class ApiOperations
    {
        private string baseUrl;
        public ApiOperations()
        {
            this.baseUrl = "http://10.10.10.15:7000/";
        }

        // this method common for all api with access token needs to be call 
        public string callApi(string userUrl, string userMethod, string userBody,Boolean token)
        {   // this line makes final url for the api call using user url and base url.
            string endpoint = this.baseUrl + userUrl;
            string response = null;
            WebClient wc = new WebClient();
            // this line setting content type of request
            wc.Headers["Content-Type"] = "application/json";
            if (token)
            {
                // this line adding Authoriazations with our user token
                wc.Headers["Authorization"] = "" + Properties.Settings.Default.userToken;
            }
            try
            {   //this checking which method want to execute the user Ex. POST and PUT
                if (userMethod == "POST" || userMethod == "PUT")
                {
                    response = wc.UploadString(endpoint, userMethod, userBody);
                }
                else
                { // this executing for the GET and DELETE method
                    response = wc.UploadString(endpoint, userMethod);
                }
            }
            catch (WebException msg)
            {
                response = null;
            }

            return response;
        }
    }
}

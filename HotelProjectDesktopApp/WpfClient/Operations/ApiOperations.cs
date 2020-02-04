using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
//------
using HotelDashboard.WpfClient.Models;
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


        /**
        * Authenticate user with Web Api Endpoint
        * @param string username
        * @param string password
        */
        public TokenResponse AuthenticateUser(string username, string password)
        {
            string endpoint = this.baseUrl + "auth/user/token";
            string method = "POST";
            string json = JsonConvert.SerializeObject(new
            {
                userEmail = username,
                userPassword = password
            });
            WebClient wc = new WebClient();
            wc.Headers["Content-Type"] = "application/json";
            try
            {
                string response = wc.UploadString(endpoint, method, json);
                return JsonConvert.DeserializeObject<TokenResponse>(response);
            }
            catch (Exception msg)
            {
                new HotelDashboard.Helper.UserExceptions().showExceptions(msg.Message);
                return null;
            }
        }
    }
}

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
            catch (WebException msg)
            {
                TokenResponse token = new TokenResponse();
                if (msg.Status == WebExceptionStatus.ProtocolError)
                {
                    HttpWebResponse response = (HttpWebResponse)msg.Response;
                    // This condtions checking 500 error got or not
                    if ((int)response.StatusCode == 500)
                    { token.userToken="500 Error";}
                }
                else
                {
                    new UserExceptions().showExceptions(msg.Message);
                    token.userToken = null;
                }
                return token;
            }
        }
    }
}

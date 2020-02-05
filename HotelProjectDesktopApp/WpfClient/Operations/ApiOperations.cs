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
                    { token.userToken=CommonMessage.SYS_500_ERROR;}
                }
                else
                {
                    new UserExceptions().showExceptions(msg.Message);
                    token.userToken = null;
                }
                return token;
            }
        }

         /*
         * This method register the user by taking User Model as parameter
         */

        public User registerUser(User userInput)
        {   // This lines making josn data for api calling
            string userBodyData = JsonConvert.SerializeObject(new {
                name=userInput.name,
                userEmail = userInput.userEmail,
                userPassword = userInput.userPassword,
            });
            
            // This line calling api using access token and store result of api into res varilabel
            string res=this.callApiUsingAccessToken("auth/user/register","POST",userBodyData);
            if (res != null)
            {   // this line convert string result into Josn and paste into User Model and returning user model
                return JsonConvert.DeserializeObject<User>(res);
            }
            return null;
        }

        // this method common for all api with access token needs to be call 
        public string callApiUsingAccessToken(string userUrl,string userMethod, string userBody)
        {   // this line makes final url for the api call using user url and base url.
            string endpoint = this.baseUrl + userUrl;
            string response=null;
            // this condtions checking user token is there or not
            if (Properties.Settings.Default.userToken != "")
            {   // this line creating new object for WebClient call
                WebClient wc = new WebClient();
                // this line setting content type of request
                wc.Headers["Content-Type"] = "application/json";
                // this line adding Authoriazations with our user token
                wc.Headers["Authorization"] = ""+Properties.Settings.Default.userToken;
                try
                {   //this checking which method want to execute the user Ex. POST and PUT
                    if (userMethod == "POST" || userMethod == "PUT")
                    {
                        response = wc.UploadString(endpoint, userMethod, userBody);
                    }else{ // this executing for the GET and DELETE method
                        response = wc.UploadString(endpoint, userMethod);
                    }
                }
                catch (WebException msg)
                {
                    return msg.ToString();
                }
            }
            return response;
        }
    }
}

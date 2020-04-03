using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//-----
using HotelDashboard.WpfClient.Models;
using HotelDashboard.Helper;
using Newtonsoft.Json;
using System.Net;

namespace HotelDashboard.WpfClient.Operations
{
     class AuthApiService
    {
        public string commonUrl = "";

        public AuthApiService()
        {
            this.commonUrl = "auth/user/";
        }

       /**
       * Authenticate user with Web Api Endpoint
       * @param string username
       * @param string password
       */
        public string AuthenticateUser(string username, string password)
        {
            string userBodyData = JsonConvert.SerializeObject(new{
                userEmail = username,
                userPassword = password
            });

            // This line calling api using access token and store result of api into res varilabel
            string res = new ApiOperations().callApi(this.commonUrl + "token", "POST", userBodyData,false);
            return (res != null) ? this.setUserToken(JsonConvert.DeserializeObject<TokenResponse>(res)) : null;
        }

        // This user method register the user 
        public User registerUser(User userInput)
        {   // This lines making josn data for api calling
            string userBodyData = JsonConvert.SerializeObject(new
            {
                name = userInput.name,
                userEmail = userInput.userEmail,
                userPassword = userInput.userPassword,
            });

            // This line calling api using access token and store result of api into res varilabel
            string res = new ApiOperations().callApi( this.commonUrl+"register", "POST", userBodyData,false);
            return (res != null) ? JsonConvert.DeserializeObject<User>(res) : null;
        }

        //-----

        public string setUserToken(TokenResponse user)
        {
            Properties.Settings.Default.userToken = user.userToken;
            Properties.Settings.Default.refreshToekn = user.userRefreshToken;
            return "true";
        }

    }
}

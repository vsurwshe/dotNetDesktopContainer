using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
//------
using HotelDashboard.WpfClient.Models;
using HotelDashboard.Helper;
using Newtonsoft.Json;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;


namespace HotelDashboard.WpfClient.Operations
{
    class ApiOperations
    {
        private string baseUrl;
        public ApiOperations()
        {
            //this.baseUrl = "http://10.10.10.15:7000/";
            this.baseUrl = ConfigurationManager.AppSettings.Get("URL");
        }

        // this method common for all api with access token needs to be call 
        public string callApi(string userUrl, string userMethod, string userBody, Boolean token)
        {   // this line makes final url for the api call using user url and base url.
            string endpoint = this.baseUrl + userUrl;
            string response = null;
            WebClient wc = new WebClient();
            // this line setting content type of request
            wc.Headers["Content-Type"] = "application/json";
            wc.Encoding = Encoding.UTF8;
            if (token)
            {
                // this line adding Authoriazations with our user token
                wc.Headers["Authorization"] = "Bearer " + Properties.Settings.Default.userToken;
            }
            try
            {   //this checking which method want to execute the user Ex. POST and PUT
                if (userMethod == "POST" || userMethod == "PUT")
                {
                    response = wc.UploadString(endpoint, userMethod, userBody);
                }
                else
                {
                    if (userMethod == "DELETE")
                    {
                        using (var httpClient = new HttpClient())
                        {
                            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.userToken);
                            var result = httpClient.DeleteAsync(endpoint).Result;
                            if(result.IsSuccessStatusCode){
                                response = CommonMessage.PROFILE_DELETE_SUCCESS_MESSAGE;
                            }else{
                                response = CommonMessage.PROFILE_DELETE_UNSUCCESS_MESSAGE;
                            }
                        }
                    }
                    else
                    {   // this executing for the GET and DELETE method
                        response = wc.DownloadString(endpoint);
                    }
                }
            }
            catch (WebException msg)
            {
                new HotelDashboard.Helper.UserExceptions().showExceptions(msg.Message);
                response = null;
            }
            return response;
        }
    }
}

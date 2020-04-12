using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------
using System.Configuration;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using CloudDesktopApp.Helper;

namespace CloudDesktopApp.ApiOperations
{
    class CommonApiOperation
    {
        public String CommonUrl;
        public HttpClient client;

        public CommonApiOperation()
        {
            this.CommonUrl = ConfigurationManager.AppSettings.Get("URL");
            this.client = new HttpClient();
        }

        public Object apiCall(String url, String userMethod, String userBody, Boolean token)
        {
            String result = null;
            result = this.commonApiCall(CommonUrl + url, userMethod, userBody, token).Result.Content.ReadAsStringAsync().Result.ToString();
            return result;
        }

        async public Task<HttpResponseMessage> commonApiCall(String userUrl, String userMethod,Object modelName, Boolean token, Boolean doubleCall=false)
        {
            HttpResponseMessage response = null;
            if (token)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.userToken);
            }
            switch (userMethod)
            {
                case "GET": response =  await client.GetAsync(userUrl).ConfigureAwait(false);
                            break;
                case "POST": response = await client.PostAsync(userUrl, new StringContent(modelName.ToString(), Encoding.UTF8, "application/json")).ConfigureAwait(false);
                             break;
                case "PUT":  response = await client.PutAsync(userUrl, new StringContent(modelName.ToString(), Encoding.UTF8, "application/json")).ConfigureAwait(false);
                             break;
                case "DELETE":response = await client.DeleteAsync(userUrl).ConfigureAwait(false);
                              break;
            }
            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                switch (response.StatusCode)
                {
                    case HttpStatusCode.Unauthorized:
                        break;
                    case  HttpStatusCode.NotFound:
                        response.Content = new StringContent(CommonMessage.NOT_FOUND);
                        break;
                    case HttpStatusCode.InternalServerError: 
                        response.Content = new StringContent(CommonMessage.INTERNAL_SERVER_ERROR);
                        break;
                    case HttpStatusCode.BadRequest: 
                        response.Content = new StringContent(CommonMessage.BAD_REQUEST);
                        break;
                    default: return null;
                }
                return response;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------
using System.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

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
            if (userMethod == "GET")
            {
                result = this.getRequest(CommonUrl + url, token).Result.Content.ReadAsStringAsync().Result.ToString();
            }
            else
            {
                if (userMethod == "POST")
                {
                    result = this.postRequest(CommonUrl + url, userBody, token).Result.Content.ReadAsStringAsync().Result.ToString();
                }
                else
                {
                    if (userMethod == "PUT")
                    {
                        result = this.putRequest(CommonUrl + url, userBody, token).Result.Content.ReadAsStringAsync().Result.ToString();
                    }
                    else
                    {
                        if (userMethod == "DELETE")
                        {
                            result = this.deleteRequest(CommonUrl + url, token).Result.Content.ReadAsStringAsync().Result.ToString();
                        }    
                    }
                }
            }
            return result;
        }

        async public Task<HttpResponseMessage> getRequest(String userUrl, Boolean token)
        {
            if (token)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.userToken);
            }
            HttpResponseMessage response = await client.GetAsync(userUrl).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return null;
            }
        }

        async public Task<HttpResponseMessage> postRequest(String userUrl, Object modelName, Boolean token)
        {
            if (token)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.userToken);
            }
          HttpResponseMessage response= await client.PostAsync(userUrl, new StringContent(modelName.ToString(),Encoding.UTF8,"application/json")).ConfigureAwait(false);
          if (response.IsSuccessStatusCode)
          {
              return response;
          }
          else
          {
              return null;
          }
        }

        async public Task<HttpResponseMessage> putRequest(String userUrl, Object modelName, Boolean token)
        {
            if (token)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.userToken);
            }
            HttpResponseMessage response = await client.PutAsync(userUrl, new StringContent(modelName.ToString(), Encoding.UTF8, "application/json")).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return null;
            }
        }
        async public Task<HttpResponseMessage> deleteRequest(String userUrl,Boolean token)
        {
            if (token)
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.userToken);
            }
            HttpResponseMessage response = await client.DeleteAsync(userUrl).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            else
            {
                return null;
            }
        }

    }
}

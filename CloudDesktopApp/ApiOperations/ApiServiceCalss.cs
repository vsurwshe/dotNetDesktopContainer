using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------
using CloudDesktopApp.Helper;
using CloudDesktopApp.ApiOperations;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace CloudDesktopApp.ApiOperations
{
    class ApiServiceCalss
    {
    }

    // This the login and resgister api service class
    public class LoginRegsiter
    {
        public string commonUrl;
        public LoginRegsiter()
        {
            this.commonUrl = "auth/user/";
        }
        
        // This method used for the login 
        public TokenResponse loginUser(string userBodyData)
        {
            TokenResponse result = null;
               Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "token", "POST", userBodyData, false);
               if (resultApi != null)
               {
                   result = JsonConvert.DeserializeObject<TokenResponse>(resultApi.ToString()); 
               }
               else
               {
                   throw new Exception(CommonMessage.LOGIN_USERPASS_WORNG);
               }
               return result;
        }
    }
}

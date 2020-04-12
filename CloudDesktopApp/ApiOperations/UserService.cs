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
    class UserService
    {
        public string commonUrl;
        public UserService()
        {
            this.commonUrl = "auth/user/";
        }

        public User verifyUser(string verificationCode)
        {
            User result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + GlobalClass.user.userId +"/verify/"+verificationCode, "GET", null, false);
            if (CommonClasses.checkResposeResult(resultApi))
            {
                result = JsonConvert.DeserializeObject<User>(resultApi.ToString());
            }
            else
            {
                throw new Exception(CommonMessage.USER_VERIFIED_UNSUCCESS);
            }
            return result;
        }
    }
}

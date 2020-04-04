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
        
        // This method use for the regsiter the user.
        public User registerUser(User user)
        {
            User result = null;
            var userBodyData = JsonConvert.SerializeObject(new
            {
                userEmail = user.userEmail,
                userPassword = user.userPassword,
                userName=user.userName
            });
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "register", "POST", userBodyData, false);
            if (resultApi != null)
            {
                result = JsonConvert.DeserializeObject<User>(resultApi.ToString());
            }
            else
            {
                throw new Exception(CommonMessage.APP_USER_CREATION_FAIL);
            }
            return result;
        }
    }

    // This method used for the 
    class ProfileApiService
    {
        public string commonUrl;
        public ProfileApiService()
        {
            this.commonUrl = "user/profile/";
        }

        // This method get the profile types 
        public List<ProfileTypes> getProfilesType()
        {
            List<ProfileTypes> result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "types", "GET", null, true);
            if(resultApi != null)
            {
                result = JsonConvert.DeserializeObject<List<ProfileTypes>>(resultApi.ToString());
            }
            return result;
        }

        public List<ProfileModel> loadProfiles()
        {
            List<ProfileModel> result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "getAll", "GET", null, true);
            if (resultApi != null && !resultApi.Equals(CommonMessage.NOT_FOUND) )
            {
                result = JsonConvert.DeserializeObject<List<ProfileModel>>(resultApi.ToString());
            }
            else
            {
                throw new Exception(CommonMessage.PROFILE_NOT_FOUND);
            }
            return result;
        }

        // This method used for the creating profile
        public ProfileModel createProfile(string userBodyData)
        {
            ProfileModel result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "saveProfile", "POST", userBodyData, true);
            if (resultApi != null)
            {
                result = JsonConvert.DeserializeObject<ProfileModel>(resultApi.ToString());
            }
            else
            {
                throw new Exception(CommonMessage.PROFILE_NOT_SAVE);
            }
            return result;
        }

        // This method used for the update the profile
        public ProfileModel updateProfile(ProfileModel userProfile,string userBodyData)
        {
            ProfileModel result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl+userProfile.profileId+"/updateProfile","PUT",userBodyData,true);
            if (resultApi != null)
            {
                result = JsonConvert.DeserializeObject<ProfileModel>(resultApi.ToString());
            }
            else
            {
                throw new Exception(CommonMessage.PROFILE_UPDATE_UNSUCCESS);
            }
            return result;
        }

        // This method used for the update the profile
        public String deleteProfile(ProfileModel profileModel)
        {
            String result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl+profileModel.profileId,"DELETE",null,true);
            if (resultApi != null)
            {
                result = resultApi.ToString();
            }
            else
            {
                throw new Exception(CommonMessage.PROFILE_DELETE_UNSUCCESS_MESSAGE);
            }
            return result;
        }
    }
}

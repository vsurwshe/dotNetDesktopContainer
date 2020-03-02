using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//-----
using Newtonsoft.Json;
using HotelDashboard.WpfClient.Models;
using HotelDashboard.WpfClient.Operations;

namespace HotelDashboard.WpfClient.Operations
{
    class ProfileService
    {
        public String commonURL;
        public ProfileService()
        {
            this.commonURL = "user/profile/";
        }

        public List<ProfileTypes> getProfileTypes()
        {
           List<ProfileTypes> result=null;
            try
            {
                string apiResult = new ApiOperations().callApi(this.commonURL + "types", "get", null, true);
                if (!apiResult.Equals(null))
                {
                    result = JsonConvert.DeserializeObject<List<ProfileTypes>>(apiResult);
                }
            }
            catch (Exception msg)
            {
                new HotelDashboard.Helper.UserExceptions().showExceptions(msg.Message);
            }
            return result; 
        }

        public ProfileModel createProfile(ProfileModel userProfile)
        {
            ProfileModel profileResult = null;
            String userBodyData = JsonConvert.SerializeObject(new
            {
                profileName = userProfile.name,
                type = userProfile.type
            });
            try
            {
                String apiResult=new ApiOperations().callApi(this.commonURL + "saveProfile", "POST", userBodyData, true);
                if (!apiResult.Equals(null))
                {
                    profileResult = JsonConvert.DeserializeObject<ProfileModel>(apiResult);
                }
            }
            catch (Exception msg)
            {
                throw new Exception(msg.Message);
            }
            return profileResult;
        }

    }
}

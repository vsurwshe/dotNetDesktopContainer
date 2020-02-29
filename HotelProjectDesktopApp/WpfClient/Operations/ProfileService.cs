using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//-----
using Newtonsoft.Json;
using HotelDashboard.WpfClient.Models;

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
                string apiResult = new HotelDashboard.WpfClient.Operations.ApiOperations().callApi(this.commonURL + "types", "get", null, true);
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
    }
}

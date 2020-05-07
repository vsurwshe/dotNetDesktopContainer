﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------
using CloudDesktopApp.Helper;
using Newtonsoft.Json;

namespace CloudDesktopApp.ApiOperations
{
    class CustomerApiServices
    {
        public string commonUrl;
        public CustomerApiServices()
        {
            String profileId = Properties.Settings.Default.profileId;
            if (profileId != null)
            {
                this.commonUrl = "user/profile/" + profileId + "/customer/";
            }
            else
            {
                UserMessage.showWarningMessage(CommonMessage.PROFILE_CREATED_MESSAGE);
            }
        }

        // This method used for the saving customer 
        public CustomerModel saveCustomer(string customerBodyData)
        {
            CustomerModel result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "save", "POST", customerBodyData, true);
            if (CommonClasses.checkResposeResult(resultApi))
            {
                result = JsonConvert.DeserializeObject<CustomerModel>(resultApi.ToString());
            }
            else
            {
                throw new Exception(CommonMessage.PROFILE_NOT_SAVE);
            }
            return result;
        }

        // This method used for the update the profile
        public CustomerModel updateCustomer(int customerId, string customerBodyData)
        {
            CustomerModel result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "/update/"+customerId, "PUT", customerBodyData, true);
            if (CommonClasses.checkResposeResult(resultApi))
            {
                result = JsonConvert.DeserializeObject<CustomerModel>(resultApi.ToString());
            }
            else
            {
                throw new Exception(CommonMessage.PROFILE_UPDATE_UNSUCCESS);
            }
            return result;
        }

        // This method used for the update the profile
        public String deleteCustomer(CustomerModel customerModel)
        {
            String result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl +"/delete/"+customerModel.customerId, "DELETE", null, true);
            if (CommonClasses.checkResposeResult(resultApi))
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

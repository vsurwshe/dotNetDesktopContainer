using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------
using CloudDesktopApp.Helper;
using Newtonsoft.Json;

namespace CloudDesktopApp.ApiOperations
{
    class FoodApiServices
    {
        public string commonUrl;
        public FoodApiServices()
        {
            String profileId = Properties.Settings.Default.profileId;
            if (profileId != null)
            {
                this.commonUrl = "user/profile/" + profileId + "/food/";
            }
            else
            {
                UserMessage.showWarningMessage(CommonMessage.PROFILE_CREATED_MESSAGE);
            }
        }

        // This method used for the get the food list 
        public List<FoodModel> getFoods()
        {
            List<FoodModel> result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "gets", "GET", null, true);
            if (CommonClasses.checkResposeResult(resultApi))
            {
                result = JsonConvert.DeserializeObject<List<FoodModel>>(resultApi.ToString());
            }
            else
            {
                throw new Exception(CommonMessage.FOOD_NO_RECORD_MESSAGE);
            }
            return result;
        }

        // This method used for the saving food details
        public FoodModel saveFood(string foodBodyData)
        {
            FoodModel result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "save", "POST", foodBodyData, true);
            if (CommonClasses.checkResposeResult(resultApi))
            {
                result = JsonConvert.DeserializeObject<FoodModel>(resultApi.ToString());
            }
            else
            {
                throw new Exception(CommonMessage.FOOD_SAVED_UNSUCCESS_MESSAGE);
            }
            return result;
        }

        // This method used for the update the food deatils
        public FoodModel updateFood(int foodId, string foodBodyData)
        {
            FoodModel result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "update/" + foodId, "PUT", foodBodyData, true);
            if (CommonClasses.checkResposeResult(resultApi))
            {
                result = JsonConvert.DeserializeObject<FoodModel>(resultApi.ToString());
            }
            else
            {
                throw new Exception(CommonMessage.FOOD_UPDATE_UNSUCCESS_MESSAGE);
            }
            return result;
        }

        // This method used for the delete the food deatils
        public String deleteFood(FoodModel foodModel)
        {
            String result = null;
            Object resultApi = new CommonApiOperation().apiCall(this.commonUrl + "delete/" + foodModel.foodId, "DELETE", null, true);
            if (CommonClasses.checkResposeResult(resultApi))
            {
                result = resultApi.ToString();
            }
            else
            {
                throw new Exception(CommonMessage.FOOD_DELETE_UNSUCCESS_MESSAGE);
            }
            return result;
        }
    }
}

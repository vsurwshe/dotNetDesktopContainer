using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudDesktopApp.Helper
{
    class CommonMessage
    {
        //---- Status Code ---
        public static String NOT_FOUND = "Not Found";
        public static String INTERNAL_SERVER_ERROR = "Internal Server Error";
        public static String BAD_REQUEST = "Bad Request";
        //-------- Common string ----
        public static String NOT_ENABLED = " Please verify your account. You are not verifyed ?";
        public static String USER_VERIFIED_UNSUCCESS = " Sorry your Verifications is not done successfully.";
        public static String USER_VERIFIED_SUCCESS = " Your Verifications is done successfully.";
        //----- User realted string message ---
        public static String LOGIN_USERPASS_WORNG = "You Provided Username and Password are Wrong !";
        public static String LOGIN_USERPASS_VAILD = "Please Enter Vaild Username or Password !";
        public static String SYS_500_ERROR = "500 Error";
        public static String APP_EXIT_MSG ="Are Sure want to Exit form Applications ? ";
        public static String APP_USER_CREATION= "You SuccessFully Registerd !";
        public static String APP_USER_CREATION_FAIL = "You Not SuccessFully Register !";
        public static String APP_USER_CREATION_WARN = "Plesae Provide Vaild Details";
        public static String EMAIL_SUBJECT = "User registered on "+DateTime.Now.ToShortDateString();

        //----- Profile related string
        public static String PROFILE_SUCCESS = "Your Profile Created Successfully";
        public static String PROFILE_VALID_MESSAGE = "Please enter valid data";
        public static String PROFILE_UPDATE_SUCCESS = "Your Profile Updated Successfully";
        public static String PROFILE_UPDATE_UNSUCCESS = "Your Profile Not Updated Successfully";
        public static String PROFILE_NOT_FOUND = "No Profiles found";
        public static String PROFILE_NOT_SAVE = "Your Profile is not Save";
        public static String PROFILE_DELETE_MESSAGE = "Are you sure want to delete this profile ?";
        public static String PROFILE_DELETE_UNSUCCESS_MESSAGE = "Sorry your profile is not deleted successfully";
        public static String PROFILE_DELETE_SUCCESS_MESSAGE = "Your profile is deleted successfully";
        public static String PROFILE_CREATED_MESSAGE = "Please create the any profile";
        public static String PROFILE_SELECTED_MESSAGE = " This profile will be selected now.";

        //----- Customer realted string
        public static String CUSTOMER_INVALID_DATA_MESSAGE = "Please create the any profile";
        public static String CUSTOMER_NO_RECORD_MESSAGE = "There is no list of Customers in this profile";
        public static String CUSTOMER_SAVED_SUCCESS_MESSAGE = "Your customer record saved successfully";
        public static String CUSTOMER_SAVED_UNSUCCESS_MESSAGE = "Your customer record not saved successfully";
        public static String CUSTOMER_UPDATE_SUCCESS_MESSAGE = "Your customer record updated successfully";
        public static String CUSTOMER_UPDATE_UNSUCCESS_MESSAGE = "Your customer record not updated Successfully";
        public static String CUSTOMER_DELETE_SUCCESS_MESSAGE = "Your customer record deleted successfully";
        public static String CUSTOMER_DELETE_UNSUCCESS_MESSAGE = "Your customer record not deleted successfully";

        //----- Food realted string
        public static String FOOD_INVALID_DATA_MESSAGE = "Please enter valid data";
        public static String FOOD_NO_RECORD_MESSAGE = "There is no list of foods in this profile";
        public static String FOOD_SAVED_SUCCESS_MESSAGE = "Your food record saved successfully";
        public static String FOOD_SAVED_UNSUCCESS_MESSAGE = "Your food record not saved successfully";
        public static String FOOD_UPDATE_SUCCESS_MESSAGE = "Your food record updated successfully";
        public static String FOOD_UPDATE_UNSUCCESS_MESSAGE = "Your food record not updated Successfully";
        public static String FOOD_DELETE_SUCCESS_MESSAGE = "Your food record deleted successfully";
        public static String FOOD_DELETE_UNSUCCESS_MESSAGE = "Your food record not deleted successfully";

        //----- Hotel tabel realted string
        public static String HOTEL_TABLE_INVALID_DATA_MESSAGE = "Please enter valid data";
        public static String HOTEL_TABLE_NO_RECORD_MESSAGE = "There is no list of hotel table in this profile";
        public static String HOTEL_TABLE_SAVED_SUCCESS_MESSAGE = "Your hotel table record saved successfully";
        public static String HOTEL_TABLE_SAVED_UNSUCCESS_MESSAGE = "Your hotel table record not saved successfully";
        public static String HOTEL_TABLE_UPDATE_SUCCESS_MESSAGE = "Your hotel table record updated successfully";
        public static String HOTEL_TABLE_UPDATE_UNSUCCESS_MESSAGE = "Your hotel table record not updated Successfully";
        public static String HOTEL_TABLE_DELETE_SUCCESS_MESSAGE = "Your hotel table record deleted successfully";
        public static String HOTEL_TABLE_DELETE_UNSUCCESS_MESSAGE = "Your hotel table record not deleted successfully";

    }
}

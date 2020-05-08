using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudDesktopApp.Helper
{
    class CommonMessage
    {
        public static String LOGIN_USERPASS_WORNG = "You Provided Username and Password are Wrong !";
        public static String LOGIN_USERPASS_VAILD = "Please Enter Vaild Username or Password !";
        public static String SYS_500_ERROR = "500 Error";
        public static String APP_EXIT_MSG ="Are Sure want to Exit form Applications ? ";
        public static String APP_USER_CREATION= "You SuccessFully Registerd !";
        public static String APP_USER_CREATION_FAIL = "You Not SuccessFully Register !";
        public static String APP_USER_CREATION_WARN = "Plesae Provide Vaild Details";
        public static String EMAIL_SUBJECT = "User registered on "+DateTime.Now.ToShortDateString();

        //----- Profile
        public static String PROFILE_SUCCESS = "Your Profile Created Successfully";
        public static String PROFILE_VALID_MESSAGE = "Please enter valid data";
        public static String PROFILE_UPDATE_SUCCESS = "Your Profile Updated Successfully";
        public static String PROFILE_UPDATE_UNSUCCESS = "Your Profile Not Updated Successfully";
        public static String PROFILE_NOT_FOUND = "No Profiles found";
        public static String PROFILE_NOT_SAVE = "Your Profile is not Save";
        public static String PROFILE_DELETE_MESSAGE = "Are you sure want to delete this profile ?";
        public static String PROFILE_DELETE_UNSUCCESS_MESSAGE = "Sorry your profile is not deleted successfully";
        public static String PROFILE_DELETE_SUCCESS_MESSAGE = "Your profile is deleted successfully";
    }
}

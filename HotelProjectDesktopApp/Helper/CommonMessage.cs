using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDashboard.Helper
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
    }
}

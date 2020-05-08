using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//------
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace CloudDesktopApp.Helper
{
    class CommonClasses
    {
        // This method execute when user want quit form applications
        public static void appExit()
        {
            DialogResult dr = MessageBox.Show(CommonMessage.APP_EXIT_MSG, messageBoxHeader.APP_EXIT.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // This method use for the check response result
        public static Boolean checkResposeResult(Object resultApi)
        {
            if (resultApi != null && !resultApi.Equals(CommonMessage.BAD_REQUEST) && !resultApi.Equals(CommonMessage.NOT_FOUND) && !resultApi.Equals(CommonMessage.INTERNAL_SERVER_ERROR))
            {
                return true;
            }else{
                return false;
            }
        }

    }

    //This class setting Skin of applications 
    public class SkinClass
    {
        public static void SetSkiner(MaterialForm formName)
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(formName);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.Green500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE); 
        }
    }

    //This class used for The Showing Message box header
    public class messageBoxHeader
    {
        public static String APP_EXIT { get { return "Exit Applications"; } }
        public static String APP_WARN { get { return "Applications Warning"; } }
        public static String APP_ERROR { get { return "Applications Error"; } }
        public static String APP_SUCCESS { get { return "Successfull"; } }
    }

    //This class use for the showing different message box
    public class UserMessage
    {
        public static void ShowExceptions(String message)
        {
            MessageBox.Show(message, messageBoxHeader.APP_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // This mehod use for show warning message in applications
        public static void showWarningMessage(String message)
        {
            MessageBox.Show(message, messageBoxHeader.APP_WARN.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // This mehod use for show Error message in applications
        public void showErrorMessage(String message)
        {
            MessageBox.Show(message, messageBoxHeader.APP_ERROR.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // This mehod use for show Error message in applications
        public static void showSuccessMessage(String message)
        {
            MessageBox.Show(message, messageBoxHeader.APP_SUCCESS.ToString(), MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        //public String getEmailBody(User user)
        //{
        //    String body = null;
        //    try
        //    {
        //        String tempBody = "<html xmlns='https://www.w3.org/1999/xhtml' xmlns:v='urn:schemas-microsoft-com:vml' xmlns:o='urn:schemas-microsoft-com:office:office'><head><title>V & Y Soft. Tech. Pvt. Ltd.</title><meta http-equiv='Content-Type' content='text/html; charset=utf-8'><meta http-equiv='X-UA-Compatible' content='IE=edge'><meta name='viewport' content='width=device-width, initial-scale=1.0 '><meta name='format-detection' content='telephone=no'><link href='https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700,800' rel='stylesheet'><style type='text/css'>body {    margin: 0 !important;    padding: 0 !important;    -webkit-text-size-adjust: 100% !important;    -ms-text-size-adjust: 100% !important;    -webkit-font-smoothing: antialiased !important;img {    border: 0 !important;    outline: none !important;p {    Margin: 0px !important;    Padding: 0px !important;table {    border-collapse: collapse;    mso-table-lspace: 0px;    mso-table-rspace: 0px;td,a,span {    border-collapse: collapse;    mso-line-height-rule: exactly;.ExternalClass * {    line-height: 100%;.em_defaultlink a {    color: inherit !important;    text-decoration: none !important;span.MsoHyperlink {    mso-style-priority: 99;    color: inherit;span.MsoHyperlinkFollowed {    mso-style-priority: 99;    color: inherit;} @media only screen and (min-width:481px) and (max-width:699px) {.em_main_table {    width: 100% !important;.em_wrapper {    width: 100% !important;.em_hide {    display: none !important;.em_img {    width: 100% !important;    height: auto !important;.em_h20 {    height: 20px !important;.em_padd {    padding: 20px 10px !important;}@media screen and (max-width: 480px) {.em_main_table {    width: 100% !important;.em_wrapper {    width: 100% !important;.em_hide {    display: none !important;.em_img {    width: 100% !important;    height: auto !important;.em_h20 {    height: 20px !important;.em_padd {    padding: 20px 10px !important;.em_text1 {    font-size: 16px !important;    line-height: 24px !important;u+.em_body .em_full_wrap {    width: 100% !important;    width: 100vw !important;} } </style></head><body class='em_body' style='margin:0px; padding:0px;' bgcolor='#efefef'><table class='em_full_wrap' valign='top' width='100%' cellspacing='0' cellpadding='0' border='0' bgcolor='#efefef' align='center'><tbody><tr><td valign='top' align='center'><table class='em_main_table' style='width:700px;' width='700' cellspacing='0' cellpadding='0' border='0' align='center'><tbody><tr><td style='padding:15px;' class='em_padd' valign='top' bgcolor='#f6f7f8' align='center'><table width='100%' cellspacing='0' cellpadding='0' border='0' align='center'><tbody><tr><td style='font-family:Open Sans, Arial, sans-serif; font-size:12px; line-height:15px; color:#0d1121;' valign='top' align='center'>Welcome by | <a href='#' target='_blank' style='color:#0d1121; text-decoration:underline;'>V & Y Soft. Tech. Pvt. Ltd.</a></td></tr></tbody></table></td></tr><tr><td style='padding:35px 70px 30px;' class='em_padd' valign='top' bgcolor='#0d1121' align='center'><table width='100%' cellspacing='0' cellpadding='0' border='0' align='center'><tbody><tr><td style='font-family:Open Sans, Arial, sans-serif; font-size:16px; line-height:30px; color:#ffffff;' valign='top' align='left'>" + user.userEmail.ToString() + "</td></tr><tr><td style='font-family:Open Sans, Arial, sans-serif; font-size:18px; line-height:22px; color:#fbeb59; letter-spacing:2px; padding-bottom:12px;' valign='top' align='center'>" +
        //            "This Mail is Regarding Your Successfull Registration with V&Y company Bar Managment Software(BMS).<br>With Follows Details:<br>Name : " + user.user_id.ToString() + "<br>Email : " + user.userEmail.ToString() + "<br></td></tr><tr><td style='font-family:Open Sans, Arial, sans-serif; font-size:18px; line-height:22px; color:#fbeb59; text-transform:uppercase; letter-spacing:2px; padding-bottom:12px;' valign='top' align='left'>Thanks for register </td></tr></tbody></table></td></tr>" + "<tr><td style='font-family:Open Sans, Arial, sans-serif; font-size:11px; line-height:18px; color:#999999;'valign='top' align='center'>© 2020 V & Y Soft. Tech. Pvt. Ltd. All Rights Reserved.<br></td></tr></tbody></table></td></tr></tbody></table></td></tr></tbody></table><div class='em_hide' style='white-space: nowrap; display: none; font-size:0px; line-height:0px;'>&nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</div></body></html>";
        //        body = tempBody;
        //    }
        //    catch (Exception msg)
        //    {
        //        new UserExceptions().showExceptions(msg.Message);
        //    }
        //    return body;
        //}
    }

}

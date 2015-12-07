using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using UtilitiesLibrary;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Web.Security;


namespace TermProject_3342
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        MerchantStoreSvc.MerchantStore pxy = new MerchantStoreSvc.MerchantStore();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }
        protected void SendMail(object sender, EventArgs e)
        {
            Email objEmail = new Email();
            string emailRecipient = txtMercEmail.Text;
            string password = pxy.GetPassword(emailRecipient);
            string emailSender = "passwordrecovery@happyhipsters.com";
            string emailSubject = "Password Recovery";
            string emailMessage = "Your Password is:  " + password;

            try
            {
                objEmail.SendMail(emailRecipient, emailSender, emailSubject, emailMessage);
                lblResponse.Text = "Please Check Your Email!";
                lblResponse.Visible = true;
            }
            catch (Exception ex)
            {

                lblResponse.Text = "The was an error, Please try again!";
                lblResponse.Visible = true;
            }
        }
    }
}
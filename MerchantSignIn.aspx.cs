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

namespace TermProject_3342
{
    public partial class MerchantSignIn : System.Web.UI.Page
    {
        MerchantStoreSvc.MerchantStore pxy = new MerchantStoreSvc.MerchantStore();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MercLogIn_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnMercReg_Click(object sender, EventArgs e)
        {

        }
        protected void validateMercLogIn(object sender, EventArgs e) {
            string mercEmail = txtMercEmail.Text;
            string mercPassword = txtMercPassword.Text;
            string mercAPI = txtMercAPIKey.Text;

            if (mercAPI == "" || mercEmail =="" || mercPassword == "")
            {
                lblResponse.Text = "Please complete all fields before proceeding!";
                lblResponse.Visible = true;
            }
            else
            {
                DataSet validEmail = pxy.EmailExists(mercEmail);
                if (validEmail.Tables.Count <= 0)
	            {
		            lblResponse.Text = "Email not Found!";
                    lblResponse.Visible = true;
	            }
                else if (!validEmail.Tables.Contains(mercPassword))
	            {
		            lblResponse.Text = "Incorrect Password!";
                    lblResponse.Visible = true;                       
	            }
                else
	            {
                    //DataSet API = pxy.
	            }
	
            }
        }
    }
}
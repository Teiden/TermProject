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
    public partial class MerchantPage : System.Web.UI.Page
    {

        MerchantStoreSvc.MerchantStore pxy = new MerchantStoreSvc.MerchantStore();
        protected void Page_Load(object sender, EventArgs e)
        {
                if (Session["Email"] != null)
                {
             string mercEmail = Session["Email"].ToString();
           
            DataSet validEmail = pxy.EmailExists(mercEmail);
            DataSet MerchantInfo = pxy.GetMerchantInfo(mercEmail);
            string MerchantName = (string)MerchantInfo.Tables[0].Rows[0][4];

            lblMerchantNameData.Text = MerchantName;

                }
                else
                {
                    Response.Redirect("LandingPage.aspx");
                }

        }

        protected void btnURLEdit_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtURL.Visible = true;
            btmUpdateURL.Visible = true;
        }

        protected void btmUpdateURL_Click(object sender, EventArgs e)
        {
            string mercName = lblMerchantName.Text;
            string mercURL = txtURL.Text;
            if (txtURL.Text == "")
            {
                txtURL.Visible = false;
                btmUpdateURL.Visible = false;
                lblURLUpdated.Text = "NO Changes Were Made!";
                lblURLUpdated.Visible = true;
            }
            else
            {
                string MercUrl = pxy.updateURL(mercName, mercURL);
                lblURLUpdated.Text = mercURL;
                lblURLUpdated.Visible = true;

            }
        }

       

    }
}
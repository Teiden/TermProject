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

                if (validEmail.Tables.Count <= 0)
                {
                    Response.Redirect("LandingPage.aspx");
                }
            }
            else
            {
                Response.Redirect("LandingPage.aspx");
            }

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;      
using System.IO;                                           
using System.Xml.Serialization;
using UtilitiesLibrary;

namespace TermProject_3342
{
    public partial class ShoppingCart : System.Web.UI.Page
    {

        double cost = 0;
        MerchantStoreSvc.MerchantStore pxy = new MerchantStoreSvc.MerchantStore();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)

            { 
                Response.Redirect("Login.aspx"); 
            }

            string user = Session["Username"].ToString();

            DataSet cart = pxy.GetCart(user);
            Session["cart"] = cart;

        }
    }
}
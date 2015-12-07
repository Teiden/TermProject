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
            if (Session["customerEmail"] == null)

            { 
                Response.Redirect("Login.aspx"); 
            }

            string customerEmail = Session["customerEmail"].ToString();

            gvShoppingCart.DataSource = pxy.FindCart(customerEmail);
            gvShoppingCart.DataBind();

            // Session["cart"] = cart;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TermProject_3342
{
    public partial class LoginAction : System.Web.UI.Page
    {

        MerchantStoreSvc.MerchantStore pxy = new MerchantStoreSvc.MerchantStore();
        string customerEmail;
        protected void Page_Load(object sender, EventArgs e)
        {
            customerEmail = Session["customerEmail"].ToString();
           
            DataSet shoppingCart = new DataSet();

            shoppingCart = pxy.FindCart(customerEmail);
            Session["cart"] = shoppingCart;
        }

        







    }
}
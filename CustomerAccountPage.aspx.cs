using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;



namespace TermProject_3342
{
    public partial class CustomerAccountPage : System.Web.UI.Page
    {
        MerchantStoreSvc.MerchantStore pxy = new MerchantStoreSvc.MerchantStore();
        string CustomerEmail;

        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerEmail = Session["customerEmail"].ToString();
         DataSet customer = pxy.GetCustomers(CustomerEmail);
         gvAccount.DataSource = customer;
         gvAccount.DataBind();
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {


            Session.Abandon();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TermProject_3342
{
    public partial class CustomerPage : System.Web.UI.Page
    {

        MerchantStoreSvc.MerchantStore pxy = new MerchantStoreSvc.MerchantStore();
        
        protected void Page_Load(object sender, EventArgs e)
        {

            ddlDepartments.DataSource = pxy.GetDepartments();
            ddlDepartments.DataBind();


        }
    }
}
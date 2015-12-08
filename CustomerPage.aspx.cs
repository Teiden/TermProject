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


        DataSet cart = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {

            string CustomerEmail = "";
            if (Session["customerEmail"] == null)
            {

                Response.Redirect("LandingPage.aspx");


            }

            CustomerEmail = Session["customerEmail"].ToString();
            DataSet validEmail = pxy.EmailExists(CustomerEmail);



            lblWelcome.Text = "Welcome, " + CustomerEmail + "!";

            if (!IsPostBack)
            {
                ddlDepartments.DataSource = pxy.GetDepartments();
                ddlDepartments.DataValueField = "DepartmentNumber";
                ddlDepartments.DataTextField = "DepartmentName";
                ddlDepartments.DataBind();
            }



        }

        protected void ddlDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {

            gvProducts.Visible = true;

            string x = ddlDepartments.SelectedValue.ToString();
            gvProducts.DataSource = pxy.GetProductCatalog(ddlDepartments.SelectedValue.ToString());
            gvProducts.DataBind();
        }

        protected void gvProducts_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string user = Session["customerEmail"].ToString();

            int rowIndex = int.Parse(e.CommandArgument.ToString());
            cart = (DataSet)Session["foundSet"];
        }
    }
}



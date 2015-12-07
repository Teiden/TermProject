using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TermProject_3342
{
    public partial class LogIn : System.Web.UI.Page
    {

        MerchantStoreSvc.MerchantStore pxy = new MerchantStoreSvc.MerchantStore();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                HttpCookie userDataCookie = Request.Cookies["UserLogin"];
                if (userDataCookie != null)
                {

                    txtUsername.Text = userDataCookie["Username"].ToString();
                    userDataCookie.Expires = DateTime.Now.AddDays(1d);
                    chkRemember.Checked = true;

                }

                else
                {
                    txtUsername.Text = "";
                    chkRemember.Checked = false;
                }


            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string customerEmail = txtUsername.Text;
            string customerPassword = txtPassword.Text;
          
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                lblError.Text = "Please fill out all forms!";
            }
            else
            {
                if (chkForget.Checked == false || chkRemember.Checked == false)
                {
                    lblError.Text = "";
                  
                        if (chkRemember.Checked)
                        {
                            HttpCookie userDataCookie = new HttpCookie("UserLogin");
                            userDataCookie["username"] = txtUsername.Text;
                            userDataCookie.Expires = DateTime.Now.AddDays(5d);
                            Response.Cookies.Add(userDataCookie);
                        }

                        if (chkForget.Checked)
                        {
                            HttpCookie termCookie = new HttpCookie("UserLogin");
                            termCookie["username"] = txtUsername.Text;
                            termCookie.Expires = DateTime.Now.AddDays(-1d);
                            Response.Cookies.Add(termCookie);
                        }

                        DataSet validEmail = pxy.CustomerEmailExists(customerEmail);
                        string password = (string)validEmail.Tables[0].Rows[0][1];
                    if (validEmail.Tables[0].Rows.Count <= 0)

                        {
                            lblError.Text = "Email not Found!";
                            lblError.Visible = true;
                        }
                        else if (password!=customerPassword)
                        {
                            lblError.Text = "Incorrect Password!";
                            lblError.Visible = true;
                        }

                        
                         
                    else
                    {
                            Session["customerEmail"] = txtUsername.Text;
                        Response.Redirect("CustomerPage.aspx");
                    }
                
                }

                else
                {
                    lblError.Text = "Please Choose ONLY ONE Checkbox!!!";
                }


            }
        }
        
      



        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterCustomer.aspx");
        }
    }
}
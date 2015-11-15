using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TermProject_3342
{
    public partial class LogIn : System.Web.UI.Page
    {
        

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
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                lblError.Text = "Please fill out all forms!";
            }
            else
            {
                if (chkForget.Checked == false || chkRemember.Checked == false)
                {
                    lblError.Text = "";
                  //  if (pxy.CheckLogin(txtUsername.Text, txtPassword.Text))
                   // {
                        //login();
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
                        Session["Username"] = txtUsername.Text;
                        Response.Redirect("Home.aspx");

                  //  }

                  //  else
                  //  {
                  //      lblError.Text = "No matching username and password found!";
                  //  }
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
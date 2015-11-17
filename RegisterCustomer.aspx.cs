using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TermProject_3342
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        MerchantStoreSvc.MerchantStore pxy = new MerchantStoreSvc.MerchantStore();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string CustomerEmail = txtEmail.Value.ToString();
            lblPasswordMismatch.Visible = false;
            lblIncompleteForm.Visible = false;

            string CustomerFirstName = txtFirstName.Text;
            string CustomerLastName = txtLastName.Text;
            string CustomerPassword = txtPassword.Text;
            bool complete = false;


            if (txtUsername.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || CustomerEmail == "" || CustomerPassword == "" || txtPasswordConfirm.Text == "" || txtState.Text == "" || txtStreetAddress.Text == "" || txtCity.Text == "" || txtState.Text == "")
            {
                complete = false;
            }
            else
                complete = true;

            
            if (txtPassword.Text == txtPasswordConfirm.Text)
            {
               
               
                    if (complete == true)
                    {
                       
                        if    (true)     // (pxy.RegisterCustomer( CustomerEmail,  CustomerPassword,  CustomerFirstName,  CustomerLastName))
                        { 
                        
                            Response.Redirect("LogIn.aspx");
                        }
                        else
                        {
                            lblIncompleteForm.Visible = true;
                            lblIncompleteForm.Text = "Email Already Exists";
                        }
                    }
                    else
                    {
                        lblIncompleteForm.Visible = true;
                        lblIncompleteForm.Text = "Fill Out All Fields Marked With (*)";
                    }
                
            }
            
            else
            {
                lblPasswordMismatch.Visible = true;
                lblPasswordMismatch.Text = "Password Mismatch!";
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogIn.aspx");
        }
    }
}
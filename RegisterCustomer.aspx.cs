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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Value.ToString();
            lblPasswordMismatch.Visible = false;
            lblIncompleteForm.Visible = false;

            string name = txtFirstName.Text + " " + txtLastName.Text;
            string address = txtStreetAddress.Text + " / " + txtZip.Text + " / " + txtCity.Text + " / " + txtState.Text;
            bool complete = false;

            //Checks that all forms are filled
            if (txtFirstName.Text == "" || txtLastName.Text == "" || email == "" || txtPassword.Text == "" || txtPasswordConfirm.Text == "" || txtState.Text == "" || txtStreetAddress.Text == "" || txtCity.Text == "" || txtState.Text == "")
            {
                complete = false;
            }
            else
                complete = true;

            //Confirm both passwords match
            if(txtPassword.Text == txtPasswordConfirm.Text)
            { 
                //Username is ommitted
                if (txtUsername.Text == "")
                {
                    //Confirm all forms are filled
                    if (complete == true)
                    {
                        //if (pxy.CustomerRegisterEmail(txtPassword.Text, email, txtStreetAddress.Text, name, cbCookie.Checked, txtCity.Text, txtState.Text, txtZip.Text, txtPhone.Text))
                        //{
                            Response.Redirect("Login.aspx");
                        //}
                        //else
                        //{
                        //    lblIncompleteForm.Visible = true;
                        //    lblIncompleteForm.Text = "Username or Email already exists in system";
                        //}
                    }
                    else
                    {
                        lblIncompleteForm.Visible = true;
                        lblIncompleteForm.Text = "Please fill out all required forms (*)";
                    }
                }

                //Username is entered
                else
                {
                    //Confirm all forms are filled
                    if (complete == true)
                    {
                        //if (pxy.CustomerRegister(txtUsername.Text, txtPassword.Text, email, txtStreetAddress.Text, name, cbCookie.Checked, txtCity.Text, txtState.Text, txtZip.Text, txtPhone.Text))
                        //{
                            Response.Redirect("Login.aspx");
                        //}
                        //else
                        //{
                        //    lblIncompleteForm.Visible = true;
                        //    lblIncompleteForm.Text = "Username or Email already exists in system";
                        //}
                    }
                    else
                    {
                        lblIncompleteForm.Visible = true;
                        lblIncompleteForm.Text = "Please fill out all required forms (*)";
                    }
                }
            }
            //Passwords do not match
            else
            {
                lblPasswordMismatch.Visible = true;
                lblPasswordMismatch.Text = "Passwords do not match";
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
    
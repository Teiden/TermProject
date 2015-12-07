using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using UtilitiesLibrary;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace TermProject_3342
{
    public partial class MerchantSignIn : System.Web.UI.Page
    {
        MerchantStoreSvc.MerchantStore pxy = new MerchantStoreSvc.MerchantStore();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MercLogIn_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnMercReg_Click(object sender, EventArgs e)
        {

        }

        protected void btnForgotPassword_Click(Object sender, EventArgs e)
        {
            Response.Redirect("ForgotPassword.aspx");
        }
        protected void validateMercLogIn(object sender, EventArgs e) {
            string mercEmail = txtMercEmail.Text;
            string mercPassword = txtMercPassword.Text;
            string mercAPI = txtMercAPIKey.Text;
            Session["Email"] = mercEmail;
 
            if (mercAPI == "" || mercEmail == "" || mercPassword == "")
            {
                lblResponse.Text = "Please complete all fields before proceeding!";
                lblResponse.Visible = true;
            }
            else
            {
                DataSet validEmail = pxy.EmailExists(mercEmail);
                string password = (string)validEmail.Tables[0].Rows[0][5];
                if (validEmail.Tables[0].Rows.Count <= 0)
	            {
		            lblResponse.Text = "Email not Found!";
                    lblResponse.Visible = true;
	            }
                else if (password != mercPassword)
	            {
		            lblResponse.Text = "Incorrect Password!";
                    lblResponse.Visible = true;                       
	            }
                else
	            {
                    DataSet API = pxy.APIExists(mercAPI);
                    if (!API.Tables.Contains(mercAPI))
                    {
                        lblResponse.Text = "Invalid API!";
                        lblResponse.Visible = true;
                    }
                    else
                    {
                        Response.Redirect("MerchantPage.aspx");
                    }
	            }
	
            }
        }
        protected void MerchantRegistration(object sender, EventArgs e)
        {
            string mercName = txtMercName.Text;
            string mercEmail = txtRegEmail.Text;
            string password = txtRegPassword.Text;
            string confPass = txtRegConfirm.Text;
            string phone = txtPhone.Text;
            string url = txtURL.Text;

            if (mercName == "" || mercEmail == "" || password == "" || phone == "" || url == "")
            {
                lblRegResp.Text = "Please Complete All Fields";
                lblRegResp.Visible = true;
            }
            else
            {
                int MerchantName = pxy.MerchantExists(mercName);
                if (MerchantName > 0)
                {
                    lblRegResp.Text = "This Merchant Already Exists"; //Two Merchants cannot have the same name
                    lblRegResp.Visible = true;
                }
                else
                {
                    string[] merchant = new string[5];
                    merchant[0] = mercName;
                    merchant[1] = mercEmail;
                    merchant[2] = password;
                    merchant[3] = phone;
                    merchant[4] = url;

                    string API = pxy.AddMerchant(merchant);

                    lblRegResp.Text = "Here is your API Key:  " + API;
                    lblRegResp.Visible = true;
                }
            }
        }
        protected void txtRegConfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtRegPassword.Text == txtRegConfirm.Text)
            {
                lblRegResp.Text = "Passwords do not Match!";
                lblRegResp.Visible = true;
            }
           
        }
    }
}
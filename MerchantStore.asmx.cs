using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using UtilitiesLibrary;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text;

namespace TermProject_3342
{
    /// <summary>
    /// Summary description for MerchantStore
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MerchantStore : System.Web.Services.WebService
    {
        //    DBConnect objDB = new DBConnect();
        //    SqlCommand objCommand = new SqlCommand();
        //    string strSQL;


        [WebMethod]
        public DataSet GetDepartments()
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetDepartments";
            DataSet department;
            department = objDB.GetDataSetUsingCmdObj(objCommand);
            objDB.CloseConnection();
            return department;
        }

        [WebMethod]
        public DataSet GetProductCatalog(String DepartmentNumber)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            string strSQL;
            strSQL = "SELECT * FROM TP_Poduct Where DepartmentNumber = '" + DepartmentNumber + "'";
            DataSet ProductCatalog;
            ProductCatalog = objDB.GetDataSet(strSQL);
            objDB.CloseConnection();
            return ProductCatalog;
        }

        [WebMethod]
        public DataSet EmailExists(string mercEmail)
        {

            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            string strSQL;
            strSQL = "SELECT * FROM TP_Merchant Where MerchantEmail = '" + mercEmail + "'";
            DataSet Merchant;
            Merchant = objDB.GetDataSet(strSQL);
            objDB.CloseConnection();
            return Merchant;
        }
        [WebMethod]
        public DataSet APIExists(string mercAPI)
        {

            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            string strSQL;
            strSQL = "SELECT * FROM TP_Merchant_Site Where APIKey = '" + mercAPI + "'";
            DataSet APIKey;
            APIKey = objDB.GetDataSet(strSQL);
            objDB.CloseConnection();
            return APIKey;
        }
        [WebMethod]
        public DataSet MerchantExists(string mercName)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            string strSQL;
            strSQL = "SELECT * FROM TP_Merchant Where MerchantName = '" + mercName + "'";
            DataSet MerchantName;
            MerchantName = objDB.GetDataSet(strSQL);
            objDB.CloseConnection();
            return MerchantName;

        }
        [WebMethod]
        public string AddMerchant(string[] Merchant)
        {
            string API = genAPI();
            string PageURL = Merchant[4];
            string MerchantEmail = Merchant[1];
            string MerchantPhone = Merchant[3];
            string MerchantName = Merchant[0];
            string MerchantPassword = Merchant[2];



            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            string strSQL;
            strSQL = "INSERT INTO TP_Merchant (MerchantURL, MerchantEmail, MerchantPhone, MerchantName, MerchantPassword)"
                        + " Values (@PageURl, @MerchantEmail, @MerchantPhone, @MerchantName, @MerchantPassword)";

            objCommand.Parameters.AddWithValue("@PageURL", PageURL);
            objCommand.Parameters.AddWithValue("@MerchantEmail", MerchantEmail);
            objCommand.Parameters.AddWithValue("@MerchantPhone", MerchantPhone);
            objCommand.Parameters.AddWithValue("@MerchantPassword", MerchantPassword);

            objDB.DoUpdateUsingCmdObj(objCommand);

            strSQL = "INSERT INTO TP_Merchant_Site (APIKey) Values (@APIKey)";
            objCommand.Parameters.AddWithValue("@APIKey", API);

            objDB.DoUpdateUsingCmdObj(objCommand);

            objDB.CloseConnection();

            return API;

        }

        private string genAPI(int length = 20)
        {
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            StringBuilder API = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                API.Append(characters[rand.Next(characters.Length)]);
            }
            return API.ToString();
        }



        [WebMethod]
        public Boolean RegisterSite( string SiteName, string SiteDescription, string APIKey, string SiteEmail, string OwnerName, string Phone, string Street, string Suite, string City, string StateName, string Zipcode)
        {
            try
            {
                DBConnect objDB = new DBConnect();
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "RegisterSite";

                objCommand.Parameters.AddWithValue("@SiteName", SiteName);
                objCommand.Parameters.AddWithValue("@SiteDescription", SiteDescription);
                objCommand.Parameters.AddWithValue("@APIKey", APIKey);
                objCommand.Parameters.AddWithValue("@SiteEmail", SiteEmail);
                objCommand.Parameters.AddWithValue("@OwnerName", OwnerName);
                objCommand.Parameters.AddWithValue("@Phone", Phone);
                objCommand.Parameters.AddWithValue("@Street", Street);
                objCommand.Parameters.AddWithValue("@Suite", Suite);
                objCommand.Parameters.AddWithValue("@City", City);
                objCommand.Parameters.AddWithValue("@StateName", StateName);
                objCommand.Parameters.AddWithValue("@Zipcode", Zipcode);
                

                objDB.DoUpdateUsingCmdObj(objCommand);
                objDB.CloseConnection();

                return true;
            }
            catch
            {

                return false;
            }
        }


        
        [WebMethod]
        public Boolean Purchase( string ProductID, int Quantity, string SiteID, string APIKey, string[] CustomerCardInfo)
        {
            try
            {
                DBConnect objDB = new DBConnect();
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "Purchase";

                objCommand.Parameters.AddWithValue("@ProductID", ProductID);
                objCommand.Parameters.AddWithValue("@Quantity", Quantity);
                objCommand.Parameters.AddWithValue("@SiteID", SiteID);
                objCommand.Parameters.AddWithValue("@APIKey", APIKey);
                objCommand.Parameters.AddWithValue("@CustomerCardType", CustomerCardInfo[0]);
                objCommand.Parameters.AddWithValue("@CustomerNameOnCard", CustomerCardInfo[1]);
                objCommand.Parameters.AddWithValue("@CustomerBillingAddress", CustomerCardInfo[2]);
                objCommand.Parameters.AddWithValue("@CustomerCity", CustomerCardInfo[3]);
                objCommand.Parameters.AddWithValue("@CustomerState", CustomerCardInfo[4]);
                objCommand.Parameters.AddWithValue("@CustomerZipcode", CustomerCardInfo[5]);
                objCommand.Parameters.AddWithValue("@CustomerCardNumber", CustomerCardInfo[6]);
                objCommand.Parameters.AddWithValue("@CustomerCardExpMonth", CustomerCardInfo[7]);
                objCommand.Parameters.AddWithValue("@CustomerCardExpYear", CustomerCardInfo[8]);
                objCommand.Parameters.AddWithValue("@CustomerCardCsc", CustomerCardInfo[9]);
                objDB.DoUpdateUsingCmdObj(objCommand);
                objDB.CloseConnection();

                return true;
            }
            catch
            {
                return false;
            }
        }


        [WebMethod]
        public Boolean RegisterCustomer(string CustomerEmail, string CustomerPassword, string CustomerFirstName, string CustomerLastName)
        {



            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT * FROM TP_Customer";
            DataSet data = objDB.GetDataSet(strSQL);
            DataTable dt = data.Tables[0];
           

            
            

            bool customerExists = false;

            foreach (DataTable table in data.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row["CustomerEmail"].ToString() == CustomerEmail)
                    {
                        customerExists = true;
                    }
                }
            }


            if (customerExists == false)
            {

                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "addCustomer";

                objCommand.Parameters.AddWithValue("@CustomerEmail", CustomerEmail);
                objCommand.Parameters.AddWithValue("@CustomerPassword", CustomerPassword);
                objCommand.Parameters.AddWithValue("@FirstName", CustomerFirstName);
                objCommand.Parameters.AddWithValue("@LastName", CustomerLastName);


                objDB.DoUpdateUsingCmdObj(objCommand);

            }

            
              return true;  
        }
       






    }
}
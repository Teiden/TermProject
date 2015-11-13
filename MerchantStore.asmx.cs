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

namespace CIS3342TermProject
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
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        string strSQL;
        

        [WebMethod]
        public DataSet GetDepartments()
        {
            //strSQL = "SELECT * FROM TP_Department";
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

            strSQL = "SELECT * FROM TP_Poduct Where DepartmentNumber = '" + DepartmentNumber + "'";
            DataSet ProductCatalog;
            ProductCatalog = objDB.GetDataSet(strSQL);

            return ProductCatalog;
        }
        [WebMethod]
        public Boolean Purchase(String ProductID, int Quantity, String siteID, String APIKey, String[] CustomerCreditCardInformation)
    }
}

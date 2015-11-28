﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
// 
#pragma warning disable 1591

namespace TermProject_3342.MerchantStoreSvc1 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="MerchantStoreSoap", Namespace="http://tempuri.org/")]
    public partial class MerchantStore : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetDepartmentsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetProductCatalogOperationCompleted;
        
        private System.Threading.SendOrPostCallback EmailExistsOperationCompleted;
        
        private System.Threading.SendOrPostCallback APIExistsOperationCompleted;
        
        private System.Threading.SendOrPostCallback MerchantExistsOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddMerchantOperationCompleted;
        
        private System.Threading.SendOrPostCallback RegisterSiteOperationCompleted;
        
        private System.Threading.SendOrPostCallback PurchaseOperationCompleted;
        
        private System.Threading.SendOrPostCallback RegisterCustomerOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public MerchantStore() {
            this.Url = global::TermProject_3342.Properties.Settings.Default.TermProject_3342_MerchantStoreSvc1_MerchantStore;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetDepartmentsCompletedEventHandler GetDepartmentsCompleted;
        
        /// <remarks/>
        public event GetProductCatalogCompletedEventHandler GetProductCatalogCompleted;
        
        /// <remarks/>
        public event EmailExistsCompletedEventHandler EmailExistsCompleted;
        
        /// <remarks/>
        public event APIExistsCompletedEventHandler APIExistsCompleted;
        
        /// <remarks/>
        public event MerchantExistsCompletedEventHandler MerchantExistsCompleted;
        
        /// <remarks/>
        public event AddMerchantCompletedEventHandler AddMerchantCompleted;
        
        /// <remarks/>
        public event RegisterSiteCompletedEventHandler RegisterSiteCompleted;
        
        /// <remarks/>
        public event PurchaseCompletedEventHandler PurchaseCompleted;
        
        /// <remarks/>
        public event RegisterCustomerCompletedEventHandler RegisterCustomerCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetDepartments", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetDepartments() {
            object[] results = this.Invoke("GetDepartments", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetDepartmentsAsync() {
            this.GetDepartmentsAsync(null);
        }
        
        /// <remarks/>
        public void GetDepartmentsAsync(object userState) {
            if ((this.GetDepartmentsOperationCompleted == null)) {
                this.GetDepartmentsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDepartmentsOperationCompleted);
            }
            this.InvokeAsync("GetDepartments", new object[0], this.GetDepartmentsOperationCompleted, userState);
        }
        
        private void OnGetDepartmentsOperationCompleted(object arg) {
            if ((this.GetDepartmentsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDepartmentsCompleted(this, new GetDepartmentsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetProductCatalog", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetProductCatalog(string DepartmentNumber) {
            object[] results = this.Invoke("GetProductCatalog", new object[] {
                        DepartmentNumber});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetProductCatalogAsync(string DepartmentNumber) {
            this.GetProductCatalogAsync(DepartmentNumber, null);
        }
        
        /// <remarks/>
        public void GetProductCatalogAsync(string DepartmentNumber, object userState) {
            if ((this.GetProductCatalogOperationCompleted == null)) {
                this.GetProductCatalogOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProductCatalogOperationCompleted);
            }
            this.InvokeAsync("GetProductCatalog", new object[] {
                        DepartmentNumber}, this.GetProductCatalogOperationCompleted, userState);
        }
        
        private void OnGetProductCatalogOperationCompleted(object arg) {
            if ((this.GetProductCatalogCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProductCatalogCompleted(this, new GetProductCatalogCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EmailExists", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet EmailExists(string mercEmail) {
            object[] results = this.Invoke("EmailExists", new object[] {
                        mercEmail});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void EmailExistsAsync(string mercEmail) {
            this.EmailExistsAsync(mercEmail, null);
        }
        
        /// <remarks/>
        public void EmailExistsAsync(string mercEmail, object userState) {
            if ((this.EmailExistsOperationCompleted == null)) {
                this.EmailExistsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEmailExistsOperationCompleted);
            }
            this.InvokeAsync("EmailExists", new object[] {
                        mercEmail}, this.EmailExistsOperationCompleted, userState);
        }
        
        private void OnEmailExistsOperationCompleted(object arg) {
            if ((this.EmailExistsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EmailExistsCompleted(this, new EmailExistsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/APIExists", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet APIExists(string mercAPI) {
            object[] results = this.Invoke("APIExists", new object[] {
                        mercAPI});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void APIExistsAsync(string mercAPI) {
            this.APIExistsAsync(mercAPI, null);
        }
        
        /// <remarks/>
        public void APIExistsAsync(string mercAPI, object userState) {
            if ((this.APIExistsOperationCompleted == null)) {
                this.APIExistsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAPIExistsOperationCompleted);
            }
            this.InvokeAsync("APIExists", new object[] {
                        mercAPI}, this.APIExistsOperationCompleted, userState);
        }
        
        private void OnAPIExistsOperationCompleted(object arg) {
            if ((this.APIExistsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.APIExistsCompleted(this, new APIExistsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/MerchantExists", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet MerchantExists(string mercName) {
            object[] results = this.Invoke("MerchantExists", new object[] {
                        mercName});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void MerchantExistsAsync(string mercName) {
            this.MerchantExistsAsync(mercName, null);
        }
        
        /// <remarks/>
        public void MerchantExistsAsync(string mercName, object userState) {
            if ((this.MerchantExistsOperationCompleted == null)) {
                this.MerchantExistsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMerchantExistsOperationCompleted);
            }
            this.InvokeAsync("MerchantExists", new object[] {
                        mercName}, this.MerchantExistsOperationCompleted, userState);
        }
        
        private void OnMerchantExistsOperationCompleted(object arg) {
            if ((this.MerchantExistsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MerchantExistsCompleted(this, new MerchantExistsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddMerchant", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddMerchant(string[] Merchant) {
            object[] results = this.Invoke("AddMerchant", new object[] {
                        Merchant});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddMerchantAsync(string[] Merchant) {
            this.AddMerchantAsync(Merchant, null);
        }
        
        /// <remarks/>
        public void AddMerchantAsync(string[] Merchant, object userState) {
            if ((this.AddMerchantOperationCompleted == null)) {
                this.AddMerchantOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddMerchantOperationCompleted);
            }
            this.InvokeAsync("AddMerchant", new object[] {
                        Merchant}, this.AddMerchantOperationCompleted, userState);
        }
        
        private void OnAddMerchantOperationCompleted(object arg) {
            if ((this.AddMerchantCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddMerchantCompleted(this, new AddMerchantCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RegisterSite", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool RegisterSite(string SiteName, string SiteDescription, string APIKey, string SiteEmail, string OwnerName, string Phone, string Street, string Suite, string City, string StateName, string Zipcode) {
            object[] results = this.Invoke("RegisterSite", new object[] {
                        SiteName,
                        SiteDescription,
                        APIKey,
                        SiteEmail,
                        OwnerName,
                        Phone,
                        Street,
                        Suite,
                        City,
                        StateName,
                        Zipcode});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void RegisterSiteAsync(string SiteName, string SiteDescription, string APIKey, string SiteEmail, string OwnerName, string Phone, string Street, string Suite, string City, string StateName, string Zipcode) {
            this.RegisterSiteAsync(SiteName, SiteDescription, APIKey, SiteEmail, OwnerName, Phone, Street, Suite, City, StateName, Zipcode, null);
        }
        
        /// <remarks/>
        public void RegisterSiteAsync(string SiteName, string SiteDescription, string APIKey, string SiteEmail, string OwnerName, string Phone, string Street, string Suite, string City, string StateName, string Zipcode, object userState) {
            if ((this.RegisterSiteOperationCompleted == null)) {
                this.RegisterSiteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegisterSiteOperationCompleted);
            }
            this.InvokeAsync("RegisterSite", new object[] {
                        SiteName,
                        SiteDescription,
                        APIKey,
                        SiteEmail,
                        OwnerName,
                        Phone,
                        Street,
                        Suite,
                        City,
                        StateName,
                        Zipcode}, this.RegisterSiteOperationCompleted, userState);
        }
        
        private void OnRegisterSiteOperationCompleted(object arg) {
            if ((this.RegisterSiteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegisterSiteCompleted(this, new RegisterSiteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Purchase", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Purchase(string ProductID, int Quantity, string SiteID, string APIKey, string[] CustomerCardInfo) {
            object[] results = this.Invoke("Purchase", new object[] {
                        ProductID,
                        Quantity,
                        SiteID,
                        APIKey,
                        CustomerCardInfo});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void PurchaseAsync(string ProductID, int Quantity, string SiteID, string APIKey, string[] CustomerCardInfo) {
            this.PurchaseAsync(ProductID, Quantity, SiteID, APIKey, CustomerCardInfo, null);
        }
        
        /// <remarks/>
        public void PurchaseAsync(string ProductID, int Quantity, string SiteID, string APIKey, string[] CustomerCardInfo, object userState) {
            if ((this.PurchaseOperationCompleted == null)) {
                this.PurchaseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPurchaseOperationCompleted);
            }
            this.InvokeAsync("Purchase", new object[] {
                        ProductID,
                        Quantity,
                        SiteID,
                        APIKey,
                        CustomerCardInfo}, this.PurchaseOperationCompleted, userState);
        }
        
        private void OnPurchaseOperationCompleted(object arg) {
            if ((this.PurchaseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PurchaseCompleted(this, new PurchaseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RegisterCustomer", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool RegisterCustomer(string CustomerEmail, string CustomerPassword, string CustomerFirstName, string CustomerLastName) {
            object[] results = this.Invoke("RegisterCustomer", new object[] {
                        CustomerEmail,
                        CustomerPassword,
                        CustomerFirstName,
                        CustomerLastName});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void RegisterCustomerAsync(string CustomerEmail, string CustomerPassword, string CustomerFirstName, string CustomerLastName) {
            this.RegisterCustomerAsync(CustomerEmail, CustomerPassword, CustomerFirstName, CustomerLastName, null);
        }
        
        /// <remarks/>
        public void RegisterCustomerAsync(string CustomerEmail, string CustomerPassword, string CustomerFirstName, string CustomerLastName, object userState) {
            if ((this.RegisterCustomerOperationCompleted == null)) {
                this.RegisterCustomerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegisterCustomerOperationCompleted);
            }
            this.InvokeAsync("RegisterCustomer", new object[] {
                        CustomerEmail,
                        CustomerPassword,
                        CustomerFirstName,
                        CustomerLastName}, this.RegisterCustomerOperationCompleted, userState);
        }
        
        private void OnRegisterCustomerOperationCompleted(object arg) {
            if ((this.RegisterCustomerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegisterCustomerCompleted(this, new RegisterCustomerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void GetDepartmentsCompletedEventHandler(object sender, GetDepartmentsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDepartmentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDepartmentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void GetProductCatalogCompletedEventHandler(object sender, GetProductCatalogCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProductCatalogCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetProductCatalogCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void EmailExistsCompletedEventHandler(object sender, EmailExistsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EmailExistsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EmailExistsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void APIExistsCompletedEventHandler(object sender, APIExistsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class APIExistsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal APIExistsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void MerchantExistsCompletedEventHandler(object sender, MerchantExistsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MerchantExistsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MerchantExistsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void AddMerchantCompletedEventHandler(object sender, AddMerchantCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddMerchantCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddMerchantCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void RegisterSiteCompletedEventHandler(object sender, RegisterSiteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RegisterSiteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RegisterSiteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void PurchaseCompletedEventHandler(object sender, PurchaseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PurchaseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PurchaseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void RegisterCustomerCompletedEventHandler(object sender, RegisterCustomerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RegisterCustomerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RegisterCustomerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
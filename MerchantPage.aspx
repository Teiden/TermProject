<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MerchantPage.aspx.cs" Inherits="TermProject_3342.MerchantPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
    <link href="Css.css" rel="stylesheet" />
</head>
<body>
    <h1>Merchant Information Page</h1>
    <form id="form1" runat="server">
        
    <div class="merchant">
        <h3>Merchant Information</h3>
    
        <asp:Label ID="lblMerchantName" runat="server" BorderStyle="Solid" BorderWidth="2px" Text=" Merchant Name " ValidateRequestMode="Disabled"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMerchantNameData" runat="server" Text=""></asp:Label>
        <br />
     <asp:Label ID="lblMerchantURL" runat="server" BorderStyle="Solid" BorderWidth="2px" Text=" Merchant URL " ValidateRequestMode="Disabled"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMerchantURLData" runat="server" Text=""></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEditURL" runat="server" OnClick="Button1_Click" Text="Edit" />
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtURL" runat="server" Visible="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btmUpdateURL" runat="server" OnClick="btmUpdateURL_Click" Text="Update" Visible="False" />
        <br />
        <asp:Label ID="lblURLUpdated" runat="server" BorderColor="Blue" BorderStyle="Dotted" BorderWidth="2px" Visible="False"></asp:Label>
        <br />
        <asp:Label ID="lblMerchantEmail" runat="server" BorderStyle="Solid" BorderWidth="2px" Text=" Merchant Email " ValidateRequestMode="Disabled"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblMerchantEmailData" runat="server" Text=""></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEditEmail" runat="server" OnClick="ButtonEditEmail_Click" Text="Edit" />
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server" Visible="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdateMerchantEmail" runat="server" OnClick="btmUpdateEmail_Click" Text="Update" Visible="False" />
        <br />
        <asp:Label ID="lblEmailUpdated" runat="server" BorderColor="Blue" BorderStyle="Dotted" BorderWidth="2px" Visible="False"></asp:Label>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="TermProject_3342.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
    <link href="Css.css" rel="stylesheet" />
</head>
<body>
    <h1>Happy Hipsters' Merchant Password Recovery</h1>
    <form id="form1" runat="server">
    <div class="merchant">
    <h3>Recover Your Password Here</h3>
        <asp:TextBox CssClass="register" ID="txtMercEmail" runat="server" placeholder="Enter Your Email" ></asp:TextBox>
        <asp:Button ID="btnMercPassREcovery" CSSClass="login" runat="server" OnClick="SendMail" Text="Request Password" Width="172px" />
        <asp:Label ID="lblResponse" runat="server" BorderColor="Red" BorderStyle="Dashed" Font-Bold="True" Font-Italic="True" Visible="False" ForeColor="Red"></asp:Label>
    </div>
    </form>
</body>
</html>

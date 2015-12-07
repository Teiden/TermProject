<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MerchantSignIn.aspx.cs" Inherits="TermProject_3342.MerchantSignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
    <title></title>
</head>
<body>
    <h1>Happy Hipsters' Merchant Portal</h1>
    <form id="form1" runat="server">
    <div class="absoluteLeft">
    <h2>Already a Registered Merchant?</h2>
        <h3>Sign In Here</h3>
        <asp:TextBox CssClass="register" ID="txtMercEmail" runat="server" placeholder="Enter Your Email"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox CssClass="register" ID="txtMercPassword" runat="server" placeholder="Enter Your Password"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox CssClass="register" ID="txtMercAPIKey" runat="server" placeholder="Enter You API Key"></asp:TextBox>
        <br />
        <br />        
        <asp:Label ID="lblResponse" runat="server" BorderColor="Red" BorderStyle="Dashed" Font-Bold="True" Font-Italic="True" Visible="False" ForeColor="Red"></asp:Label>
        <asp:Button ID="btnMercLogIn" CSSClass="login" runat="server" OnClick="validateMercLogIn" Text="Log Me In" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnForgotPassword" CSSClass="login" runat="server" OnClick="btnForgotPassword_Click" Text="Forgot Password" />
    </div>
        <div class="absoluteRight">
            <h2>Want to be a Registered Merchant?</h2>
            <h3>Enter Your Information Below</h3>
            <asp:TextBox CssClass="register" ID="txtMercName" runat="server" placeholder="Enter Your Store Name"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox CssClass="register" ID="txtRegEmail" runat="server" placeholder="Enter Your Email"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox CssClass="register" ID="txtRegPassword" runat="server" placeholder="Enter Your Password"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox CssClass="register" ID="txtRegConfirm" runat="server" placeholder="Confirm Your Password" OnTextChanged="txtRegConfirm_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox CssClass="register" ID="txtPhone" runat="server" placeholder="Enter Your Phone Number"></asp:TextBox>
            <br />
            <br />
             <asp:TextBox CssClass="register" ID="txtURL" runat="server" placeholder="Enter Web-Method URL"></asp:TextBox>
            <br />
            <br />          
            <asp:Label ID="lblRegResp" runat="server" BorderColor="Red" BorderStyle="Dashed" Font-Bold="True" Font-Italic="True" ForeColor="Red" Visible="False"></asp:Label>
            <asp:Button ID="btnMercReg" CssClass="login" runat="server" Text="Register Me" OnClick="MerchantRegistration" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

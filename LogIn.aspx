<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="TermProject_3342.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 500px; top: 225px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 500px; position: absolute; top: 262px" TextMode="Password"></asp:TextBox>
        <asp:CheckBox ID="chkRemember" runat="server" style="z-index: 1; left: 500px; top: 314px; position: absolute" Text="Remember Me" ToolTip="Remember information as a cookie" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 430px; top: 197px; position: absolute"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 430px; top: 263px; position: absolute" Text="Password"></asp:Label>
        <p>
            <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 430px; top: 226px; position: absolute" Text="Username"></asp:Label>
        </p>
        <asp:Label ID="lblHeader" runat="server" style="z-index: 1; left: 528px; top: 127px; position: absolute" Text="Welcome!"></asp:Label>
        <asp:Label ID="lblSubHeader" runat="server" style="z-index: 1; left: 424px; top: 169px; position: absolute" Text="Login to begin Planning Your Get-Away!"></asp:Label>
        <asp:CheckBox ID="chkForget" runat="server" style="z-index: 1; left: 500px; top: 337px; position: absolute" Text="Forget Me" ToolTip="Forget information stored as cookie" />
        <p>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 457px; top: 376px; position: absolute" Text="Submit" />
        </p>
        <asp:Button ID="btnRegister" runat="server" style="z-index: 1; left: 554px; top: 376px; position: absolute" Text="Register" OnClick="btnRegister_Click" />
    </form>
</body>
</html>

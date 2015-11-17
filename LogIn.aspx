<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="TermProject_3342.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  
      <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="absoluteLeft">
    
    
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 116px; top: 150px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 115px; position: absolute; top: 182px" TextMode="Password"></asp:TextBox>
        <asp:CheckBox ID="chkRemember" runat="server" style="z-index: 1; left: 92px; top: 217px; position: absolute" Text="Remember Me" ToolTip="Remember information as a cookie" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 37px; top: 125px; position: absolute"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 30px; top: 185px; position: absolute" Text="Password"></asp:Label>
        <p>
            <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 26px; top: 149px; position: absolute" Text="Username"></asp:Label>
        </p>
        <asp:Label ID="lblHeader" runat="server" style="z-index: 1; left: 75px; top: 56px; position: absolute; height: 21px; width: 290px;" Text="Welcome Back!" Font-Bold="True" Font-Size="Large"></asp:Label>
        <asp:Label ID="lblSubHeader" runat="server" style="z-index: 1; left: 64px; top: 100px; position: absolute" Text="Login to Access WebStore"></asp:Label>
        <asp:CheckBox ID="chkForget" runat="server" style="z-index: 1; left: 91px; top: 242px; position: absolute" Text="Forget Me" ToolTip="Forget information stored as cookie" />
        <p>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 107px; top: 292px; position: absolute; width: 66px;" Text="Submit" />
        </p>
        <asp:Label ID="lblDontHaveAccount" runat="server" style="z-index: 1; left: 76px; top: 343px; position: absolute" Text="(Don't Have an Account?)"></asp:Label>
        <asp:Button ID="btnRegister" runat="server" style="z-index: 1; left: 106px; top: 366px; position: absolute; height: 26px; width: 70px;" Text="Register" OnClick="btnRegister_Click" />
    </div>

    </form>
</body>
</html>

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
    
    
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 500px; top: 225px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 500px; position: absolute; top: 262px" TextMode="Password"></asp:TextBox>
        <asp:CheckBox ID="chkRemember" runat="server" style="z-index: 1; left: 500px; top: 314px; position: absolute" Text="Remember Me" ToolTip="Remember information as a cookie" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 430px; top: 197px; position: absolute"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 430px; top: 263px; position: absolute" Text="Password"></asp:Label>
        <p>
            <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 430px; top: 226px; position: absolute" Text="Username"></asp:Label>
        </p>
        <asp:Label ID="lblHeader" runat="server" style="z-index: 1; left: 498px; top: 71px; position: absolute; height: 21px; width: 290px;" Text="Welcome Back!" Font-Bold="True" Font-Size="Large"></asp:Label>
        <asp:Label ID="lblSubHeader" runat="server" style="z-index: 1; left: 475px; top: 143px; position: absolute" Text="Login to Access WebStore"></asp:Label>
        <asp:CheckBox ID="chkForget" runat="server" style="z-index: 1; left: 500px; top: 337px; position: absolute" Text="Forget Me" ToolTip="Forget information stored as cookie" />
        <p>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 522px; top: 372px; position: absolute; width: 66px;" Text="Submit" />
        </p>
        <asp:Label ID="lblDontHaveAccount" runat="server" style="z-index: 1; left: 483px; top: 435px; position: absolute" Text="(Don't Have an Account?)"></asp:Label>
        <asp:Button ID="btnRegister" runat="server" style="z-index: 1; left: 523px; top: 460px; position: absolute; height: 26px; width: 70px;" Text="Register" OnClick="btnRegister_Click" />
    </div>

    </form>
</body>
</html>

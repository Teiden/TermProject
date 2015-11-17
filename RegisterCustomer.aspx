<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterCustomer.aspx.cs" Inherits="TermProject_3342.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
     <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
    <title></title>
 

    
</head>
<body>
    <form id="form1" runat="server">
    <div class="absoluteLeft">
    
    
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 90px; top: 150px; position: absolute; width: 97px;"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 210px; top: 150px; position: absolute; width: 97px;"></asp:TextBox>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 90px; top: 230px; position: absolute; width: 215px;"></asp:TextBox>
        <input id="txtEmail" runat="server" style="z-index: 1; left: 90px; top: 310px; position: absolute; width: 215px;" type="Email" onfocus="init();" onblur="unit()" />
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 90px; top: 390px; position: absolute; width: 215px;" TextMode="Password"></asp:TextBox>
        <asp:TextBox ID="txtPasswordConfirm" runat="server" style="z-index: 1; left: 90px; top: 470px; position: absolute; width: 215px;" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 90px; top: 130px; position: absolute" Text="First Name *"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 210px; top: 130px; position: absolute" Text="Last Name *"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 90px; top: 210px; position: absolute" Text="Username"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 90px; top: 290px; position: absolute" Text="Email *"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 90px; top: 370px; position: absolute" Text="Password *"></asp:Label>
        <asp:Label ID="lblPasswordConfirm" runat="server" style="z-index: 1; left: 90px; top: 450px; position: absolute" Text="Confirm Password *"></asp:Label>

        <asp:TextBox ID="txtStreetAddress" runat="server" style="z-index: 1; left: 350px; top: 150px; position: absolute; width: 165px;"></asp:TextBox>
        <asp:TextBox ID="txtZip" runat="server" style="z-index: 1; left: 350px; top: 230px; position: absolute; width: 165px;"></asp:TextBox>
        <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 350px; top: 310px; position: absolute; width: 165px;"></asp:TextBox>
        <asp:TextBox ID="txtState" runat="server" style="z-index: 1; left: 350px; top: 390px; position: absolute; width: 165px;"></asp:TextBox>
        <asp:Label ID="lblStreetAddress" runat="server" style="z-index: 1; left: 350px; top: 130px; position: absolute" Text="Street Address *"></asp:Label>
        <asp:Label ID="lblZip" runat="server" style="z-index: 1; left: 350px; top: 210px; position: absolute" Text="ZIP Code *"></asp:Label>
        <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 350px; top: 290px; position: absolute" Text="City *"></asp:Label>
        <asp:Label ID="lblState" runat="server" style="z-index: 1; left: 350px; top: 370px; position: absolute" Text="State *"></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; left: 350px; top: 470px; position: absolute; width: 165px; right: 451px;"></asp:TextBox>
        <asp:Label ID="lblPhone" runat="server" style="z-index: 1; left: 350px; top: 450px; position: absolute" Text="Phone Number"></asp:Label>

        <asp:CheckBox ID="cbCookie" runat="server" style="z-index: 1; left: 385px; top: 535px; position: absolute; height: 44px; width: 79px;" Text="Save log in as cookie" />
        <asp:Button ID="btnSubmit" runat="server" style="z-index: 1; left: 465px; top: 535px; position: absolute" Text="Submit" OnClick="btnSubmit_Click" />
        <asp:Label ID="lblIncompleteForm" runat="server" style="z-index: 1; left: 570px; top: 150px; position: absolute" Text="" Visible = "false"></asp:Label>
        <asp:Label ID="lblPasswordMismatch" runat="server" style="z-index: 1; left: 570px; top: 230px; position: absolute" Text="" Visible ="false"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 70px; top: 34px; position: absolute" Text="Return" OnClick="btnLogin_Click" />
   </div>
         </form>
</body>
</html>

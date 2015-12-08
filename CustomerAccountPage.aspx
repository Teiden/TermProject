<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerAccountPage.aspx.cs" Inherits="TermProject_3342.CustomerAccountPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
         <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                <asp:Label ID="lblWelcome" runat="server" Text="Welcome to Account Management Page, Customer!" Font-Size="X-Large"></asp:Label>

    </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblEditCard" runat="server" Text="Click on Payment to view and edit your Credit Card Information"></asp:Label>
        </p>
        <p>
        <asp:Button ID="btnEditCardInfo" runat="server" Text="Payment" />

        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:GridView ID="gvAccount" runat="server" style="z-index: 1; left: 552px; top: 3px; position: absolute; height: 235px; width: 391px">
            </asp:GridView>
        </p>
        <p>
            <asp:Label ID="lblEditPersonalInfo" runat="server" Text="Click on Details to modify your personal information"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnModifyDetails" runat="server" Text="Details" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblSecurity" runat="server" Text="Click on Security to review password settings"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnSecurity" runat="server" Text="Security" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="Logout!" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

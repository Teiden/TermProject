<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerPage.aspx.cs" Inherits="TermProject_3342.CustomerPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblWelcome" runat="server" Text="Welcome, Customer!" Font-Size="X-Large"></asp:Label>
        <p>
            <asp:Label ID="lblSelectDepartment" runat="server" Text="Please Select a Department:"></asp:Label>
            <asp:DropDownList ID="ddlDepartments" runat="server">
            </asp:DropDownList>
        </p>

        <br/>
        <asp:GridView ID="gvProducts" runat="server">
            <Columns>
                <asp:ImageField>
                </asp:ImageField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Add to Cart" />
        <br/>
        <br/>



    </div>

    </form>
</body>
</html>

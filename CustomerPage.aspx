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
            <asp:Label ID="lblSelectDepartment" runat="server" Text="Please Select a Department:" ></asp:Label>
            <asp:DropDownList ID="ddlDepartments" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlDepartments_SelectedIndexChanged">
            </asp:DropDownList>
        </p>

        <br/>
        <asp:GridView ID="gvProducts" runat="server" OnRowCommand="gvProducts_RowCommand">
            <Columns>
                <asp:ImageField DataImageUrlField="ProductImageURL">
                    <ItemStyle Height="80px" Width="100px" />
                </asp:ImageField>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnCheckout" runat="server" Text="Proceed to Checkout!" OnClick="btnCheckout_Click" Width="183px" />
        <br/>
        <asp:Button ID="btnManageAccount" runat="server" OnClick="btnManageAccount_Click" Text="Account Settings" Width="182px" />
        <br/>



    </div>

    </form>
</body>
</html>

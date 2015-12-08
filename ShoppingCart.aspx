<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="TermProject_3342.ShoppingCartsbc" %>

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
    <br />
    <br />

        <asp:Label ID="lblCart" runat="server" Text="Please Review Your Cart and Checkout"></asp:Label>
    <br />

        <asp:GridView ID="gvShoppingCart" runat="server">
            <Columns>
                <asp:ImageField DataImageUrlField="ProductImageURL">
                </asp:ImageField>
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
            </Columns>
         </asp:GridView>

         <asp:Button ID="btnPurchase" runat="server" OnClick="btnPurchase_Click" Text="Checkout!" />

    </div>
    </form>
</body>
</html>

﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MerchantPage.aspx.cs" Inherits="TermProject_3342.MerchantPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
    <link href="Css.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:TemplateField></asp:TemplateField>
                <asp:TemplateField></asp:TemplateField>
                <asp:TemplateField></asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </EmptyDataTemplate>
        </asp:GridView>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="TermProject_3342.LandingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
    <title></title>
</head>
<body>
    <h1 style="text-align:center">Tal and Allen, Happy Hipsters Selling Hemp</h1>
    <form id="form1" runat="server">
        
        <div>


            <h2 style="text-align:center">Uses of Hemp</h2>

            <h3>Housing</h3>

            <p>70% of the Cannabis Plant total weight is made up of a woody inner core. This part of the plant is THC free (i.e. Hemp) and is used in housing construction. The silica leached from the soil by the plant combined with unslaked lime forms a chemical bond similar to cement which is fire and water proof. Cannabis Homes</p>

            <h3>Food</h3>

            <p>Hemp may be grown also for food (the seed) but in the UK at least (and probably in other EU countries) cultivation licenses are not available for this purpose. Within Defra (the UK's Department for Environment, Food and Rural Affairs) hemp is treated as purely a non-food crop, despite the fact that seed can and does appear on the UK market as a perfectly legal food product.</p>

            <h3>Nutrition</h3>

            <p>Both the complete protein and the oils contained in hempseeds (rich in lanolin and linolenic acids) are in ideal ratios for human nutrition.</p>

            <h3>Fiber</h3>

            <p>Until its rediscovery in the late 1980s, the use of hemp for fiber production had declined sharply over the past decades, but hemp still occupied an important place amongst natural fibers as it is strong, durable and unaffected by water. The main uses of hemp fiber were inrope, sacking, carpet, nets and webbing. A hemp clothing industry was reborn in the West in 1988, and hemp is being used in increasing quantities in paper manufacturing. The cellulose content is about 70%.</p>

            <h3>Fuel</h3>

           <p>Fuel can be a by-product of hemp cultivation. One fuel would be biodiesel because of the oils in the seeds and stalk of the hemp, another would be biofuel from the fibrous stalks</p3>
               <br /><br />
            <a href="http://www.hempbasics.com/shop/hemp-information">Source: HempBasics</a>
        </div>
        <div class="absolute">
            <h2>Welcome to our Emporium</h2>
            <h2>This is a member only site</h2>
            <h3>Are you:</h3>
            <table style="text-align:center; width:100%">
                <tr>
                    <td>
                       <%-- //<a href="LogIn.aspx" type="button">An Existing Client</a>--%>
                        <asp:Button ID="btnExist" runat="server" Text="An Existing Member" href="LogIn.aspx" OnClick="btnExist_Click"/></td>
               
                    <td>
                        <asp:Button ID="btnNew" runat="server" Text="A New Member" OnClick="btnNew_Click" /></td>
                </tr>
            </table>
            <br /><br />

        </div>
    </form>
</body>
</html>

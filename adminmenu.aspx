<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="adminmenu.aspx.cs" Inherits="adminmenu" Title="Untitled Page" %>

<%@ Register src="UserControls/nav.ascx" tagname="nav" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
    {
        width: 77%;
            height: 634px;
            margin-right: 3px;
        }
        .style6
        {
        }
        .style7
        {
            width: 205px;
        }
        .style8
        {
            width: 248px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
            <table class="style4" align="center">
                <tr>
                    <td class="style8">
                        <img alt="" src="Admin/admin%20images/product-icon.png" 
                            style="width: 157px; height: 90px" /><br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="adminpro" runat="server" onclick="adminpro_Click">Manage 
                        Products</asp:LinkButton>
                    </td>
                    <td class="style7">
                        <img alt="" src="Admin/admin%20images/lock-icon.png" 
                            style="width: 157px; height: 90px" /><br />
                    <asp:LinkButton ID="roleman" runat="server" onclick="roleman_Click">Role 
                    Management</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="style8">
                        <img alt="" src="Admin/admin%20images/Product-documentation-icon.png" 
                            style="width: 158px; height: 89px" /><br />
                    <asp:LinkButton ID="admincat" runat="server" onclick="admincat_Click">Manage 
                        Catagories</asp:LinkButton>
                        <br />
                    </td>
                    <td class="style7">
                        <img alt="" src="Admin/admin%20images/product-sales-report-icon.png" 
                            style="width: 157px; height: 90px" /><br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="procat" runat="server" onclick="procat_Click">View Products </asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="style8">
                        <img alt="" src="Admin/admin%20images/Clipboard-icon.png" 
                            style="width: 157px; height: 90px" /><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Manage 
                        Orders</asp:LinkButton>
                    </td>
                    <td class="style7">
                        <img alt="" src="Admin/admin%20images/personal-information-icon.png" 
                            style="width: 157px; height: 90px" /><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="lnkusers" runat="server" onclick="lnkusers_Click">Administer 
                    Users</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="style8">
                        <img alt="" src="Admin/admin%20images/stocks-icon.png" 
                            style="width: 157px; height: 90px" /><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Lnkstrpt" runat="server" onclick="Lnkstrpt_Click">Stock 
                    Report</asp:LinkButton>
                    </td>
                    <td class="style7">
                        <img alt="" src="Admin/admin%20images/calculator-icon.png" 
                            style="width: 157px; height: 90px" /><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="LinkButton8" runat="server" onclick="LinkButton8_Click">Sales 
                        and Profit</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td class="style6" colspan="2">
                        &nbsp;&nbsp;&nbsp;
                        <img alt="" src="Admin/admin%20images/stockalerts.png" 
                            style="width: 154px; height: 128px" /><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:LinkButton ID="lnkstockalerts" runat="server" 
                            onclick="lnkstockalerts_Click">Stock Alerts</asp:LinkButton>
                    </td>
                </tr>
            </table>
            <p>
    </p>
    
</asp:Content>


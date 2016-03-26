<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="stockordergrid.aspx.cs" Inherits="stockordergrid" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">


    .style4
    {
        width: 100%;
    }
        .style5
        {
        }
        .style6
        {
            width: 253px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style4">
    <tr>
        <td class="style5" align="center" colspan="2">
            <asp:LinkButton ID="LinkButton8" runat="server" onclick="LinkButton8_Click">Stock Reports
            </asp:LinkButton>
            |
            <asp:LinkButton ID="LinkButton9" runat="server" onclick="LinkButton9_Click">Stock Alerts</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td class="style6">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style6">
            Product Name:</td>
        <td>
            &nbsp;<asp:Label ID="lblproname" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Supplier Name</td>
        <td>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged"  AutoPostBack="true">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Supplier Cell</td>
        <td>
&nbsp;<asp:Label ID="lblcell" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Supplier Address</td>
        <td>
&nbsp;<asp:Label ID="lbladdress" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Ordered Quantity</td>
        <td>
            <asp:TextBox ID="txtOrderedQuantity" runat="server"></asp:TextBox>
&nbsp;</td>
    </tr>
    <tr>
        <td colspan="2" align="center">
            <asp:Button ID="btnOrder" runat="server" onclick="btnOrder_Click" 
                Text="Order Product" />
        </td>
    </tr>
    <tr>
        <td colspan="2" align="center">
            <asp:Label ID="lblresult" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2" align="center">
            &nbsp;</td>
    </tr>
</table>
    <p>
    </p>
    <p>
    </p>
</asp:Content>


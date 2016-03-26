<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="acknowledge.aspx.cs" Inherits="acknowledge" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style4
    {
        width: 66%;
    }
    .style5
    {
    }
    .style6
    {
        width: 155px;
    }
    .style7
    {
        width: 155px;
        height: 18px;
    }
    .style8
    {
        height: 18px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p align="center">
        <asp:LinkButton ID="LinkButton11" runat="server" onclick="LinkButton11_Click">Stock 
        Reports</asp:LinkButton>
            |
            <asp:LinkButton ID="LinkButton12" runat="server" 
            onclick="LinkButton12_Click">Stock Alerts</asp:LinkButton>
    <br />
</p>
<table align="center" class="style4">
    <tr>
        <td class="style6">
            StockId</td>
        <td>
            <asp:Label ID="lblstockid" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Prorduct Name</td>
        <td>
            <asp:Label ID="lblproname" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Supplier Name</td>
        <td>
            <asp:Label ID="lblsuppliername" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Supplier Cell</td>
        <td>
            <asp:Label ID="lblsuppliercell" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style7">
            Supplier Address</td>
        <td class="style8">
            <asp:Label ID="lblsupplieradress" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Ordered Quantity</td>
        <td>
            <asp:Label ID="lblorderedquantity" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style6">
            Ordering Date</td>
        <td>
            <asp:Label ID="lblorderingdate" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td align="center" class="style5" colspan="2">
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Confirm Order" />
        </td>
    </tr>
    <tr>
        <td align="center" class="style5" colspan="2">
            <asp:Label ID="lblshow" runat="server"></asp:Label>
        </td>
    </tr>
</table>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>


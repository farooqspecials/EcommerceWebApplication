<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="stock.aspx.cs" Inherits="stock" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    .style4
    {
        width: 100%;
    }
        .style5
        {
            width: 163px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;Product Order If Not&nbsp;</p>
<table class="style4">
    <tr>
        <td class="style5">
            Product Name:</td>
        <td>
            <asp:DropDownList ID="dpproductname" runat="server">
            </asp:DropDownList>
        &nbsp;<asp:Label ID="lblproname" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="style5">
            Supplier Name</td>
        <td>
            <asp:TextBox ID="txtsuppliername" runat="server"></asp:TextBox>
&nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            Supplier Cell</td>
        <td>
            <asp:TextBox ID="txtsuppliercell" runat="server"></asp:TextBox>
&nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
            Supplier Address</td>
        <td>
            <asp:TextBox ID="txtSupplierAddress" runat="server"></asp:TextBox>
&nbsp;</td>
    </tr>
    <tr>
        <td class="style5">
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
            <asp:Label ID="lblresult" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="2" align="center">
            To Add More Products :<asp:LinkButton ID="LinkButton1" runat="server" 
                onclick="LinkButton1_Click">ClickMe</asp:LinkButton>
        </td>
    </tr>
</table>
    <p>
    </p>
    </asp:Content>


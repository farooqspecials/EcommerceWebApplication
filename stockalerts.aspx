<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="stockalerts.aspx.cs" Inherits="stock_alerts" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
        }
        .style4
        {
            height: 36px;
        }
        .style5
        {
            height: 42px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table class="style3">
        <tr>
            <td class="style4">
                <h2 align="center">Stock Alerts</h2></td>
        </tr>
        <tr>
            <td align="center" class="style5" >
                <asp:LinkButton ID="LinkButton10" runat="server" onclick="LinkButton10_Click">Stock 
                Reports</asp:LinkButton>
            |
            <asp:LinkButton ID="LinkButton9" runat="server" onclick="LinkButton9_Click">Stock 
                Alerts</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td align="center" class="style5" >
            <font color="red">The Stock of fallowing products is low. Kindly order them on time in order to 
                avoid complications</font>
                <br />
            </td>
        </tr>
        <tr>
            <td align="center">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="ProductID">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("ProductID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Product Name">
                    <ItemTemplate>
                        <asp:Label ID="lblproname" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sale Price">
                    <ItemTemplate>
                        <asp:Label ID="lblsaleprice" runat="server" Text='<%# Eval("UnitCost") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Buy Price">
                    <ItemTemplate>
                        <asp:Label ID="lblbuyprice" runat="server" Text='<%# Eval("origionalPrice") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Stock Quantity">
                    <ItemTemplate>
                        <asp:Label ID="lblstockquantity" runat="server" 
                            Text='<%# Eval("productquantity") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Order More">
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkordermore" runat="server" onclick="lnkordermore_Click" PostBackUrl='<%# "~/stockordergrid.aspx?ID="+Eval("ProductName") %>'>Order More</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
            </td>
        </tr>
    </table>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
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
    <p>
    </p>
</asp:Content>


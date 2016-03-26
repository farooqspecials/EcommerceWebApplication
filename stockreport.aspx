<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="stockreport.aspx.cs" Inherits="stockreport" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table class="style3">
        <tr>
            <td>
                <h2 align="center">Stock Reports</h2></td>
        </tr>
        <tr>
            <td align="center">
                <br />
        <asp:LinkButton ID="LinkButton11" runat="server" onclick="LinkButton11_Click">Stock 
        Alerts</asp:LinkButton>
            |
            <asp:LinkButton ID="LinkButton9" runat="server" onclick="LinkButton9_Click">Admin 
        Menu</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td align="center">
                <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="ProductID">
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkproid" runat="server" PostBackUrl='<%# "~/stockOrderHistory.aspx?ID="+Eval("ProductID") %>'  Text='<%# Eval("ProductID") %>'></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Product Name">
                    <ItemTemplate>
                        <asp:Label ID="lblproname" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sale Price">
                    <ItemTemplate>
                        <asp:Label ID="lblunitcost" runat="server" Text='<%# Convert.ToDouble(Eval("UnitCost")) %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Buy Price">
                    <ItemTemplate>
                        <asp:Label ID="lblbuyprice" runat="server" Text='<%# Convert.ToDouble(Eval("origionalPrice")) %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Stock Quantity">
                    <ItemTemplate>
                        <asp:Label ID="lblstockquantity" runat="server" 
                            Text='<%# Eval("productquantity") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Order History">
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkOrderHistory" PostBackUrl='<%# "~/stockOrderHistory.aspx?ID="+Eval("ProductID") %>' runat="server">Order History</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Order More">
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkOrderMore" PostBackUrl='<%# "~/stockordergrid.aspx?ID="+Eval("ProductName") %>' runat="server">Order More</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
            </td>
        </tr>
    </table>
    
</asp:Content>


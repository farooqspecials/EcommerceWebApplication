<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="stockOrderHistory.aspx.cs" Inherits="stockOrderHistory" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <table class="style3">
        <tr>
            <td align="center">
                <asp:LinkButton ID="LinkButton12" runat="server" onclick="LinkButton12_Click">Stock 
                Alerts</asp:LinkButton>
            |
                <asp:LinkButton ID="LinkButton13" runat="server" onclick="LinkButton13_Click">Stock 
                Reports</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="center">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="StockId">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("StockId") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Product Name">
                    <ItemTemplate>
                        <asp:Label ID="lblproname" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Supplier Name">
                    <ItemTemplate>
                        <asp:Label ID="lblsupname" runat="server" Text='<%# Eval("SupplierName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Supplier Cell">
                    <ItemTemplate>
                        <asp:Label ID="lblsupcell" runat="server" Text='<%# Eval("SupplierCell") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Supplier Address">
                    <ItemTemplate>
                        <asp:Label ID="lblsupaddress" runat="server" 
                            Text='<%# Eval("SupplierAddress") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ordered Quantity">
                    <ItemTemplate>
                        <asp:Label ID="lblorderquantity" runat="server" 
                            Text='<%# Eval("OrderedQuantity") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Ordering Date">
                    <ItemTemplate>
                        <asp:Label ID="lblorderdate" runat="server" Text='<%# Eval("OrderDate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delivary Status">
                    <ItemTemplate>
                        <asp:Label ID="lblstatus" runat="server" Text='<%# Eval("DelivaryStatus") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Acknowledge Order">
                    <ItemTemplate>
                        <asp:LinkButton ID="Lnkacknowledge" runat="server" PostBackUrl='<%# "~/acknowledge.aspx?ID="+Eval("StockId") %>'>Acknowledge</asp:LinkButton>
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
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>


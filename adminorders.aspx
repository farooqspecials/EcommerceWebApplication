<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="adminorders.aspx.cs" Inherits="adminorders" Title="Untitled Page" %>

<%@ Register src="UserControls/nav.ascx" tagname="nav" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table class="style4">
                <tr>
                    <td align="center">
                        <h2>
                            Order History and Details of the Customers</h2>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            HorizontalAlign="Center" AllowPaging="True" 
                    onpageindexchanging="_pagechange" PageSize="15" Width="500px">
                            <Columns>
                                <asp:TemplateField HeaderText="OrderID">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="linkorder" runat="server"  
                            PostBackUrl='<%# "~/adminOrdersDetails.aspx?ID="+Eval("OrderID") %>' 
                            Text='<%# Eval("OrderID") %>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="OrderDate">
                                    <ItemTemplate>
                                        <asp:Label ID="lblorderdate" runat="server" Text='<%# Eval("OrderDate") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="CustomerID">
                                    <ItemTemplate>
                                        <asp:Label ID="lblcustomerID" runat="server" Text='<%# Eval("CustomerID") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Status">
                                    <ItemTemplate>
                                        <asp:Label ID="lblstatus" runat="server" Text='<%# Eval("Status") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Total Amount">
                                    <ItemTemplate>
                                        <asp:Label ID="lblamt" runat="server" 
                            Text='<%# Convert.ToDouble(Eval("totalAmount")) %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
    </p>
</asp:Content>


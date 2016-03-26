<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ProductCatalog.aspx.cs" Inherits="ProductCatalog" Title="Untitled Page" %>

<%@ Register src="UserControls/nav.ascx" tagname="nav" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </p>
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
        <asp:Label ID="lblshow" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            <asp:GridView ShowHeader="False" ID="GridView1" runat="server" AutoGenerateColumns="False" 
            Width="581px" 
            style="margin-right: 4px" onrowcommand="_RowCammand" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <table style="width: 100%">
                                <tr>
                                    <td rowspan="4" valign="top" width="5%">
                                        <asp:Image ID="Image1" runat="server" Height="150px" Width="150px" ImageUrl='<%# Eval("ProductImage") %>' />
                                    </td>
                                    <td align="left">
                                        <asp:LinkButton ID="lnkname" runat="server" Text='<%# Eval("ProductName") %>'></asp:LinkButton>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left">
                                        <asp:Label ID="Label3" runat="server" 
                                        Text='<%# GetShortDescription(Eval("Description").ToString()) %>' 
                                            Font-Bold="True"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="left">
                                        <asp:Label ID="Label5" runat="server" SkinID="FormLabel" Text="Price :"></asp:Label>
                                        <asp:Label ID="Label4" runat="server" 
                                            Text='<%# "Rs "+Convert.ToDouble(Eval("UnitCost")) %>' Font-Bold="True" 
                                            ForeColor="Black"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Button ID="btnaddcart" runat="server" Text="Add to Cart" 
                                        CommandArgument='<%# Eval("ProductID") %>' />
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                        <ItemStyle BorderColor="DarkGoldenrod" BorderStyle="Solid" BorderWidth="0px" />
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>


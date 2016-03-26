<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="search" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
       <h2 align="center"> <asp:Label ID="lblsearch" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label></h2>
        <br />
    </p>
    <p>
        <asp:GridView ShowHeader="false" ID="GridView1" runat="server" AutoGenerateColumns="False" 
            Width="581px" 
            style="margin-right: 4px" onrowcommand="_rowcommand" >
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <table style="width: 100%">
                            <tr>
                                <td rowspan="4" valign="top" width="5%">
                                    <asp:Image ID="Image1" runat="server" Height="150px" Width="150px" ImageUrl='<%# Eval("ProductImage") %>' />
                                </td>
                                <td align="left">
                                    <asp:LinkButton ID="lnkname" runat="server" 
                                        PostBackUrl='<%# "~/ProductCatalog.aspx?ID="+Eval("ProductID") %>' 
                                        Text='<%# Eval("ProductName") %>'></asp:LinkButton>
                                </td>
                            </tr>
                            <tr>
                                <td align="left">
                                    <asp:Label ID="Label3" runat="server" 
                                        Text='<%# GetShortDescription(Eval("Description").ToString()) %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td align="left">
                                    <asp:Label ID="Label5" runat="server" SkinID="FormLabel" Text="Price :"></asp:Label>
                                    <asp:Label ID="Label4" runat="server" Text='<%# "Rs "+Eval("UnitCost") %>'></asp:Label>
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
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>


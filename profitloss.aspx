<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="profitloss.aspx.cs" Inherits="profitloss" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
        }
        .style4
        {
            height: 18px;
        }
        .style5
        {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table class="style3" >
                <tr>
                    <td class="style5" colspan="2">
                        <h2 align="center">Sales Report</h2></td>
                </tr>
                <tr>
                    <td class="style5">
                        &nbsp;&nbsp;<br />
                        <br />
                        <br />
                        &nbsp; Start Date:
                        <asp:TextBox ID="txtstrdate" runat="server"></asp:TextBox>
                        <asp:CalendarExtender ID="CalendarExtender1" runat="server" Format="MM/d/yyyy" 
                            TargetControlID="txtstrdate">
                        </asp:CalendarExtender>
                        &nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <br />
                        <br />
                        End Date:
                        <asp:TextBox ID="txtenddate" runat="server"></asp:TextBox>
                        <asp:CalendarExtender ID="CalendarExtender2" runat="server" Format="MM/d/yyyy" 
                            TargetControlID="txtenddate">
                        </asp:CalendarExtender>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnsbt" runat="server" onclick="btnsbt_Click" Text="Enter" />
                        &nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="center" class="style5" colspan="2">
                        <br />
                        <br />
                        <asp:Label ID="lblresult" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2" >
                        <br />
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            onrowdatabound="_row" Width="640px" AllowPaging="True" Height="134px" onpageindexchanging="_pagechange" 
            onselectedindexchanged="_indexchange" >
                            <Columns>
                                <asp:TemplateField HeaderText="ProductID">
                                    <ItemTemplate>
                                        <asp:Label ID="lblproid" runat="server" Text='<%# Eval("ProductID") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ProductName">
                                    <ItemTemplate>
                                        <asp:Label ID="lblProductName" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Buy Price">
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" 
                                            Text='<%# Convert.ToDouble(Eval("buyprice")) %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Quantity">
                                    <ItemTemplate>
                                        <asp:Label ID="lblquantity" runat="server" Text='<%# Eval("Quantity") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Sale Price">
                                    <ItemTemplate>
                                        <asp:Label ID="lblunitcost" runat="server" Text='<%# Eval("UnitCost") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Purchase Date">
                                    <ItemTemplate>
                                        <asp:Label ID="lblPurchaseDate" runat="server" 
                            Text='<%# Eval("PurchaseDate") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Status">
                                    <ItemTemplate>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("Status") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Total Sale Price">
                                    <FooterTemplate>
                                        <asp:Label ID="lblfotter1" runat="server"></asp:Label>
                                    </FooterTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbltotalsale" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Total Buy Price">
                                    <FooterTemplate>
                                        <asp:Label ID="lblfooter2" runat="server" Text="Label"></asp:Label>
                                    </FooterTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="lbltotalbuy" runat="server" Text="Label"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="style4" colspan="2" align="center">
                        <asp:Label ID="lblsale" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
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
</asp:Content>


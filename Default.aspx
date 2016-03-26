<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>

<%@ Register src="UserControls/nav.ascx" tagname="nav" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
        	
            width: 100%;
            border: 1px solid #666;
            
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            
            <p>
                <asp:DataList ID="DataList1" runat="server" CellPadding="6" CellSpacing="8" 
            RepeatDirection="Horizontal" Width="79px" RepeatColumns="4" >
                    <ItemTemplate>
                        <br />
                        <table class="style4" >
                            <tr bgcolor="#666" class="style4">
                                <td align="center" >
                                    <asp:LinkButton ID="lnkproname" runat="server" 
                                PostBackUrl='<%# "~/ProductCatalog.aspx?ID="+Eval("ProductID") %>' 
                                Text='<%# Eval("ProductName") %>' Font-Bold="True" Font-Underline="False" 
                                        ForeColor="White"></asp:LinkButton>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <asp:ImageButton ID="ImageButton1" Height="150px" Width="150px" runat="server" PostBackUrl='<%# "~/ProductCatalog.aspx?ID="+Eval("ProductID") %>' 
                                ImageUrl='<%# Eval("ProductImage") %>' />
                                </td>
                            </tr>
                            <tr bgcolor="#F7F7DE">
                                <td align="center">
                                    <asp:Label ID="lblprice" runat="server" 
                                Text='<%# "Rs "+Convert.ToDouble(Eval("UnitCost")) %>' Font-Bold="True" 
                                        ForeColor="Blue"></asp:Label>
                                </td>
                            </tr>
                            <tr bgcolor="#F7F7DE">
                                <td align="center">
                                    <asp:ImageButton ID="ImageButton2" ImageUrl="~/Admin/images/clean_ecommerce_web_buttons_03.jpg" PostBackUrl='<%# "~/ProductCatalog.aspx?ID="+Eval("ProductID") %>'  runat="server" />
                                </td>
                            </tr>
                        </table>
                        <br />
                        <br />
                        <br />
                    </ItemTemplate>
                </asp:DataList>
            </p>
            <p align="center">
                <asp:LinkButton ID="LinkButton8" runat="server" onclick="LinkButton8_Click">&lt;&lt;Previous</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton9" runat="server" onclick="LinkButton9_Click">Next&gt;&gt;</asp:LinkButton>
            </p>
            <p align="center">
                &nbsp;</p>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>


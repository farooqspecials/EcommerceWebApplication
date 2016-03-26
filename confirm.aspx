<%@ Page Language="C#"  Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="confirm.aspx.cs" Inherits="confirm" Title="Untitled Page" %>

<%@ Register src="UserControls/nav.ascx" tagname="nav" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style6
        {
            width: 100%;
        }
        .style4
        {
            width: 73%;
        }
        .style7
        {
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
            <p>
                
                <h2 align="center">Order Confirmation</h2></p>
            <asp:Panel ID="Panel1" runat="server">
                <p>
                    Ordered Products:-</p>
                <p align="center">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            Width="654px">
                        <Columns>
                            <asp:TemplateField HeaderText="Product Name">
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Quantity">
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Quantity") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Price">
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("UnitCost") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </p>
                <table align="left" class="style6">
                    <tr>
                        <td align="right">
                            Total Dues:&nbsp;
                            <asp:Label ID="lbltotal" runat="server"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </td>
                    </tr>
                </table>
                <p>
                    Shipping Information:-</p>
                <table align="center" class="style4">
                    <tr>
                        <td class="style5">
                            First Name:</td>
                        <td>
                            <asp:Label ID="lblfirstname" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Last Name:</td>
                        <td>
                            <asp:Label ID="lbllastname" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Address:</td>
                        <td>
                            <asp:Label ID="lbladdress" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Phone No:</td>
                        <td>
                            <asp:Label ID="lblphoneno" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Province:</td>
                        <td>
                            <asp:Label ID="lblprovince" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            City:</td>
                        <td>
                            <asp:Label ID="lblcity" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5">
                            Postal Code:</td>
                        <td>
                            <asp:Label ID="lblpostalcode" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5" colspan="2">
                            <asp:Label ID="lblorder" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
                <p>
                </p>
                <p>
                </p>
            </asp:Panel>
            <table class="style6" __designer:mapid="50">
                <tr __designer:mapid="51">
                    <td align="center" class="style7" __designer:mapid="52">
                        <asp:Button ID="btnprint" runat="server" Text="Print Invoice" Width="153px" 
                    onclick="btnprint_Click" />
                    </td>
                    <td align="left" __designer:mapid="56">
                        <asp:Button ID="Button1" runat="server" Text="Get Mobile Confirmation" 
                    Width="184px" onclick="Button1_Click" />
                    </td>
                </tr>
            </table>
            <p __designer:mapid="58">
                &nbsp;</p>
            <p align="center" __designer:mapid="59">
                <asp:Label ID="lblexp" runat="server"></asp:Label>
            </p>
            </asp:Content>


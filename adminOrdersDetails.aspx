<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="adminOrdersDetails.aspx.cs" Inherits="adminOrdersDetails" Title="Untitled Page" %>

<%@ Register src="UserControls/nav.ascx" tagname="nav" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 60%;
        }
        .style5
        {
        }
        .style6
        {
        }
        .style7
        {
            width: 100%;
        }
        .style8
        {
            width: 145px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
                        <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table class="style7">
                <tr>
                    <td>
                        <h2 align="center">
                            Shipping Details</h2>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <table align="center" class="style4" border="1" bordercolor="#eee8aa;" >
                            <tr>
                                <td class="style8">
                                    CustomerId</td>
                                <td>
                                    <asp:Label ID="lblcustomerID" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style8">
                                    First Name:</td>
                                <td>
                                    <asp:Label ID="lblfirstname" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style8">
                                    LastName:</td>
                                <td>
                                    <asp:Label ID="lbllastname" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style8">
                                    Company:</td>
                                <td>
                                    <asp:Label ID="lblcompany" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style8">
                                    Address:</td>
                                <td>
                                    <asp:Label ID="lbladdress" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style8">
                                    Country:</td>
                                <td>
                                    <asp:Label ID="lblcountry" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style8">
                                    Province:</td>
                                <td>
                                    <asp:Label ID="lblprovince" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style8">
                                    ZipCode</td>
                                <td>
                                    <asp:Label ID="lblzipcode" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style8">
                                    Telephone:
                                </td>
                                <td>
                                    <asp:Label ID="lbltelephone" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style8">
                                    Fax:</td>
                                <td>
                                    <asp:Label ID="lblfax" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style8">
                                    City:</td>
                                <td>
                                    <asp:Label ID="lblcity" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style8">
                                    Status</td>
                                <td>
                                    <asp:Label ID="lblstatus" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="style6" colspan="2">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="style6" colspan="2">
                                    <h2>
                                        Update Shipping Status</h2>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td align="center" class="style8">
                                    Update Status:</td>
                                <td align="center" class="style5">
                                    <asp:DropDownList ID="DropDownList1" runat="server">
                                        <asp:ListItem>New</asp:ListItem>
                                        <asp:ListItem>InProcess</asp:ListItem>
                                        <asp:ListItem>Completed</asp:ListItem>
                                    </asp:DropDownList>
                                    <br />
                                    <asp:Label ID="lblcombo" runat="server" ForeColor="Red" 
                                        Text="Functionality is Disable"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" class="style5" colspan="2">
                                    <asp:Button ID="Button1" runat="server" Text="Update Order Information" 
                                        onclick="Button1_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td align="center" class="style5" colspan="2">
                                    <asp:Label ID="lblshow" runat="server"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <h2 align="center">
                            Items Details</h2>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" onrowdatabound="_dtabound" DataKeyNames="ProductID"
                            >
                            <Columns>
                                <asp:TemplateField HeaderText="ProductID">
                                    <ItemTemplate>
                                        <asp:Label ID="lblproid" runat="server" Text='<%# Eval("ProductID") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="ProductName">
                                    <ItemTemplate>
                                        <asp:Label ID="lblproductname" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Quantity">
                                    <ItemTemplate>
                                        <asp:Label ID="lblqty" runat="server" Text='<%# Eval("Quantity") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="UnitCost">
                                    <ItemTemplate>
                                        <asp:Label ID="lblprice" runat="server" Text='<%# Eval("UnitCost") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Total Order Price">
                                    <ItemTemplate>
                                        <asp:Label ID="lbltotal" runat="server" Text="Label"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        Total Dues:&nbsp;
                        <asp:Label ID="lblDues" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
        
                        </asp:Content>


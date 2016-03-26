<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RoleManagement.aspx.cs" Inherits="Admin_RoleManagement" Title="Untitled Page" %>

<%@ Register src="UserControls/nav.ascx" tagname="nav" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 54%;
            height: 63px;
        }
        .style5
        {
        }
        .style6
        {
            width: 55%;
        }
        .style7
        {
        }
        .style8
        {
            width: 58%;
        }
        .style9
        {
        }
        .style10
        {
            width: 106px;
        }
        .style11
        {
            height: 18px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <p>
                <h2 align="center">
                    Add Role</h2>
                <table align="center"class="style4">
                    <tr>
                        <td class="style5">
                            Role Name:</td>
                        <td>
                            <asp:TextBox ID="txtaddrole" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5" colspan="2" align="center">
                            <br />
                            <asp:Button ID="btnaddrole" runat="server" onclick="btnaddrole_Click" 
            Text="Add New Role" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style5" colspan="2" align="center">
                            <asp:Label ID="lblresult" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style5" colspan="2" align="center">
                            <br />
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            HorizontalAlign="Center">
                                <Columns>
                                    <asp:TemplateField HeaderText="GroupID">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtgpid" runat="server" Text='<%# Eval("RoleName") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="lblgpid" runat="server" Text='<%# Eval("GroupID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="RoleName">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtrolename" runat="server" Text='<%# Eval("RoleName") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="lblrolename" runat="server" Text='<%# Eval("RoleName") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
                <p align="left">
                    &nbsp;</p>
                <p align="left">
                    <h2 align="center">
                        Assign Roles to Users</h2>
                    <table align="center" class="style6">
                        <tr>
                            <td class="style10">
                                UserName:</td>
                            <td>
                                <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="style10">
                                Role Name:</td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" Height="29px" Width="132px">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" class="style7" colspan="2">
                                <br />
                                <asp:Button ID="btnassignrole" runat="server" onclick="btnassignrole_Click" 
            Text="Assign Role" />
                            </td>
                        </tr>
                        <tr>
                            <td align="center" class="style7" colspan="2">
                                <asp:Label ID="lblasign" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    <p align="left">
                        <h2 align="center">
                            Delete User Roles</h2>
                        &nbsp;<table align="center" 
        class="style8">
                            <tr>
                                <td class="style11">
                                    &nbsp;</td>
                                <td class="style11">
                                </td>
                            </tr>
                            <tr>
                                <td class="style9" colspan="2">
                                    <br />
                                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            HorizontalAlign="Center" onrowdeleting="_rowdel">
                                        <Columns>
                                            <asp:TemplateField HeaderText="User Name">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblusername" runat="server" Text='<%# Eval("UserName") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Role Name">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblrolename" runat="server" Text='<%# Eval("RoleName") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:CommandField ShowDeleteButton="True" />
                                        </Columns>
                                    </asp:GridView>
                                </td>
                            </tr>
                        </table>
                        <p align="left">
                            &nbsp;&nbsp;</p>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>


<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="categoryManagement.aspx.cs" Inherits="Admin_catad" Title="Untitled Page" %>

<%@ Register src="UserControls/nav.ascx" tagname="nav" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 55%;
        }
        .style5
        {
            width: 115px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <p>
                &nbsp;</p>
            <p>
                <h2 align="center">
                    Add New Catagory</h2>
                <table align="center" class="style4">
                    <tr>
                        <td class="style5">
                            Category Name:</td>
                        <td>
                            <asp:TextBox ID="txtaddcat" runat="server" Height="18px" Width="186px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            <br />
                            <asp:Button ID="btnaddcat" runat="server" Text="Add Category" 
            onclick="btnaddcat_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            <br />
                            <asp:Label ID="showlbl" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            <br />
                            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" onpageindexchanging="_pagechange" 
            onrowcancelingedit="_rowcancel" onrowdeleting="_rowdeleting" 
            onrowediting="_rowediting" onrowupdating="_rowupdating" Width="394px"  
            onselectedindexchanged="GridView1_SelectedIndexChanged" onrowdatabound="_rowbound" DataKeyNames="CategoryID" >
                                <Columns>
                                    <asp:TemplateField HeaderText="Category ID">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtid" runat="server" Text='<%# Eval("CategoryID") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="lblid" runat="server" Text='<%# Eval("CategoryID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Category Name">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtcatname" runat="server" Text='<%# Eval("CategoryName") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="lblcatname" runat="server" Text='<%# Eval("CategoryName") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:CommandField ShowEditButton="True" />
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:LinkButton ID="LinkButton8" CommandName="Delete" runat="server" 
                                                OnClientClick="javascript:return confirm('Do you really want to \ndelete the item?');" 
                                                ForeColor="Black">Delete</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                                <p>
                </p>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>


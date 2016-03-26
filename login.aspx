<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 125px;
        }
        .style4
        {
            width: 338px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <p>
                &nbsp;</p>
            <p>
                <table align="center">
                    <tr>
                        <td class="style3">
                        </td>
                        <td class="style4">
                        </td>
                    </tr>
                    <tr>
                        <td align="center" class="style3">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; UserID</td>
                        <td class="style4">
                            <asp:TextBox ID="txtUserid" runat="server" Width="130px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" class="style3">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password</td>
                        <td class="style4">
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="130px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                        </td>
                        <td class="style4">
                            <asp:CheckBox ID="chkRemeberMe" runat="server" Text="Remember me next time." />
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                        </td>
                        <td class="style4">
                            <asp:Label ID="lblMessage" runat="server" ForeColor="Maroon"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style3">
                        </td>
                        <td class="style4">
                            <asp:Button ID="btnlogin" runat="server" OnClick="btnLogin_Click" 
                        Text="Login" />
                        </td>
                    </tr>
                    <tr>
                        <td align="left" colspan="2">
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:LinkButton ID="lnknewuser" runat="server" Font-Underline="False" 
                        onclick="lnknewuser_Click">New User 
                    Click Here!</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" colspan="2">
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:LinkButton ID="lnkforget" runat="server" Font-Underline="False" 
                                onclick="lnkforget_Click">Forget 
                    Password?</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </p>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>


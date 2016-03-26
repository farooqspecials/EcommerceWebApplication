<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="forget.aspx.cs" Inherits="forget" Title="Untitled Page" %>

<%@ Register src="UserControls/nav.ascx" tagname="nav" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
       
        .style3
        {
            width: 434px;
        }
       
        .style4
        {
            width: 128px;
        }
        .style5
        {
            width: 202px;
        }
        .style6
        {
            width: 434px;
            font-weight: bold;
        }
       
       
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <table width="100%" align="center">
        <tr >
            <td>
                <h2 align="center">Recover Your Password</h2></td>
                            </tr>
                        </table>
                        <br />
                        <br />
    <table align="center" class="page" style="width: 420px" >
        
        <tr>
            <td class="style6" >
                UserName:</td>
            <td class="style5">
                <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3" >
                <b>Send Password to Email:</b></td>
            <td align="left" class="style5">
                <asp:CheckBox ID="chkemail" runat="server" />
            </td>
        </tr>
        <tr>
            <td align="left" class="style3">
                <b>Send Password to Mobile:</b>
            </td>
            <td align="left" class="style5">
                <asp:CheckBox ID="chkmobile" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnEmail" runat="server" Text="Submit" 
                    onclick="btnEmail_Click" Height="26px" Width="61px" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                
                <asp:Label ID="lblemail" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
    <p>
                &nbsp;</p>
    <table class="style4" align="center">
        <tr>
            
        </tr>
    </table>
</asp:Content>


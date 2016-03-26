<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProductSearch.ascx.cs" Inherits="UserControls_ProductSearch" %>
<asp:Panel ID="panel1" runat="server">
    <table style="width: 100%">
        <tr>
            <td align="center">
                <asp:Label ID="Label1" runat="server" SkinID="FormLabel" 
                    Text="Search Products :"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Button ID="Button1" runat="server" Text="Go" onclick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Panel>

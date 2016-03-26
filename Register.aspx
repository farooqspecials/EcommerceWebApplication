<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" Title="Untitled Page" %>

<%@ Register src="UserControls/nav.ascx" tagname="nav" tagprefix="uc1" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
        {
            width: 45%;
        }
        .style6
        {
            width: 415px;
        }
        .style7
        {
            width: 587px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
                        <br />
            <h2 align="center">Please Register Here to Use Our Services</h2><br />
            <table class="style4" align="center">
                <tr>
                    <td class="style7">
                        UserName:</td>
                    <td align="left" class="style6">
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" 
            ErrorMessage="You must enter some UserName" Display="Dynamic">*</asp:RequiredFieldValidator>
            
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        Password:</td>
                    <td class="style6">
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        Confirm Password:</td>
                    <td class="style6">
                        <asp:TextBox ID="txtconfirmpass" runat="server" TextMode="Password"></asp:TextBox>
                         <asp:CompareValidator ID="CompareValidator1" runat="server"
                         ControlToValidate="txtPassword" ControlToCompare="txtconfirmpass"       
                            ErrorMessage="*password doesnot match" Display="Dynamic">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        First Name:</td>
                    <td class="style6">
                        <asp:TextBox ID="txtfirstname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtfirstname" 
            ErrorMessage="Please Enter First Name" Display="Dynamic">*</asp:RequiredFieldValidator>                        
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        Last Name:</td>
                    <td class="style6">
                        <asp:TextBox ID="txtlastname" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtlastname" 
            ErrorMessage="Please Enter Last Name" Display="Dynamic">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        Emil:</td>
                    <td class="style6">
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                        ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"
                        ControlToValidate="txtemail" ErrorMessage="Please Enter Valid Email">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style7">
                        Mobile No:</td>
                    <td class="style6">
                        <asp:TextBox ID="txtmobileno" runat="server"></asp:TextBox>
                        
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <br />
                        <asp:Button ID="btnreg" runat="server" Text="Register" onclick="btnreg_Click" />
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Label ID="lblreg" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
        <asp:CheckBox ID="CheckBox1" runat="server" />
    </p>
    <p>
    </p>
</asp:Content>


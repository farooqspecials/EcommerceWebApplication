<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CheckOut.aspx.cs" Inherits="CheckOut" Title="Untitled Page" %>

<%@ Register src="UserControls/nav.ascx" tagname="nav" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style4
    {
        width: 56%;
    }
    .style5
    {
        height: 26px;
            width: 267px;
        }
        .style6
        {
            width: 91px;
        }
        .style7
        {
            height: 26px;
            width: 91px;
        }
        .style8
        {
            width: 267px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
        
        <h2 align="center">
                Please Enter Your Shipping Information</h2>
<table class="style4" align="center">
    <tr>
        <td class="style6">
            First Name:&nbsp;</td>
        <td class="style8">
                    <asp:TextBox ID="firstnametxt" runat="server" Width="139px" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstnametxt" 
            ErrorMessage="Please Enter Your First Name" Display="Dynamic">*</asp:RequiredFieldValidator>
        
        </td>
    </tr>
    <tr>
        <td class="style6">
            Last Name:&nbsp;</td>
        <td class="style8">
            <asp:TextBox ID="lastnametxt" runat="server" Width="139px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lastnametxt" 
            ErrorMessage="Please Enter Your Last Name" Display="Dynamic">*</asp:RequiredFieldValidator>
            
        
    
        </td>
    </tr>
    <tr>
        <td class="style6">
            Company:</td>
        <td class="style8">
            <asp:TextBox ID="companytxt" runat="server" Width="244px" Height="22px" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="companytxt" 
            ErrorMessage="Please Enter Company Name" Display="Dynamic">*</asp:RequiredFieldValidator>
        
    
        </td>
    </tr>
    <tr>
        <td class="style6">
            Address:</td>
        <td class="style8">
            <asp:TextBox ID="addresstxt" runat="server" Width="256px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="addresstxt" 
            ErrorMessage="Please Enter Address" Display="Dynamic">*</asp:RequiredFieldValidator>
        
    
        </td>
    </tr>
    <tr>
        <td class="style6">
            Country:</td>
        <td class="style8">
            <asp:DropDownList ID="dpcountry" runat="server">
            <asp:ListItem>Pakistan</asp:ListItem>
            <asp:ListItem>India</asp:ListItem>
            <asp:ListItem>Sri Lanka</asp:ListItem>
            <asp:ListItem>Bangladesh</asp:ListItem>
        </asp:DropDownList>
    
        </td>
    </tr>
    <tr>
        <td class="style6">
            City:</td>
        <td class="style8">
            <asp:TextBox ID="citytxt" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="citytxt" 
            ErrorMessage="Please Enter City Name" Display="Dynamic">*</asp:RequiredFieldValidator>
        
    
        </td>
    </tr>
    <tr>
        <td class="style6">
            Province:&nbsp;</td>
        <td class="style8">
            <asp:TextBox ID="provincetxt" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="provincetxt" 
            ErrorMessage="Enter Province Name" Display="Dynamic">*</asp:RequiredFieldValidator>
        
    
        </td>
    </tr>
    <tr>
        <td class="style6">
            ZipCode:</td>
        <td class="style8">
            <asp:TextBox ID="zipcodetxt" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="zipcodetxt" 
            ErrorMessage="Enter zipcode" Display="Dynamic">*</asp:RequiredFieldValidator>
        
    
        </td>
    </tr>
    <tr>
        <td class="style7">
            Telephone:</td>
        <td class="style5">
            <asp:TextBox ID="telephonetxt" runat="server"></asp:TextBox>
        
    
        </td>
    </tr>
    <tr>
        <td class="style6">
            Fax:</td>
        <td class="style8">
            <asp:TextBox ID="faxtxt" runat="server"></asp:TextBox>
                
        
        </td>
    </tr>
    <tr>
        <td align="center" colspan="2">
        <asp:Button ID="Button1" runat="server" Text="Place Order" 
            Width="152px" onclick="Button1_Click" />
        </td>
    </tr>
    <tr>
        <td align="center" colspan="2">
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td align="center" colspan="2">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </td>
    </tr>
</table>
                
    <p style="margin-left: 80px" align="center">
        &nbsp;</p>
        <p style="margin-left: 80px" align="center">
            &nbsp;</p>
    
</asp:Content>


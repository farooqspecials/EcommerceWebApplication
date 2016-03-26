<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Admin_Products" Title="Untitled Page" %>

<%@ Register src="UserControls/nav.ascx" tagname="nav" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    .style4
    {
        width: 100%;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server" >
        </asp:ScriptManager>
        <br />
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
    <Triggers>
    <asp:PostBackTrigger ControlID="btnaddproduct" />
        </Triggers>
        <ContentTemplate>
            <p>
               <h2 align="center"> Add new Products:</h2>
                <p>
                </p>
                <p align="center">
                    <asp:Label ID="UploadStatusLabel" runat="server"></asp:Label>
                </p>
                <table class="style4">
                    <tr>
                        <td>
                            Category Name:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="170px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Product Name:</td>
                        <td>
                            <asp:TextBox ID="txtproname" runat="server" Width="174px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                ControlToValidate="txtproname" Display="Dynamic" 
                                ErrorMessage="Please Enter Product Name">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Product Image:</td>
                        <td>
                            <asp:FileUpload ID="FileUpload1" runat="server" Width="218px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Product Price:</td>
                        <td>
                            <asp:TextBox ID="txtproprice" runat="server" Width="138px"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtproprice"
                            ErrorMessage="Please Enter Valid Price" Display="Dynamic" ValidationExpression="^\d+$" >*</asp:RegularExpressionValidator>
                            
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Description :</td>
                        <td>
                            <asp:TextBox ID="txtprodesc" runat="server" Height="50px" TextMode="MultiLine" 
                                Width="267px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txtprodesc" Display="Dynamic" 
                                ErrorMessage="Enter Product Description">*</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Original Price</td>
                        <td>
                            <asp:TextBox ID="txtOrigional" runat="server" Width="136px"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtOrigional"
                            ErrorMessage="Please Enter Valid Price" Display="Dynamic" ValidationExpression="^\d+$" >*</asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Stock Quantity</td>
                        <td>
                            <asp:DropDownList ID="dpquantity" runat="server">
                                <asp:ListItem>0</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>20</asp:ListItem>
                                <asp:ListItem>50</asp:ListItem>
                                <asp:ListItem>100</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <p align="center">
                                &nbsp;<asp:Button ID="btnaddproduct" runat="server" CausesValidation="true" 
                                    onclick="btnaddproduct_Click" Text="Add Product" Width="115px" />
                                &nbsp;&nbsp;&nbsp;&nbsp;
                            </p>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                        </td>
                    </tr>
                </table>
                <p align="center">
                    <asp:Label ID="lblresult" runat="server"></asp:Label>
                </p>
                <p align="center">
                    To Order for Product Click Me:<asp:LinkButton ID="orderpro" runat="server" 
                        CausesValidation="false" onclick="orderpro_Click">ClickMe</asp:LinkButton>
                </p>
                <p align="center">
                    &nbsp;</p>
                <p align="center">
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" 
                        onpageindexchanging="_pagechange" onrowcancelingedit="_rowcancel" 
                        onrowdeleting="_rowdeleting" onrowediting="_rowediting" 
                        onrowupdating="_rowupdating" DataKeyNames="ProductID" 

                         
                        onrowdatabound="_row" HorizontalAlign="Center" Width="411px">
                        <Columns>
                            <asp:TemplateField HeaderText="ProductID">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtproid" runat="server" Text='<%# Eval("ProductID") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblproid" runat="server" Text='<%# Eval("ProductID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ProductName">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtproname" runat="server" Text='<%# Eval("ProductName") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblproname" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="UnitCost">
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtproprice" runat="server" Text='<%# Eval("UnitCost") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="lblproprice" runat="server" Text='<%# Eval("UnitCost") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:CommandField ShowEditButton="True" CausesValidation="false" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton8" CommandName="Delete" runat="server" 
                                        onclick="LinkButton8_Click" CausesValidation="false" ForeColor="Black" OnClientClick="javascript:return confirm('Do you really want to \ndelete the item?');" >Delete</asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </p>
                <p align="center">
                    &nbsp;</p>
                <p align="center">
                    &nbsp;</p>
                <p>
                    &nbsp;</p>
                <p>
                    &nbsp;</p>
                <p>
                    &nbsp;</p>
                <p>
                </p>
                <p>
                </p>
                <p>
                </p>
                <p>
                </p>
                <p>
                </p>
                <p>
                </p>
                <p>
                </p>
            </p>
            
            
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>


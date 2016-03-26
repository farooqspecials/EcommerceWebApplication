<%@ Page Language="C#" Theme="YellowShades" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="shoppingcart.aspx.cs" Inherits="shoppingcart" Title="Untitled Page" %>

<%@ Register src="UserControls/nav.ascx" tagname="nav" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

    </p>
    
    

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            
            <asp:Panel ID="Panel1" runat="server">
                <p>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                        DataKeyNames="ProductID" onrowdatabound="_rowdatabound" 
                        onrowdeleting="_rowDeleting" ShowFooter="True" Width="648px">
                        <Columns>
                            <asp:TemplateField HeaderText="ProductID">
                                <ItemTemplate>
                                    <asp:Label ID="lblproid" runat="server" Text='<%# Eval("ProductID") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ProductName">
                                <ItemTemplate>
                                    <asp:Label ID="lblproname" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="UnitPrice">
                                <ItemTemplate>
                                    <asp:Label ID="lblunitprice" runat="server" 
                                        Text='<%# "Rs "+Eval("UnitCost").ToString() %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtunitprice" runat="server" Text='<%# Bind("UnitCost") %>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Quantity" SortExpression="Quantity">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtmainqty" runat="server" Height="20px" 
                                        Text='<%# Bind("Quantity") %>' Width="39px"></asp:TextBox>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txteditqty" runat="server" Text='<%# Bind("Quantity") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <FooterTemplate>
                                    &nbsp;<asp:Label ID="lbltotal" runat="server"></asp:Label>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:CommandField ShowDeleteButton="True" />
                        </Columns>
                    </asp:GridView>
                    <asp:Button ID="btnupdatecart" runat="server" onclick="btnupdatecart_Click" 
                        Text="Update Cart" Width="101px" />
                    <asp:Button ID="btnplaceorder" runat="server" onclick="btnplaceorder_Click" 
                        Text="Place Order" Width="91px" />
                </p>
                <p align="left">
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </p>
            </asp:Panel>
            <p align="center">
                <asp:Label ID="Labelinfo" runat="server" 
            Text="Your Cart Does Not Contain Any Items" Font-Bold="True" ForeColor="#FF6666"></asp:Label>
            </p>
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
    </p>
    <p align="left">
        <br />
    </p>
</asp:Content>


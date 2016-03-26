<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Categories.ascx.cs" Inherits="UserControls_Categories" %>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    Height="74px" HorizontalAlign="Center" Width="246px">
    <Columns>
        <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText="Categories">
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="false" 
                    PostBackUrl='<%# "~/ProductCatalog.aspx?ID="+Eval("CategoryID") %>' 
                    Text='<%# Eval("CategoryName") %>' onclick="LinkButton1_Click" 
                    Font-Underline="False"></asp:LinkButton>
                <br />
            </ItemTemplate>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
        </asp:TemplateField>
    </Columns>
    <EmptyDataTemplate>
        <asp:HyperLink ID="HyperLink1" runat="server" 
            Text='<%# Eval("CatagoryName") %>'></asp:HyperLink>
    </EmptyDataTemplate>
</asp:GridView>

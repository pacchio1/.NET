<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="WebForm_Database.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Elenco Prodotti</h1>
    <asp:SqlDataSource ID="sdsProducts" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" 
        SelectCommand="SELECT [ProductID], [ProductName], [UnitPrice], [UnitsInStock], c.Categoryname FROM [Products]  p inner join categories c on c.CategoryID=p.CategoryID  ORDER BY [ProductName]"></asp:SqlDataSource>
    <asp:GridView ID="gvProducts" runat="server" Width="90%" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="sdsProducts" AllowPaging="True" HorizontalAlign="Center" PageSize="50" PagerStyle-HorizontalAlign="Center" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="CategoryName" HeaderText="Category Name" SortExpression="CategoryName"></asp:BoundField>
            <asp:BoundField DataField="ProductName" HeaderText="Product Name" SortExpression="ProductName"></asp:BoundField>
            <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" SortExpression="UnitPrice"></asp:BoundField>
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" InsertVisible="False" SortExpression="ProductID"></asp:BoundField>
            <asp:BoundField DataField="UnitsInStock" HeaderText="Units In Stock" SortExpression="UnitsInStock" Visible="False"></asp:BoundField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate><!--Bind("ProductID","~/DetailsProduct.aspx?id={0})-->
                    <asp:LinkButton ID="LBtDetaglio" runat="server" CausesValidation="false" PostBackUrl='<%# Bind("ProductID","~/DetailsProduct.aspx?id={0}") %>' CommandName="" Text="dettaglio"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>

        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />

<PagerStyle HorizontalAlign="Center" BackColor="#284775" ForeColor="White"></PagerStyle>
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
</asp:Content>

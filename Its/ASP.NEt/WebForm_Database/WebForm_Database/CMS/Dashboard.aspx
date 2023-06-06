<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebForm_Database.CMS.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Dashboard</h1>
    <asp:HyperLink ID="lnkclienti" NavigateUrl="~/CMS/ElencoClienti.aspx" runat="server">Gestione clienti</asp:HyperLink>
    <asp:HyperLink ID="lnkOrdini" runat="server">Gestione ordini</asp:HyperLink>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="WebForm_Database.CMS.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Dashboard</h1>
    <asp:HyperLink ID="lnkclienti" NavigateUrl="~/CMS/ElencoClienti.aspx" runat="server">Gestione clienti</asp:HyperLink>
    <br />
    <asp:HyperLink ID="lnkOrdini"  NavigateUrl="~/CMS/GestioneOrdini.aspx" runat="server">Gestione ordini</asp:HyperLink>
</asp:Content>

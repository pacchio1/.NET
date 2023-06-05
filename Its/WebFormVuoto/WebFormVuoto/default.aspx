<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebFormVuoto._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:Label ID="Lbl1" runat="server" Text="inseresci testo"></asp:Label>
                <asp:TextBox ID="Txt1" runat="server"></asp:TextBox>
                <asp:Button ID="Btn1" runat="server" Text="invia" OnClick="Btn1_Click" />
                <br />
                <asp:Label ID="LblOut" runat="server" Text=""></asp:Label>
                <br />
                <br />
                <br />
                <asp:HyperLink NavigateUrl="~/chisiamo.aspx" ID="Link1" runat="server">chi siamo</asp:HyperLink>
            </div>
        </form>
    </body>
</html>

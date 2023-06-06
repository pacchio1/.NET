<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contatti.aspx.cs" Inherits="WebFormVuoto.Contatti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Contatti</h1>
            <br />
            
            <asp:Label ID="email" runat="server" Text="email: a@a.a"></asp:Label>
            <asp:TextBox ID="messaggio" runat="server" Text="" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="btn_invia" />
        </div>
    </form>
</body>
</html>

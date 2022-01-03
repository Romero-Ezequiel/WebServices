<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ConsumirWSDemo.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Consumir Web Services desde ASP.NET</h1>
            <asp:Label ID="lblNumero1" Text="Numero 1:" runat="server"/>
            <asp:TextBox ID="txtNumero1" runat="server" />
            <hr />

            <asp:Label ID="lblNumero2" Text="Numero 2:" runat="server" />
            <asp:TextBox ID="txtNumero2" runat="server" />
            <hr />

            <asp:Button ID="btnSumar" Text="Sumar" runat="server" OnClick="btnSumar_Click" />
            <hr />
            <asp:Label ID="lblResultado" runat="server" />

           
        </div>
    </form>
</body>
</html>

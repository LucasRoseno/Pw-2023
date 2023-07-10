<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginDB.aspx.cs" Inherits="PrjLoginDB.LoginDB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>



            <asp:Label ID="Label1" runat="server" Text="Usuário"></asp:Label><br />
            <asp:TextBox ID="txtUsu" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label><br />
            <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btnEntrar" runat="server" Text="Entrar" Width="79px" OnClick="btnEntrar_Click" /> <br /><br />
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label><br />
        </div>
    </form>
</body>
</html>

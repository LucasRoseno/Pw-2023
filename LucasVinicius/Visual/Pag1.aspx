<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pag1.aspx.cs" Inherits="NovoProjUser.Pag1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml"  style="background-color:#5c5b5b">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body >
    <form id="form1" runat="server">
        <div style="text-align:center; height: 703px; width: 100%;"> <br /><br /><br />
            <asp:Label ID="Label1" runat="server" Font-Overline="False" Font-Size="30px" Height="36px" Text="Para Fazer Login Insira" Width="323px" BorderStyle="Double"></asp:Label>
            <br /> <br /><br /><br /><br />
                <asp:Label ID="lbl1" runat="server" Text="Código de Funcíonario"></asp:Label><br />
                <asp:TextBox ID="txtUser" runat="server" TabIndex="1"></asp:TextBox><br /><br /><br />
                <asp:Label ID="lbl2" runat="server" Text="Telefone" Width="142px"></asp:Label><br />
                <asp:TextBox ID="txtSenha" runat="server" TabIndex="2"></asp:TextBox><br /><br /><br />
                <asp:Label ID="lblAviso" runat="server" Font-Size="25px"></asp:Label><br /><br />
                <asp:Button ID="btnEntrar" runat="server" Text="Entrar" Height="43px" Width="87px" OnClick="btnEntrar_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCod" runat="server" Height="43px" Text="Código" Width="96px" OnClick="btnCod_Click" />
            <br /><br />
            <asp:Label ID="Label3" runat="server" BorderStyle="Double"></asp:Label>
            <br /><br />
            <asp:Label ID="Label2" runat="server" Font-Size="20px" Text="Lista de Login"></asp:Label><br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="172px" ImageUrl="~/imagens/loginlist.jpg" Width="903px" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

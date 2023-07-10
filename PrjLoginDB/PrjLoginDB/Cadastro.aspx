<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="PrjLoginDB.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Código"></asp:Label><br />
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label><br />
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label3" runat="server" Text="Fone"></asp:Label><br />
            <asp:TextBox ID="txtFone" runat="server"></asp:TextBox><br />

                <br /><br />

            <asp:Button ID="btnIncluir" runat="server" Text="Incluir" OnClick="btnIncluir_Click" />
            <asp:Button ID="btnAlterar" runat="server" Text="Alterar" OnClick="btnAlterar_Click" />
            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" OnClick="btnExcluir_Click" />
            <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click" />  <br /><br />
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

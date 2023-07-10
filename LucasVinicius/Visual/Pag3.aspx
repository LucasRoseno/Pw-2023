<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pag3.aspx.cs" Inherits="NovoProjUser.Pag3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml"style="background-color:#5c5b5b">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; height: 494px;""><br /><br />
            <br />
            <asp:Label ID="Label3" runat="server" BorderStyle="Double" Font-Size="35px" Text="Exclusão de Categoria"></asp:Label>
            <br />
            <br />
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Excluir Categoria"></asp:Label>
            <br />
            <asp:TextBox ID="txtExclusao" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btnVoltar" runat="server" Height="30px" OnClick="btnVoltar_Click" Text="Voltar" Width="61px" />&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDeletar" runat="server" OnClick="btnDeletar_Click" Text="Deletar" Height="31px" Width="74px" />&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnProx" runat="server" Height="31px" Text="Próximo" Width="66px" OnClick="btnProx_Click" />
            <br /><br />
            <asp:Label ID="Label1" runat="server" Text="Digite o nome da Categoria para exclui-la"></asp:Label><br />
            <br />
            <asp:GridView ID="grdDado" runat="server" HorizontalAlign="Center"></asp:GridView>
            <br />
        </div>
        
    </form>
</body>
</html>

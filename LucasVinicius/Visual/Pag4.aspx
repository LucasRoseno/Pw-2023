<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pag4.aspx.cs" Inherits="NovoProjUser.Pag4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color:#5c5b5b">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; height: 703px; width: 100%;">
            <p><br /><br /><br /><br /><br /><br />
            <asp:Label ID="Label1" runat="server" Text="Mostrar os pedidos que o cliente fez (utilize o codigo do cliente)"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tb1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Inserir" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Mostrar todos os clientes que fizeram pedidos nesta data (usar datas)"></asp:Label>
            <asp:TextBox ID="tb2" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Inserir" OnClick="Button2_Click" />
            <BR />
            <asp:Label ID="Label3" runat="server" Text="Quais pedidos o funcionario participou (usar codigo do Funcionario) "></asp:Label>
            <asp:TextBox ID="tb3" runat="server"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" Text="Inserir" OnClick="Button3_Click" />
                <br /> <br /><br /><br />
                <asp:Label ID="lblErro" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" Height="39px" Width="88px" />
            </p>
        <p>
            <asp:Label ID="lbl4" runat="server" Text="Label"></asp:Label>
            <asp:GridView ID="gv1" runat="server" Width="661px" HorizontalAlign="Center">
            </asp:GridView>
        </p>
        </div>
    </form>
</body>
</html>

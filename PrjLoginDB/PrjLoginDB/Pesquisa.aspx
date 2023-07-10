<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pesquisa.aspx.cs" Inherits="PrjLoginDB.Pesquisa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label>
            <asp:TextBox ID="txtTexto" runat="server"></asp:TextBox>
            <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click" />
                    <br /><br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                <br />
            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>

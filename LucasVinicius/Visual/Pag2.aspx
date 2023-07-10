<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pag2.aspx.cs" Inherits="NovoProjUser.Pag2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-color:#5c5b5b">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; height: 648px;"> <br /><br /><br /> 
            <asp:Label ID="Label1" runat="server" BorderStyle="Double" Font-Size="35px" Text="Inserir Categoria" Width="297px"></asp:Label>
            <br /><br /><br />
            <br />
            <br />
            <asp:Label ID="lbl4" runat="server" Text="Categoria"></asp:Label><br />
            <br />
            <asp:TextBox ID="txtCat" runat="server"></asp:TextBox><br /><br />
            <br />
            <br /><br />
            <asp:Button ID="btnVoltar1" runat="server" Text="Voltar" Height="32px" Width="68px" OnClick="btnVoltar1_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Button ID="btnInserir" runat="server" Text="Inserir" Height="32px" Width="68px" OnClick="btnInserir_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnProx" runat="server" Text="Proxímo" Height="32px" OnClick="btnProx_Click" Width="60px" />
            <br />

            <asp:GridView ID="GridInsert" runat="server" HorizontalAlign="Center">
            </asp:GridView>

        </div>
    </form>
</body>
</html>

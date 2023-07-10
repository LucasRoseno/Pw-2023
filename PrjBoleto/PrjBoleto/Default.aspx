<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PrjBoleto.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="pnl_dados" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Sacado"></asp:Label><br />
            <asp:TextBox ID="txtSacado" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Vencimento"></asp:Label><br />
            <asp:TextBox ID="txtVencimento" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Endereço"></asp:Label><br />
            <asp:TextBox ID="txtEndereco" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Bairro"></asp:Label><br />
            <asp:TextBox ID="txtBairro" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label5" runat="server" Text="Cidade"></asp:Label><br />
            <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label6" runat="server" Text="CEP"></asp:Label><br />
            <asp:TextBox ID="txtCEP" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label7" runat="server" Text="UF"></asp:Label><br />
            <asp:TextBox ID="txtUF" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label8" runat="server" Text="Valor"></asp:Label><br />
            <asp:TextBox ID="txtValor" runat="server"></asp:TextBox><br /><br /><br />
            <asp:Button ID="btnGerar" runat="server" Text="Gerar" OnClick="btnGerar_Click" />
            </asp:Panel>
            <asp:Panel ID="pnl_boleto" runat="server"></asp:Panel>
        </div>
    </form>
</body>
</html>

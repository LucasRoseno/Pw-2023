<%@ Page Language="C#" MasterPageFile="~/Layout1.Master" AutoEventWireup="true" CodeBehind="JavaScript1.aspx.cs" Inherits="ASPXMasterPageDB1.JavaScript1" %>

<asp:Content id="Content1" ContentPlaceholderID="cabecalho" runat="server">
    JavaScript
</asp:Content>

<asp:Content id="Content2" ContentPlaceholderID="corpo_principal" runat="server">

    <script type="text/javascript" src="js/contato.js"></script>

    Digite o Email:<asp:TextBox ID="TextBox1" runat="server" /><br />
    Somente Números:<asp:TextBox ID="TextBox2" runat="server" onkeypress="return somente_numeros(event);" /><br />
    <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click" OnClientClick="enviar_dados();" /><br />
    <input type="button" value="Pega Valor TextBox2" onclick="pegar_valor()" />

</asp:Content>
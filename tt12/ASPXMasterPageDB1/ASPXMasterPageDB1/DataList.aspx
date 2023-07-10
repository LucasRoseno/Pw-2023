<%@ Page Language="C#" MasterPageFile="~/Layout1.Master" AutoEventWireup="true" CodeBehind="DataList.aspx.cs" Inherits="ASPXMasterPageDB1.Pagina1" %>

<asp:Content id="Content1" ContentPlaceholderID="cabecalho" runat="server">
    página 1
</asp:Content>

<asp:Content id="Content2" ContentPlaceholderID="corpo_principal" runat="server">
    <asp:DataList ID="DataList1" runat="server">
	    <ItemTemplate>
		    Produto: <asp:Label ID="lblProduto"	Runat="server"	Text='<%# Eval("ID") %>'/>
		    <br/>
		    Unidades no estoque: <asp:Label ID="lblQuantidade" Runat="server" Text='<%# Eval("NOME") %>'/>
		    <br/>
		    Preço unitário: <asp:Label ID="lblValor" Runat="server"	Text='<%# Eval("FONE") %>'/>
		    <br /><br /><br />
	    </ItemTemplate>
    </asp:DataList>
</asp:Content>

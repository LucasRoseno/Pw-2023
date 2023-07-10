<%@ Page Language="C#" MasterPageFile="~/Layout1.Master" AutoEventWireup="true" CodeBehind="Manifesto.aspx.cs" Inherits="ASPXMasterPageDB1.Inicio" %>

<asp:Content id="Content1" ContentPlaceholderID="cabecalho" runat="server">
    Inicio
</asp:Content>

<asp:Content id="Content2" ContentPlaceholderID="corpo_principal" runat="server">
    <font face="arial" size="6.5">
        O Manifesto do Partido Comunista<br>
        </font>
        <label style="font-size:20px">
            O Manifesto comunista (Das Kommunistische Manifest), originalmente denominado Manifesto do Partido comunista (em alemão: Manifest der Kommunistischen Partei), publicado pela primeira vez em 21 de fevereiro de 1848, é historicamente um dos tratados políticos de maior influência mundial. Comissionado pela Liga dos Comunistas e escrito pelos teóricos fundadores do socialismo científico Karl Marx e Friedrich Engels, expressa o programa e propósitos da Liga.
        </label><br />
    <asp:Image ID="Image1" runat="server" ImageUrl="~/imagens/manifesto.jpg" Height="152px" Width="177px" />
    <label style="font-size:20px">O Manifesto comunista foi escrito no meio do grande processo de lutas urbanas das Revoluções de 1848, chamadas também de Primavera dos Povos, um processo revolucionário de quase um ano que atingiu os principais países Europeus e é uma análise da Revolução Industrial contemporânea a ela. Duas de suas maiores reivindicações foram reformas sociais: a conquista da diminuição da jornada diária de trabalho de doze para dez horas e o voto universal, embora apenas para os homens.</label>
   
</asp:Content>


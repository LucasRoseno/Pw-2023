<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="PrjMasterPage_Italo.Pagina1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cabecalho" runat="server">
    Página Teste
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="corpo_principal" runat="server">
    <div class="mainPAGE">
        <div class="blockPAGE">
            <div class="imgdivPAGE">
                <asp:Image ID="Image1" class="imgPAGE" runat="server" ImageUrl="~/imagens/manifesto.jpg" />
            </div>
            <div class="textPAGE">
                <h1 class="tituloPAGE">
                     O Manifesto do Partido Comunista
                </h1>
                <p class="textoPAGE">
                    O Manifesto comunista (Das Kommunistische Manifest),
                    originalmente denominado Manifesto do Partido comunista (em alemão: Manifest der Kommunistischen Partei),
                    publicado pela primeira vez em 21 de fevereiro de 1848, é historicamente um dos tratados políticos de maior influência mundial.
                    Comissionado pela Liga dos Comunistas e escrito pelos teóricos fundadores do socialismo científico Karl Marx e Friedrich Engels,
                    expressa o programa e propósitos da Liga.
                </p>
                <br />
                <p class="textoPAGE">
                    O Manifesto comunista foi escrito no meio do grande processo de lutas urbanas das Revoluções de 1848,
                    chamadas também de Primavera dos Povos,
                    um processo revolucionário de quase um ano que atingiu os principais países Europeus e é uma análise da Revolução Industrial contemporânea a ela.
                    Duas de suas maiores reivindicações foram reformas sociais:
                    a conquista da diminuição da jornada diária de trabalho de doze para dez horas e o voto universal, embora apenas para os homens.
                </p>
                <br />
                    
            </div>
         </div>
    </div>
</asp:Content>


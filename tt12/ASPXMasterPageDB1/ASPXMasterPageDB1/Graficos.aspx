<%@ Page Language="C#" MasterPageFile="~/Layout1.Master" AutoEventWireup="true" CodeBehind="Graficos.aspx.cs" Inherits="ASPXMasterPageDB1.Pagina2" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content id="Content1" ContentPlaceholderID="cabecalho" runat="server">
    página 2
</asp:Content>

<asp:Content id="Content2" ContentPlaceholderID="corpo_principal" runat="server">

    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Março</asp:ListItem>
        <asp:ListItem>Abril</asp:ListItem>
        <asp:ListItem>Maio</asp:ListItem>
    </asp:DropDownList><asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />   <br /><br />



    <asp:Chart ID="chart1" runat="server" Width="500px">
        <Series>
            <asp:Series Name="Series1"></asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
        </ChartAreas>
    </asp:Chart>

</asp:Content>

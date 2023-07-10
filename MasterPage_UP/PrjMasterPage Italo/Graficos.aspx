<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Graficos.aspx.cs" Inherits="PrjMasterPage_Italo.Graficos" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cabecalho" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="corpo_principal" runat="server">
    <asp:Chart ID="chart1" runat="server" Width="500px">
        <Series>
            <asp:Series Name="Series1"></asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    
    <br />
    <asp:DropDownList ID="DropDownList2" runat="server">
        <asp:ListItem>Março</asp:ListItem>
        <asp:ListItem>Abril</asp:ListItem>
        <asp:ListItem>Maio</asp:ListItem>
    </asp:DropDownList>
     
    <asp:Button ID="btnConsuGraf" runat="server" Text="consultar grafico" OnClick="btnConsuGraf_Click" />

</asp:Content>
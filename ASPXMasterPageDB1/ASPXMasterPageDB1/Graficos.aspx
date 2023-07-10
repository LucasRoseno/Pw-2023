<%@ Page Language="C#" MasterPageFile="~/Layout1.Master" AutoEventWireup="true" CodeBehind="Graficos.aspx.cs" Inherits="ASPXMasterPageDB1.Pagina2" %>


<asp:Content id="Content1" ContentPlaceholderID="cabecalho" runat="server">
    página 2
</asp:Content>

<asp:Content id="Content2" ContentPlaceholderID="corpo_principal" runat="server">
    <br /><br />
        <br /><br />

      <br /><br />
    
    <br />

    <asp:Chart ID="chart1" runat="server" Width="500px">
        <Series>
            <asp:Series Name="Series1"></asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
    
    <br />
     <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>Março</asp:ListItem>
        <asp:ListItem>Abril</asp:ListItem>
        <asp:ListItem>Maio</asp:ListItem>
    </asp:DropDownList> <br />

</asp:Content>

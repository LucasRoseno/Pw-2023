<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="ASPXGoogleMaps.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       cidade: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
      estado:  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
      Rua: <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
      Cep:  <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </div>
    </form>
</body>
</html>

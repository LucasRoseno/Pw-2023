<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPXMasterPageDB1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Login ID="Login1" runat="server" BackColor="#E3EAEB" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" DisplayRememberMe="False" FailureText="Usuário ou Senha Inválido" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" Height="159px" LoginButtonText="Entrar" OnAuthenticate="Login1_Authenticate" PasswordLabelText="Senha:" PasswordRequiredErrorMessage="Digite a senha." TextLayout="TextOnTop" TitleText="Digite: Usuário e Senha" UserNameLabelText="Usuário:" UserNameRequiredErrorMessage="Digite o Usuário." Width="333px">
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <LoginButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
            <TextBoxStyle Font-Size="0.8em" />
            <TitleTextStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
        </asp:Login>
    </div>
    </form>
</body>
</html>

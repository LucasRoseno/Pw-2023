<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Produtos.aspx.cs" Inherits="ASPXDataListImagens2.Produtos" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="css/estilo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="dlProdutos" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" Width="600px">
            <ItemTemplate>
            <div>
                <ul id="plans">
                  <li>
                      <ul>
                          <li>
                             <h4>
                                  <asp:Label ID="Label2" runat="server" Text='<%# Bind("nome") %>'></asp:Label>
                              </h4>
                          </li>
                          <li>
                                <asp:Image ID="imgFoto" runat="server" Width="80px" Height="80px" ImageUrl='<%# Bind("id","~/Imagens/Img({0}).png") %>' />
                          </li>
                          <li>
                              <ul>
                                  <li>
                                      <span>
                                      <asp:Label ID="lblNome" runat="server" Text='<%# Bind("nome") %>'></asp:Label>
                                      </span>
                                  </li>
                                  <li>
                                      <span>
                                      <asp:Label ID="lblCidade" runat="server" Text=' <%# Bind("fone") %>'></asp:Label>
                                      </span>
                                  </li>
                              </ul>
                          </li>
                          <li>
                              <a href="Produto<%# Eval("id") %>.aspx">Produto <%# Eval("id") %></a>
                          </li>
                      </ul>
                  </li>
              </ul>
            </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>

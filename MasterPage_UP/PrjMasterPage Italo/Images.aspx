<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaster.Master"  CodeBehind="Images.aspx.cs" Inherits="PrjMasterPage_Italo.Images" %>
<asp:Content ID="Content2" ContentPlaceHolderID="cabecalho" runat="server">
    Página Teste
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="corpo_principal" runat="server">
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
                                <asp:Image ID="imgFoto" runat="server" Width="80px" ImageUrl='<%# Bind("img") %>' Height="80px"  />
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
    <asp:TextBox ID="TextBox1" runat="server">Nome...</asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server">Fone...</asp:TextBox>
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="btnUpload" runat="server" OnClick="btnImg_OnClick" Text="Upload File"/>
</asp:Content>



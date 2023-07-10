using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPXMasterPageDB1
{
    public partial class Carrinho_Produtos : System.Web.UI.Page
    {
        ClasseConexao xx = new ClasseConexao();
        Classe_Alerta yy = new Classe_Alerta();
        DataSet ds;
        
        private void atualizar_grid()
        {
            ds = xx.executa_sql("select * from contatos");
            GridView1.DataSource = ds.Tables[0].DefaultView;
            GridView1.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.AutoGenerateColumns = false; //false Os campos serão adicionados manualmente
                GridView1.PagerSettings.Mode = PagerButtons.Numeric; //default
                GridView1.PagerSettings.FirstPageText = "Primeira Página";
                GridView1.PagerSettings.NextPageText = "Próxima Página";
                GridView1.PagerSettings.PreviousPageText = "Página Anterior";
                GridView1.PagerSettings.LastPageText = "Última Página";
                GridView1.AllowPaging = true; //permite a paginação
                GridView1.PageSize = 2; //quantidade de registros por página

	            BoundField campo1 = new BoundField();
                campo1.DataField = "id";
                campo1.HeaderText = "Identificação";

                BoundField campo2 = new BoundField();
                campo2.DataField = "nome";
                campo2.HeaderText = "Nome cli";

                BoundField campo3 = new BoundField();
                campo3.DataField = "tel1";
                campo3.HeaderText = "Telefone 11";

                ButtonField campo4 = new ButtonField();
                campo4.HeaderText = "Adicionar";
                campo4.DataTextField = "";
                campo4.Text = "Adicionar";
                campo4.CommandName = "Adicionar";

                ButtonField campo5 = new ButtonField();
                campo5.HeaderText = "Excluir";
                campo5.DataTextField = "";
                campo5.Text = "Excluir";
                campo5.CommandName = "Excluir";

                GridView1.Columns.Add(campo1);
                GridView1.Columns.Add(campo2);
                GridView1.Columns.Add(campo3);
                GridView1.Columns.Add(campo4);
                GridView1.Columns.Add(campo5);

                atualizar_grid();

                /*
                BoundField campo4 = new BoundField();
                campo4.DataField = "";
                campo4.HeaderText = "Telefone 11";
                //campo4.ItemStyle = new CheckBoxField(0);
                */

                /*
                ButtonField campo4 = new ButtonField();
                campo4.DataTextField="";
                campo4.Text="Adicionar";
                campo4.CommandName = "Adicionar";
                */

                /*
                ImageField campo4 = new ImageField();
                campo4.DataImageUrlField="";
                campo4.DataImageUrlFormatString="~/imagens/banner.jpg";
                */

                /*
                CheckBoxField campo4 = new CheckBoxField();
                campo4.DataField = ""; 
                campo4.HeaderText="Ativo";
                campo4.Text = "x";
                */

                //CommandField campo4 = new CommandField();
                //campo4.ShowEditButton=true;
                //campo4.ShowSelectButton=true;

                /*
                TemplateColumn colSelecionar = new TemplateColumn();
                colSelecionar.HeaderText = "Selecionar";
                //informa o que o ItemTemplate é do tipo TemplateColumnCheckBox
                */

                /*
                // Deixando o linkbutton centralizado
                e.Row.Cells[0].Style.Add("text-align", "center");
                // Instanciando o linkbutton
                LinkButton lb = new LinkButton();
                lb.Text = "Inserir";
                // Registrando o evento
                lb.Click += new EventHandler(meu_metodo);
                // Adicionando a celula
                e.Row.Cells[0].Controls.Add(lb);
                 * /
                * 
                private void meu_metodo(object sender, EventArgs e)
                {
                    //throw new NotImplementedException();
                }
                */

                //GridView1.Columns["CustomerID"].Visible = false;

                /*
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    //valor = DataBinder.Eval(e.Row.DataItem, "nome").ToString();
                }
                */
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            atualizar_grid();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                /*
                //nomes das colunas atribuidas no load da página
                e.Row.Cells[0].Text = "Código";
                e.Row.Cells[1].Text = "Nome do Cliente";
                e.Row.Cells[2].Text = "Fone";
                */
                e.Row.Cells[0].Width = 100;
                e.Row.Cells[1].Width = 100;
                e.Row.Cells[2].Width = 100;
            }
            else
            {
                e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='Silver'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#FFFBD6'");
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Adicionar")
            {
                Response.Redirect("Teste.aspx", false);
            }
            if (e.CommandName == "Excluir")
            {
                GridViewRow row = GridView1.Rows[Convert.ToInt32(e.CommandArgument)];
                string codigo = row.Cells[0].Text;
                string x = "delete from Contatos where ID=" + codigo;
                if(xx.executa_sql(x)!=null)
                    yy.chama_alerta("Excluido com Sucesso");
                else
                    yy.chama_alerta("Falhou !!!");
                atualizar_grid();
            }
        }
    }
}
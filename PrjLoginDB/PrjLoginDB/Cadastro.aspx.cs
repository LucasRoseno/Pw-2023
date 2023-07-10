using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjLoginDB
{
    public partial class Cadastro : System.Web.UI.Page
    {
        ClasseConexao con;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con = new ClasseConexao();
                dt = new DataTable();
                dt = con.executarSQL("select * from contatos");
                if(dt.Rows.Count > 0)
                {
                    txtId.Text = dt.Rows[0]["id"].ToString();
                    txtNome.Text = dt.Rows[0]["nome"].ToString();
                    txtFone.Text = dt.Rows[0]["fone"].ToString();
                }
                else { lblMsg.Text = "Nenhum registro encontrado"; }
            }
        }

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            //dt = new DataTable();
            SqlCommand cmd = new SqlCommand("INSERT INTO contatos(nome,fone) VALUES(@nome,@fone)");
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("fone", txtFone.Text);
            

            int x = con.manutencaoDB_Parametros(cmd);
            if (x > 0)
            {
                lblMsg.Text = "Registro cadastrado com sucesso";
            }
            else { lblMsg.Text = "Falha ao cadastrar"; }

        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
           
            SqlCommand cmd = new SqlCommand
                ("UPDATE contatos set nome = @nome, fone = @fone WHERE id= @id");
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("fone", txtFone.Text);
            

            int x = con.manutencaoDB_Parametros(cmd);
            if(x > 0)
            { lblMsg.Text = "Registro alterado com sucesso"; }
            else { lblMsg.Text = "Falha ao alterar"; }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            
            String id = txtId.Text;
            SqlCommand cmd = new SqlCommand
            ("DELETE FROM contatos where id = @id");
            cmd.Parameters.AddWithValue("id", txtId.Text);
            

            int x = con.manutencaoDB_Parametros(cmd);
            if (x > 0)
            { lblMsg.Text = "Exclusão feita com sucesso"; }
            else { lblMsg.Text = "Falha ao excluir"; }
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cadastro.aspx");
        }
    }
}
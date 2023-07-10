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
    public partial class LoginDB : System.Web.UI.Page
    {
        ClasseConexao con;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            dt = new DataTable();

            SqlCommand cmd = new SqlCommand("select * from contatos where nome=@usu and fone=@sen");
            cmd.Parameters.AddWithValue("@usu", txtUsu.Text);
            cmd.Parameters.AddWithValue("@sen", txtSenha.Text);
            dt = con.exSQLParametros(cmd);

            if(dt.Rows.Count > 0) { Response.Redirect("Cadastro.aspx"); }
            else { lblMsg.Text = "Falha ao efetuar o login"; }


            /*con = new ClasseConexao();
            dt = new DataTable();
            String usu = txtUsu.Text;
            String sen = txtSenha.Text;
            String sql = "select * from contatos where nome = '" +usu+"'"+ "and fone = '"+sen+"'";

            dt = con.executarSQL(sql);
            if(dt.Rows.Count > 0)
            {
                Response.Redirect("Cadastro.aspx");
            }
            else
            {
                lblMsg.Text = "Falha ao efetuar o login";
            }*/
        }
    }
}
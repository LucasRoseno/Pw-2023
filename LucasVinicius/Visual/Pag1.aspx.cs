using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace NovoProjUser
{
    public partial class Pag1 : System.Web.UI.Page
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

            SqlCommand cmd = new SqlCommand("select * from funcionarios where CodFun=@CodFun and Fone=@fone");
            cmd.Parameters.AddWithValue("@CodFun", txtUser.Text);
            cmd.Parameters.AddWithValue("@fone", txtSenha.Text);
            dt = con.exSQLParametros(cmd);

            if(dt.Rows.Count > 0) { Response.Redirect("Pag2.aspx"); }
            else { lblAviso.Text = "Falha ao Logar"; }



            
            
        }



        protected void btnCod_Click(object sender, EventArgs e)
        {
            Label3.Text = "create PROCEDURE usp_loginFunZ @codFun int, @telefone varchar(24) AS If(SELECT count(*) from Funcionarios where @codFun = CodFun AND @telefone = Fone) > 0 begin Select 1 end  Else begin Select 0 end";
        }


    }

       
 }
    

    
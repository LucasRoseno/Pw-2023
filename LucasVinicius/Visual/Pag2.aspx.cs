using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace NovoProjUser
{
    public partial class Pag2 : System.Web.UI.Page
    {
        ClasseConexao con;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void btnVoltar1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pag1.aspx");
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {

            con = new ClasseConexao();
            dt = new DataTable();

            SqlCommand cmd = new SqlCommand("insert into Categorias(Descr) VALUES (@Ndescr)");
            cmd.Parameters.AddWithValue("@Ndescr", txtCat.Text);


            dt = con.exSQLParametros(cmd);
            GridInsert.DataSource = dt.DefaultView;
            GridInsert.DataBind();

        }

        protected void btnProx_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pag3.aspx");
        }
    }
}
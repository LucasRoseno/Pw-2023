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
    public partial class Pag3 : System.Web.UI.Page
    {
        ClasseConexao con;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            dt = new DataTable();

            SqlCommand cmd = new SqlCommand("DELETE FROM Categorias WHERE @Ndescr = Descr");
            cmd.Parameters.AddWithValue("@Ndescr", txtExclusao.Text);

            dt = con.exSQLParametros(cmd);
            grdDado.DataSource = dt.DefaultView;
            grdDado.DataBind();
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pag2.aspx");
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            
            
        }

        protected void btnProx_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pag4.aspx");
        }
    }
}
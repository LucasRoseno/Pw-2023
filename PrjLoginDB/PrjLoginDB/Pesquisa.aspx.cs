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
    public partial class Pesquisa : System.Web.UI.Page
    {
        ClasseConexao con;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            dt = new DataTable();

            SqlCommand cmd = new SqlCommand("select * from contatos where nome like '%@val%'");
            cmd.Parameters.AddWithValue("@val", txtTexto.Text);
            dt = con.exSQLParametros(cmd);
            if (dt.Rows.Count > 0)
            {
                 
            }
            GridView1.DataSource = dt.DefaultView;
            GridView1.DataBind();
        }
    }
}
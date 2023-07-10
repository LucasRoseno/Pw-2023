using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPXDataListImagens2
{
    public partial class Produtos : System.Web.UI.Page
    {

        ClasseConexao xx;
        DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    xx = new ClasseConexao();
                    ds = new DataSet();
                    ds = xx.executa_sql("select * from contatos");
                    dlProdutos.DataSource = ds.Tables[0];
                    dlProdutos.DataBind();
                }
                catch (Exception) { }
            }
        }
    }
}
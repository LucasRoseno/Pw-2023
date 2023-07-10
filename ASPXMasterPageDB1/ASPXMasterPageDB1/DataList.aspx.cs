using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPXMasterPageDB1
{
    public partial class Pagina1 : System.Web.UI.Page
    {
        ClasseConexao xx = new ClasseConexao();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ds = xx.executa_sql("select * from contatos");
                DataList1.DataSource = ds.Tables[0].DefaultView;
                DataList1.DataBind();
            }
        }
    }
}
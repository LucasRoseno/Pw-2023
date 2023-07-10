using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjMasterPage_Italo
{
    public partial class Images : System.Web.UI.Page
    {
        ClasseConexao xx;
        DataSet ds;
        private string caminhoImagem = null;

        public object Cursor { get; private set; }
        public object Cursors { get; private set; }

        int pos = 0; // para navegar entre os registros
        int posMAX = 0; //a
       


        void Page_Load(Object sender, EventArgs e)
        {

            // Load sample data only once, when the page is first loaded.
          

        }
   
       
        protected void btnImg_OnClick(object sender, EventArgs e)
        {
             ICollection CreateDataSource()
        {

            // Create sample data for the DataList control.
            DataTable dt = new DataTable();
            DataRow dr;

            // Define the columns of the table.
            dt.Columns.Add(new DataColumn("StringValue", typeof(String)));
            dt.Columns.Add(new DataColumn("CurrencyValue", typeof(String)));
            dt.Columns.Add(new DataColumn("img", typeof(Byte)));
                if (FileUpload1.HasFile)
                {
                    byte[] imageBytes = FileUpload1.FileBytes;

                    if (!IsPostBack)
                    {
                        dlProdutos.DataSource = CreateDataSource();
                        dlProdutos.DataBind();
                    }

                    // Populate the table with sample values.
                    
                        dr = dt.NewRow();

                    dr[0] = TextBox1.Text;
                    dr[1] = TextBox2.Text;
                    dr[2] = imageBytes;

                    dt.Rows.Add(dr);
                }

            DataView dv = new DataView(dt);
            return dv;
        }
            dlProdutos.DataSource = CreateDataSource();
            dlProdutos.DataBind();
        }

  
        }
    }

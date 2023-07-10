using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace ASPXMasterPageDB1
{
    public partial class Pagina2 : System.Web.UI.Page
    {
        ClasseConexao xx = new ClasseConexao();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ds = xx.executa_sql("select * from relatorio");
                chart1.Series["Series1"].ChartType = SeriesChartType.Column;
                chart1.Palette = ChartColorPalette.Excel; //chart1.Palette = ChartColorPalette.None;
                chart1.Titles.Add("VENDAS DO ANO");
                chart1.DataSource = ds.Tables[0].DefaultView;
                chart1.Series[0].XValueMember = "MES"; // EIXO X SEMPRE STRING
                chart1.Series[0].YValueMembers = "VALOR"; //EIXO Y SEMPRE VALORES (INT OU FLOAT).

                /*
                string[] meses = new string[5];
                float[] valores = new float[5];

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    meses[i] = ds.Tables[0].Rows[i]["MES"].ToString();
                    valores[i] = float.Parse(ds.Tables[0].Rows[i]["VALOR"].ToString());
                }

                for (int i = 0; i < meses.Length; i++)
                {
                    //Series series = this.chart1.Series.Add(meses[i]); // X
                    //series.Points.Add(valores[i]); // Y

                    //Series series = this.chart1.Series.Add(meses[i]); // X somente string
                    //series.Points.Add(valores[i]); // Y somente valores int ou float
                }
                 */
            }
        }

        protected void btnGrafm_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex > 0)
            {
                string x = DropDownList1.SelectedValue;
                if (x.Equals("Março"))
                {
                    ds = xx.executa_sql("select * from relatorio WHERE MES like 'Março'");
                    chart1.Series["Series1"].ChartType = SeriesChartType.Column;
                    chart1.Palette = ChartColorPalette.Excel;
                    chart1.Titles.Add("VENDAS DO ANO");
                    chart1.DataSource = ds.Tables[0].DefaultView;
                    chart1.Series[0].XValueMember = "MES";
                    chart1.Series[0].YValueMembers = "VALOR";
                }
                if (x.Equals("Abril"))
                {
                    ds = xx.executa_sql("select * from relatorio WHERE MES like 'Abril'");
                    chart1.Series["Series1"].ChartType = SeriesChartType.Column;
                    chart1.Palette = ChartColorPalette.Excel;
                    chart1.Titles.Add("VENDAS DO ANO");
                    chart1.DataSource = ds.Tables[0].DefaultView;
                    chart1.Series[0].XValueMember = "MES";
                    chart1.Series[0].YValueMembers = "VALOR";
                }
                if (x.Equals("Maio"))
                {
                    ds = xx.executa_sql("select * from relatorio WHERE MES like 'Maio'");
                    chart1.Series["Series1"].ChartType = SeriesChartType.Column;
                    chart1.Palette = ChartColorPalette.Excel;
                    chart1.Titles.Add("VENDAS DO ANO");
                    chart1.DataSource = ds.Tables[0].DefaultView;
                    chart1.Series[0].XValueMember = "MES";
                    chart1.Series[0].YValueMembers = "VALOR";
                }

            }

        }


    }
}

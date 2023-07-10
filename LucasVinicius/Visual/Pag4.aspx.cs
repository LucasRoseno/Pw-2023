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
    public partial class Pag4 : System.Web.UI.Page
    {
        ClasseConexao con;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            con = new ClasseConexao();
            dt = new DataTable();

            SqlCommand cmd = new SqlCommand("Select prd.Descr, Cli.Nome, Cli.Endereco from Produtos as prd" +
                " Inner Join DetalhesPed as dPed On dPed.CodProd = prd.CodProd" +
                " INNER Join Pedidos as Ped On Ped.NumPed = dPed.NumPed " +
                "INNER JOIN Clientes as Cli on Cli.CodCli = Ped.CodCli and Cli.CodCli = @CodCli");
            cmd.Parameters.AddWithValue("@CodCli", tb1.Text);

            dt = con.exSQLParametros(cmd);

            if (dt.Rows.Count > 0)
            {
                gv1.DataSource = dt.DefaultView;
                gv1.DataBind();
            }
            else { lblErro.Text = "ERROOOOOO"; }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            dt = new DataTable();

            SqlCommand cmd = new SqlCommand("Select cl.Nome,p.DataPed,p.DataEntrega from Pedidos as p" +
                " INNER JOIN Clientes AS cl On cl.CodCli = p.CodCli where P.DataPed = @dtPed");

            cmd.Parameters.AddWithValue("@dtPed", tb2.Text);

            string duo = tb2.Text;


            DateTime assa;
            if(DateTime.TryParse(duo,out assa))
            {
                
                dt = con.exSQLParametros(cmd);

                if (dt.Rows.Count > 0)
                {
                    gv1.DataSource = dt.DefaultView;
                    gv1.DataBind();
                }
            }
            else
            {
                lblErro.Text = "ERROOOO2";
                return;
            }

           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            dt = new DataTable();

            SqlCommand cmd = new SqlCommand("Select fun.Nome, Fun.Sobrenome, Fun.Cargo, count(*) as 'Qtde de pedidos feitos ' from Produtos as prd" +
                " Inner Join DetalhesPed as dPed On dPed.CodProd = prd.CodProd" +
                " INNER Join Pedidos as Ped On Ped.NumPed = dPed.NumPed " +
                "INNER JOIN Funcionarios as Fun on Fun.CodFun = Ped.CodFun  " +
                "where Fun.CodFun = @CodFun Group by Fun.Nome, Fun.sobrenome, Fun.Cargo");

            cmd.Parameters.AddWithValue("@CodFun", tb3.Text);


           

         
            dt = con.exSQLParametros(cmd);
                    if (dt.Rows.Count > 0)
                    {
                        gv1.DataSource = dt.DefaultView;
                        gv1.DataBind();
                    }
            else
            {
                lblErro.Text = "ERROOOOO3";
                return;
            }
                      
             

              
            




          
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pag3.aspx");
        }
    }
}
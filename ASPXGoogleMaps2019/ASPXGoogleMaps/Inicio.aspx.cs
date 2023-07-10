using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPXGoogleMaps
{
    public partial class Inicio : System.Web.UI.Page
    {
        StringBuilder sbLogradouro;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String cidade = "";
            String estado = "";
            String rua = "";
            String cep = "";

			sbLogradouro = new StringBuilder();
            sbLogradouro.Append("http://maps.google.com/maps?q=");
            try
            {
                if (TextBox1.Text != "")
                {
                    cidade = TextBox1.Text.Replace(" ", "+");
                    sbLogradouro.Append(cidade + "," + "+");
                }
                if (TextBox2.Text != "")
                {
                    estado = TextBox2.Text.Replace(" ", "+");
                    sbLogradouro.Append(estado + "," + "+");
                }
                if (TextBox3.Text != "")
                {
                    rua = TextBox3.Text.Replace(" ", "+");
                    sbLogradouro.Append(rua + "," + "+");
                }
                if (TextBox4.Text != "")
                {
                    cep = TextBox4.Text.Replace(" ", "+");
                    sbLogradouro.Append(cep);
                }
                Response.Redirect(sbLogradouro.ToString());
            }
            catch (Exception){}
        }
    }
}
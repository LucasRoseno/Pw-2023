using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;

public class Classe_Alerta
{

    public void chama_alerta(String mensagem)
    {
        System.Web.HttpContext.Current.Response.Write("<script type='text/javascript'>alert('"+mensagem+"');</script>");
    }
}
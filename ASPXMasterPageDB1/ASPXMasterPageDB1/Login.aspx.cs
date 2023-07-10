using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPXMasterPageDB1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //NÃO UTILIZADO NO MOMENTO
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if ((Login1.UserName == "rub") && (Login1.Password == "1"))
            {
                e.Authenticated = true;
                //ATENÇÃO ******** VER Web.config
                /*
                name: Nome do cookie que será utilizado pelo ASP.NET para armazenar as informações do usuário logado.
                loginUrl: Nome da pagina que contem a lógica que controlará a autenticação dos usuários do site.
                defaultUrl: Nome da pagina inicial da sua aplicação
                timeout: Tempo em minutos que o cookie é persistido. Se você ficar mais tempo do que o aqui definido
                sem interação com a aplicação, você será redirecionado novamente para a tela definida no parâmetro loginUrl.
                path: Identificador de qual diretório da aplicação deve receber a proteção quanto ao acesso sem a devida autenticação.
                */
            }
            else
            {
                e.Authenticated = false;
                //Response.Redirect("Falha.htm");
            }
        }
    }
}
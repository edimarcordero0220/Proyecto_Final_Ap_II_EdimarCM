using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entidades;
using System.Web.Security;

namespace Sistema_DiscoGrafico_EdimarCM
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public bool ValidarUsuario()
        {
            if (UsuariosBLL.GetListaNombre(NombreTextBox.Text).Count() == 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Usuario No Existe!!');</script>");
                return false;
            }
            return true;
        }

        public bool ValidarContrasena()
        {
            if (UsuariosBLL.GetContrasena(ClaveTextBox.Text).Count() == 0)
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Clave invalida!!');</script>");
                return false;
            }
            return true;
        }
        protected void EntrarButton_Click(object sender, EventArgs e)
        {
            if (NombreTextBox.Text == "" || ClaveTextBox.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar ambos Campos!!');</script>");
            }
            else
            {
                if (ValidarUsuario() && ValidarContrasena() == true)
                {

                    FormsAuthentication.RedirectFromLoginPage(NombreTextBox.Text, true);




                }
            }

        }
    }
}
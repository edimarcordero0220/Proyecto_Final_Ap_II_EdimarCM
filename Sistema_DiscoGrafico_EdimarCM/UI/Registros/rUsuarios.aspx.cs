using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entidades;

namespace Sistema_DiscoGrafico_EdimarCM.UI.Registros
{
    public partial class rUsuarios : System.Web.UI.Page
    {
        Validar v = new Validar();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.FechaTextBox.Text = string.Format("{0:G}", DateTime.Now);
        }
        public void LlenarClase(Usuarios u)
        {
            u.Nombre = NombreTextBox.Text;
            u.Clave = ClaveTextBox.Text;
            u.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            u.Email = EmailTextBox.Text;
            u.Direccion = DireccionTextBox.Text;
            u.Telefono = TelefonoTextBox.Text;
            u.Celular = CelularTextBox.Text;

        }

       
    protected void GuardarButton_Click(object sender, EventArgs e)
        {

            if (NombreTextBox.Text == "" || ClaveTextBox.Text == "" || DireccionTextBox.Text == "" || TelefonoTextBox.Text==""
                || CelularTextBox.Text == "" || EmailTextBox.Text == "" )
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar Los Campos');</script>");
            }
            else
            {
                Entidades.Usuarios usu = new Entidades.Usuarios();
                LlenarClase(usu);
                UsuariosBLL.Insertar(usu);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Proceso Completado');</script>");
                Limpiar();
            }
        }
        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }

        public void BuscarUsuario(Entidades.Usuarios u)
        {
            if (UsuariosBLL.Buscar(String(IdTextBox.Text)) == null)
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No Existe');</script>");


            }
            else
            {

                NombreTextBox.Text = u.Nombre;
                ClaveTextBox.Text = u.Clave;
                u.Fecha = Convert.ToDateTime(FechaTextBox.Text);
                DireccionTextBox.Text = u.Direccion;
                TelefonoTextBox.Text = u.Telefono;
                CelularTextBox.Text = u.Celular;
                EmailTextBox.Text = u.Email;

            }
        }
        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if(IdTextBox.Text == "")
            {
                base.Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes llenar el campo Id para realizar la busqueda!');</script>");
            }
            else
            {
                BuscarUsuario(UsuariosBLL.Buscar(v.String(IdTextBox.Text)));
            }
            
        }

        public void Limpiar()
        {
            IdTextBox.Text = "";
            NombreTextBox.Text = "";
            ClaveTextBox.Text = "";
            DireccionTextBox.Text = "";
            TelefonoTextBox.Text = "";
            CelularTextBox.Text = "";
            EmailTextBox.Text = "";
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            if (IdTextBox.Text == "" )
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Debes Llenar el Campo Id');</script>");
            }
            else
            {
                if (UsuariosBLL.Buscar(String(IdTextBox.Text)) == null)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No existe este Usuario');</script>");
                }
                else
                {
                    UsuariosBLL.Eliminar(v.String(IdTextBox.Text));
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Proceso Completado');</script>");
                }
                
            }

            
        
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
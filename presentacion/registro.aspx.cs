using Dominio;
using Helper;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servicios;

namespace presentacion
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
                if (Seguridad.sesionActiva(Session["usuario"]))
                {
                    Session.Add("error", "Usted ya se ha registrado");
                    Response.Redirect("error.aspx");
                }

			}
            catch (ThreadAbortException) { }
			catch (Exception ex)
			{
                Session.Add("error", HelpClass.mensajeError(ex));
                Response.Redirect("error.aspx");
			}
        }

        protected void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            UsuarioNegocio negocio = new UsuarioNegocio();
            Mail mail = new Mail();
            try
            {
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Pass = txtContraseña.Text;
                usuario.Email = txtEmail.Text;
                usuario.Admin = false;
                usuario.ImagenPerfil = "";

                negocio.CrearUsuario(usuario);
                Session.Add("usuario", usuario);

                mail.CorreoBienvenida(usuario.Nombre, usuario.Apellido, "Su registro fue exitoso", usuario.Email);
                mail.enviarEmail();

                Response.Redirect("miPerfil.aspx");
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                Session.Add("error", HelpClass.mensajeError(ex));
                Response.Redirect("error.aspx");
            }
        }
    }
}
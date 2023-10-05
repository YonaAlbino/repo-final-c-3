using Dominio;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace presentacion
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page is administracion || Page is miPerfil || Page is favoritos || Page is formulario)
            {
                if (!(Seguridad.sesionActiva(Session["usuario"])))
                    Response.Redirect("loguin.aspx");
            }

            if (Seguridad.sesionActiva(Session["usuario"]))
            {
                Usuario user = (Usuario)Session["usuario"];
                if (!(string.IsNullOrEmpty(user.ImagenPerfil)))
                {
                    lblEmailUsuario.Text = user.Email;
                    imgAvatar.ImageUrl = HelpClass.refrescarImagen(user.ImagenPerfil);
                }
                else
                    imgAvatar.ImageUrl = "https://w7.pngwing.com/pngs/627/693/png-transparent-computer-icons-user-user-icon-thumbnail.png";
            }
        }

        protected void btnDesconectarse_Click(object sender, EventArgs e)
        {
            try
            {
                Session.Clear();
                Response.Redirect("default.aspx");
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                Session.Add("error", HelpClass.mensajeError(ex));
                Response.Redirect("error.aspx");
            }
        }

        protected void btnConectarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("loguin.aspx");
        }
    }
}
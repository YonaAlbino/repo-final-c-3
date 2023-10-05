using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Servicios;

namespace presentacion
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!(IsPostBack))
            {
                dropCiudad.Items.Add("Posadas");
                dropProvincia.Items.Add("Misiones");
            }
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail();
            try
            {
                mail.armarCorreo(txtNombre.Text, txtApellido.Text, txtAsunto.Text, txtEmail.Text, txtMensaje.Text);
                mail.enviarEmail();
            }
            catch (Exception ex)
            {
                Session.Add("error", HelpClass.mensajeError(ex));
                Response.Redirect("error.aspx");
            }
        }
    }
}
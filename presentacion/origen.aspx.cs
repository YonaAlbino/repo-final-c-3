using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Helper;
using Negocio;

namespace presentacion
{
    public partial class _default : System.Web.UI.Page
    {
		public List<Articulo> ListaArticulos { get; set; }
		protected void Page_Load(object sender, EventArgs e)
        {
			ArticuloNegocio negocio= new ArticuloNegocio();
			try
			{
				if((!IsPostBack))
				{
                    ListaArticulos = negocio.listar();
					repetidor.DataSource = ListaArticulos;
                    repetidor.DataBind();
					
                }
            }

			catch (ThreadAbortException) { }
			catch (Exception ex)
			{

				Session.Add("error", HelpClass.mensajeError(ex));
				Response.Redirect("error.aspx");
			}
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
			string idArticulo = ((Button)sender).CommandArgument;
			Response.Redirect("detalle.aspx?id=" + idArticulo);
        }
    }
}
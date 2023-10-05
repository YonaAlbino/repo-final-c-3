using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Helper;
using System.Threading;
using Dominio;

namespace presentacion
{
    public partial class Detalle : System.Web.UI.Page
    {
        public List<Articulo> listaArticulos = new List<Articulo>();
        public Articulo articulo { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (!(IsPostBack))
                {
                    listaArticulos = negocio.listar();

                    if (Request.QueryString["id"] != null)
                    {
                        int id = int.Parse(Request.QueryString["id"]);
                        articulo = listaArticulos.Find(x => x.Id == id);

                        imagenDetalle.ImageUrl = articulo.ImagenUrl;
                        txtDescripcion.Text = articulo.Descripcion;
                        txtDescripcion.ReadOnly = true;

                        
                    }
                }
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
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
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if ((!IsPostBack))
                {
                    ListaArticulos = negocio.listar("4");
                    Session.Add("listaArticulos", ListaArticulos);

                    repetidor.DataSource = Session["listaArticulos"];
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

        protected void btnFavoritos_Click(object sender, EventArgs e)
        {
            try
            {
                int articuloId = int.Parse(((Button)sender).CommandArgument);
                List<Articulo> fav = ((List<Articulo>)Session["listaArticulos"]).FindAll(x => x.Id == articuloId);

                if (Session["articuloFav"] != null)
                {
                    List<Articulo> listaFavoritos;
                    listaFavoritos = (List<Articulo>)Session["articuloFav"];

                    Articulo art = listaFavoritos.Find(x => x.Id == fav[0].Id);
                    if (art == null)
                    {
                        listaFavoritos.Add(fav[0]);
                        Session.Add("articuloFav", listaFavoritos);
                    }
                }
                else
                    Session.Add("articuloFav", fav);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                string id = ((Button)sender).CommandArgument;
                Response.Redirect("detalle.aspx?id=" + id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void txtCantidadArticulos_TextChanged(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {

                Session.Add("listaArticulos", negocio.listar(txtCantidadArticulos.Text));
                repetidor.DataSource = Session["listaArticulos"];
                repetidor.DataBind();
            }
            catch (Exception ex)
            {

                Session.Add("error", HelpClass.mensajeError(ex));
                Response.Redirect("error.aspx");
            }
        }
    }
}
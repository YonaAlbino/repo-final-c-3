using Dominio;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace presentacion
{
    public partial class favoritos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Session["articuloFav"] != null)
                    {

                        repetidorFavoritos.DataSource = Session["articuloFav"];
                        repetidorFavoritos.DataBind();
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        protected void btnFavoritos_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(((Button)sender).CommandArgument);
                List<Articulo> listaFavoritos;
                listaFavoritos = (List<Articulo>)Session["articuloFav"];

                int indice = -1;

                foreach (var item in listaFavoritos)
                {
                    if (item.Id == id)
                    {
                        indice = listaFavoritos.IndexOf(item);
                    }
                }

                if(indice != -1)
                    listaFavoritos.RemoveAt(indice);

                Session.Add("articuloFav", listaFavoritos);

                repetidorFavoritos.DataSource = Session["articuloFav"];
                repetidorFavoritos.DataBind();
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                Session.Add("error", HelpClass.mensajeError(ex));
                Response.Redirect("error.aspx");
            }
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(((Button)sender).CommandArgument);
                Response.Redirect("detalle.aspx?id=" + id);
            }
            catch(ThreadAbortException) { }
            catch (Exception ex)
            {
                Session.Add("error", HelpClass.mensajeError(ex));
                Response.Redirect("error.aspx");
            }
        }
    }
}
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
    public partial class administracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (Seguridad.sesionActiva(Session["usuario"]))
                {
                    if (!(Seguridad.esAdmin(Session["usuario"])))
                        Response.Redirect("default.aspx");
                }
                else
                    Response.Redirect("loguin.aspx");


                Session.Add("listaArticulos", negocio.listar());
                dgvAticulos.DataSource = Session["listaArticulos"];
                dgvAticulos.DataBind();
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("error.aspx");
            }
        }

        protected void dgvAticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var id = dgvAticulos.SelectedDataKey.Value;
                Response.Redirect("formulario.aspx?id=" + id);
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {

                Session.Add("error", HelpClass.mensajeError(ex));
                Response.Redirect("error.aspx");
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("formulario.aspx");
        }

        protected void dgvAticulos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                dgvAticulos.PageIndex = e.NewPageIndex;
                dgvAticulos.DataBind();
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {

                Session.Add("error", HelpClass.mensajeError(ex));
            }
        }

        protected void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltroRapido.Text;
                List<Articulo> lista;
                lista = ((List<Articulo>)Session["listaArticulos"]).FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
                dgvAticulos.DataSource = lista;
                dgvAticulos.DataBind();

            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {

                Session.Add("error", HelpClass.mensajeError(ex));
                Response.Redirect("error.aspx");
            }
        }

        protected void checkFiltroAvanzado_CheckedChanged(object sender, EventArgs e)
        {
            txtFiltroRapido.Enabled = !checkFiltroAvanzado.Checked;
        }

        protected void dropCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dropCriterio.Items.Clear();

                if (dropCampo.Text == "Precio")
                {
                    dropCriterio.Items.Add("Igual a");
                    dropCriterio.Items.Add("Mayor a");
                    dropCriterio.Items.Add("Menor a");
                }
                else
                {
                    dropCriterio.Items.Add("Comienza con");
                    dropCriterio.Items.Add("Termina con");
                    dropCriterio.Items.Add("Contiene");
                }
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {

                Session.Add("error", HelpClass.mensajeError(ex));
                Response.Redirect("error.aspx");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                dgvAticulos.DataSource = negocio.FiltroAvanzado(dropCampo.Text, dropCriterio.Text, txtFiltroAvanzado.Text);
                dgvAticulos.DataBind();
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
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
    public partial class formulario : System.Web.UI.Page
    {
        public MarcaNegocio negocioMarca = new MarcaNegocio();
        public CategoriaNegocio negocioCategoria = new CategoriaNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                btnEliminar.Enabled = false;

                if (!(IsPostBack))
                {
                    dropMarca.DataSource = negocioMarca.listar();

                    dropMarca.DataBind();


                    dropCategoria.DataSource = negocioCategoria.listar();
                    dropCategoria.DataTextField = "Descripcion";
                    dropCategoria.DataValueField = "Id";
                    dropCategoria.DataBind();

                    dropMarca.DataSource = negocioMarca.listar();
                    dropMarca.DataTextField = "Descripcion";
                    dropMarca.DataValueField = "Id";
                    dropMarca.DataBind();


                    if (Request.QueryString["id"] != null)
                    {
                        btnAceptar.Text = "Modificar";
                        btnEliminar.Enabled = true;


                        int id = int.Parse(Request.QueryString["id"].ToString());
                        Articulo articulo = ((List<Articulo>)Session["listaArticulos"]).Find(x => x.Id == id);

                        txtNombre.Text = articulo.Nombre;
                        txtCodigo.Text = articulo.Codigo;
                        dropMarca.SelectedValue = articulo.MarcaArticulo.Id.ToString();
                        dropCategoria.Text = articulo.CategoriaArticulo.Id.ToString();
                        txtPrecio.Text = articulo.Precio.ToString();
                        txtDescripcion.Text = articulo.Descripcion;
                        txtImagen.Text = articulo.ImagenUrl;
                        imagenProducto.ImageUrl = articulo.ImagenUrl;
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

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.MarcaArticulo = new Marca();
                articulo.MarcaArticulo.Id = int.Parse(dropMarca.SelectedValue);
                articulo.CategoriaArticulo = new Categoria();
                articulo.CategoriaArticulo.Id = int.Parse(dropCategoria.SelectedValue);
                articulo.ImagenUrl = txtImagen.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (Request.QueryString["id"] != null) {
                    articulo.Id = int.Parse(Request.QueryString["id"]);
                    negocio.modificar(articulo);
                }
                else
                    negocio.agregar(articulo);


                Response.Redirect("administracion.aspx");

            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                Session.Add("error", HelpClass.mensajeError(ex));
                Response.Redirect("error.aspx");
                
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void txtImagen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                imagenProducto.ImageUrl = txtImagen.Text;
            }
            catch (Exception ex)
            {
                Session.Add("error", HelpClass.mensajeError(ex));
                Response.Redirect("error.aspx");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                int id = int.Parse(Request.QueryString["id"]);
                negocio.eliminarFisico(id);
                Response.Redirect("administracion.aspx");
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
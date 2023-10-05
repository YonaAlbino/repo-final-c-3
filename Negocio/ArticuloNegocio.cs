using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Conexion_Base_de_datos;
using Helper;
using System.Windows.Forms;
//using System.Reflection;





namespace Negocio
{
    public class ArticuloNegocio
    {
        private AccesoDatos datos = new AccesoDatos();
        HelpClass help = new HelpClass();


        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();

            try
            {
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, M.Descripcion Marca, C.Descripcion Categoria, A.IdMarca,  A.IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C  where A.IdMarca = M.Id and A.IdCategoria = C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    lista.Add(SetearDatos());
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Articulo> listar(string cantidadRegistros)
        {
            List<Articulo> lista = new List<Articulo>();

            try
            {
                datos.setearConsulta("select top " + cantidadRegistros + " A.Id, Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, M.Descripcion Marca, C.Descripcion Categoria, A.IdMarca,  A.IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C  where A.IdMarca = M.Id and A.IdCategoria = C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    lista.Add(SetearDatos());
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public Articulo SetearDatos()
        {
            Articulo aux = new Articulo();


            aux.Id = (int)datos.Lector["Id"];

            if (!(help.validarColumnaNula(datos.Lector, "Codigo")))
                aux.Codigo = (string)datos.Lector["Codigo"];

            if (!(help.validarColumnaNula(datos.Lector, "Nombre")))
                aux.Nombre = (string)datos.Lector["Nombre"];

            if (!(help.validarColumnaNula(datos.Lector, "Descripcion")))
                aux.Descripcion = (string)datos.Lector["Descripcion"];

            if (!(help.validarColumnaNula(datos.Lector, "ImagenUrl")))
                aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

            if (!(help.validarColumnaNula(datos.Lector, "Precio")))
                aux.Precio = (decimal)datos.Lector["Precio"];

            aux.MarcaArticulo = new Marca();

            if (!(help.validarColumnaNula(datos.Lector, "Marca")))
                aux.MarcaArticulo.Descripcion = (string)datos.Lector["Marca"];
            aux.MarcaArticulo.Id = (int)datos.Lector["IdMarca"];

            aux.CategoriaArticulo = new Categoria();

            if (!(help.validarColumnaNula(datos.Lector, "Categoria")))
                aux.CategoriaArticulo.Descripcion = (string)datos.Lector["Categoria"];
            aux.CategoriaArticulo.Id = (int)datos.Lector["IdCategoria"];

            return aux;

        }

        public void eliminarFisico(int seleccionado)
        {
            try
            {
                datos.setearConsulta("delete from ARTICULOS where id = @id");
                datos.setearParametro("@id", seleccionado);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo nuevo)
        {
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio)values(@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.MarcaArticulo.Id);
                datos.setearParametro("@IdCategoria", nuevo.CategoriaArticulo.Id);
                datos.setearParametro("@ImagenUrl", nuevo.ImagenUrl);
                datos.setearParametro("@Precio", nuevo.Precio);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminarVarios(List<Articulo> lista)
        {
            foreach (Articulo articulo in lista)
            {
                try
                {
                    datos.setearConsulta();
                    datos.setearParametro("@id", articulo.Id);
                    datos.ejecutarAccion();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    datos.cerrarConexion();
                }
            }
        }

        public void modificar(Articulo articulo)
        {
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where id = @id");
                datos.setearParametro("@Codigo", articulo.Codigo);
                datos.setearParametro("@Nombre", articulo.Nombre);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@IdMarca", articulo.MarcaArticulo.Id);
                datos.setearParametro("@IdCategoria", articulo.CategoriaArticulo.Id);
                datos.setearParametro("@ImagenUrl", articulo.ImagenUrl);
                datos.setearParametro("@Precio", articulo.Precio);
                datos.setearParametro("@id", articulo.Id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> FiltroAvanzado(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            try
            {
                string consulta = "select A.Id, Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, M.Descripcion Marca, C.Descripcion Categoria, A.IdMarca,  A.IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C  where A.IdMarca = M.Id and A.IdCategoria = C.Id And ";
                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Precio >" + filtro;
                            break;
                        case "Menor a":
                            consulta += "Precio <" + filtro;
                            break;
                        case "Igual a":
                            consulta += "Precio =" + filtro;
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;
                        case "Contiene":
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Marca")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += " M.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += " M.Descripcion like '%" + filtro + "'";
                            break;
                        case "Contiene":
                            consulta += " M.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }

                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += " C.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += " C.Descripcion like '%" + filtro + "'";
                            break;
                        case "Contiene":
                            consulta += " C.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    lista.Add(SetearDatos());
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Helper;
using Conexion_Base_de_datos;


namespace Negocio
{
    public class MarcaNegocio
    {
        AccesoDatos datos = new AccesoDatos();
        HelpClass help = new HelpClass();
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
           
            try
            {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();

                    aux.Id = (int)datos.Lector["id"];

                    if(!(help.validarColumnaNula(datos.Lector, "Descripcion")))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
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

        public void agregar(Marca nuevo)
        {
            try
            {
                datos.setearConsulta("insert into MARCAS (Descripcion)values(@Descripcion)");
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
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

        public void eliminarMarca(Marca seleccionada)
        {
            try
            {
                datos.setearConsulta("delete from MARCAS where id = @id");
                datos.setearParametro("@id", seleccionada.Id);
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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion_Base_de_datos;
using Dominio;
using Helper;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public bool Loguin(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            HelpClass help = new HelpClass();
            try
            {
                datos.setearConsulta("select id, email, pass, nombre, apellido, urlImagenPerfil, admin from USERS where email = @email and pass = @pass");
                datos.setearParametro("@email", usuario.Email);
                datos.setearParametro("@pass", usuario.Pass);

                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["id"];


                    if (!(help.validarColumnaNula(datos.Lector, "nombre")))
                        usuario.Nombre = (string)datos.Lector["nombre"];

                    if (!(help.validarColumnaNula(datos.Lector, "apellido")))
                        usuario.Apellido = (string)datos.Lector["apellido"];

                    if (!(help.validarColumnaNula(datos.Lector, "urlImagenPerfil")))
                        usuario.ImagenPerfil = (string)datos.Lector["urlImagenPerfil"];

                    usuario.Admin = (bool)datos.Lector["admin"];
                    return true;

                }
                else
                    return false;
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
        public void CrearUsuario(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into USERS (email, pass, nombre, apellido, urlImagenPerfil, admin) output inserted.Id values (@email, @pass, @nombre, @apellido, @urlImagenPerfil, @admin)");
                datos.setearParametro("@email", usuario.Email);
                datos.setearParametro("@pass", usuario.Pass);
                datos.setearParametro("@nombre", usuario.Nombre);
                datos.setearParametro("@apellido", usuario.Apellido);
                datos.setearParametro("@urlImagenPerfil", usuario.ImagenPerfil);
                datos.setearParametro("@admin", usuario.Admin);

                usuario.Id = datos.ejecutarAccionEscalar();

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
        public void ActualizarUsuario(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update USERS set pass = @pass, nombre = @nombre, apellido = @apellido, urlImagenPerfil = @urlImagenPerfil where id = @id");
                datos.setearParametro("@pass", usuario.Pass);
                datos.setearParametro("@nombre", usuario.Nombre);
                datos.setearParametro("@apellido", usuario.Apellido);
                datos.setearParametro("@urlImagenPerfil", (object)usuario.ImagenPerfil ?? DBNull.Value);
                datos.setearParametro("@id", usuario.Id);

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

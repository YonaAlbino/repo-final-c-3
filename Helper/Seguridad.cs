using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;



namespace Helper
{
    public static class Seguridad
    {
        public static bool sesionActiva(object usser)
        {
            Usuario usuario = usser != null ? (Usuario)usser : null;

            if (usuario != null && usuario.Id != 0)
                return true;
            else
                return false;
        }

        public static bool esAdmin(object usser)
        {
            try
            {
                Usuario usuario = usser != null ? (Usuario)usser : null;
                return usuario.Admin;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }


}

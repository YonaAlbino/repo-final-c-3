using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Librerias.EntidadesNegocio
{
    public class beEmpleado
    {
        public int IdEmpleado { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string NombreCompleto
        {
            get
            {
                return (String.Format("{0} {1}", Nombre, Apellido));
            }
        }
        public DateTime FechaNacimiento { get; set; }
    }
}

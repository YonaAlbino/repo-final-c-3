using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //ConfigurationManager
using System.Data.SqlClient;

namespace Northwind.Librerias.ReglasNegocio
{
    public class brGeneral
    {

        //Propiedad
        public string Conexion { get; set; }

        //Constructor
        public brGeneral()
        {
            Conexion = ConfigurationManager.ConnectionStrings["conNW"].ConnectionString;
        }
    }
}

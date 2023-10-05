using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Northwind.Librerias.EntidadesNegocio;
using Northwind.Librerias.AccesoDatos;

namespace Northwind.Librerias.ReglasNegocio
{
    public class brEmpleado : brGeneral //Herencia
    {
        public List<beEmpleado> listar()
        {
            List<beEmpleado> lbeEmpleado = null;
            using (SqlConnection con = new SqlConnection(Conexion))
            {
                try
                {
                    con.Open();
                    daEmpleado odaEmpleado = new daEmpleado();
                    lbeEmpleado = odaEmpleado.listar(con);
                }
                catch (SqlException ex)
                {
                    //Capturar el error y grabar un Log
                }
            } //con.Close(); con.Dispose(); con = null;
            return (lbeEmpleado);
        }
    }
}
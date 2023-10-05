using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dominio;
using Servicios;



namespace Helper
{
    public class HelpClass
    {
        public void cargarImagen(PictureBox pcb, string urlImagen)
        {
            try
            {
                pcb.Load(urlImagen);
            }
            catch (Exception)
            {
                pcb.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }
        }
        public void cambiarFormatoDgv(DataGridView grilla, string columna, string formato)
        {
            try
            {
                grilla.Columns[columna].DefaultCellStyle.Format = formato;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool validarColumnaNula(SqlDataReader lector, string columna)
        {
            try
            {
                if (lector[columna] is DBNull)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool validarSiNo(string texto, string titulo)
        {
            try
            {
                DialogResult respuesta = MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool existeComboBox(ComboBox comboBox, string nuevaInclusion)
        {
            try
            {
                int i;
                i = comboBox.FindStringExact(nuevaInclusion);
                if (i != -1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string obtenerRuta(string ruta, string nombreArchivo)
        {
            try
            {
                string rutaComleta = ruta + @"\" + nombreArchivo;
                return rutaComleta;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool soloNumeros(string cadena)
        {
            try
            {
                foreach (char item in cadena)
                {
                    if (!(char.IsNumber(item)))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool soloNumerosInsertPrecio(string cadena)
        {
            try
            {
                int i = 0;
                foreach (char item in cadena)
                {
                    if (cadena.Count() == 1 && cadena[0] == ',')
                        return false;

                    if (!(char.IsNumber(item)))
                    {
                        if (item == ',')
                            i++;
                        if (i == 2)
                            return false;
                        if (!(item == ','))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool SoloLetrasONumeros(string cadena)
        {
            try
            {
                foreach (char item in cadena)
                {
                    if (!(char.IsLetterOrDigit(item)))
                    {
                        if (!(char.IsWhiteSpace(item)))
                            return false;
                    }
                    else if (item.ToString() == "ª" || item.ToString() == "º")
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool soloLetras(string cadena)
        {
            try
            {
                foreach (char item in cadena)
                {
                    if (!(char.IsLetter(item)))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public bool ValidarVacio(string control)
        {
            try
            {
                if (string.IsNullOrEmpty(control))
                    return true;
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool comboBoxVacio(List<ComboBox> lista)
        {
            try
            {
                foreach (var item in lista)
                {
                    if (item.SelectedItem == null)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string reemplazarComa(string cadena)
        {
            try
            {
                cadena = cadena.Replace(",", ".");
                return cadena;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<OpenFileDialog> listadoImagenesArticulos(List<Articulo> listaArt)
        {
            List<OpenFileDialog> lista = new List<OpenFileDialog>();
            //List<Articulo> listaArt = new List<Articulo>();
            //ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                //listaArt = negocio.listar();

                foreach (var item in listaArt)
                {
                    OpenFileDialog archivo = new OpenFileDialog();
                    archivo.FileName = item.ImagenUrl;
                    lista.Add(archivo);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool BuscarImagenesCompartidas(List<OpenFileDialog> lista, OpenFileDialog ArchivoEnModificar)
        {
            try
            {
                int aux = 0;
                foreach (var item in lista)
                {
                    if (item.SafeFileName == ArchivoEnModificar.SafeFileName)
                        aux++;
                }
                if (aux == 1)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        static public string mensajeError(object error)
        {
            Mail mail = new Mail();
            try
            {
                
                mail.correoError(((Exception)error).Message.ToString(), "Hubo un error en la pagina ");
                mail.enviarEmail();
                return ((Exception)error).Message.ToString();
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }
        static public string refrescarImagen(string imagen)
        {
            try
            {
                return "~/imagenes/Perfiles/" + imagen + "?v=" + DateTime.Now.Ticks.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

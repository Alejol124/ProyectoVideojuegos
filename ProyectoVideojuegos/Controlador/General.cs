using ProyectoVideojuegos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVideojuegos.Controlador
{
    public class General
    {
        //Saber el rol para los formularios
        public static string rol;
        //No recuerdo esta, buscarla
        public static int confirmar;
        //Validar que nuestra api esté en funcionamiento
        public static int ApiOK;

        //Método par cargar Form en el panel principal (MENU MDI)
        public static void CargarForm(Form formulario, Panel pnPrincipal)
        {
            VerificarAPI();
            pnPrincipal.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnPrincipal.Controls.Add(formulario);
            formulario.Show();
        }

        //Inicio de Sesión consumiendo la api
        public static void inicioSesion(string usuario, string clave)
        {
            string url = "http://localhost:51550/api/Usuario";
            if (ApiOK == 1)
            {
                dynamic respuesta = DBApi.Get(url);
                string[] contenido = respuesta.ToString().Split('}');
                for (int i = 0; i < contenido.Length - 1; i++)
                {
                    if (usuario == respuesta[i].NombreUsuario.ToString() && clave == respuesta[i].Clave.ToString())
                    {
                        rol = respuesta[i].RolID.ToString();
                        MessageBox.Show("Rol: " + rol);
                        return;
                    }
                }
            }
            else if (ApiOK == 0)
            {
                MessageBox.Show("La API no está disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Método para verificar si nuestra api está en funcionamiento
        public static async void VerificarAPI()
        {
            string urlApi = "http://localhost:51550/api/Usuario";

            bool apiEncendida = await DBApi.IsApiAvailableAsync(urlApi);

            if (apiEncendida)
            {
                ApiOK = 1;
            }
            else
            {
                ApiOK = 0;
            }
        }

        //Para poder crear un cliente correctamente con su usuario y datos personales
        public static int CrearUsuario(string documento, string nombre, string telefono, string email, string usuario, string clave)
        {
            DB.conectar();
            string query = "INSERT Cliente(Documento,Nombre,Telefono,Email,NombreUsuario,Clave,RolID) " +
                "VALUES('" + documento + "','" + nombre + "', '" + telefono + "', '" + email + "','" + usuario + "'," +
                "'" + clave + "', '" + 1 + "')";
            int resultado = DB.operar(query, DB.conexion);
            DB.cerrar(DB.conexion);
            return resultado;
        }

        //Cargar imagen a un PictureBox, Pasar imagen a binario
        public static string cargarImagen(OpenFileDialog of, PictureBox pb)
        {
            of.Title = "Agrega la imagen del juego";
            of.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (of.ShowDialog() == DialogResult.OK)
            {
                string ruta = of.FileName;
                if (File.Exists(of.FileName))
                {
                    pb.Image = Image.FromFile(ruta);
                    return ruta;
                }
            }
            else
            {
                MessageBox.Show("No existe el archivo o ingreso uno invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        //Pasar imagen a binario para la insercción a la BD
        public static byte[] ConvertirImagenABinario(string rutaImagen)
        {
            byte[] imagenBytes;
            using (FileStream fs = new FileStream(rutaImagen, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    imagenBytes = br.ReadBytes((int)fs.Length);
                }
            }
            return imagenBytes;
        }

        //Insertar Videojuego en la BD
        public static void IngresarJuego(string titulo, string plataforma, string desarrollador, string genero, string rutaImagen)
        {
            byte[] imagen = ConvertirImagenABinario(rutaImagen);
            string query = "INSERT Videojuego(Titulo,Plataforma,Desarrollador,Genero,Caratula) " +
                "VALUES('" + titulo + "', '" + plataforma + "', '" + desarrollador + "', '" + genero + "', @Caratula)";
            DB.conectar();
            try
            {
                SqlCommand comando = new SqlCommand(query, DB.conexion);
                comando.Parameters.Add("@Caratula", System.Data.SqlDbType.VarBinary).Value = imagen;
                int bandera = comando.ExecuteNonQuery();
                if (bandera > 0) {
                    MessageBox.Show("Registro Exitoso");
                }
                else
                {
                    MessageBox.Show("Valio verga");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                DB.cerrar(DB.conexion);
            }
        }

    }

}


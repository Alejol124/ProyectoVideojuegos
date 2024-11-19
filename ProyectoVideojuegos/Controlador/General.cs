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
        //Docuemnto para relacionarlo a los prestamos
        public static string documento;
        //Para poder abrir el juego en el prestamo
        public static int banderaJuegos = 0;

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
                        documento = respuesta[i].Documento.ToString();
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
                if (bandera > 0)
                {
                    MessageBox.Show("Registro Exitoso", "¡Nuevo Juego!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("");
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
        //Convertir imagen de la bd a la app
        public static Image ConvertirDeBDaApp(byte[] binarios)
        {
            using (MemoryStream ms = new MemoryStream(binarios))
            {
                return Image.FromStream(ms);
            }
        }

        //Cargar juegos al panel
        public static void CargarJuegoPanel(FlowLayoutPanel flp, string query)
        {
            DB.CargarJuegosDesdeBD(flp, query);
        }

        //Registro nuevo prestamo
        public static int NuevoPrestamo(string fecPrest, string fecDev, string documento, ComboBox cmbjuego)
        {
            int registroID = DB.InsertarPrestamo(fecPrest, fecDev, documento, cmbjuego);
            if (DB.banderaPrest == 1)
            {
                DB.ActualizarPrestado(cmbjuego.SelectedValue.ToString());
                return registroID;
            }
            return 0;
        }

        //Consulta de un juego en el FormBuscarJuego
        public static void consulta(string query, TextBox id, TextBox titulo, TextBox plataforma, TextBox desarrollador, TextBox genero,
            TextBox prestado, PictureBox pbImg)
        {
            DB.ConsultaJuego(query, id, titulo, plataforma, desarrollador, genero, prestado, pbImg);
        }

        //Llenar el datagridView en el control de permisos
        public static void lLenarDGV(string query, DataGridView dgv)
        {
            DB.actualizarTabla(query, dgv);
        }

        //Ejecutar la consulta y el update
        public static int CambioUsuario(string query)
        {
            int registros = DB.operar(query, DB.conexion);
            return registros;
        }

        //LLenar caja de texto con el numero de usuarios
        public static void CantidadU(TextBox cantidad)
        {
            DB.CantidadUsuarios(cantidad);
        }

        //Consulta de un juego para el Update de juegos en el FormActJuego
        public static void ConsultaUpdate(string query, TextBox id, TextBox titulo, TextBox plataforma, ComboBox desarrollador,
            ComboBox genero, PictureBox pbImg)
        {
            DB.ConsultaJuegoUpdate(query, id, titulo, plataforma, desarrollador, genero, pbImg);
        }

        //Actualizar juego sin cambiar la imagen
        public static void ActualizarJuegoSinImg(string query)
        {
            int registros = DB.operar(query, DB.conexion);
            if (registros > 0)
            {
                MessageBox.Show("Registro Actualizado corrrectamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Actualizar juego con nueba imagen
        public static void ActualizarJuegoConImg(string query, string rutaImagen)
        {
            byte[] imagen = ConvertirImagenABinario(rutaImagen);
            DB.conectar();
            try
            {
                SqlCommand comando = new SqlCommand(query, DB.conexion);
                comando.Parameters.Add("@Caratula", System.Data.SqlDbType.VarBinary).Value = imagen;
                int bandera = comando.ExecuteNonQuery();
                if (bandera > 0)
                {
                    MessageBox.Show("Actualización éxitosa", "¡Actualizado correctamente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar, intente de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        //Para eliminar un juego
        public static void EliminarJuego(string query)
        {
            int registros = 0;
            registros = DB.operar(query, DB.conexion);
            if (registros > 0)
            {
                MessageBox.Show("Juego eliminado éxitosamente", "Juego Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el juego, intente de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Eliminar un prestamo
        public static void EliminarPrest(string titulo, string codPrest)
        {
            DB.EliminarPrestamo(titulo, codPrest);
        }

        //Verificar que no esté prestado
        public static void VerifPrestado(string codJueg)
        {
            DB.VerificarPrestado(codJueg);
        }
    }
}


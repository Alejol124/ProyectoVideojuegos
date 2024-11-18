using ProyectoVideojuegos.Controlador;
using ProyectoVideojuegos.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace ProyectoVideojuegos.Modelo
{
    public class DB
    {
        public static SqlConnection conexion = new SqlConnection(@"Data Source=Portatil-Alejo\SQLSERVER ; Initial Catalog= TiendaJuegos  ;  Integrated Security=True");
        //para validar el cambio de rol para el usuario
        public static int banderaPermisos = 1;
        //Para mantener la cantidad de usuarios
        public static int numUsers = 0;
        //Por si no se encuentra nada no seguir con lo demas
        public static int banderaElim = 0;

        public static SqlConnection conectar()
        {
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)

            {
                MessageBox.Show("Fallo la conexión " + ex.ToString());
                return null;
            }
        }

        //Consulta de juego para el FormBuscar - Buscar por código/Nombre
        public static void ConsultaJuego(string conSQL, SqlConnection conector, TextBox id, TextBox titulo,
            TextBox plataforma, TextBox desarrollador, TextBox genero, TextBox prestado, PictureBox pbImg)
        {
            try
            {
                conectar();
                SqlCommand comando = new SqlCommand(conSQL, conector);
                SqlDataReader tabla = comando.ExecuteReader();
                if (tabla.Read())
                {
                    id.Text = tabla[0].ToString();
                    titulo.Text = tabla[1].ToString();
                    plataforma.Text = tabla[2].ToString();
                    desarrollador.Text = tabla[3].ToString();
                    genero.Text = tabla[4].ToString();
                    prestado.Text = tabla[5].ToString();
                    byte[] img = (byte[])tabla["Caratula"];
                    Image caratula = General.ConvertirDeBDaApp(img);
                    pbImg.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbImg.Image = caratula;
                }
                else
                {
                    MessageBox.Show("No se encontró ningun juego, inténtelo bien de nuevo", "No se encontró nada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la consulta " + ex.ToString());
            }
            finally
            {
                cerrar(conector);
            }
        }
        public static int operar(string conSQL, SqlConnection conector)
        {
            int num = 0;
            try
            {
                conectar();
                SqlCommand comando = new SqlCommand(conSQL, conector);
                num = comando.ExecuteNonQuery();
                return num;
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                MessageBox.Show("Error: Estás intentando ingresar una clave primaria repetida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return num;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cerrar(conector);
            }
            return num;
        }
        public static void cerrar(SqlConnection conector)
        {
            try
            {
                conector.Close();
            }
            catch (SqlException eq)
            {
                MessageBox.Show("Error: " + eq);
            }
        }
        //Cargar los juegos en el FLowLayoutPanel
        public static void CargarJuegosDesdeBD(FlowLayoutPanel flp, string query)
        {
            conectar();
            SqlCommand command = new SqlCommand(query, conexion);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Crea un objeto con los datos del juego
                    var juego = new
                    {
                        Titulo = reader.GetString(0),
                        Plataforma = reader.GetString(1),
                        Desarrollador = reader.GetString(2),
                        Genero = reader.GetString(3),
                        Prestado = reader.GetString(4),
                        Caratula = (byte[])reader["Caratula"]
                    };
                    Image caratula = General.ConvertirDeBDaApp(juego.Caratula);

                    MuestraJuego muestra = new MuestraJuego
                    {
                        Titulo = juego.Titulo,
                        Genero = juego.Genero,
                        Desarrollador = juego.Desarrollador,
                        Plataforma = juego.Plataforma,
                        Prestado = juego.Prestado,
                        Imagen = caratula
                    };
                    flp.Controls.Add(muestra);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los juegos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cerrar(conexion);
            }
        }

        public static int InsertarPrestamo(string fecPrest, string fecDev, string documento, ComboBox cmbjuego)
        {
            string idJuego = cmbjuego.SelectedValue.ToString();
            string query = "INSERT Prestamo (FechaPrestamo,FechaDevolucion,ClienteID,JuegoID) " +
                "VALUES('" + fecPrest + "','" + fecDev + "','" + documento + "','" + cmbjuego.SelectedValue + "');SELECT SCOPE_IDENTITY();";
            int idRegistro = 0;
            conectar();
            try
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                // Ejecuta la consulta y obtiene el ID
                object result = comando.ExecuteScalar();
                if (result != null)
                {
                    idRegistro = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                cerrar(conexion);
                ActualizarPrestado(idJuego);
            }
            return idRegistro;
        }

        public static void ActualizarPrestado(string idJuego)
        {
            string query = "UPDATE Videojuego SET Prestado = 'Si' WHERE JuegoID = '" + idJuego + "'";
            conectar();
            try
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error con el código: " + ex);
            }
            finally
            {
                cerrar(conexion);
            }
        }

        //ACTUALIZAR TABLAS DE DATOS
        public static void actualizarTabla(string query, DataGridView dgv)
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                adapter.Fill(tabla);
                dgv.DataSource = tabla;
                banderaPermisos = 1;
                if (tabla.Rows.Count == 0)
                {
                    banderaPermisos = 0;
                    MessageBox.Show("No se encontró nada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        //Cantidad de usuarios
        public static void CantidadUsuarios(TextBox cantidad)
        {
            conectar();
            try
            {
                string query = "SELECT COUNT(*) FROM Usuario";
                SqlCommand comando = new SqlCommand(query, conexion);
                object result = comando.ExecuteScalar();
                if (result != null)
                {
                    numUsers = Convert.ToInt32(result);
                    cantidad.Text = numUsers.ToString();
                }
                else
                {
                    MessageBox.Show("Hubo un error en la consulta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                cerrar(conexion);
            }
        }

        public static void ConsultaJuegoUpdate(string conSQL, SqlConnection conector, TextBox id ,TextBox titulo,
            TextBox plataforma, ComboBox desarrollador, ComboBox genero, PictureBox pbImg)
        {
            try
            {
                conectar();
                SqlCommand comando = new SqlCommand(conSQL, conector);
                SqlDataReader tabla = comando.ExecuteReader();
                if (tabla.Read())
                {
                    titulo.Text = tabla[0].ToString();
                    plataforma.Text = tabla[1].ToString();
                    desarrollador.Text = tabla[2].ToString();
                    genero.Text = tabla[3].ToString();
                    byte[] img = (byte[])tabla["Caratula"];
                    Image caratula = General.ConvertirDeBDaApp(img);
                    pbImg.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbImg.Image = caratula;
                    banderaElim = 1;
                }
                else
                {
                    MessageBox.Show("No se encontró ningun juego, inténtelo bien de nuevo", "No se encontró nada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    banderaElim = 0;
                    id.Clear();
                    titulo.Clear();
                    plataforma.Clear();
                    pbImg.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la consulta " + ex.ToString());
            }
            finally
            {
                cerrar(conector);
            }
        }
    }
}


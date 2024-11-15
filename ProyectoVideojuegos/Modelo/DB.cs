using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVideojuegos.Modelo
{
    public class DB
    {
        public static SqlConnection conexion = new SqlConnection(@"Data Source=Portatil-Alejo\SQLSERVER ; Initial Catalog= TiendaJuegos  ;  Integrated Security=True");
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

        public static SqlDataReader consulta(string conSQL, SqlConnection conector)
        {
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                SqlDataReader tabla = comando.ExecuteReader();
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la consulta " + ex.ToString());
                return null;
            }
        }
        public static int operar(string conSQL, SqlConnection conector)
        {
            int num = 0;
            try
            {
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

        /*
        public static int ConfirmarCredenciales(string conSQL, SqlConnection conector, string usuario, string clave)
        {
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                SqlDataReader tabla = comando.ExecuteReader();
                if (tabla.Read())
                {
                    if (tabla[0].ToString() == usuario && tabla[1].ToString() == clave)
                    {
                        rol = tabla[2].ToString();
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return 0;
            }
            return 0;
        }
        */
    }
}
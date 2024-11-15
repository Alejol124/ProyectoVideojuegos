using ProyectoVideojuegos.Controlador;
using ProyectoVideojuegos.Modelo;
using ProyectoVideojuegos.Vista.InicioParaRol;
using ProyectoVideojuegos.Vista.MaestroDetalle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVideojuegos.Vista
{
    public partial class FormMaestro : Form
    {
        public static Color colorPred = Color.FromArgb(25, 25, 63);
        public FormMaestro()
        {
            InitializeComponent();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");
            timerHora.Start();
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora " + DateTime.Now.ToString("HH:mm:ss");
        }

        //Aquí Verificamos que rol posee el usuario
        private void FormMaestro_Load(object sender, EventArgs e)
        {
            General.CargarForm(new FormAdmin(), pnlPrincipal);
            if (General.rol == "1")
            {
                MessageBox.Show("Bienvenido Cliente");
                tsPermisos.Visible = false;
                tsMaestro.Visible = false;
                General.CargarForm(new FormAdmin(), pnlPrincipal);
                tsInicio.Enabled = false;
            }
            else if (General.rol == "2")
            {
                MessageBox.Show("Bienvenido Admin");
                General.CargarForm(new FormAdmin(), pnlPrincipal);
                tsInicio.Enabled = false;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsCerrarSes_Click(object sender, EventArgs e)
        {
            FormInicio form1 = new FormInicio();
            form1.Visible = true;
            this.Close();
        }

        private void tsInicio_Click(object sender, EventArgs e)
        {
            if (General.rol == "1")
            {
                General.CargarForm(new FormAdmin(), pnlPrincipal);
            }
            else if (General.rol == "2")
            {
                General.CargarForm(new FormAdmin(), pnlPrincipal);
            }
        }

        //Maestro detalle de prestamos de un cliente por nombre
        private void smPrestaUsuarios_Click(object sender, EventArgs e)
        {
            General.CargarForm(new FormMaestroDetalle(), pnlPrincipal);
        }

        //Maestro detalle de Videojuegos por desarrollador
        private void tsJuegoDesar_Click(object sender, EventArgs e)
        {
            General.CargarForm(new FormDetalleJuego(), pnlPrincipal);
        }

        //Vista juegos
        private void tsJuegDesarr_Click(object sender, EventArgs e)
        {
            General.CargarForm(new FormVistaJu(), pnlPrincipal);
        }

        private void tsIngresarJuego_Click(object sender, EventArgs e)
        {
            General.CargarForm(new FormNuevoJuego(), pnlPrincipal);
        }
    }
}

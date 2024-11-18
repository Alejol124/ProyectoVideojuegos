using ProyectoVideojuegos.Controlador;
using ProyectoVideojuegos.Modelo;
using ProyectoVideojuegos.Vista.Crud;
using ProyectoVideojuegos.Vista.InicioParaRol;
using ProyectoVideojuegos.Vista.MaestroDetalle;
using ProyectoVideojuegos.Vista.Prestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            //General.CargarForm(new FormUsuario(), pnlPrincipal);
            if (General.rol == "1")
            {
                tsPermisos.Visible = false;
                tsMaestro.Visible = false;
                tsActualizar.Visible = false;
                tsEntregarJ.Visible = false;
                tsVerUsuario.Visible = false;
                General.CargarForm(new FormUsuario(), pnlPrincipal);
            }
            else if (General.rol == "2")
            {
                General.CargarForm(new FormAdmin(), pnlPrincipal);
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
                General.CargarForm(new FormUsuario(), pnlPrincipal);
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

        //Nuevo Juego para ingresar
        private void tsIngresarJuego_Click(object sender, EventArgs e)
        {
            General.CargarForm(new FormNuevoJuego(), pnlPrincipal);
        }

        private void tsWeb_Click(object sender, EventArgs e)
        {
            Process.Start("http://localhost:57312/");
        }

        private void tsTodosJuegos_Click(object sender, EventArgs e)
        {
            General.CargarForm(new FormVideojuegos(), pnlPrincipal);
        }

        private void tsPrestarJ_Click(object sender, EventArgs e)
        {
            General.CargarForm(new FormPrestar(), pnlPrincipal);
        }

        private void tsNombCod_Click(object sender, EventArgs e)
        {
            General.CargarForm(new FormBusqueda(),pnlPrincipal);
        }

        private void tsPer_Click(object sender, EventArgs e)
        {
            General.CargarForm(new FormPermisos(), pnlPrincipal);
        }

        private void tsVerUsuario_Click(object sender, EventArgs e)
        {
            General.CargarForm(new FormVerUser(), pnlPrincipal);
        }

        private void tsActJuego_Click(object sender, EventArgs e)
        {
            General.CargarForm(new FormActJuego(), pnlPrincipal);
        }

        private void tsElimJuego_Click(object sender, EventArgs e)
        {
            General.CargarForm(new FormElimJuego(), pnlPrincipal);
        }
    }
}

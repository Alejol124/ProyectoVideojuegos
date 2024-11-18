using ProyectoVideojuegos.Controlador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVideojuegos.Vista.Crud
{
    public partial class FormVideojuegos : Form
    {
        private static string queryGeneral = "SELECT v.Titulo, v.Plataforma, d.NombreEmpresa, " +
               "g.Nombre AS Genero, v.Prestado, v.Caratula FROM Videojuego AS v " +
               "INNER JOIN Desarrollador AS d ON d.DesarrolladorID = v.Desarrollador " +
               "INNER JOIN Genero AS g ON g.GeneroID = v.Genero";
        public FormVideojuegos()
        {

            InitializeComponent();
            cmbGenero.Visible = false;
            lblGenero.Visible = false;
            cmbDesarr.Visible = false;
            lblDesarr.Visible = false;
        }

        private void FormVideojuegos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaJuegosDataSet.Desarrollador' Puede moverla o quitarla según sea necesario.
            this.desarrolladorTableAdapter.Fill(this.tiendaJuegosDataSet.Desarrollador);
            // TODO: esta línea de código carga datos en la tabla 'tiendaJuegosDataSet.Genero' Puede moverla o quitarla según sea necesario.
            this.generoTableAdapter.Fill(this.tiendaJuegosDataSet.Genero);

            General.CargarJuegoPanel(flpJuegos, queryGeneral);
        }

        private void cmbFiltrarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpJuegos.Controls.Clear();
            string queryFiltrado = "";
            if (cmbFiltrarPor.SelectedIndex != 2)
            {
                lblGenero.Visible = false;
                cmbGenero.Visible = false;
            }
            if (cmbFiltrarPor.SelectedIndex != 3)
            {
                lblDesarr.Visible = false;
                cmbDesarr.Visible = false;
            }
            /*-Juegos prestados -Juegos No Prestados -Por género -Por desarrollador*/
            switch (cmbFiltrarPor.SelectedIndex)
            {
                case 0:
                    queryFiltrado = "SELECT v.Titulo, v.Plataforma, d.NombreEmpresa, " +
               "g.Nombre AS Genero, v.Prestado, v.Caratula FROM Videojuego AS v " +
               "INNER JOIN Desarrollador AS d ON d.DesarrolladorID = v.Desarrollador " +
               "INNER JOIN Genero AS g ON g.GeneroID = v.Genero WHERE v.Prestado = 'Si'";
                    break;
                case 1:
                    queryFiltrado = "SELECT v.Titulo, v.Plataforma, d.NombreEmpresa, " +
               "g.Nombre AS Genero, v.Prestado, v.Caratula FROM Videojuego AS v " +
               "INNER JOIN Desarrollador AS d ON d.DesarrolladorID = v.Desarrollador " +
               "INNER JOIN Genero AS g ON g.GeneroID = v.Genero WHERE v.Prestado = 'No'";
                    break;
                case 2:
                    lblGenero.Visible = true;
                    cmbGenero.Visible = true;
                    queryFiltrado = "SELECT v.Titulo, v.Plataforma, d.NombreEmpresa, " +
               "g.Nombre AS Genero, v.Prestado, v.Caratula FROM Videojuego AS v " +
               "INNER JOIN Desarrollador AS d ON d.DesarrolladorID = v.Desarrollador " +
               "INNER JOIN Genero AS g ON g.GeneroID = v.Genero WHERE v.Genero = '" + cmbGenero.SelectedValue + "'";
                    General.CargarJuegoPanel(flpJuegos, queryFiltrado);
                    break;
                case 3:
                    lblDesarr.Visible = true;
                    cmbDesarr.Visible = true;
                    queryFiltrado = "SELECT v.Titulo, v.Plataforma, d.NombreEmpresa, " +
               "g.Nombre AS Genero, v.Prestado, v.Caratula FROM Videojuego AS v " +
               "INNER JOIN Desarrollador AS d ON d.DesarrolladorID = v.Desarrollador " +
               "INNER JOIN Genero AS g ON g.GeneroID = v.Genero WHERE v.Desarrollador = '" + cmbDesarr.SelectedValue + "'";
                    break;
            }
            General.CargarJuegoPanel(flpJuegos, queryFiltrado);
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpJuegos.Controls.Clear();
            string query = "";
            query = "SELECT v.Titulo, v.Plataforma, d.NombreEmpresa, " +
   "g.Nombre AS Genero, v.Prestado, v.Caratula FROM Videojuego AS v " +
   "INNER JOIN Desarrollador AS d ON d.DesarrolladorID = v.Desarrollador " +
   "INNER JOIN Genero AS g ON g.GeneroID = v.Genero WHERE v.Genero = '" + cmbGenero.SelectedValue + "'";
            General.CargarJuegoPanel(flpJuegos, query);
        }

        private void cmbDesarr_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpJuegos.Controls.Clear();
            string query = "";
            query = "SELECT v.Titulo, v.Plataforma, d.NombreEmpresa, " +
   "g.Nombre AS Genero, v.Prestado, v.Caratula FROM Videojuego AS v " +
   "INNER JOIN Desarrollador AS d ON d.DesarrolladorID = v.Desarrollador " +
   "INNER JOIN Genero AS g ON g.GeneroID = v.Genero WHERE v.Desarrollador = '" + cmbDesarr.SelectedValue + "'";
            General.CargarJuegoPanel(flpJuegos, query);
        }

        private void btnActu_MouseEnter(object sender, EventArgs e)
        {
            btnActu.BackColor = Color.RoyalBlue;
        }

        private void btnActu_MouseLeave(object sender, EventArgs e)
        {
            btnActu.BackColor = Color.FromArgb(28, 128, 255);
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            flpJuegos.Controls.Clear();
            General.CargarJuegoPanel(flpJuegos, queryGeneral);
        }
    }
}

using ProyectoVideojuegos.Controlador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVideojuegos.Vista.Crud
{
    public partial class FormActJuego : Form
    {
        public static string rutaimag;
        public static Image imganterior;
        public FormActJuego()
        {
            InitializeComponent();
            gbInfo.Visible = false;
            btnConfirmar.Visible = false;
            btnVolver.Visible = false;
            pbImagen.Visible = false;
            btnCargar.Visible = false;
            btnActJue.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtID.Text))
            {
                string query = "SELECT v.Titulo, v.Plataforma, d.NombreEmpresa, " +
                "g.Nombre AS Genero, v.Caratula FROM Videojuego AS v " +
                "INNER JOIN Desarrollador AS d ON d.DesarrolladorID = v.Desarrollador " +
                "INNER JOIN Genero AS g ON g.GeneroID = v.Genero WHERE v.JuegoID = '" + txtID.Text + "'";
                General.ConsultaUpdate(query, txtID, txtTitulo, txtPlataforma, cmbDesarro, cmbGenero, pbImagen);
                gbInfo.Visible = true;
                btnConfirmar.Visible = true;
                pbImagen.Visible = true;
                imganterior = pbImagen.Image;
            }
            else
            {
                MessageBox.Show("Ingrese la info solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormActJuego_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaJuegosDataSet.Genero' Puede moverla o quitarla según sea necesario.
            this.generoTableAdapter.Fill(this.tiendaJuegosDataSet.Genero);
            // TODO: esta línea de código carga datos en la tabla 'tiendaJuegosDataSet.Desarrollador' Puede moverla o quitarla según sea necesario.
            this.desarrolladorTableAdapter.Fill(this.tiendaJuegosDataSet.Desarrollador);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtTitulo.Text != "" && txtPlataforma.Text != "")
            {
                txtID.Enabled = false;
                gbInfo.Enabled = false;
                btnConfirmar.Visible = false;
                btnVolver.Visible = true;
                btnBuscar.Enabled = false;
                btnActJue.Visible = true;
                btnCargar.Visible = true;
                pbImagen.Visible = true;
            }
            else
            {
                MessageBox.Show("Ingrese la info solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            gbInfo.Enabled = true;
            txtID.Enabled = true;
            btnConfirmar.Visible = true;
            btnVolver.Visible = false;
            btnBuscar.Enabled = true;
            btnCargar.Visible = false;
            btnActJue.Visible = false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            rutaimag = General.cargarImagen(openFileDialog1, pbImagen);
            if (pbImagen.Image != null)
            {
                btnActJue.Visible = true;
            }
        }

        private void btnActJue_Click(object sender, EventArgs e)
        {
            string query = "";
            if (pbImagen.Image != imganterior)
            {
                query = "Update Videojuego set Titulo = '" + txtTitulo.Text + "', Plataforma = '" + txtPlataforma.Text + "', " +
                    "Desarrollador = '" + cmbDesarro.SelectedValue + "', Genero = '" + cmbGenero.SelectedValue + "', Caratula = @Caratula " +
                    "WHERE JuegoID = '" + txtID.Text + "'";
                General.ActualizarJuegoConImg(query, rutaimag);
            }
            else if (pbImagen.Image == imganterior)
            {
                query = "Update Videojuego set Titulo = '" + txtTitulo.Text + "', Plataforma = '" + txtPlataforma.Text + "', " +
                    "Desarrollador = '" + cmbDesarro.SelectedValue + "', Genero = '" + cmbGenero.SelectedValue + "' " +
                    "WHERE JuegoID = '" + txtID.Text + "'";
                General.ActualizarJuegoSinImg(query);
            }
            gbInfo.Visible = false;
            gbInfo.Enabled = true;
            txtID.Enabled = true;
            txtID.Clear();  
            btnBuscar.Enabled = true;
            btnConfirmar.Visible = false;
            btnVolver.Visible = false;
            btnCargar.Visible = false;
            btnActJue.Visible = false;
            pbImagen.Visible = false;
            pbImagen.Image = null;
        }

        private void btnCargar_MouseEnter(object sender, EventArgs e)
        {
            btnCargar.BackColor = Color.DarkSlateGray;
        }

        private void btnCargar_MouseLeave(object sender, EventArgs e)
        {
            btnCargar.BackColor = Color.MediumTurquoise;
        }

        private void btnActJue_MouseEnter(object sender, EventArgs e)
        {
            btnActJue.BackColor = Color.Green;
        }

        private void btnActJue_MouseLeave(object sender, EventArgs e)
        {
            btnActJue.BackColor = Color.Lime;
        }
    }
}

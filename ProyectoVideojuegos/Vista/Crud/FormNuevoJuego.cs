using ProyectoVideojuegos.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVideojuegos.Vista
{
    public partial class FormNuevoJuego : Form
    {
        public static string rutaimagen;
        public FormNuevoJuego()
        {
            InitializeComponent();
            
            btnAgregarJ.Visible = false;
            btnVolver.Visible = false;
            btnCargar.Visible = false;
            pbImagen.Visible = false;
        }

        private void btnAgregarJ_Click(object sender, EventArgs e)
        {
            General.IngresarJuego(txtTitulo.Text, txtPlataforma.Text, cmbDesarro.SelectedValue.ToString(),
                cmbGenero.SelectedValue.ToString(), rutaimagen);
            btnLimpiar.PerformClick();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            rutaimagen = General.cargarImagen(openFileDialog1, pbImagen);
            if (pbImagen.Image != null)
            {
                btnAgregarJ.Visible = true;
            }
        }



        private void btnCargar_MouseEnter(object sender, EventArgs e)
        {
            btnCargar.BackColor = Color.DarkSlateGray;
        }

        private void btnCargar_MouseLeave(object sender, EventArgs e)
        {
            btnCargar.BackColor = Color.MediumTurquoise;
        }

        private void btnAgregarJ_MouseEnter(object sender, EventArgs e)
        {
            btnAgregarJ.BackColor = Color.Green;
        }

        private void btnAgregarJ_MouseLeave(object sender, EventArgs e)
        {
            btnAgregarJ.BackColor = Color.Lime;
        }

        private void btnLimpiar_MouseEnter(object sender, EventArgs e)
        {
            btnLimpiar.BackColor = Color.Gold;
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.BackColor = Color.FromArgb(255, 192, 128);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTitulo.Text) && !String.IsNullOrEmpty(txtPlataforma.Text))
            {
                gbInfo.Enabled = false;
                btnConfirmar.Visible = false;
                btnVolver.Visible = true;
                btnCargar.Visible = true;
                pbImagen.Visible = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            btnVolver.Visible = false;
            gbInfo.Enabled = true;
            btnConfirmar.Visible = true;
            pbImagen.Enabled = false;
            btnCargar.Visible = false;
            pbImagen.Image = null;
            pbImagen.Visible = false;
            btnAgregarJ.Visible = false;
        }

        private void FormNuevoJuego_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaJuegosDataSet.Genero' Puede moverla o quitarla según sea necesario.
            this.generoTableAdapter.Fill(this.tiendaJuegosDataSet.Genero);
            // TODO: esta línea de código carga datos en la tabla 'tiendaJuegosDataSet.Desarrollador' Puede moverla o quitarla según sea necesario.
            this.desarrolladorTableAdapter.Fill(this.tiendaJuegosDataSet.Desarrollador);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnAgregarJ.Visible = false;
            btnCargar.Visible = false;
            btnVolver.Visible = false;
            pbImagen.Visible = false;
            btnConfirmar.Visible = true;
            txtTitulo.Clear();
            txtPlataforma.Clear();
            cmbDesarro.SelectedIndex = 0;
            cmbGenero.SelectedIndex = 0;
            gbInfo.Enabled = true;
            pbImagen.Image = null;
        }
    }
}

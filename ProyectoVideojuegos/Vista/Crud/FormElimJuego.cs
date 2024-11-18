using ProyectoVideojuegos.Controlador;
using ProyectoVideojuegos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVideojuegos.Vista.Crud
{
    public partial class FormElimJuego : Form
    {
        public FormElimJuego()
        {
            InitializeComponent();
            gbInfo.Visible = false;
            gbInfo.Enabled = false;
            pbImagen.Visible = false;
            btnVolver.Visible = false;
            btnElim.Visible = false;
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
                if (DB.banderaElim == 1)
                {
                    gbInfo.Visible = true;
                    pbImagen.Visible = true;
                    txtID.Enabled = false;
                    btnBuscar.Visible = false;
                    btnVolver.Visible = true;
                    btnElim.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Ingrese la info solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActJue_MouseEnter(object sender, EventArgs e)
        {
            btnElim.BackColor = Color.DarkRed;
        }

        private void btnActJue_MouseLeave(object sender, EventArgs e)
        {
            btnElim.BackColor = Color.Red;
        }

        private void FormElimJuego_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaJuegosDataSet.Genero' Puede moverla o quitarla según sea necesario.
            this.generoTableAdapter.Fill(this.tiendaJuegosDataSet.Genero);
            // TODO: esta línea de código carga datos en la tabla 'tiendaJuegosDataSet.Desarrollador' Puede moverla o quitarla según sea necesario.
            this.desarrolladorTableAdapter.Fill(this.tiendaJuegosDataSet.Desarrollador);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            btnBuscar.Visible = true;
            btnVolver.Visible = false;
            pbImagen.Visible = false;
            btnElim.Visible = false;
            gbInfo.Visible = false;
            txtID.Enabled = true;
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Videojuego WHERE JuegoID = '" + txtID.Text + "'";
            var respuesta = MessageBox.Show($"¿Estás seguro de eliminar\n {txtTitulo.Text} ?", "Confirmar Eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                General.EliminarJuego(query);
            }
            btnVolver.PerformClick();
        }
    }
}

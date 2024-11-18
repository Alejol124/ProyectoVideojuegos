using ProyectoVideojuegos.Controlador;
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
    public partial class FormBusqueda : Form
    {
        public FormBusqueda()
        {
            InitializeComponent();
            gbInformacion.Visible = false;
            txtInfo.Visible = false;
        }

        private void rbCod_Click(object sender, EventArgs e)
        {
            if (rbCod.Checked)
            {
                lblInfo.Text = "Código:";
                lblIngrese.Text = "Ingrese el Código del Videojuego";
                txtInfo.Visible = true;
            }
        }

        private void rbNomb_Click(object sender, EventArgs e)
        {
            if (rbNomb.Checked)
            {
                lblInfo.Text = "Nombre:";
                lblIngrese.Text = "Ingrese el Nombre del Videojuego";
                txtInfo.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = "";
            if (!String.IsNullOrEmpty(txtInfo.Text))
            {
                if (rbCod.Checked)
                {
                    query = "SELECT v.JuegoID, v.Titulo, v.Plataforma, d.NombreEmpresa, " +
               "g.Nombre AS Genero, v.Prestado, v.Caratula FROM Videojuego AS v " +
               "INNER JOIN Desarrollador AS d ON d.DesarrolladorID = v.Desarrollador " +
               "INNER JOIN Genero AS g ON g.GeneroID = v.Genero WHERE v.JuegoID = '" + txtInfo.Text + "'";
                }
                else if (rbNomb.Checked)
                {
                    query = "SELECT v.JuegoID, v.Titulo, v.Plataforma, d.NombreEmpresa, " +
               "g.Nombre AS Genero, v.Prestado, v.Caratula FROM Videojuego AS v " +
               "INNER JOIN Desarrollador AS d ON d.DesarrolladorID = v.Desarrollador " +
               "INNER JOIN Genero AS g ON g.GeneroID = v.Genero WHERE v.Titulo = '" + txtInfo.Text + "'";
                }
                General.consulta(query,txtCod,txtTitu,txtPlatf,txtDesar,txtGen,txtPrest,pbImagen);
                gbInformacion.Visible = true;
            }
            else
            {
                MessageBox.Show("Ingrese la info solicitada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPlatf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

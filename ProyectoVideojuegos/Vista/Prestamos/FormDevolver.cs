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

namespace ProyectoVideojuegos.Vista.Prestamos
{
    public partial class FormDevolver : Form
    {
        public static string idPrestamo;
        public static string titulo;
        public FormDevolver()
        {
            InitializeComponent();
            dgvPrestamo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPrestamo.ScrollBars = ScrollBars.Both;
            dgvPrestamo.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 12, FontStyle.Regular);
            dgvPrestamo.DefaultCellStyle.Font = new Font("Verdana", 12);
            btnDevolver.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDocumento.Text))
            {
                this.juegosClienteTableAdapter.FillBy(this.tiendaJuegosDataSet1.JuegosCliente, txtDocumento.Text);
                dgvPrestamo.Refresh();
            }
        }

        private void dgvPrestamo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //1011511261
            if (e.RowIndex >= 0 && e.ColumnIndex != -1)
            {
                DataGridViewRow fila = dgvPrestamo.Rows[e.RowIndex];
                idPrestamo = fila.Cells[0].Value.ToString();
                titulo = fila.Cells[2].Value.ToString();
                txtPrestID.Text = idPrestamo;
                txtTitulo.Text = titulo;
                btnDevolver.Visible = true;
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text != "" && txtPrestID.Text != "")
            {
                btnDevolver.Visible = true;
                General.EliminarPrest(titulo, idPrestamo);
                txtTitulo.Text = "";
                txtPrestID.Text = "";
                btnDevolver.Visible = false;
                this.juegosClienteTableAdapter.FillBy(this.tiendaJuegosDataSet1.JuegosCliente, txtDocumento.Text);
                dgvPrestamo.Refresh();
            }
        }
    }
}

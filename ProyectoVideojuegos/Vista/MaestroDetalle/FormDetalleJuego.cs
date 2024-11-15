using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVideojuegos.Vista.MaestroDetalle
{
    public partial class FormDetalleJuego : Form
    {
        public FormDetalleJuego()
        {
            InitializeComponent();
            dgvJuego.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJuego.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvJuego.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvJuego.DefaultCellStyle.Font = new Font("Verdana", 12); // Para las celdas
            dgvJuego.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 14, FontStyle.Regular);
            lblRecordatorio.Visible = false;
        }

        private void FormDetalleJuego_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaJuegosDataSet.Videojuego' Puede moverla o quitarla según sea necesario.
            this.videojuegoTableAdapter.Fill(this.tiendaJuegosDataSet.Videojuego);
            // TODO: esta línea de código carga datos en la tabla 'tiendaJuegosDataSet.Desarrollador' Puede moverla o quitarla según sea necesario.
            this.desarrolladorTableAdapter.Fill(this.tiendaJuegosDataSet.Desarrollador);
        }

        private void cmbDesarr_DropDown(object sender, EventArgs e)
        {
            lblRecordatorio.Visible = true;
        }

        private void cmbDesarr_DropDownClosed(object sender, EventArgs e)
        {
            lblRecordatorio.Visible = false;
        }

        private void videojuegoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void desarrolladorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void desarrolladorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void desarrolladorBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {

        }

        private void desarrolladorBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.desarrolladorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiendaJuegosDataSet);

        }
    }
}

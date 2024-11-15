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
    public partial class FormMaestroDetalle : Form
    {
        public FormMaestroDetalle()
        {
            InitializeComponent();
            dgvPrestamo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamo.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrestamo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrestamo.DefaultCellStyle.Font = new Font("Verdana", 12); // Para las celdas
            dgvPrestamo.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 14, FontStyle.Regular);
            lblRecordatorio.Visible = false;
        }

        private void prestamoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void FormMaestroDetalle_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaJuegosDataSet1.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.tiendaJuegosDataSet1.Usuario);
            // TODO: esta línea de código carga datos en la tabla 'tiendaJuegosDataSet1.Prestamo' Puede moverla o quitarla según sea necesario.
            this.prestamoTableAdapter.Fill(this.tiendaJuegosDataSet1.Prestamo);

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            lblRecordatorio.Visible = true;
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            lblRecordatorio.Visible = false;
        }

        private void prestamoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.prestamoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiendaJuegosDataSet1);

        }

        private void cmbCliente_DropDown(object sender, EventArgs e)
        {
            lblRecordatorio.Visible = true;
        }

        private void cmbCliente_DropDownClosed(object sender, EventArgs e)
        {
            lblRecordatorio.Visible = false;
        }
    }
}

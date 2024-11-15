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
    public partial class FormVistaJu : Form
    {
        public FormVistaJu()
        {
            InitializeComponent();
            dgvVista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVista.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVista.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVista.DefaultCellStyle.Font = new Font("Verdana", 12); // Para las celdas
            dgvVista.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 14, FontStyle.Regular);
        }

        private void FormVistaJu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaJuegosDataSet1.InfoVideoJuego' Puede moverla o quitarla según sea necesario.
            this.infoVideoJuegoTableAdapter.Fill(this.tiendaJuegosDataSet1.InfoVideoJuego);

        }
    }
}

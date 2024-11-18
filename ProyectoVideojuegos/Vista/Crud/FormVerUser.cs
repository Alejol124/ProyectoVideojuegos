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
    public partial class FormVerUser : Form
    {
        private static string queryGeneral;
        public FormVerUser()
        {
            InitializeComponent();
            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsuario.ScrollBars = ScrollBars.Both;
            dgvUsuario.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 14, FontStyle.Regular);
            dgvUsuario.DefaultCellStyle.Font = new Font("Verdana", 14);
        }

        private void FormVerUser_Load(object sender, EventArgs e)
        {
            queryGeneral = "SELECT u.Documento, u.Nombre, u.FechaRegistro, u.Telefono ,r.NombreRol " +
                "FROM Usuario AS u INNER JOIN Rol AS r ON r.RolID = u.RolID ";
            General.lLenarDGV(queryGeneral,dgvUsuario);
            General.CantidadU(txtCant);
        }
    }
}

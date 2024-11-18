using ProyectoVideojuegos.Controlador;
using ProyectoVideojuegos.Modelo;
using System;
using System.Collections;
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
    public partial class FormPermisos : Form
    {
        public FormPermisos()
        {
            InitializeComponent();
            gbInfo.Visible = false;
            btnConfirmar.Visible = false;
            dgvUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUsuario.ScrollBars = ScrollBars.Both;
            dgvUsuario.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 14, FontStyle.Regular);
            dgvUsuario.DefaultCellStyle.Font = new Font("Verdana", 14);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDocumento.Text))
            {
                string query = "SELECT u.Documento, u.Nombre, u.FechaRegistro, r.NombreRol FROM Usuario AS u " +
                    "INNER JOIN Rol AS r ON r.RolID = u.RolID WHERE u.Documento = '" + txtDocumento.Text + "'";
                General.lLenarDGV(query, dgvUsuario);
                if (DB.banderaPermisos == 1)
                {
                    gbInfo.Visible = true;
                    txtDocumento.Enabled = false;
                    dgvUsuario.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Ingrese el documento del usuario por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string query = "";
            if (brCliente.Checked)
            {
                query = "Update Usuario set RolID = 1 WHERE Documento = '" + txtDocumento.Text + "'";
            }
            else if (brAdmin.Checked)
            {
                query = "Update Usuario set RolID = 2 WHERE Documento = '" + txtDocumento.Text + "'";
            }
            if (General.CambioUsuario(query) > 0)
            {
                btnBuscar.PerformClick();
                MessageBox.Show("Cambio exitoso", "Cambio de rol confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbInfo.Visible = false;
                btnConfirmar.Visible = false;
                txtDocumento.Enabled = true;
                txtDocumento.Clear();
            }
        }

        private void brCliente_Click(object sender, EventArgs e)
        {
            if (brCliente.Checked)
            {
                btnConfirmar.Visible = true;
            }
        }

        private void brAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (brAdmin.Checked)
            {
                btnConfirmar.Visible = true;
            }
        }
    }
}

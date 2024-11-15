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

namespace ProyectoVideojuegos.View
{
    public partial class FormCrearUser : Form
    {
        public static Color colorPred = Color.FromArgb(25, 25, 63);
        public FormCrearUser()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void FormCrearUser_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\Aleja\source\repos\ProyectoVideojuegos\ProyectoVideojuegos\Resources\panelLogin.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnCrearUser_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txClave.Text != "" && txtDocumento.Text != "" && txtNombre.Text != "" &&
                txtTel.Text != "" && txtEmail.Text != "")
            {
                if (General.CrearUsuario(txtDocumento.Text, txtNombre.Text, txtTel.Text, txtEmail.Text, txtUsuario.Text, txClave.Text) > 0)
                {
                    MessageBox.Show("Creaste tu cuenta satisfactoriamente " + txtNombre.Text, "¡Bienvenido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimpiar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Hubo un error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos solicitados","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCrearUser_MouseEnter(object sender, EventArgs e)
        {
            btnCrearUser.BackColor = Color.Indigo;
        }

        private void btnCrearUser_MouseLeave(object sender, EventArgs e)
        {
            btnCrearUser.BackColor = colorPred;
        }

        private void btnLimpiar_MouseEnter(object sender, EventArgs e)
        {
            btnLimpiar.BackColor = Color.Indigo;
        }

        private void btnLimpiar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpiar.BackColor = colorPred;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDocumento.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtTel.Clear();
            txtUsuario.Clear();
            txClave.Clear();
        }
        private void txClave_Leave(object sender, EventArgs e)
        {
            lblClave.Text = "";
        }

        private void txClave_Enter(object sender, EventArgs e)
        {
            lblClave.Text = "la contraseña debe contener numeros\n" +
                "y caracteres especiales";
        }
    }
}

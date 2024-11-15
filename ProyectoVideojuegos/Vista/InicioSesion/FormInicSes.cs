using ProyectoVideojuegos.Controlador;
using ProyectoVideojuegos.Modelo;
using ProyectoVideojuegos.Vista;
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
    public partial class FormInicSes : Form
    {
        public static Color colorPred = Color.FromArgb(25, 25, 63);
        public static int bandera = 0;
        public FormInicSes()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void FormInicSes_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\Aleja\source\repos\ProyectoVideojuegos\ProyectoVideojuegos\Resources\panelLogin.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtClave.Text))
            {
                General.inicioSesion(txtUsuario.Text, txtClave.Text);
                if (General.rol == "1" || General.rol == "2")
                {
                    bandera = 1;
                    this.Close();
                }
                else if(General.ApiOK == 1)
                {
                    MessageBox.Show("Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese información en los campos solicitados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
            btnEntrar.BackColor = Color.Indigo;
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            btnEntrar.BackColor = colorPred;
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
            txtUsuario.Clear();
            txtClave.Clear();
        }
    }
}

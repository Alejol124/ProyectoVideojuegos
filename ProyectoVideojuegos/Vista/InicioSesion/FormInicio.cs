using ProyectoVideojuegos.Controlador;
using ProyectoVideojuegos.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVideojuegos.Vista
{
    public partial class FormInicio : Form
    {
        public static Color colorPred = Color.FromArgb(25, 25, 63);
        public static Size tamBotones;
        public FormInicio()
        {
            InitializeComponent();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");
            timerHora.Start();
            tamBotones = btnCrearU.Size;
            this.Text = "Inicio de Sesión";
            General.CargarForm(new FormInicSes(), pnPrincipal);
            
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnCrearU_MouseEnter(object sender, EventArgs e)
        {
            btnCrearU.BackColor = Color.BlueViolet;
            btnCrearU.Height = 100;
        }

        private void btnCrearU_MouseLeave(object sender, EventArgs e)
        {
            btnCrearU.BackColor = colorPred;
            btnCrearU.Size = tamBotones;
        }

        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.Blue;
            btnIngresar.Height = 100;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = colorPred;
            btnIngresar.Size = tamBotones;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Red;
            btnSalir.Height = 100;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = colorPred;
            btnSalir.Size = tamBotones;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            General.CargarForm(new FormInicSes(),pnPrincipal);
            this.Text = "Inicio de Sesión";
        }

        private void btnCrearU_Click(object sender, EventArgs e)
        {
            General.CargarForm(new FormCrearUser(), pnPrincipal);
            this.Text = "Crear Cuenta";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnPrincipal_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (FormInicSes.bandera == 1)
            {
                if (pnPrincipal.Controls.Count == 0)
                {
                    FormMaestro form1 = new FormMaestro();
                    form1.Visible = true;
                    this.Hide();
                }
            }
        }
    }
}

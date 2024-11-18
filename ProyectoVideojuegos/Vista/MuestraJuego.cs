using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVideojuegos.Vista
{
    public partial class MuestraJuego : UserControl
    {
        private Color colorPred = Color.FromArgb(25,25,63);
        public string Titulo
        {
            get => lblTitulo.Text;
            set => lblTitulo.Text = value;
        }

        public string Plataforma
        {
            get => lblPlatf.Text;
            set => lblPlatf.Text = value;
        }
        public string Desarrollador
        {
            get => lblCreador.Text;
            set => lblCreador.Text = value;
        }

        public string Genero
        {
            get => lblGenero.Text;
            set => lblGenero.Text = value;
        }

        public string Prestado
        {
            get => lblPrestado.Text;
            set => lblPrestado.Text = value;
        }

        public Image Imagen
        {
            get => pbPortada.Image;
            set => pbPortada.Image = value;
        }
        public MuestraJuego()
        {
            InitializeComponent();
        }
        private void btnPrestar_Click(object sender, EventArgs e)
        {

        }

        private void MuestraJuego_MouseEnter(object sender, EventArgs e)
        {
            if (lblPrestado.Text == "No")
            {
                this.BackColor = Color.LimeGreen;
            }
            else if(lblPrestado.Text == "Si")
            {
                this.BackColor= Color.Red;
            }
        }

        private void MuestraJuego_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void MuestraJuego_Load(object sender, EventArgs e)
        {
            if (lblPrestado.Text == "Si")
            {
                btnPrestar.Visible = false;
            }
        }

        private void btnPrestar_MouseEnter(object sender, EventArgs e)
        {
            btnPrestar.BackColor = Color.LimeGreen;
        }

        private void btnPrestar_MouseLeave(object sender, EventArgs e)
        {
            btnPrestar.BackColor = Color.FromArgb(192, 192, 255);
        }
    }
}

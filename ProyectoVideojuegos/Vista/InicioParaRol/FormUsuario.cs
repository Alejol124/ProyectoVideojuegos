﻿using ProyectoVideojuegos.Controlador;
using ProyectoVideojuegos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVideojuegos.Vista.InicioParaRol
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"C:\Users\Aleja\source\repos\ProyectoVideojuegos\ProyectoVideojuegos\Resources\FnAdmin.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
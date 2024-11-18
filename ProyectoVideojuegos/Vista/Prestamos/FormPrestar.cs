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

namespace ProyectoVideojuegos.Vista.Prestamos
{
    public partial class FormPrestar : Form
    {
        public FormPrestar()
        {
            InitializeComponent();
            btnVolver.Visible = false;
            txtSalida.Visible = false;
            btnPrestar.Visible = false;
        }

        private void FormPrestar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaJuegosDataSet1.JuegosNoPrestados' Puede moverla o quitarla según sea necesario.
            this.juegosNoPrestadosTableAdapter.Fill(this.tiendaJuegosDataSet1.JuegosNoPrestados);
            //General.CargarJuegosPrestados(cmbJuegos);
            txtDocumento.Text = General.documento;
            txtDocumento.Enabled = false;
            txtFecEntrega.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            pnlInfo.Enabled = false;
            btnVolver.Visible = true;
            btnConfirmar.Visible = false;
            txtSalida.Visible = true;
            btnPrestar.Visible = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            btnConfirmar.Visible = true;
            btnVolver.Visible = false;
            pnlInfo.Enabled = true;
            txtSalida.Visible = false;
            btnPrestar.Visible = false;
            txtSalida.Clear();
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            string fechaEntrega = txtFecEntrega.Text;
            string fechaDevolver = dtpDev.Value.ToString("yyyy-MM-dd");
            int registroID = General.NuevoPrestamo(fechaEntrega, fechaDevolver, txtDocumento.Text, cmbJuegos);
            txtSalida.Text = "\t\t\t\t***FACTURA DEL PRESTAMO***\r\n" +
                "Código Factura: ----------> " + registroID + "\r\n" +
                "Documento: ----------> " + txtDocumento.Text + "\r\n" +
                "Videojuego: ----------> " + cmbJuegos.Text + "\r\n" +
                "Fecha Prestamo : ----------> " + fechaEntrega + "\r\n" +
                "Fecha Devolución: ----------> " + fechaDevolver + "\r\n\n"+
                "\t\tRecuerde entregar el juego a tiempo, de lo contrario deberá pagar una multa";
            MessageBox.Show("El código de su factura es " + registroID, "Código de tu nuevo prestamo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnPrestar.Visible = false;
        }
    }
}
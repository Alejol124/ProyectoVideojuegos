namespace ProyectoVideojuegos.Vista.Prestamos
{
    partial class FormPrestar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.tiendaJuegosDataSet1 = new ProyectoVideojuegos.TiendaJuegosDataSet1();
            this.juegosNoPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.juegosNoPrestadosTableAdapter = new ProyectoVideojuegos.TiendaJuegosDataSet1TableAdapters.JuegosNoPrestadosTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.cmbJuegos = new System.Windows.Forms.ComboBox();
            this.dtpDev = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecEntrega = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaJuegosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegosNoPrestadosBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSalida
            // 
            this.txtSalida.BackColor = System.Drawing.Color.White;
            this.txtSalida.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(303, 518);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ReadOnly = true;
            this.txtSalida.Size = new System.Drawing.Size(1416, 217);
            this.txtSalida.TabIndex = 0;
            // 
            // btnPrestar
            // 
            this.btnPrestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPrestar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestar.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestar.ForeColor = System.Drawing.Color.White;
            this.btnPrestar.Location = new System.Drawing.Point(303, 445);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(384, 49);
            this.btnPrestar.TabIndex = 12;
            this.btnPrestar.Text = "Realizar Prestamo";
            this.btnPrestar.UseVisualStyleBackColor = false;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // tiendaJuegosDataSet1
            // 
            this.tiendaJuegosDataSet1.DataSetName = "TiendaJuegosDataSet1";
            this.tiendaJuegosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // juegosNoPrestadosBindingSource
            // 
            this.juegosNoPrestadosBindingSource.DataMember = "JuegosNoPrestados";
            this.juegosNoPrestadosBindingSource.DataSource = this.tiendaJuegosDataSet1;
            // 
            // juegosNoPrestadosTableAdapter
            // 
            this.juegosNoPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImage = global::ProyectoVideojuegos.Properties.Resources.FondoLogin;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 155);
            this.panel2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(653, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(893, 73);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prestamo de Videojuegos";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.pnlInfo.Controls.Add(this.txtFecEntrega);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.pictureBox1);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.txtDocumento);
            this.pnlInfo.Controls.Add(this.cmbJuegos);
            this.pnlInfo.Controls.Add(this.dtpDev);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 155);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1924, 254);
            this.pnlInfo.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(1100, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fecha devolución:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(335, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Juego:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(335, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 40);
            this.label5.TabIndex = 17;
            this.label5.Text = "Documento:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumento.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(592, 43);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(424, 33);
            this.txtDocumento.TabIndex = 14;
            // 
            // cmbJuegos
            // 
            this.cmbJuegos.DataSource = this.juegosNoPrestadosBindingSource;
            this.cmbJuegos.DisplayMember = "Titulo";
            this.cmbJuegos.DropDownHeight = 90;
            this.cmbJuegos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJuegos.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJuegos.FormattingEnabled = true;
            this.cmbJuegos.IntegralHeight = false;
            this.cmbJuegos.Location = new System.Drawing.Point(479, 124);
            this.cmbJuegos.Name = "cmbJuegos";
            this.cmbJuegos.Size = new System.Drawing.Size(579, 36);
            this.cmbJuegos.TabIndex = 13;
            this.cmbJuegos.ValueMember = "JuegoID";
            // 
            // dtpDev
            // 
            this.dtpDev.CalendarFont = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDev.Location = new System.Drawing.Point(1440, 118);
            this.dtpDev.Name = "dtpDev";
            this.dtpDev.Size = new System.Drawing.Size(588, 38);
            this.dtpDev.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoVideojuegos.Properties.Resources.IcoControl;
            this.pictureBox1.Location = new System.Drawing.Point(31, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 236);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(1553, 415);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(218, 49);
            this.btnConfirmar.TabIndex = 21;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(1096, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 40);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha de entrega:";
            // 
            // txtFecEntrega
            // 
            this.txtFecEntrega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecEntrega.Enabled = false;
            this.txtFecEntrega.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecEntrega.Location = new System.Drawing.Point(1440, 43);
            this.txtFecEntrega.Name = "txtFecEntrega";
            this.txtFecEntrega.Size = new System.Drawing.Size(304, 33);
            this.txtFecEntrega.TabIndex = 23;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(1836, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(218, 49);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormPrestar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1924, 758);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtSalida);
            this.Name = "FormPrestar";
            this.Text = "FormPrestar";
            this.Load += new System.EventHandler(this.FormPrestar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiendaJuegosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegosNoPrestadosBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Button btnPrestar;
        private TiendaJuegosDataSet1 tiendaJuegosDataSet1;
        private System.Windows.Forms.BindingSource juegosNoPrestadosBindingSource;
        private TiendaJuegosDataSet1TableAdapters.JuegosNoPrestadosTableAdapter juegosNoPrestadosTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox cmbJuegos;
        private System.Windows.Forms.DateTimePicker dtpDev;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtFecEntrega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVolver;
    }
}
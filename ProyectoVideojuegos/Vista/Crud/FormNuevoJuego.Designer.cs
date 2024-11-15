namespace ProyectoVideojuegos.Vista
{
    partial class FormNuevoJuego
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
            this.btnAgregarJ = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaJuegosDataSet = new ProyectoVideojuegos.TiendaJuegosDataSet();
            this.cmbDesarro = new System.Windows.Forms.ComboBox();
            this.desarrolladorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlataforma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.desarrolladorTableAdapter = new ProyectoVideojuegos.TiendaJuegosDataSetTableAdapters.DesarrolladorTableAdapter();
            this.generoTableAdapter = new ProyectoVideojuegos.TiendaJuegosDataSetTableAdapters.GeneroTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaJuegosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolladorBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarJ
            // 
            this.btnAgregarJ.BackColor = System.Drawing.Color.Lime;
            this.btnAgregarJ.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAgregarJ.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarJ.Image = global::ProyectoVideojuegos.Properties.Resources.AggJuego;
            this.btnAgregarJ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarJ.Location = new System.Drawing.Point(0, 501);
            this.btnAgregarJ.Name = "btnAgregarJ";
            this.btnAgregarJ.Size = new System.Drawing.Size(537, 102);
            this.btnAgregarJ.TabIndex = 1;
            this.btnAgregarJ.Text = "Agregar Juego";
            this.btnAgregarJ.UseVisualStyleBackColor = false;
            this.btnAgregarJ.Click += new System.EventHandler(this.btnAgregarJ_Click);
            this.btnAgregarJ.MouseEnter += new System.EventHandler(this.btnAgregarJ_MouseEnter);
            this.btnAgregarJ.MouseLeave += new System.EventHandler(this.btnAgregarJ_MouseLeave);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCargar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargar.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Image = global::ProyectoVideojuegos.Properties.Resources.IcoArchivo;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Location = new System.Drawing.Point(0, 0);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(537, 85);
            this.btnCargar.TabIndex = 29;
            this.btnCargar.Text = "Cargar Imagen";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            this.btnCargar.MouseEnter += new System.EventHandler(this.btnCargar_MouseEnter);
            this.btnCargar.MouseLeave += new System.EventHandler(this.btnCargar_MouseLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.White;
            this.pbImagen.Location = new System.Drawing.Point(411, 122);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(283, 334);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 30;
            this.pbImagen.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::ProyectoVideojuegos.Properties.Resources.FondoAgJueg;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1543, 123);
            this.panel1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1061, 73);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresar un nuevo Videojuego";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Controls.Add(this.gbInfo);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 603);
            this.panel2.TabIndex = 32;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnVolver.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(727, 212);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(252, 63);
            this.btnVolver.TabIndex = 42;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnConfirmar.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(727, 83);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(252, 63);
            this.btnConfirmar.TabIndex = 41;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.cmbGenero);
            this.gbInfo.Controls.Add(this.cmbDesarro);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.txtPlataforma);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.txtTitulo);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Location = new System.Drawing.Point(16, 62);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(674, 417);
            this.gbInfo.TabIndex = 32;
            this.gbInfo.TabStop = false;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DataSource = this.generoBindingSource;
            this.cmbGenero.DisplayMember = "Nombre";
            this.cmbGenero.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(184, 322);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(398, 40);
            this.cmbGenero.TabIndex = 45;
            this.cmbGenero.ValueMember = "GeneroID";
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.tiendaJuegosDataSet;
            // 
            // tiendaJuegosDataSet
            // 
            this.tiendaJuegosDataSet.DataSetName = "TiendaJuegosDataSet";
            this.tiendaJuegosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbDesarro
            // 
            this.cmbDesarro.DataSource = this.desarrolladorBindingSource;
            this.cmbDesarro.DisplayMember = "NombreEmpresa";
            this.cmbDesarro.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDesarro.FormattingEnabled = true;
            this.cmbDesarro.Location = new System.Drawing.Point(255, 216);
            this.cmbDesarro.Name = "cmbDesarro";
            this.cmbDesarro.Size = new System.Drawing.Size(402, 40);
            this.cmbDesarro.TabIndex = 44;
            this.cmbDesarro.ValueMember = "DesarrolladorID";
            // 
            // desarrolladorBindingSource
            // 
            this.desarrolladorBindingSource.DataMember = "Desarrollador";
            this.desarrolladorBindingSource.DataSource = this.tiendaJuegosDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 34);
            this.label7.TabIndex = 43;
            this.label7.Text = "Plataforma:";
            // 
            // txtPlataforma
            // 
            this.txtPlataforma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlataforma.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlataforma.Location = new System.Drawing.Point(233, 112);
            this.txtPlataforma.Name = "txtPlataforma";
            this.txtPlataforma.Size = new System.Drawing.Size(424, 40);
            this.txtPlataforma.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 34);
            this.label1.TabIndex = 38;
            this.label1.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(149, 21);
            this.txtTitulo.MaxLength = 3000;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(508, 40);
            this.txtTitulo.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 34);
            this.label6.TabIndex = 40;
            this.label6.Text = "Género:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 34);
            this.label2.TabIndex = 39;
            this.label2.Text = "Desarrollador:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::ProyectoVideojuegos.Properties.Resources.IcoLimp;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(0, 501);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(1006, 102);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.MouseEnter += new System.EventHandler(this.btnLimpiar_MouseEnter);
            this.btnLimpiar.MouseLeave += new System.EventHandler(this.btnLimpiar_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(582, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingrese todos los datos solicitados:";
            // 
            // desarrolladorTableAdapter
            // 
            this.desarrolladorTableAdapter.ClearBeforeFill = true;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.btnAgregarJ);
            this.panel4.Controls.Add(this.pbImagen);
            this.panel4.Controls.Add(this.btnCargar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1006, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(537, 603);
            this.panel4.TabIndex = 33;
            // 
            // FormNuevoJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1543, 726);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormNuevoJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNuevoJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaJuegosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolladorBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarJ;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private TiendaJuegosDataSet tiendaJuegosDataSet;
        private System.Windows.Forms.BindingSource desarrolladorBindingSource;
        private TiendaJuegosDataSetTableAdapters.DesarrolladorTableAdapter desarrolladorTableAdapter;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private TiendaJuegosDataSetTableAdapters.GeneroTableAdapter generoTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbDesarro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlataforma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVolver;
    }
}
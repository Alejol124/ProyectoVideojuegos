namespace ProyectoVideojuegos.Vista.Crud
{
    partial class FormElimJuego
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbDesarro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlataforma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnElim = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tiendaJuegosDataSet = new ProyectoVideojuegos.TiendaJuegosDataSet();
            this.desarrolladorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desarrolladorTableAdapter = new ProyectoVideojuegos.TiendaJuegosDataSetTableAdapters.DesarrolladorTableAdapter();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generoTableAdapter = new ProyectoVideojuegos.TiendaJuegosDataSetTableAdapters.GeneroTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaJuegosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolladorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::ProyectoVideojuegos.Properties.Resources.FondoAgJueg;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1552, 123);
            this.panel1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(749, 73);
            this.label3.TabIndex = 3;
            this.label3.Text = "Eliminar Videojuegos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.gbInfo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 621);
            this.panel2.TabIndex = 34;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(426, 58);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(236, 63);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 34);
            this.label4.TabIndex = 47;
            this.label4.Text = "ID Juego:";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(215, 71);
            this.txtID.MaxLength = 3000;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(158, 40);
            this.txtID.TabIndex = 46;
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
            this.gbInfo.Location = new System.Drawing.Point(124, 153);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(712, 350);
            this.gbInfo.TabIndex = 32;
            this.gbInfo.TabStop = false;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DataSource = this.generoBindingSource;
            this.cmbGenero.DisplayMember = "Nombre";
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(180, 261);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(398, 40);
            this.cmbGenero.TabIndex = 45;
            this.cmbGenero.ValueMember = "GeneroID";
            // 
            // cmbDesarro
            // 
            this.cmbDesarro.DataSource = this.desarrolladorBindingSource;
            this.cmbDesarro.DisplayMember = "NombreEmpresa";
            this.cmbDesarro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesarro.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDesarro.FormattingEnabled = true;
            this.cmbDesarro.Location = new System.Drawing.Point(251, 182);
            this.cmbDesarro.Name = "cmbDesarro";
            this.cmbDesarro.Size = new System.Drawing.Size(420, 40);
            this.cmbDesarro.TabIndex = 44;
            this.cmbDesarro.ValueMember = "DesarrolladorID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 34);
            this.label7.TabIndex = 43;
            this.label7.Text = "Plataforma:";
            // 
            // txtPlataforma
            // 
            this.txtPlataforma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlataforma.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlataforma.Location = new System.Drawing.Point(229, 101);
            this.txtPlataforma.Name = "txtPlataforma";
            this.txtPlataforma.ReadOnly = true;
            this.txtPlataforma.Size = new System.Drawing.Size(442, 40);
            this.txtPlataforma.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 34);
            this.label1.TabIndex = 38;
            this.label1.Text = "Titulo:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(145, 26);
            this.txtTitulo.MaxLength = 3000;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(526, 40);
            this.txtTitulo.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 261);
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
            this.label2.Location = new System.Drawing.Point(11, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 34);
            this.label2.TabIndex = 39;
            this.label2.Text = "Desarrollador:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(766, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingrese el id del juego para traer la información y eliminar";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnElim);
            this.panel4.Controls.Add(this.pbImagen);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(1002, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 621);
            this.panel4.TabIndex = 35;
            // 
            // btnElim
            // 
            this.btnElim.BackColor = System.Drawing.Color.Red;
            this.btnElim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnElim.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElim.Image = global::ProyectoVideojuegos.Properties.Resources.ElimJuego;
            this.btnElim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElim.Location = new System.Drawing.Point(0, 519);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(550, 102);
            this.btnElim.TabIndex = 1;
            this.btnElim.Text = "Eliminar Juego";
            this.btnElim.UseVisualStyleBackColor = false;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            this.btnElim.MouseEnter += new System.EventHandler(this.btnActJue_MouseEnter);
            this.btnElim.MouseLeave += new System.EventHandler(this.btnActJue_MouseLeave);
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.White;
            this.pbImagen.Location = new System.Drawing.Point(308, 71);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(385, 413);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 30;
            this.pbImagen.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(688, 56);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(244, 65);
            this.btnVolver.TabIndex = 49;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tiendaJuegosDataSet
            // 
            this.tiendaJuegosDataSet.DataSetName = "TiendaJuegosDataSet";
            this.tiendaJuegosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // desarrolladorBindingSource
            // 
            this.desarrolladorBindingSource.DataMember = "Desarrollador";
            this.desarrolladorBindingSource.DataSource = this.tiendaJuegosDataSet;
            // 
            // desarrolladorTableAdapter
            // 
            this.desarrolladorTableAdapter.ClearBeforeFill = true;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.tiendaJuegosDataSet;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(395, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 48);
            this.label8.TabIndex = 4;
            this.label8.Text = "Carátula";
            // 
            // FormElimJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 744);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormElimJuego";
            this.Text = "FormElimJuego";
            this.Load += new System.EventHandler(this.FormElimJuego_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaJuegosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolladorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbDesarro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlataforma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnVolver;
        private TiendaJuegosDataSet tiendaJuegosDataSet;
        private System.Windows.Forms.BindingSource desarrolladorBindingSource;
        private TiendaJuegosDataSetTableAdapters.DesarrolladorTableAdapter desarrolladorTableAdapter;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private TiendaJuegosDataSetTableAdapters.GeneroTableAdapter generoTableAdapter;
        private System.Windows.Forms.Label label8;
    }
}
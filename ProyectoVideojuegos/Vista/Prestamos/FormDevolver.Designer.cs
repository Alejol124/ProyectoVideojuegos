namespace ProyectoVideojuegos.Vista.Prestamos
{
    partial class FormDevolver
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPrestID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.prestamoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juegoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juegosClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaJuegosDataSet1 = new ProyectoVideojuegos.TiendaJuegosDataSet1();
            this.juegosClienteTableAdapter = new ProyectoVideojuegos.TiendaJuegosDataSet1TableAdapters.JuegosClienteTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSeleccion = new System.Windows.Forms.Panel();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegosClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaJuegosDataSet1)).BeginInit();
            this.pnlSeleccion.SuspendLayout();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(1715, 155);
            this.panel2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(653, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(946, 73);
            this.label3.TabIndex = 3;
            this.label3.Text = "Devolución de Videojuegos";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.pnlInfo.Controls.Add(this.lbl1);
            this.pnlInfo.Controls.Add(this.txtTitulo);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.btnBuscar);
            this.pnlInfo.Controls.Add(this.txtPrestID);
            this.pnlInfo.Controls.Add(this.label6);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.txtDocumento);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 155);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1715, 220);
            this.pnlInfo.TabIndex = 23;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl1.Location = new System.Drawing.Point(976, 75);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(114, 36);
            this.lbl1.TabIndex = 29;
            this.lbl1.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(1120, 78);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(554, 33);
            this.txtTitulo.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(976, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 36);
            this.label2.TabIndex = 27;
            this.label2.Text = "ID Prestamo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(666, 138);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(188, 49);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPrestID
            // 
            this.txtPrestID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrestID.Enabled = false;
            this.txtPrestID.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrestID.Location = new System.Drawing.Point(1216, 141);
            this.txtPrestID.Name = "txtPrestID";
            this.txtPrestID.ReadOnly = true;
            this.txtPrestID.Size = new System.Drawing.Size(184, 33);
            this.txtPrestID.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(841, 34);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ingrese el documento del usuario para ver sus prestamos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(33, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Documento del cliente:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumento.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(424, 78);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(424, 33);
            this.txtDocumento.TabIndex = 14;
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.AutoGenerateColumns = false;
            this.dgvPrestamo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prestamoIDDataGridViewTextBoxColumn,
            this.juegoIDDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.fechaPrestamoDataGridViewTextBoxColumn,
            this.fechaDevolucionDataGridViewTextBoxColumn});
            this.dgvPrestamo.DataSource = this.juegosClienteBindingSource;
            this.dgvPrestamo.Location = new System.Drawing.Point(39, 492);
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.RowHeadersWidth = 51;
            this.dgvPrestamo.RowTemplate.Height = 24;
            this.dgvPrestamo.Size = new System.Drawing.Size(1795, 169);
            this.dgvPrestamo.TabIndex = 25;
            this.dgvPrestamo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamo_CellClick);
            // 
            // prestamoIDDataGridViewTextBoxColumn
            // 
            this.prestamoIDDataGridViewTextBoxColumn.DataPropertyName = "PrestamoID";
            this.prestamoIDDataGridViewTextBoxColumn.HeaderText = "PrestamoID";
            this.prestamoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prestamoIDDataGridViewTextBoxColumn.Name = "prestamoIDDataGridViewTextBoxColumn";
            this.prestamoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.prestamoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // juegoIDDataGridViewTextBoxColumn
            // 
            this.juegoIDDataGridViewTextBoxColumn.DataPropertyName = "JuegoID";
            this.juegoIDDataGridViewTextBoxColumn.HeaderText = "JuegoID";
            this.juegoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.juegoIDDataGridViewTextBoxColumn.Name = "juegoIDDataGridViewTextBoxColumn";
            this.juegoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.juegoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaPrestamoDataGridViewTextBoxColumn
            // 
            this.fechaPrestamoDataGridViewTextBoxColumn.DataPropertyName = "FechaPrestamo";
            this.fechaPrestamoDataGridViewTextBoxColumn.HeaderText = "FechaPrestamo";
            this.fechaPrestamoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaPrestamoDataGridViewTextBoxColumn.Name = "fechaPrestamoDataGridViewTextBoxColumn";
            this.fechaPrestamoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDevolucionDataGridViewTextBoxColumn
            // 
            this.fechaDevolucionDataGridViewTextBoxColumn.DataPropertyName = "FechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.HeaderText = "FechaDevolucion";
            this.fechaDevolucionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDevolucionDataGridViewTextBoxColumn.Name = "fechaDevolucionDataGridViewTextBoxColumn";
            this.fechaDevolucionDataGridViewTextBoxColumn.Width = 125;
            // 
            // juegosClienteBindingSource
            // 
            this.juegosClienteBindingSource.DataMember = "JuegosCliente";
            this.juegosClienteBindingSource.DataSource = this.tiendaJuegosDataSet1;
            // 
            // tiendaJuegosDataSet1
            // 
            this.tiendaJuegosDataSet1.DataSetName = "TiendaJuegosDataSet1";
            this.tiendaJuegosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // juegosClienteTableAdapter
            // 
            this.juegosClienteTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(23, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(836, 34);
            this.label4.TabIndex = 28;
            this.label4.Text = "Seleccione el registro del juego que desea devolver";
            // 
            // pnlSeleccion
            // 
            this.pnlSeleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.pnlSeleccion.Controls.Add(this.label4);
            this.pnlSeleccion.Location = new System.Drawing.Point(0, 381);
            this.pnlSeleccion.Name = "pnlSeleccion";
            this.pnlSeleccion.Size = new System.Drawing.Size(920, 67);
            this.pnlSeleccion.TabIndex = 28;
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDevolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolver.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.Location = new System.Drawing.Point(982, 399);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(269, 49);
            this.btnDevolver.TabIndex = 22;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // FormDevolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1715, 787);
            this.Controls.Add(this.pnlSeleccion);
            this.Controls.Add(this.dgvPrestamo);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDevolver);
            this.Name = "FormDevolver";
            this.Text = "FormDevolver";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegosClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaJuegosDataSet1)).EndInit();
            this.pnlSeleccion.ResumeLayout(false);
            this.pnlSeleccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.BindingSource juegosClienteBindingSource;
        private TiendaJuegosDataSet1 tiendaJuegosDataSet1;
        private TiendaJuegosDataSet1TableAdapters.JuegosClienteTableAdapter juegosClienteTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn prestamoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juegoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrestID;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtTitulo;
    }
}
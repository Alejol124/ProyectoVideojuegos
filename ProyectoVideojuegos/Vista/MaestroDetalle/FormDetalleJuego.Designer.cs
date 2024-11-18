namespace ProyectoVideojuegos.Vista.MaestroDetalle
{
    partial class FormDetalleJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalleJuego));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordatorio = new System.Windows.Forms.Label();
            this.cmbDesarr = new System.Windows.Forms.ComboBox();
            this.desarrolladorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaJuegosDataSet = new ProyectoVideojuegos.TiendaJuegosDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.desarrolladorTableAdapter = new ProyectoVideojuegos.TiendaJuegosDataSetTableAdapters.DesarrolladorTableAdapter();
            this.tableAdapterManager = new ProyectoVideojuegos.TiendaJuegosDataSetTableAdapters.TableAdapterManager();
            this.videojuegoTableAdapter = new ProyectoVideojuegos.TiendaJuegosDataSetTableAdapters.VideojuegoTableAdapter();
            this.desarrolladorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.desarrolladorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvJuego = new System.Windows.Forms.DataGridView();
            this.juegoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataformaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desarrolladorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caratulaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.prestadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKVideojuegDesar4E88ABD4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolladorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaJuegosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolladorBindingNavigator)).BeginInit();
            this.desarrolladorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVideojuegDesar4E88ABD4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1709, 123);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1523, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maestro detalle: Videojuego y Desarrollador";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(11, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 102);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(625, 72);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione el nombre del desarrollador\r\nPara ver los juegos que posees de este:";
            // 
            // lblRecordatorio
            // 
            this.lblRecordatorio.AutoSize = true;
            this.lblRecordatorio.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordatorio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordatorio.ForeColor = System.Drawing.Color.Black;
            this.lblRecordatorio.Location = new System.Drawing.Point(1312, 192);
            this.lblRecordatorio.Name = "lblRecordatorio";
            this.lblRecordatorio.Size = new System.Drawing.Size(377, 75);
            this.lblRecordatorio.TabIndex = 8;
            this.lblRecordatorio.Text = "¡Recuerda que solo aparecerán los\r\nDesarrolladores con Juegos de estos\r\nregistrad" +
    "os!";
            // 
            // cmbDesarr
            // 
            this.cmbDesarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.cmbDesarr.DataSource = this.desarrolladorBindingSource;
            this.cmbDesarr.DisplayMember = "NombreEmpresa";
            this.cmbDesarr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesarr.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDesarr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbDesarr.FormattingEnabled = true;
            this.cmbDesarr.Location = new System.Drawing.Point(796, 192);
            this.cmbDesarr.Name = "cmbDesarr";
            this.cmbDesarr.Size = new System.Drawing.Size(468, 40);
            this.cmbDesarr.TabIndex = 7;
            this.cmbDesarr.DropDown += new System.EventHandler(this.cmbDesarr_DropDown);
            this.cmbDesarr.DropDownClosed += new System.EventHandler(this.cmbDesarr_DropDownClosed);
            // 
            // desarrolladorBindingSource
            // 
            this.desarrolladorBindingSource.DataMember = "Desarrollador";
            this.desarrolladorBindingSource.DataSource = this.tiendaJuegosDataSet;
            // 
            // tiendaJuegosDataSet
            // 
            this.tiendaJuegosDataSet.DataSetName = "TiendaJuegosDataSet";
            this.tiendaJuegosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoVideojuegos.Properties.Resources.ImgDesarr;
            this.pictureBox1.Location = new System.Drawing.Point(24, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 346);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // desarrolladorTableAdapter
            // 
            this.desarrolladorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DesarrolladorTableAdapter = this.desarrolladorTableAdapter;
            this.tableAdapterManager.GeneroTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoVideojuegos.TiendaJuegosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VideojuegoTableAdapter = this.videojuegoTableAdapter;
            // 
            // videojuegoTableAdapter
            // 
            this.videojuegoTableAdapter.ClearBeforeFill = true;
            // 
            // desarrolladorBindingNavigator
            // 
            this.desarrolladorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.desarrolladorBindingNavigator.BindingSource = this.desarrolladorBindingSource;
            this.desarrolladorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.desarrolladorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.desarrolladorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.desarrolladorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.desarrolladorBindingNavigatorSaveItem});
            this.desarrolladorBindingNavigator.Location = new System.Drawing.Point(0, 123);
            this.desarrolladorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.desarrolladorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.desarrolladorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.desarrolladorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.desarrolladorBindingNavigator.Name = "desarrolladorBindingNavigator";
            this.desarrolladorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.desarrolladorBindingNavigator.Size = new System.Drawing.Size(1709, 31);
            this.desarrolladorBindingNavigator.TabIndex = 11;
            this.desarrolladorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // desarrolladorBindingNavigatorSaveItem
            // 
            this.desarrolladorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.desarrolladorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("desarrolladorBindingNavigatorSaveItem.Image")));
            this.desarrolladorBindingNavigatorSaveItem.Name = "desarrolladorBindingNavigatorSaveItem";
            this.desarrolladorBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.desarrolladorBindingNavigatorSaveItem.Text = "Guardar datos";
            this.desarrolladorBindingNavigatorSaveItem.Click += new System.EventHandler(this.desarrolladorBindingNavigatorSaveItem_Click_3);
            // 
            // dgvJuego
            // 
            this.dgvJuego.AutoGenerateColumns = false;
            this.dgvJuego.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.dgvJuego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJuego.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.juegoIDDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.plataformaDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.desarrolladorDataGridViewTextBoxColumn,
            this.caratulaDataGridViewImageColumn,
            this.prestadoDataGridViewTextBoxColumn});
            this.dgvJuego.DataSource = this.fKVideojuegDesar4E88ABD4BindingSource;
            this.dgvJuego.Location = new System.Drawing.Point(446, 312);
            this.dgvJuego.Name = "dgvJuego";
            this.dgvJuego.RowHeadersWidth = 51;
            this.dgvJuego.RowTemplate.Height = 24;
            this.dgvJuego.Size = new System.Drawing.Size(1516, 380);
            this.dgvJuego.TabIndex = 11;
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
            // plataformaDataGridViewTextBoxColumn
            // 
            this.plataformaDataGridViewTextBoxColumn.DataPropertyName = "Plataforma";
            this.plataformaDataGridViewTextBoxColumn.HeaderText = "Plataforma";
            this.plataformaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plataformaDataGridViewTextBoxColumn.Name = "plataformaDataGridViewTextBoxColumn";
            this.plataformaDataGridViewTextBoxColumn.Width = 125;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.Width = 125;
            // 
            // desarrolladorDataGridViewTextBoxColumn
            // 
            this.desarrolladorDataGridViewTextBoxColumn.DataPropertyName = "Desarrollador";
            this.desarrolladorDataGridViewTextBoxColumn.HeaderText = "Desarrollador";
            this.desarrolladorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.desarrolladorDataGridViewTextBoxColumn.Name = "desarrolladorDataGridViewTextBoxColumn";
            this.desarrolladorDataGridViewTextBoxColumn.Width = 125;
            // 
            // caratulaDataGridViewImageColumn
            // 
            this.caratulaDataGridViewImageColumn.DataPropertyName = "Caratula";
            this.caratulaDataGridViewImageColumn.HeaderText = "Caratula";
            this.caratulaDataGridViewImageColumn.MinimumWidth = 6;
            this.caratulaDataGridViewImageColumn.Name = "caratulaDataGridViewImageColumn";
            this.caratulaDataGridViewImageColumn.Width = 125;
            // 
            // prestadoDataGridViewTextBoxColumn
            // 
            this.prestadoDataGridViewTextBoxColumn.DataPropertyName = "Prestado";
            this.prestadoDataGridViewTextBoxColumn.HeaderText = "Prestado";
            this.prestadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prestadoDataGridViewTextBoxColumn.Name = "prestadoDataGridViewTextBoxColumn";
            this.prestadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fKVideojuegDesar4E88ABD4BindingSource
            // 
            this.fKVideojuegDesar4E88ABD4BindingSource.DataMember = "FK__Videojueg__Desar__4E88ABD4";
            this.fKVideojuegDesar4E88ABD4BindingSource.DataSource = this.desarrolladorBindingSource;
            // 
            // FormDetalleJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1709, 704);
            this.Controls.Add(this.dgvJuego);
            this.Controls.Add(this.desarrolladorBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRecordatorio);
            this.Controls.Add(this.cmbDesarr);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDetalleJuego";
            this.Text = "FormDetalleJuego";
            this.Load += new System.EventHandler(this.FormDetalleJuego_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolladorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaJuegosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolladorBindingNavigator)).EndInit();
            this.desarrolladorBindingNavigator.ResumeLayout(false);
            this.desarrolladorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVideojuegDesar4E88ABD4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordatorio;
        private System.Windows.Forms.ComboBox cmbDesarr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TiendaJuegosDataSet tiendaJuegosDataSet;
        private System.Windows.Forms.BindingSource desarrolladorBindingSource;
        private TiendaJuegosDataSetTableAdapters.DesarrolladorTableAdapter desarrolladorTableAdapter;
        private TiendaJuegosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator desarrolladorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton desarrolladorBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvJuego;
        private TiendaJuegosDataSetTableAdapters.VideojuegoTableAdapter videojuegoTableAdapter;
        private System.Windows.Forms.BindingSource fKVideojuegDesar4E88ABD4BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn juegoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataformaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desarrolladorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn caratulaDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prestadoDataGridViewTextBoxColumn;
    }
}
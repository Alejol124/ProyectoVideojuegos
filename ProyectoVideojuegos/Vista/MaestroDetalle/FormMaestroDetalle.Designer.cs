namespace ProyectoVideojuegos.Vista.MaestroDetalle
{
    partial class FormMaestroDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaestroDetalle));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tiendaJuegosDataSet1 = new ProyectoVideojuegos.TiendaJuegosDataSet1();
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamoTableAdapter = new ProyectoVideojuegos.TiendaJuegosDataSet1TableAdapters.PrestamoTableAdapter();
            this.tableAdapterManager = new ProyectoVideojuegos.TiendaJuegosDataSet1TableAdapters.TableAdapterManager();
            this.prestamoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.prestamoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.prestamoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPrestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juegoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKPrestamoClient5BE2A6F2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.usuarioTableAdapter = new ProyectoVideojuegos.TiendaJuegosDataSet1TableAdapters.UsuarioTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaJuegosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingNavigator)).BeginInit();
            this.prestamoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPrestamoClient5BE2A6F2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1407, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maestro detalle: Cliente y sus prestamos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1633, 123);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 74);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione el nombre del cliente\r\nPara ver los prestamos que tiene:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 102);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoVideojuegos.Properties.Resources.ImgMaesDetalle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 346);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tiendaJuegosDataSet1
            // 
            this.tiendaJuegosDataSet1.DataSetName = "TiendaJuegosDataSet1";
            this.tiendaJuegosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataMember = "Prestamo";
            this.prestamoBindingSource.DataSource = this.tiendaJuegosDataSet1;
            // 
            // prestamoTableAdapter
            // 
            this.prestamoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PrestamoTableAdapter = this.prestamoTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProyectoVideojuegos.TiendaJuegosDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // prestamoBindingNavigator
            // 
            this.prestamoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.prestamoBindingNavigator.BindingSource = this.prestamoBindingSource;
            this.prestamoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.prestamoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.prestamoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.prestamoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prestamoBindingNavigatorSaveItem});
            this.prestamoBindingNavigator.Location = new System.Drawing.Point(0, 123);
            this.prestamoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.prestamoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.prestamoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.prestamoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.prestamoBindingNavigator.Name = "prestamoBindingNavigator";
            this.prestamoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.prestamoBindingNavigator.Size = new System.Drawing.Size(1633, 31);
            this.prestamoBindingNavigator.TabIndex = 7;
            this.prestamoBindingNavigator.Text = "bindingNavigator1";
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
            // prestamoBindingNavigatorSaveItem
            // 
            this.prestamoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prestamoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prestamoBindingNavigatorSaveItem.Image")));
            this.prestamoBindingNavigatorSaveItem.Name = "prestamoBindingNavigatorSaveItem";
            this.prestamoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.prestamoBindingNavigatorSaveItem.Text = "Guardar datos";
            this.prestamoBindingNavigatorSaveItem.Click += new System.EventHandler(this.prestamoBindingNavigatorSaveItem_Click_1);
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.AutoGenerateColumns = false;
            this.dgvPrestamo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prestamoIDDataGridViewTextBoxColumn,
            this.fechaPrestamoDataGridViewTextBoxColumn,
            this.fechaDevolucionDataGridViewTextBoxColumn,
            this.clienteIDDataGridViewTextBoxColumn,
            this.juegoIDDataGridViewTextBoxColumn});
            this.dgvPrestamo.DataSource = this.fKPrestamoClient5BE2A6F2BindingSource;
            this.dgvPrestamo.Location = new System.Drawing.Point(449, 363);
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.RowHeadersWidth = 51;
            this.dgvPrestamo.RowTemplate.Height = 24;
            this.dgvPrestamo.Size = new System.Drawing.Size(1391, 395);
            this.dgvPrestamo.TabIndex = 7;
            // 
            // prestamoIDDataGridViewTextBoxColumn
            // 
            this.prestamoIDDataGridViewTextBoxColumn.DataPropertyName = "PrestamoID";
            this.prestamoIDDataGridViewTextBoxColumn.HeaderText = "PrestamoID";
            this.prestamoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prestamoIDDataGridViewTextBoxColumn.Name = "prestamoIDDataGridViewTextBoxColumn";
            this.prestamoIDDataGridViewTextBoxColumn.Width = 125;
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
            // clienteIDDataGridViewTextBoxColumn
            // 
            this.clienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.HeaderText = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clienteIDDataGridViewTextBoxColumn.Name = "clienteIDDataGridViewTextBoxColumn";
            this.clienteIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // juegoIDDataGridViewTextBoxColumn
            // 
            this.juegoIDDataGridViewTextBoxColumn.DataPropertyName = "JuegoID";
            this.juegoIDDataGridViewTextBoxColumn.HeaderText = "JuegoID";
            this.juegoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.juegoIDDataGridViewTextBoxColumn.Name = "juegoIDDataGridViewTextBoxColumn";
            this.juegoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fKPrestamoClient5BE2A6F2BindingSource
            // 
            this.fKPrestamoClient5BE2A6F2BindingSource.DataMember = "FK__Prestamo__Client__5BE2A6F2";
            this.fKPrestamoClient5BE2A6F2BindingSource.DataSource = this.usuarioBindingSource;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.tiendaJuegosDataSet1;
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.White;
            this.cmbCliente.DataSource = this.usuarioBindingSource;
            this.cmbCliente.DisplayMember = "Nombre";
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(659, 213);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(468, 40);
            this.cmbCliente.TabIndex = 8;
            this.cmbCliente.DropDown += new System.EventHandler(this.cmbCliente_DropDown);
            this.cmbCliente.DropDownClosed += new System.EventHandler(this.cmbCliente_DropDownClosed);
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // FormMaestroDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1633, 729);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.dgvPrestamo);
            this.Controls.Add(this.prestamoBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMaestroDetalle";
            this.Text = "FormMaestroDetalle";
            this.Load += new System.EventHandler(this.FormMaestroDetalle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaJuegosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingNavigator)).EndInit();
            this.prestamoBindingNavigator.ResumeLayout(false);
            this.prestamoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPrestamoClient5BE2A6F2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TiendaJuegosDataSet1 tiendaJuegosDataSet1;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private TiendaJuegosDataSet1TableAdapters.PrestamoTableAdapter prestamoTableAdapter;
        private TiendaJuegosDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prestamoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton prestamoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private TiendaJuegosDataSet1TableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prestamoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPrestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juegoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKPrestamoClient5BE2A6F2BindingSource;
    }
}
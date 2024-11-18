namespace ProyectoVideojuegos.Vista.Crud
{
    partial class FormVideojuegos
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
            this.flpJuegos = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbFiltrarPor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaJuegosDataSet = new ProyectoVideojuegos.TiendaJuegosDataSet();
            this.generoTableAdapter = new ProyectoVideojuegos.TiendaJuegosDataSetTableAdapters.GeneroTableAdapter();
            this.lblDesarr = new System.Windows.Forms.Label();
            this.cmbDesarr = new System.Windows.Forms.ComboBox();
            this.desarrolladorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.desarrolladorTableAdapter = new ProyectoVideojuegos.TiendaJuegosDataSetTableAdapters.DesarrolladorTableAdapter();
            this.btnActu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaJuegosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolladorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flpJuegos
            // 
            this.flpJuegos.AutoScroll = true;
            this.flpJuegos.BackColor = System.Drawing.Color.White;
            this.flpJuegos.Location = new System.Drawing.Point(135, 115);
            this.flpJuegos.Name = "flpJuegos";
            this.flpJuegos.Size = new System.Drawing.Size(1765, 661);
            this.flpJuegos.TabIndex = 2;
            // 
            // cmbFiltrarPor
            // 
            this.cmbFiltrarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.cmbFiltrarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarPor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbFiltrarPor.FormattingEnabled = true;
            this.cmbFiltrarPor.Items.AddRange(new object[] {
            "Juegos prestados",
            "Juegos No Prestados",
            "Por género",
            "Por desarrollador"});
            this.cmbFiltrarPor.Location = new System.Drawing.Point(345, 36);
            this.cmbFiltrarPor.Name = "cmbFiltrarPor";
            this.cmbFiltrarPor.Size = new System.Drawing.Size(293, 33);
            this.cmbFiltrarPor.TabIndex = 3;
            this.cmbFiltrarPor.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrarPor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(158, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrar por:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.lblGenero.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblGenero.Location = new System.Drawing.Point(688, 20);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(104, 28);
            this.lblGenero.TabIndex = 6;
            this.lblGenero.Text = "Género";
            // 
            // cmbGenero
            // 
            this.cmbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.cmbGenero.DataSource = this.generoBindingSource;
            this.cmbGenero.DisplayMember = "Nombre";
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(819, 19);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(249, 33);
            this.cmbGenero.TabIndex = 5;
            this.cmbGenero.ValueMember = "GeneroID";
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.cmbGenero_SelectedIndexChanged);
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
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // lblDesarr
            // 
            this.lblDesarr.AutoSize = true;
            this.lblDesarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.lblDesarr.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesarr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblDesarr.Location = new System.Drawing.Point(688, 63);
            this.lblDesarr.Name = "lblDesarr";
            this.lblDesarr.Size = new System.Drawing.Size(187, 28);
            this.lblDesarr.TabIndex = 8;
            this.lblDesarr.Text = "Desarrollador";
            // 
            // cmbDesarr
            // 
            this.cmbDesarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.cmbDesarr.DataSource = this.desarrolladorBindingSource;
            this.cmbDesarr.DisplayMember = "NombreEmpresa";
            this.cmbDesarr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesarr.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDesarr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmbDesarr.FormattingEnabled = true;
            this.cmbDesarr.Location = new System.Drawing.Point(905, 62);
            this.cmbDesarr.Name = "cmbDesarr";
            this.cmbDesarr.Size = new System.Drawing.Size(306, 33);
            this.cmbDesarr.TabIndex = 7;
            this.cmbDesarr.ValueMember = "DesarrolladorID";
            this.cmbDesarr.SelectedIndexChanged += new System.EventHandler(this.cmbDesarr_SelectedIndexChanged);
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
            // btnActu
            // 
            this.btnActu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnActu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActu.ForeColor = System.Drawing.Color.Transparent;
            this.btnActu.Image = global::ProyectoVideojuegos.Properties.Resources.ActJuego;
            this.btnActu.Location = new System.Drawing.Point(1745, 3);
            this.btnActu.Name = "btnActu";
            this.btnActu.Size = new System.Drawing.Size(155, 105);
            this.btnActu.TabIndex = 10;
            this.btnActu.UseVisualStyleBackColor = false;
            this.btnActu.Click += new System.EventHandler(this.btnActu_Click);
            this.btnActu.MouseEnter += new System.EventHandler(this.btnActu_MouseEnter);
            this.btnActu.MouseLeave += new System.EventHandler(this.btnActu_MouseLeave);
            // 
            // FormVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1924, 882);
            this.Controls.Add(this.btnActu);
            this.Controls.Add(this.lblDesarr);
            this.Controls.Add(this.cmbDesarr);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltrarPor);
            this.Controls.Add(this.flpJuegos);
            this.Name = "FormVideojuegos";
            this.Text = "FormVideojuegos";
            this.Load += new System.EventHandler(this.FormVideojuegos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaJuegosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desarrolladorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpJuegos;
        private System.Windows.Forms.ComboBox cmbFiltrarPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private TiendaJuegosDataSet tiendaJuegosDataSet;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private TiendaJuegosDataSetTableAdapters.GeneroTableAdapter generoTableAdapter;
        private System.Windows.Forms.Label lblDesarr;
        private System.Windows.Forms.ComboBox cmbDesarr;
        private System.Windows.Forms.BindingSource desarrolladorBindingSource;
        private TiendaJuegosDataSetTableAdapters.DesarrolladorTableAdapter desarrolladorTableAdapter;
        private System.Windows.Forms.Button btnActu;
    }
}
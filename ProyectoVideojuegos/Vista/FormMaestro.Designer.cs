namespace ProyectoVideojuegos.Vista
{
    partial class FormMaestro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMaestro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNombCod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTodosJuegos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVerUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsIngresarJuego = new System.Windows.Forms.ToolStripMenuItem();
            this.tsActJuego = new System.Windows.Forms.ToolStripMenuItem();
            this.tsElimJuego = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMaestro = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.smPrestaUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsJuegoDesar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsJuegDesarr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPrestamo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPrestarJ = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEntregarJ = new System.Windows.Forms.ToolStripMenuItem();
            this.tsWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCerrarSes = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.pnlSup = new System.Windows.Forms.Panel();
            this.pbTiempo = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbTitulo = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInicio,
            this.tsConsulta,
            this.tsActualizar,
            this.tsPermisos,
            this.tsMaestro,
            this.tsPrestamo,
            this.tsWeb,
            this.tsCerrarSes,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1647, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "msPrinc";
            // 
            // tsInicio
            // 
            this.tsInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsInicio.Image = global::ProyectoVideojuegos.Properties.Resources.iconoHome;
            this.tsInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsInicio.Name = "tsInicio";
            this.tsInicio.Size = new System.Drawing.Size(53, 29);
            this.tsInicio.Text = " ";
            this.tsInicio.Click += new System.EventHandler(this.tsInicio_Click);
            // 
            // tsConsulta
            // 
            this.tsConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNombCod,
            this.tsTodosJuegos,
            this.tsVerUsuario});
            this.tsConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsConsulta.Image = global::ProyectoVideojuegos.Properties.Resources.iconoBuscar;
            this.tsConsulta.Name = "tsConsulta";
            this.tsConsulta.Size = new System.Drawing.Size(218, 29);
            this.tsConsulta.Text = "Consultar Juegos";
            // 
            // tsNombCod
            // 
            this.tsNombCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.tsNombCod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsNombCod.Name = "tsNombCod";
            this.tsNombCod.Size = new System.Drawing.Size(294, 30);
            this.tsNombCod.Text = "Por Código/Nombre";
            this.tsNombCod.Click += new System.EventHandler(this.tsNombCod_Click);
            // 
            // tsTodosJuegos
            // 
            this.tsTodosJuegos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.tsTodosJuegos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsTodosJuegos.Name = "tsTodosJuegos";
            this.tsTodosJuegos.Size = new System.Drawing.Size(294, 30);
            this.tsTodosJuegos.Text = "Todos los Juegos";
            this.tsTodosJuegos.Click += new System.EventHandler(this.tsTodosJuegos_Click);
            // 
            // tsVerUsuario
            // 
            this.tsVerUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.tsVerUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsVerUsuario.Name = "tsVerUsuario";
            this.tsVerUsuario.Size = new System.Drawing.Size(294, 30);
            this.tsVerUsuario.Text = "Ver Usuarios";
            this.tsVerUsuario.Click += new System.EventHandler(this.tsVerUsuario_Click);
            // 
            // tsActualizar
            // 
            this.tsActualizar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsIngresarJuego,
            this.tsActJuego,
            this.tsElimJuego});
            this.tsActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsActualizar.Image = global::ProyectoVideojuegos.Properties.Resources.iconoActu;
            this.tsActualizar.Name = "tsActualizar";
            this.tsActualizar.Size = new System.Drawing.Size(179, 29);
            this.tsActualizar.Text = "Actualización";
            // 
            // tsIngresarJuego
            // 
            this.tsIngresarJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.tsIngresarJuego.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsIngresarJuego.Name = "tsIngresarJuego";
            this.tsIngresarJuego.Size = new System.Drawing.Size(264, 30);
            this.tsIngresarJuego.Text = "Ingresar juego";
            this.tsIngresarJuego.Click += new System.EventHandler(this.tsIngresarJuego_Click);
            // 
            // tsActJuego
            // 
            this.tsActJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.tsActJuego.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsActJuego.Name = "tsActJuego";
            this.tsActJuego.Size = new System.Drawing.Size(264, 30);
            this.tsActJuego.Text = "Actualizar Juego";
            this.tsActJuego.Click += new System.EventHandler(this.tsActJuego_Click);
            // 
            // tsElimJuego
            // 
            this.tsElimJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.tsElimJuego.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsElimJuego.Name = "tsElimJuego";
            this.tsElimJuego.Size = new System.Drawing.Size(264, 30);
            this.tsElimJuego.Text = "Eliminar Juego";
            this.tsElimJuego.Click += new System.EventHandler(this.tsElimJuego_Click);
            // 
            // tsPermisos
            // 
            this.tsPermisos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPer});
            this.tsPermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsPermisos.Image = global::ProyectoVideojuegos.Properties.Resources.IcoPermisos;
            this.tsPermisos.Name = "tsPermisos";
            this.tsPermisos.Size = new System.Drawing.Size(136, 29);
            this.tsPermisos.Text = "Permisos";
            // 
            // tsPer
            // 
            this.tsPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.tsPer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsPer.Name = "tsPer";
            this.tsPer.Size = new System.Drawing.Size(279, 30);
            this.tsPer.Text = "Cambiar Permisos";
            this.tsPer.Click += new System.EventHandler(this.tsPer_Click);
            // 
            // tsMaestro
            // 
            this.tsMaestro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.tsMaestro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsMaestro.Image = global::ProyectoVideojuegos.Properties.Resources.IcoMaestro;
            this.tsMaestro.Name = "tsMaestro";
            this.tsMaestro.Size = new System.Drawing.Size(162, 29);
            this.tsMaestro.Text = "Maestro BD";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smPrestaUsuarios,
            this.tsJuegoDesar});
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(256, 30);
            this.toolStripMenuItem5.Text = "Maestro Detalle";
            // 
            // smPrestaUsuarios
            // 
            this.smPrestaUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.smPrestaUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.smPrestaUsuarios.Name = "smPrestaUsuarios";
            this.smPrestaUsuarios.Size = new System.Drawing.Size(372, 30);
            this.smPrestaUsuarios.Text = "Prestamos de Usuarios";
            this.smPrestaUsuarios.Click += new System.EventHandler(this.smPrestaUsuarios_Click);
            // 
            // tsJuegoDesar
            // 
            this.tsJuegoDesar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.tsJuegoDesar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsJuegoDesar.Name = "tsJuegoDesar";
            this.tsJuegoDesar.Size = new System.Drawing.Size(372, 30);
            this.tsJuegoDesar.Text = "Videojuego y Desarrollador";
            this.tsJuegoDesar.Click += new System.EventHandler(this.tsJuegoDesar_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsJuegDesarr});
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(256, 30);
            this.toolStripMenuItem6.Text = "Vista";
            // 
            // tsJuegDesarr
            // 
            this.tsJuegDesarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.tsJuegDesarr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsJuegDesarr.Name = "tsJuegDesarr";
            this.tsJuegDesarr.Size = new System.Drawing.Size(315, 30);
            this.tsJuegDesarr.Text = "Juego y desarrollador";
            this.tsJuegDesarr.Click += new System.EventHandler(this.tsJuegDesarr_Click);
            // 
            // tsPrestamo
            // 
            this.tsPrestamo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPrestarJ,
            this.tsEntregarJ});
            this.tsPrestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsPrestamo.Image = global::ProyectoVideojuegos.Properties.Resources.IcoPrestamos;
            this.tsPrestamo.Name = "tsPrestamo";
            this.tsPrestamo.Size = new System.Drawing.Size(150, 29);
            this.tsPrestamo.Text = "Prestamos";
            // 
            // tsPrestarJ
            // 
            this.tsPrestarJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.tsPrestarJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsPrestarJ.Name = "tsPrestarJ";
            this.tsPrestarJ.Size = new System.Drawing.Size(251, 30);
            this.tsPrestarJ.Text = "Prestar Juego";
            this.tsPrestarJ.Click += new System.EventHandler(this.tsPrestarJ_Click);
            // 
            // tsEntregarJ
            // 
            this.tsEntregarJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.tsEntregarJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsEntregarJ.Name = "tsEntregarJ";
            this.tsEntregarJ.Size = new System.Drawing.Size(251, 30);
            this.tsEntregarJ.Text = "Entregar Juego";
            // 
            // tsWeb
            // 
            this.tsWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsWeb.Image = global::ProyectoVideojuegos.Properties.Resources.Icoweb;
            this.tsWeb.Name = "tsWeb";
            this.tsWeb.Size = new System.Drawing.Size(139, 29);
            this.tsWeb.Text = "Pag. Web";
            this.tsWeb.Click += new System.EventHandler(this.tsWeb_Click);
            // 
            // tsCerrarSes
            // 
            this.tsCerrarSes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tsCerrarSes.Image = global::ProyectoVideojuegos.Properties.Resources.IcoCerrar;
            this.tsCerrarSes.Name = "tsCerrarSes";
            this.tsCerrarSes.Size = new System.Drawing.Size(185, 29);
            this.tsCerrarSes.Text = "Cerrar Sesión";
            this.tsCerrarSes.Click += new System.EventHandler(this.tsCerrarSes_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.salirToolStripMenuItem.Image = global::ProyectoVideojuegos.Properties.Resources.IcoSalir;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 198);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1647, 576);
            this.pnlPrincipal.TabIndex = 36;
            // 
            // timerHora
            // 
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // pnlSup
            // 
            this.pnlSup.BackColor = System.Drawing.Color.White;
            this.pnlSup.BackgroundImage = global::ProyectoVideojuegos.Properties.Resources.img2;
            this.pnlSup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlSup.Controls.Add(this.pbTiempo);
            this.pnlSup.Controls.Add(this.lblHora);
            this.pnlSup.Controls.Add(this.pictureBox1);
            this.pnlSup.Controls.Add(this.pbTitulo);
            this.pnlSup.Controls.Add(this.lblFecha);
            this.pnlSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSup.Location = new System.Drawing.Point(0, 33);
            this.pnlSup.Name = "pnlSup";
            this.pnlSup.Size = new System.Drawing.Size(1647, 165);
            this.pnlSup.TabIndex = 35;
            // 
            // pbTiempo
            // 
            this.pbTiempo.BackColor = System.Drawing.Color.Transparent;
            this.pbTiempo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbTiempo.Image = global::ProyectoVideojuegos.Properties.Resources.IconoReloj;
            this.pbTiempo.Location = new System.Drawing.Point(1449, 23);
            this.pbTiempo.Name = "pbTiempo";
            this.pbTiempo.Size = new System.Drawing.Size(90, 88);
            this.pbTiempo.TabIndex = 9;
            this.pbTiempo.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHora.Location = new System.Drawing.Point(1567, 34);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 52);
            this.lblHora.TabIndex = 8;
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ProyectoVideojuegos.Properties.Resources.IconoFecha;
            this.pictureBox1.Location = new System.Drawing.Point(688, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 88);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pbTitulo
            // 
            this.pbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pbTitulo.Image = global::ProyectoVideojuegos.Properties.Resources.TituloEmpresa;
            this.pbTitulo.InitialImage = null;
            this.pbTitulo.Location = new System.Drawing.Point(30, 23);
            this.pbTitulo.Name = "pbTitulo";
            this.pbTitulo.Size = new System.Drawing.Size(569, 125);
            this.pbTitulo.TabIndex = 5;
            this.pbTitulo.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFecha.Location = new System.Drawing.Point(806, 34);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 52);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 774);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlSup);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMaestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMaestro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMaestro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlSup.ResumeLayout(false);
            this.pnlSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsInicio;
        private System.Windows.Forms.ToolStripMenuItem tsConsulta;
        private System.Windows.Forms.ToolStripMenuItem tsNombCod;
        private System.Windows.Forms.ToolStripMenuItem tsTodosJuegos;
        private System.Windows.Forms.ToolStripMenuItem tsPrestamo;
        private System.Windows.Forms.ToolStripMenuItem tsPrestarJ;
        private System.Windows.Forms.ToolStripMenuItem tsEntregarJ;
        private System.Windows.Forms.ToolStripMenuItem tsCerrarSes;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel pnlSup;
        private System.Windows.Forms.PictureBox pbTiempo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.ToolStripMenuItem tsActualizar;
        private System.Windows.Forms.ToolStripMenuItem tsIngresarJuego;
        private System.Windows.Forms.ToolStripMenuItem tsActJuego;
        private System.Windows.Forms.ToolStripMenuItem tsElimJuego;
        private System.Windows.Forms.ToolStripMenuItem tsPermisos;
        private System.Windows.Forms.ToolStripMenuItem tsPer;
        private System.Windows.Forms.ToolStripMenuItem tsMaestro;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem smPrestaUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsJuegoDesar;
        private System.Windows.Forms.ToolStripMenuItem tsJuegDesarr;
        private System.Windows.Forms.ToolStripMenuItem tsWeb;
        private System.Windows.Forms.ToolStripMenuItem tsVerUsuario;
    }
}
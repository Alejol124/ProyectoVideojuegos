namespace ProyectoVideojuegos.Vista
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.pnlSup = new System.Windows.Forms.Panel();
            this.pbTiempo = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbTitulo = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCrearU = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.pnlSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).BeginInit();
            this.pnlLateral.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlSup.Location = new System.Drawing.Point(0, 0);
            this.pnlSup.Name = "pnlSup";
            this.pnlSup.Size = new System.Drawing.Size(1924, 220);
            this.pnlSup.TabIndex = 34;
            // 
            // pbTiempo
            // 
            this.pbTiempo.BackColor = System.Drawing.Color.Transparent;
            this.pbTiempo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbTiempo.Image = global::ProyectoVideojuegos.Properties.Resources.IconoReloj;
            this.pbTiempo.Location = new System.Drawing.Point(1481, 60);
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
            this.lblHora.Location = new System.Drawing.Point(1599, 71);
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
            this.pictureBox1.Location = new System.Drawing.Point(720, 60);
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
            this.lblFecha.Location = new System.Drawing.Point(838, 71);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 52);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(63)))));
            this.pnlLateral.Controls.Add(this.btnSalir);
            this.pnlLateral.Controls.Add(this.btnCrearU);
            this.pnlLateral.Controls.Add(this.btnIngresar);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 220);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(326, 835);
            this.pnlLateral.TabIndex = 35;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::ProyectoVideojuegos.Properties.Resources.IconoSalir;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 745);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(326, 90);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Salir programa";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // btnCrearU
            // 
            this.btnCrearU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btnCrearU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearU.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearU.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearU.ForeColor = System.Drawing.Color.White;
            this.btnCrearU.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearU.Image")));
            this.btnCrearU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearU.Location = new System.Drawing.Point(0, 90);
            this.btnCrearU.Name = "btnCrearU";
            this.btnCrearU.Size = new System.Drawing.Size(326, 90);
            this.btnCrearU.TabIndex = 36;
            this.btnCrearU.Text = "Crear Usuario";
            this.btnCrearU.UseVisualStyleBackColor = false;
            this.btnCrearU.Click += new System.EventHandler(this.btnCrearU_Click);
            this.btnCrearU.MouseEnter += new System.EventHandler(this.btnCrearU_MouseEnter);
            this.btnCrearU.MouseLeave += new System.EventHandler(this.btnCrearU_MouseLeave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIngresar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Image = global::ProyectoVideojuegos.Properties.Resources.IconoIngresar;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(0, 0);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(326, 90);
            this.btnIngresar.TabIndex = 36;
            this.btnIngresar.Text = "Inic. Sesion";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            this.btnIngresar.MouseEnter += new System.EventHandler(this.btnIngresar_MouseEnter);
            this.btnIngresar.MouseLeave += new System.EventHandler(this.btnIngresar_MouseLeave);
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.Location = new System.Drawing.Point(326, 220);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(1598, 835);
            this.pnPrincipal.TabIndex = 36;
            this.pnPrincipal.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnPrincipal_ControlRemoved);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.pnlSup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSup.ResumeLayout(false);
            this.pnlSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTitulo)).EndInit();
            this.pnlLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Panel pnlSup;
        private System.Windows.Forms.PictureBox pbTiempo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCrearU;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnPrincipal;
    }
}
namespace ProyectoVideojuegos.Vista
{
    partial class MuestraJuego
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPortada = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCreador = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblPlatf = new System.Windows.Forms.Label();
            this.lblPrestado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnPrestar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPortada
            // 
            this.pbPortada.BackColor = System.Drawing.Color.White;
            this.pbPortada.Location = new System.Drawing.Point(132, 19);
            this.pbPortada.Name = "pbPortada";
            this.pbPortada.Size = new System.Drawing.Size(283, 304);
            this.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortada.TabIndex = 0;
            this.pbPortada.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(3, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plataformas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Creador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(3, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Género:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(91, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(77, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "12321";
            // 
            // lblCreador
            // 
            this.lblCreador.AutoSize = true;
            this.lblCreador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.lblCreador.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreador.ForeColor = System.Drawing.Color.White;
            this.lblCreador.Location = new System.Drawing.Point(117, 46);
            this.lblCreador.Name = "lblCreador";
            this.lblCreador.Size = new System.Drawing.Size(51, 25);
            this.lblCreador.TabIndex = 6;
            this.lblCreador.Text = "123";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.lblGenero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(109, 89);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(90, 25);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "123123";
            // 
            // lblPlatf
            // 
            this.lblPlatf.AutoSize = true;
            this.lblPlatf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.lblPlatf.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatf.ForeColor = System.Drawing.Color.White;
            this.lblPlatf.Location = new System.Drawing.Point(164, 128);
            this.lblPlatf.Name = "lblPlatf";
            this.lblPlatf.Size = new System.Drawing.Size(77, 25);
            this.lblPlatf.TabIndex = 8;
            this.lblPlatf.Text = "12321";
            // 
            // lblPrestado
            // 
            this.lblPrestado.AutoSize = true;
            this.lblPrestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.lblPrestado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestado.ForeColor = System.Drawing.Color.White;
            this.lblPrestado.Location = new System.Drawing.Point(129, 174);
            this.lblPrestado.Name = "lblPrestado";
            this.lblPrestado.Size = new System.Drawing.Size(77, 25);
            this.lblPrestado.TabIndex = 10;
            this.lblPrestado.Text = "12312";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(3, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Prestado:";
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.pnlDatos.Controls.Add(this.btnPrestar);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Controls.Add(this.lblPrestado);
            this.pnlDatos.Controls.Add(this.label3);
            this.pnlDatos.Controls.Add(this.lblPlatf);
            this.pnlDatos.Controls.Add(this.label6);
            this.pnlDatos.Controls.Add(this.lblGenero);
            this.pnlDatos.Controls.Add(this.label4);
            this.pnlDatos.Controls.Add(this.lblCreador);
            this.pnlDatos.Controls.Add(this.label2);
            this.pnlDatos.Controls.Add(this.lblTitulo);
            this.pnlDatos.Location = new System.Drawing.Point(18, 342);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(509, 236);
            this.pnlDatos.TabIndex = 11;
            // 
            // btnPrestar
            // 
            this.btnPrestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrestar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPrestar.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestar.ForeColor = System.Drawing.Color.White;
            this.btnPrestar.Location = new System.Drawing.Point(292, 174);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(204, 49);
            this.btnPrestar.TabIndex = 11;
            this.btnPrestar.Text = "Prestar";
            this.btnPrestar.UseVisualStyleBackColor = false;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            this.btnPrestar.MouseEnter += new System.EventHandler(this.btnPrestar_MouseEnter);
            this.btnPrestar.MouseLeave += new System.EventHandler(this.btnPrestar_MouseLeave);
            // 
            // MuestraJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pbPortada);
            this.Name = "MuestraJuego";
            this.Size = new System.Drawing.Size(546, 595);
            this.Load += new System.EventHandler(this.MuestraJuego_Load);
            this.MouseEnter += new System.EventHandler(this.MuestraJuego_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MuestraJuego_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbPortada)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPortada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCreador;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblPlatf;
        private System.Windows.Forms.Label lblPrestado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnPrestar;
    }
}

namespace ProyectoVideojuegos.Vista.Crud
{
    partial class FormPermisos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInfor = new System.Windows.Forms.Panel();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblSelec = new System.Windows.Forms.Label();
            this.brCliente = new System.Windows.Forms.RadioButton();
            this.brAdmin = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblIngrese = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlInfor.SuspendLayout();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1614, 123);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(550, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cambiar Permisos";
            // 
            // pnlInfor
            // 
            this.pnlInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.pnlInfor.Controls.Add(this.gbInfo);
            this.pnlInfor.Controls.Add(this.btnBuscar);
            this.pnlInfor.Controls.Add(this.lblIngrese);
            this.pnlInfor.Controls.Add(this.txtDocumento);
            this.pnlInfor.Controls.Add(this.lblInfo);
            this.pnlInfor.Controls.Add(this.label3);
            this.pnlInfor.Location = new System.Drawing.Point(129, 144);
            this.pnlInfor.Name = "pnlInfor";
            this.pnlInfor.Size = new System.Drawing.Size(1018, 243);
            this.pnlInfor.TabIndex = 11;
            // 
            // gbInfo
            // 
            this.gbInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbInfo.Controls.Add(this.btnConfirmar);
            this.gbInfo.Controls.Add(this.lblSelec);
            this.gbInfo.Controls.Add(this.brCliente);
            this.gbInfo.Controls.Add(this.brAdmin);
            this.gbInfo.Location = new System.Drawing.Point(535, 3);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(471, 237);
            this.gbInfo.TabIndex = 18;
            this.gbInfo.TabStop = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(70, 168);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(324, 49);
            this.btnConfirmar.TabIndex = 21;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblSelec
            // 
            this.lblSelec.AutoSize = true;
            this.lblSelec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.lblSelec.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelec.ForeColor = System.Drawing.Color.White;
            this.lblSelec.Location = new System.Drawing.Point(49, 18);
            this.lblSelec.Name = "lblSelec";
            this.lblSelec.Size = new System.Drawing.Size(355, 68);
            this.lblSelec.TabIndex = 20;
            this.lblSelec.Text = "Seleccione el nuevo Rol\r\npara el usuario";
            this.lblSelec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brCliente
            // 
            this.brCliente.AutoSize = true;
            this.brCliente.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brCliente.ForeColor = System.Drawing.Color.White;
            this.brCliente.Location = new System.Drawing.Point(47, 108);
            this.brCliente.Name = "brCliente";
            this.brCliente.Size = new System.Drawing.Size(113, 32);
            this.brCliente.TabIndex = 18;
            this.brCliente.TabStop = true;
            this.brCliente.Text = "Cliente";
            this.brCliente.UseVisualStyleBackColor = true;
            this.brCliente.Click += new System.EventHandler(this.brCliente_Click);
            // 
            // brAdmin
            // 
            this.brAdmin.AutoSize = true;
            this.brAdmin.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brAdmin.ForeColor = System.Drawing.Color.White;
            this.brAdmin.Location = new System.Drawing.Point(228, 108);
            this.brAdmin.Name = "brAdmin";
            this.brAdmin.Size = new System.Drawing.Size(200, 32);
            this.brAdmin.TabIndex = 19;
            this.brAdmin.TabStop = true;
            this.brAdmin.Text = "Administrativo";
            this.brAdmin.UseVisualStyleBackColor = true;
            this.brAdmin.CheckedChanged += new System.EventHandler(this.brAdmin_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(24, 159);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(468, 49);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar usuario";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblIngrese
            // 
            this.lblIngrese.AutoSize = true;
            this.lblIngrese.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.lblIngrese.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrese.ForeColor = System.Drawing.Color.White;
            this.lblIngrese.Location = new System.Drawing.Point(32, 100);
            this.lblIngrese.Name = "lblIngrese";
            this.lblIngrese.Size = new System.Drawing.Size(0, 34);
            this.lblIngrese.TabIndex = 16;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(24, 66);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(468, 40);
            this.txtDocumento.TabIndex = 15;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.lblInfo.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(32, 159);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 34);
            this.lblInfo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(496, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingrese el documento del usuario";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(129, 423);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.RowHeadersWidth = 51;
            this.dgvUsuario.RowTemplate.Height = 24;
            this.dgvUsuario.Size = new System.Drawing.Size(1018, 284);
            this.dgvUsuario.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoVideojuegos.Properties.Resources.ImgCambioRol;
            this.pictureBox1.Location = new System.Drawing.Point(1305, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 564);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FormPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1614, 751);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.pnlInfor);
            this.Controls.Add(this.panel1);
            this.Name = "FormPermisos";
            this.Text = "FormPermisos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlInfor.ResumeLayout(false);
            this.pnlInfor.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlInfor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblIngrese;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblSelec;
        private System.Windows.Forms.RadioButton brAdmin;
        private System.Windows.Forms.RadioButton brCliente;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
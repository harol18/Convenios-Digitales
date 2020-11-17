namespace Usuarios_planta
{
    partial class FormEnvio_Correos
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
            this.Txtcod_convenio = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.dgvCorreos = new System.Windows.Forms.DataGridView();
            this.label38 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.TxtDestinatario_Correo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAsunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblhoy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCopiar_Monto_letras = new System.Windows.Forms.PictureBox();
            this.Btnbuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCopiar_Monto_letras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnbuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtcod_convenio
            // 
            this.Txtcod_convenio.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcod_convenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcod_convenio.Location = new System.Drawing.Point(314, 83);
            this.Txtcod_convenio.Multiline = true;
            this.Txtcod_convenio.Name = "Txtcod_convenio";
            this.Txtcod_convenio.Size = new System.Drawing.Size(119, 28);
            this.Txtcod_convenio.TabIndex = 31;
            this.Txtcod_convenio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label30.Location = new System.Drawing.Point(259, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(253, 24);
            this.label30.TabIndex = 248;
            this.label30.Text = "Gestion Correos VoBo Digital";
            // 
            // dgvCorreos
            // 
            this.dgvCorreos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorreos.Location = new System.Drawing.Point(12, 108);
            this.dgvCorreos.Name = "dgvCorreos";
            this.dgvCorreos.Size = new System.Drawing.Size(210, 356);
            this.dgvCorreos.TabIndex = 251;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label38.Location = new System.Drawing.Point(12, 54);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(189, 18);
            this.label38.TabIndex = 250;
            this.label38.Text = "Pendientes Envio Convenio";
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(314, 245);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(461, 219);
            this.dgvDatos.TabIndex = 253;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(311, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 252;
            this.label1.Text = "Codigo Convenio";
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.Btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo.ForeColor = System.Drawing.Color.White;
            this.Btn_Nuevo.Location = new System.Drawing.Point(681, 470);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(94, 27);
            this.Btn_Nuevo.TabIndex = 254;
            this.Btn_Nuevo.Text = "Descargar";
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            // 
            // TxtDestinatario_Correo
            // 
            this.TxtDestinatario_Correo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDestinatario_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDestinatario_Correo.Location = new System.Drawing.Point(313, 138);
            this.TxtDestinatario_Correo.Multiline = true;
            this.TxtDestinatario_Correo.Name = "TxtDestinatario_Correo";
            this.TxtDestinatario_Correo.Size = new System.Drawing.Size(328, 28);
            this.TxtDestinatario_Correo.TabIndex = 255;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(310, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 256;
            this.label2.Text = "Destinatario";
            // 
            // TxtAsunto
            // 
            this.TxtAsunto.BackColor = System.Drawing.SystemColors.Window;
            this.TxtAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAsunto.Location = new System.Drawing.Point(313, 194);
            this.TxtAsunto.Multiline = true;
            this.TxtAsunto.Name = "TxtAsunto";
            this.TxtAsunto.Size = new System.Drawing.Size(328, 28);
            this.TxtAsunto.TabIndex = 257;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(310, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 258;
            this.label3.Text = "Asunto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(310, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 259;
            this.label4.Text = "Datos";
            // 
            // lblhoy
            // 
            this.lblhoy.AutoSize = true;
            this.lblhoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.lblhoy.Location = new System.Drawing.Point(599, 9);
            this.lblhoy.Name = "lblhoy";
            this.lblhoy.Size = new System.Drawing.Size(0, 16);
            this.lblhoy.TabIndex = 260;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Usuarios_planta.Properties.Resources.copy_64px;
            this.pictureBox1.Location = new System.Drawing.Point(647, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 262;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnCopiar_Monto_letras
            // 
            this.BtnCopiar_Monto_letras.BackColor = System.Drawing.SystemColors.Window;
            this.BtnCopiar_Monto_letras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCopiar_Monto_letras.Image = global::Usuarios_planta.Properties.Resources.copy_64px;
            this.BtnCopiar_Monto_letras.Location = new System.Drawing.Point(647, 140);
            this.BtnCopiar_Monto_letras.Name = "BtnCopiar_Monto_letras";
            this.BtnCopiar_Monto_letras.Size = new System.Drawing.Size(25, 25);
            this.BtnCopiar_Monto_letras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCopiar_Monto_letras.TabIndex = 261;
            this.BtnCopiar_Monto_letras.TabStop = false;
            this.BtnCopiar_Monto_letras.Click += new System.EventHandler(this.BtnCopiar_Monto_letras_Click);
            // 
            // Btnbuscar
            // 
            this.Btnbuscar.BackColor = System.Drawing.SystemColors.Window;
            this.Btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnbuscar.Image = global::Usuarios_planta.Properties.Resources.search_26px;
            this.Btnbuscar.Location = new System.Drawing.Point(409, 84);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(23, 26);
            this.Btnbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btnbuscar.TabIndex = 32;
            this.Btnbuscar.TabStop = false;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // FormEnvio_Correos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCopiar_Monto_letras);
            this.Controls.Add(this.lblhoy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAsunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDestinatario_Correo);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCorreos);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.Btnbuscar);
            this.Controls.Add(this.Txtcod_convenio);
            this.Name = "FormEnvio_Correos";
            this.Text = "FormEnvio_Correos";
            this.Load += new System.EventHandler(this.FormEnvio_Correos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCopiar_Monto_letras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnbuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Btnbuscar;
        private System.Windows.Forms.TextBox Txtcod_convenio;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView dgvCorreos;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.TextBox TxtDestinatario_Correo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAsunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblhoy;
        private System.Windows.Forms.PictureBox BtnCopiar_Monto_letras;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
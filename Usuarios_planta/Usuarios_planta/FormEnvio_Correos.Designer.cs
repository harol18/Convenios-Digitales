﻿namespace Usuarios_planta
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
            this.dgvCorreos_Pendientes = new System.Windows.Forms.DataGridView();
            this.label38 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDestinatario_Correo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAsunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCopiar_Monto_letras = new System.Windows.Forms.PictureBox();
            this.Btnbuscar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpHora_Envio = new System.Windows.Forms.DateTimePicker();
            this.label34 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtCorreo_Gic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDescargar_Excel = new FontAwesome.Sharp.IconButton();
            this.btnActualizar_BD = new FontAwesome.Sharp.IconButton();
            this.btnEnviar_Correo = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVer_pte_Correos = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombre_Archivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreos_Pendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCopiar_Monto_letras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnbuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txtcod_convenio
            // 
            this.Txtcod_convenio.BackColor = System.Drawing.SystemColors.Window;
            this.Txtcod_convenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcod_convenio.Location = new System.Drawing.Point(15, 25);
            this.Txtcod_convenio.Multiline = true;
            this.Txtcod_convenio.Name = "Txtcod_convenio";
            this.Txtcod_convenio.Size = new System.Drawing.Size(119, 28);
            this.Txtcod_convenio.TabIndex = 31;
            this.Txtcod_convenio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txtcod_convenio.TextChanged += new System.EventHandler(this.Txtcod_convenio_TextChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label30.Location = new System.Drawing.Point(315, 35);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(292, 25);
            this.label30.TabIndex = 248;
            this.label30.Text = "Gestion Correos VoBo Digital";
            // 
            // dgvCorreos_Pendientes
            // 
            this.dgvCorreos_Pendientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvCorreos_Pendientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCorreos_Pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorreos_Pendientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCorreos_Pendientes.Location = new System.Drawing.Point(675, 103);
            this.dgvCorreos_Pendientes.Name = "dgvCorreos_Pendientes";
            this.dgvCorreos_Pendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCorreos_Pendientes.RowHeadersVisible = false;
            this.dgvCorreos_Pendientes.Size = new System.Drawing.Size(294, 341);
            this.dgvCorreos_Pendientes.TabIndex = 251;
            this.dgvCorreos_Pendientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCorreos_Pendientes_CellClick);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label38.Location = new System.Drawing.Point(672, 75);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(189, 18);
            this.label38.TabIndex = 250;
            this.label38.Text = "Pendientes Envio Convenio";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(15, 88);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.Size = new System.Drawing.Size(475, 237);
            this.dgvDatos.TabIndex = 253;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 252;
            this.label1.Text = "Codigo Convenio";
            // 
            // TxtDestinatario_Correo
            // 
            this.TxtDestinatario_Correo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDestinatario_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDestinatario_Correo.Location = new System.Drawing.Point(24, 469);
            this.TxtDestinatario_Correo.Multiline = true;
            this.TxtDestinatario_Correo.Name = "TxtDestinatario_Correo";
            this.TxtDestinatario_Correo.Size = new System.Drawing.Size(290, 28);
            this.TxtDestinatario_Correo.TabIndex = 255;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(21, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 256;
            this.label2.Text = "Destinatario";
            // 
            // TxtAsunto
            // 
            this.TxtAsunto.BackColor = System.Drawing.SystemColors.Window;
            this.TxtAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAsunto.Location = new System.Drawing.Point(690, 469);
            this.TxtAsunto.Multiline = true;
            this.TxtAsunto.Name = "TxtAsunto";
            this.TxtAsunto.Size = new System.Drawing.Size(248, 28);
            this.TxtAsunto.TabIndex = 257;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(687, 450);
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
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 259;
            this.label4.Text = "Datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Usuarios_planta.Properties.Resources.copy_64px;
            this.pictureBox1.Location = new System.Drawing.Point(944, 469);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 262;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCopiar_Monto_letras
            // 
            this.BtnCopiar_Monto_letras.BackColor = System.Drawing.SystemColors.Window;
            this.BtnCopiar_Monto_letras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCopiar_Monto_letras.Image = global::Usuarios_planta.Properties.Resources.copy_64px;
            this.BtnCopiar_Monto_letras.Location = new System.Drawing.Point(320, 469);
            this.BtnCopiar_Monto_letras.Name = "BtnCopiar_Monto_letras";
            this.BtnCopiar_Monto_letras.Size = new System.Drawing.Size(25, 25);
            this.BtnCopiar_Monto_letras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCopiar_Monto_letras.TabIndex = 261;
            this.BtnCopiar_Monto_letras.TabStop = false;
            // 
            // Btnbuscar
            // 
            this.Btnbuscar.BackColor = System.Drawing.SystemColors.Window;
            this.Btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnbuscar.Image = global::Usuarios_planta.Properties.Resources.search_26px;
            this.Btnbuscar.Location = new System.Drawing.Point(110, 26);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(23, 26);
            this.Btnbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btnbuscar.TabIndex = 32;
            this.Btnbuscar.TabStop = false;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(187)))), ((int)(((byte)(33)))));
            this.panel1.Location = new System.Drawing.Point(771, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 16);
            this.panel1.TabIndex = 263;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(101)))), ((int)(((byte)(124)))));
            this.panel2.Location = new System.Drawing.Point(419, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 16);
            this.panel2.TabIndex = 264;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 16);
            this.panel3.TabIndex = 265;
            // 
            // dtpHora_Envio
            // 
            this.dtpHora_Envio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpHora_Envio.CustomFormat = "HH:mm";
            this.dtpHora_Envio.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F);
            this.dtpHora_Envio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora_Envio.Location = new System.Drawing.Point(152, 26);
            this.dtpHora_Envio.Name = "dtpHora_Envio";
            this.dtpHora_Envio.Size = new System.Drawing.Size(121, 27);
            this.dtpHora_Envio.TabIndex = 266;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label34.Location = new System.Drawing.Point(149, 7);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(75, 16);
            this.label34.TabIndex = 267;
            this.label34.Text = "Hora Envio";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.lblfecha.Location = new System.Drawing.Point(821, 35);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(0, 16);
            this.lblfecha.TabIndex = 268;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Usuarios_planta.Properties.Resources.copy_64px;
            this.pictureBox2.Location = new System.Drawing.Point(655, 469);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 270;
            this.pictureBox2.TabStop = false;
            // 
            // TxtCorreo_Gic
            // 
            this.TxtCorreo_Gic.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCorreo_Gic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo_Gic.Location = new System.Drawing.Point(351, 466);
            this.TxtCorreo_Gic.Multiline = true;
            this.TxtCorreo_Gic.Name = "TxtCorreo_Gic";
            this.TxtCorreo_Gic.Size = new System.Drawing.Size(298, 28);
            this.TxtCorreo_Gic.TabIndex = 269;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(349, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 271;
            this.label5.Text = "Correo Gic";
            // 
            // btnDescargar_Excel
            // 
            this.btnDescargar_Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.btnDescargar_Excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescargar_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar_Excel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDescargar_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar_Excel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDescargar_Excel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnDescargar_Excel.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDescargar_Excel.IconSize = 19;
            this.btnDescargar_Excel.Location = new System.Drawing.Point(497, 88);
            this.btnDescargar_Excel.Name = "btnDescargar_Excel";
            this.btnDescargar_Excel.Rotation = 0D;
            this.btnDescargar_Excel.Size = new System.Drawing.Size(122, 30);
            this.btnDescargar_Excel.TabIndex = 274;
            this.btnDescargar_Excel.Text = "Exp. Excel";
            this.btnDescargar_Excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargar_Excel.UseVisualStyleBackColor = false;
            this.btnDescargar_Excel.Click += new System.EventHandler(this.btnDescargar_Excel_Click);
            // 
            // btnActualizar_BD
            // 
            this.btnActualizar_BD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.btnActualizar_BD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar_BD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar_BD.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnActualizar_BD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar_BD.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnActualizar_BD.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnActualizar_BD.IconColor = System.Drawing.Color.Gainsboro;
            this.btnActualizar_BD.IconSize = 19;
            this.btnActualizar_BD.Location = new System.Drawing.Point(497, 124);
            this.btnActualizar_BD.Name = "btnActualizar_BD";
            this.btnActualizar_BD.Rotation = 0D;
            this.btnActualizar_BD.Size = new System.Drawing.Size(122, 30);
            this.btnActualizar_BD.TabIndex = 275;
            this.btnActualizar_BD.Text = "Actualizar bd";
            this.btnActualizar_BD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar_BD.UseVisualStyleBackColor = false;
            this.btnActualizar_BD.Click += new System.EventHandler(this.btnActualizar_BD_Click);
            // 
            // btnEnviar_Correo
            // 
            this.btnEnviar_Correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.btnEnviar_Correo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar_Correo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar_Correo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEnviar_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar_Correo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEnviar_Correo.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btnEnviar_Correo.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEnviar_Correo.IconSize = 19;
            this.btnEnviar_Correo.Location = new System.Drawing.Point(497, 160);
            this.btnEnviar_Correo.Name = "btnEnviar_Correo";
            this.btnEnviar_Correo.Rotation = 0D;
            this.btnEnviar_Correo.Size = new System.Drawing.Size(122, 30);
            this.btnEnviar_Correo.TabIndex = 276;
            this.btnEnviar_Correo.Text = "Enviar Correo";
            this.btnEnviar_Correo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviar_Correo.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btnEnviar_Correo);
            this.panel4.Controls.Add(this.TxtNombre_Archivo);
            this.panel4.Controls.Add(this.btnActualizar_BD);
            this.panel4.Controls.Add(this.Btnbuscar);
            this.panel4.Controls.Add(this.btnDescargar_Excel);
            this.panel4.Controls.Add(this.dgvDatos);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.Txtcod_convenio);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label34);
            this.panel4.Controls.Add(this.dtpHora_Envio);
            this.panel4.Location = new System.Drawing.Point(24, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 341);
            this.panel4.TabIndex = 277;
            // 
            // btnVer_pte_Correos
            // 
            this.btnVer_pte_Correos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.btnVer_pte_Correos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer_pte_Correos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer_pte_Correos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVer_pte_Correos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer_pte_Correos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVer_pte_Correos.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVer_pte_Correos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVer_pte_Correos.IconSize = 19;
            this.btnVer_pte_Correos.Location = new System.Drawing.Point(882, 70);
            this.btnVer_pte_Correos.Name = "btnVer_pte_Correos";
            this.btnVer_pte_Correos.Rotation = 0D;
            this.btnVer_pte_Correos.Size = new System.Drawing.Size(87, 30);
            this.btnVer_pte_Correos.TabIndex = 278;
            this.btnVer_pte_Correos.Text = "Ver";
            this.btnVer_pte_Correos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVer_pte_Correos.UseVisualStyleBackColor = false;
            this.btnVer_pte_Correos.Click += new System.EventHandler(this.btnVer_pte_Correos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(283, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 280;
            this.label6.Text = "Nombre Archivo";
            // 
            // TxtNombre_Archivo
            // 
            this.TxtNombre_Archivo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombre_Archivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre_Archivo.Location = new System.Drawing.Point(285, 27);
            this.TxtNombre_Archivo.Multiline = true;
            this.TxtNombre_Archivo.Name = "TxtNombre_Archivo";
            this.TxtNombre_Archivo.Size = new System.Drawing.Size(205, 28);
            this.TxtNombre_Archivo.TabIndex = 279;
            // 
            // FormEnvio_Correos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 519);
            this.Controls.Add(this.btnVer_pte_Correos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TxtCorreo_Gic);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCopiar_Monto_letras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAsunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDestinatario_Correo);
            this.Controls.Add(this.dgvCorreos_Pendientes);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.panel4);
            this.MinimizeBox = false;
            this.Name = "FormEnvio_Correos";
            this.Text = "FormEnvio_Correos";
            this.Load += new System.EventHandler(this.FormEnvio_Correos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreos_Pendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCopiar_Monto_letras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btnbuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Btnbuscar;
        private System.Windows.Forms.TextBox Txtcod_convenio;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataGridView dgvCorreos_Pendientes;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDestinatario_Correo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAsunto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox BtnCopiar_Monto_letras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpHora_Envio;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtCorreo_Gic;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnDescargar_Excel;
        private FontAwesome.Sharp.IconButton btnActualizar_BD;
        private FontAwesome.Sharp.IconButton btnEnviar_Correo;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnVer_pte_Correos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNombre_Archivo;
    }
}
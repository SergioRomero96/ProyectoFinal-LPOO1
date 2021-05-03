namespace Vistas
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlPiePagina = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblApellidoyNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnPeriodos = new System.Windows.Forms.Button();
            this.btnDestinos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlPrincipal.SuspendLayout();
            this.pnlPiePagina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlContenedor);
            this.pnlPrincipal.Controls.Add(this.pnlPiePagina);
            this.pnlPrincipal.Controls.Add(this.pnlMenu);
            this.pnlPrincipal.Controls.Add(this.pnlTitulo);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1050, 600);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.pnlContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContenedor.BackgroundImage")));
            this.pnlContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(200, 40);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(850, 485);
            this.pnlContenedor.TabIndex = 3;
            // 
            // pnlPiePagina
            // 
            this.pnlPiePagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.pnlPiePagina.Controls.Add(this.lblRol);
            this.pnlPiePagina.Controls.Add(this.lblApellidoyNombre);
            this.pnlPiePagina.Controls.Add(this.lblUsuario);
            this.pnlPiePagina.Controls.Add(this.pictureBox7);
            this.pnlPiePagina.Controls.Add(this.lbFecha);
            this.pnlPiePagina.Controls.Add(this.lblHora);
            this.pnlPiePagina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPiePagina.Location = new System.Drawing.Point(200, 525);
            this.pnlPiePagina.Name = "pnlPiePagina";
            this.pnlPiePagina.Size = new System.Drawing.Size(850, 75);
            this.pnlPiePagina.TabIndex = 2;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.LightGray;
            this.lblRol.Location = new System.Drawing.Point(77, 28);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(34, 17);
            this.lblRol.TabIndex = 11;
            this.lblRol.Text = "Rol: ";
            // 
            // lblApellidoyNombre
            // 
            this.lblApellidoyNombre.AutoSize = true;
            this.lblApellidoyNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoyNombre.ForeColor = System.Drawing.Color.LightGray;
            this.lblApellidoyNombre.Location = new System.Drawing.Point(77, 47);
            this.lblApellidoyNombre.Name = "lblApellidoyNombre";
            this.lblApellidoyNombre.Size = new System.Drawing.Size(130, 17);
            this.lblApellidoyNombre.TabIndex = 10;
            this.lblApellidoyNombre.Text = "Apellido y Nombre: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.lblUsuario.Location = new System.Drawing.Point(77, 7);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 17);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario: ";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(6, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 64);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(636, 48);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(194, 17);
            this.lbFecha.TabIndex = 6;
            this.lbFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft YaHei UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(632, 8);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(164, 46);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "21:49:45";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.pnlMenu.Controls.Add(this.pictureBox11);
            this.pnlMenu.Controls.Add(this.pictureBox9);
            this.pnlMenu.Controls.Add(this.pictureBox6);
            this.pnlMenu.Controls.Add(this.pictureBox5);
            this.pnlMenu.Controls.Add(this.pictureBox4);
            this.pnlMenu.Controls.Add(this.pictureBox3);
            this.pnlMenu.Controls.Add(this.pictureBox2);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.btnCerrarSesion);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.btnPagos);
            this.pnlMenu.Controls.Add(this.btnPrestamos);
            this.pnlMenu.Controls.Add(this.btnPeriodos);
            this.pnlMenu.Controls.Add(this.btnDestinos);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 560);
            this.pnlMenu.TabIndex = 1;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox11.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox11.Location = new System.Drawing.Point(-1, 508);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(4, 40);
            this.pictureBox11.TabIndex = 18;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox9.Location = new System.Drawing.Point(-1, 357);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(4, 40);
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox6.Location = new System.Drawing.Point(-1, 311);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(4, 40);
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox5.Location = new System.Drawing.Point(-1, 265);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(4, 40);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox4.Location = new System.Drawing.Point(-1, 219);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(4, 40);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 173);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(4, 40);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(4, 40);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(4, 40);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 508);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 40);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 357);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(200, 40);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPagos.Image = ((System.Drawing.Image)(resources.GetObject("btnPagos.Image")));
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(0, 311);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPagos.Size = new System.Drawing.Size(200, 40);
            this.btnPagos.TabIndex = 6;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.FlatAppearance.BorderSize = 0;
            this.btnPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrestamos.Image = ((System.Drawing.Image)(resources.GetObject("btnPrestamos.Image")));
            this.btnPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamos.Location = new System.Drawing.Point(0, 265);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPrestamos.Size = new System.Drawing.Size(200, 40);
            this.btnPrestamos.TabIndex = 5;
            this.btnPrestamos.Text = "Préstamos";
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnPeriodos
            // 
            this.btnPeriodos.FlatAppearance.BorderSize = 0;
            this.btnPeriodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnPeriodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPeriodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriodos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPeriodos.Image = ((System.Drawing.Image)(resources.GetObject("btnPeriodos.Image")));
            this.btnPeriodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeriodos.Location = new System.Drawing.Point(0, 219);
            this.btnPeriodos.Name = "btnPeriodos";
            this.btnPeriodos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPeriodos.Size = new System.Drawing.Size(200, 40);
            this.btnPeriodos.TabIndex = 4;
            this.btnPeriodos.Text = "Periodos";
            this.btnPeriodos.UseVisualStyleBackColor = true;
            this.btnPeriodos.Click += new System.EventHandler(this.btnPeriodos_Click);
            // 
            // btnDestinos
            // 
            this.btnDestinos.FlatAppearance.BorderSize = 0;
            this.btnDestinos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnDestinos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestinos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDestinos.Image = ((System.Drawing.Image)(resources.GetObject("btnDestinos.Image")));
            this.btnDestinos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDestinos.Location = new System.Drawing.Point(0, 173);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDestinos.Size = new System.Drawing.Size(200, 40);
            this.btnDestinos.TabIndex = 3;
            this.btnDestinos.Text = "Destinos";
            this.btnDestinos.UseVisualStyleBackColor = true;
            this.btnDestinos.Click += new System.EventHandler(this.btnDestinos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 127);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(200, 40);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 81);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(200, 40);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(154, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 40);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlTitulo.Controls.Add(this.pictureBox8);
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Controls.Add(this.btnRestaurar);
            this.pnlTitulo.Controls.Add(this.btnMinimizar);
            this.pnlTitulo.Controls.Add(this.btnMaximizar);
            this.pnlTitulo.Controls.Add(this.btnCerrar);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1050, 40);
            this.pnlTitulo.TabIndex = 0;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(8, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "SISTEMA GESTIÓN DE PRÉSTAMO";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(968, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(40, 40);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(926, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(968, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(40, 40);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1010, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Financiero";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyUp);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPiePagina.ResumeLayout(false);
            this.pnlPiePagina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmFechaHora;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlPiePagina;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblApellidoyNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnPeriodos;
        private System.Windows.Forms.Button btnDestinos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox11;

    }
}
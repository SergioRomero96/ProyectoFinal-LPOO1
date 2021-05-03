namespace Vistas
{
    partial class FrmGestionPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionPrestamo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbDefecto = new System.Windows.Forms.RadioButton();
            this.gbDestino = new System.Windows.Forms.GroupBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.btnBuscarDestino = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.rbDestino = new System.Windows.Forms.RadioButton();
            this.dgwPrestamos = new System.Windows.Forms.DataGridView();
            this.btnVerCuotas = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBuscar = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaF = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaI = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGestPrest = new System.Windows.Forms.Label();
            this.gbContar = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAnulados = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCancelados = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPendientes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOtorgados = new System.Windows.Forms.TextBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.gbDestino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrestamos)).BeginInit();
            this.groupBuscar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbContar.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDefecto
            // 
            this.rbDefecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDefecto.AutoSize = true;
            this.rbDefecto.Checked = true;
            this.rbDefecto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDefecto.Location = new System.Drawing.Point(712, 78);
            this.rbDefecto.Name = "rbDefecto";
            this.rbDefecto.Size = new System.Drawing.Size(75, 21);
            this.rbDefecto.TabIndex = 47;
            this.rbDefecto.TabStop = true;
            this.rbDefecto.Text = "Defecto";
            this.rbDefecto.UseVisualStyleBackColor = true;
            this.rbDefecto.CheckedChanged += new System.EventHandler(this.rbDefecto_CheckedChanged);
            // 
            // gbDestino
            // 
            this.gbDestino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDestino.Controls.Add(this.lblDestino);
            this.gbDestino.Controls.Add(this.cmbDestino);
            this.gbDestino.Controls.Add(this.btnBuscarDestino);
            this.gbDestino.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDestino.ForeColor = System.Drawing.Color.White;
            this.gbDestino.Location = new System.Drawing.Point(41, 96);
            this.gbDestino.Name = "gbDestino";
            this.gbDestino.Size = new System.Drawing.Size(750, 71);
            this.gbDestino.TabIndex = 46;
            this.gbDestino.TabStop = false;
            // 
            // lblDestino
            // 
            this.lblDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(69, 32);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(58, 17);
            this.lblDestino.TabIndex = 21;
            this.lblDestino.Text = "Destino:";
            // 
            // cmbDestino
            // 
            this.cmbDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(162, 25);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(384, 25);
            this.cmbDestino.TabIndex = 22;
            // 
            // btnBuscarDestino
            // 
            this.btnBuscarDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBuscarDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnBuscarDestino.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscarDestino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBuscarDestino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscarDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDestino.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDestino.ForeColor = System.Drawing.Color.White;
            this.btnBuscarDestino.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarDestino.Image")));
            this.btnBuscarDestino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarDestino.Location = new System.Drawing.Point(595, 21);
            this.btnBuscarDestino.Name = "btnBuscarDestino";
            this.btnBuscarDestino.Size = new System.Drawing.Size(100, 30);
            this.btnBuscarDestino.TabIndex = 23;
            this.btnBuscarDestino.Text = "Buscar";
            this.btnBuscarDestino.UseVisualStyleBackColor = false;
            this.btnBuscarDestino.Click += new System.EventHandler(this.btnBuscarDestino_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Buscar por:";
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFecha.Location = new System.Drawing.Point(148, 77);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(62, 21);
            this.rbFecha.TabIndex = 44;
            this.rbFecha.Text = "Fecha";
            this.rbFecha.UseVisualStyleBackColor = true;
            this.rbFecha.CheckedChanged += new System.EventHandler(this.rbFecha_CheckedChanged);
            // 
            // rbDestino
            // 
            this.rbDestino.AutoSize = true;
            this.rbDestino.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDestino.Location = new System.Drawing.Point(234, 77);
            this.rbDestino.Name = "rbDestino";
            this.rbDestino.Size = new System.Drawing.Size(73, 21);
            this.rbDestino.TabIndex = 43;
            this.rbDestino.Text = "Destino";
            this.rbDestino.UseVisualStyleBackColor = true;
            this.rbDestino.CheckedChanged += new System.EventHandler(this.rbDestino_CheckedChanged);
            // 
            // dgwPrestamos
            // 
            this.dgwPrestamos.AllowUserToAddRows = false;
            this.dgwPrestamos.AllowUserToDeleteRows = false;
            this.dgwPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPrestamos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwPrestamos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgwPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwPrestamos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwPrestamos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwPrestamos.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwPrestamos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwPrestamos.EnableHeadersVisualStyles = false;
            this.dgwPrestamos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgwPrestamos.Location = new System.Drawing.Point(39, 177);
            this.dgwPrestamos.Name = "dgwPrestamos";
            this.dgwPrestamos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPrestamos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwPrestamos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPrestamos.Size = new System.Drawing.Size(750, 187);
            this.dgwPrestamos.TabIndex = 42;
            this.dgwPrestamos.CurrentCellChanged += new System.EventHandler(this.dgwPrestamos_CurrentCellChanged);
            // 
            // btnVerCuotas
            // 
            this.btnVerCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVerCuotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnVerCuotas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVerCuotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnVerCuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVerCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCuotas.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCuotas.Image = ((System.Drawing.Image)(resources.GetObject("btnVerCuotas.Image")));
            this.btnVerCuotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerCuotas.Location = new System.Drawing.Point(149, 400);
            this.btnVerCuotas.Name = "btnVerCuotas";
            this.btnVerCuotas.Size = new System.Drawing.Size(100, 30);
            this.btnVerCuotas.TabIndex = 41;
            this.btnVerCuotas.Text = "Ver Cuotas";
            this.btnVerCuotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerCuotas.UseVisualStyleBackColor = false;
            this.btnVerCuotas.Click += new System.EventHandler(this.btnVerCuotas_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(39, 400);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 40;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBuscar
            // 
            this.groupBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBuscar.Controls.Add(this.btnConsultar);
            this.groupBuscar.Controls.Add(this.dtpFechaFin);
            this.groupBuscar.Controls.Add(this.lblFechaF);
            this.groupBuscar.Controls.Add(this.dtpFechaInicio);
            this.groupBuscar.Controls.Add(this.lblFechaI);
            this.groupBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBuscar.ForeColor = System.Drawing.Color.White;
            this.groupBuscar.Location = new System.Drawing.Point(41, 96);
            this.groupBuscar.Name = "groupBuscar";
            this.groupBuscar.Size = new System.Drawing.Size(750, 71);
            this.groupBuscar.TabIndex = 50;
            this.groupBuscar.TabStop = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(595, 23);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 30);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(421, 28);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(125, 23);
            this.dtpFechaFin.TabIndex = 14;
            // 
            // lblFechaF
            // 
            this.lblFechaF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFechaF.AutoSize = true;
            this.lblFechaF.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaF.Location = new System.Drawing.Point(327, 32);
            this.lblFechaF.Name = "lblFechaF";
            this.lblFechaF.Size = new System.Drawing.Size(86, 17);
            this.lblFechaF.TabIndex = 13;
            this.lblFechaF.Text = "Fecha Hasta:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpFechaInicio.CustomFormat = "";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(162, 28);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(125, 23);
            this.dtpFechaInicio.TabIndex = 12;
            // 
            // lblFechaI
            // 
            this.lblFechaI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFechaI.AutoSize = true;
            this.lblFechaI.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaI.Location = new System.Drawing.Point(63, 32);
            this.lblFechaI.Name = "lblFechaI";
            this.lblFechaI.Size = new System.Drawing.Size(89, 17);
            this.lblFechaI.TabIndex = 11;
            this.lblFechaI.Text = "Fecha Desde:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.lblGestPrest);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 60);
            this.panel1.TabIndex = 51;
            // 
            // lblGestPrest
            // 
            this.lblGestPrest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGestPrest.AutoSize = true;
            this.lblGestPrest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.lblGestPrest.Font = new System.Drawing.Font("Microsoft YaHei UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestPrest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblGestPrest.Location = new System.Drawing.Point(246, 11);
            this.lblGestPrest.Name = "lblGestPrest";
            this.lblGestPrest.Size = new System.Drawing.Size(363, 42);
            this.lblGestPrest.TabIndex = 50;
            this.lblGestPrest.Text = "Gestión de Prestamos";
            // 
            // gbContar
            // 
            this.gbContar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContar.Controls.Add(this.label7);
            this.gbContar.Controls.Add(this.txtAnulados);
            this.gbContar.Controls.Add(this.label8);
            this.gbContar.Controls.Add(this.txtCancelados);
            this.gbContar.Controls.Add(this.label9);
            this.gbContar.Controls.Add(this.txtPendientes);
            this.gbContar.Controls.Add(this.label10);
            this.gbContar.Controls.Add(this.txtOtorgados);
            this.gbContar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContar.Location = new System.Drawing.Point(353, 370);
            this.gbContar.Name = "gbContar";
            this.gbContar.Size = new System.Drawing.Size(438, 65);
            this.gbContar.TabIndex = 62;
            this.gbContar.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 14);
            this.label7.TabIndex = 67;
            this.label7.Text = "Prestamos anulados :";
            // 
            // txtAnulados
            // 
            this.txtAnulados.Enabled = false;
            this.txtAnulados.Location = new System.Drawing.Point(369, 39);
            this.txtAnulados.Name = "txtAnulados";
            this.txtAnulados.Size = new System.Drawing.Size(46, 21);
            this.txtAnulados.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 14);
            this.label8.TabIndex = 65;
            this.label8.Text = "Prestamos cancelados :";
            // 
            // txtCancelados
            // 
            this.txtCancelados.Enabled = false;
            this.txtCancelados.Location = new System.Drawing.Point(369, 13);
            this.txtCancelados.Name = "txtCancelados";
            this.txtCancelados.Size = new System.Drawing.Size(46, 21);
            this.txtCancelados.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 14);
            this.label9.TabIndex = 63;
            this.label9.Text = "Prestamos pendientes :";
            // 
            // txtPendientes
            // 
            this.txtPendientes.Enabled = false;
            this.txtPendientes.Location = new System.Drawing.Point(150, 39);
            this.txtPendientes.Name = "txtPendientes";
            this.txtPendientes.Size = new System.Drawing.Size(46, 21);
            this.txtPendientes.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 14);
            this.label10.TabIndex = 61;
            this.label10.Text = "Prestamos otorgados :";
            // 
            // txtOtorgados
            // 
            this.txtOtorgados.Enabled = false;
            this.txtOtorgados.Location = new System.Drawing.Point(150, 13);
            this.txtOtorgados.Name = "txtOtorgados";
            this.txtOtorgados.Size = new System.Drawing.Size(46, 21);
            this.txtOtorgados.TabIndex = 60;
            // 
            // btnAnular
            // 
            this.btnAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAnular.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAnular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(259, 400);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(100, 30);
            this.btnAnular.TabIndex = 63;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // FrmGestionPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(834, 447);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.gbContar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBuscar);
            this.Controls.Add(this.rbDefecto);
            this.Controls.Add(this.gbDestino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbFecha);
            this.Controls.Add(this.rbDestino);
            this.Controls.Add(this.dgwPrestamos);
            this.Controls.Add(this.btnVerCuotas);
            this.Controls.Add(this.btnAgregar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmGestionPrestamo";
            this.Text = ".:. Gestión de Prestamos .:.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGestionPrestamo_FormClosing);
            this.Load += new System.EventHandler(this.FrmGestionPrestamo_Load);
            this.gbDestino.ResumeLayout(false);
            this.gbDestino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrestamos)).EndInit();
            this.groupBuscar.ResumeLayout(false);
            this.groupBuscar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbContar.ResumeLayout(false);
            this.gbContar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDefecto;
        private System.Windows.Forms.GroupBox gbDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Button btnBuscarDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.RadioButton rbDestino;
        private System.Windows.Forms.DataGridView dgwPrestamos;
        private System.Windows.Forms.Button btnVerCuotas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBuscar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaF;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGestPrest;
        private System.Windows.Forms.GroupBox gbContar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAnulados;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCancelados;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPendientes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOtorgados;
        private System.Windows.Forms.Button btnAnular;


    }
}
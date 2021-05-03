namespace Vistas
{
    partial class FrmGestionPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionPago));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.btnPagar = new System.Windows.Forms.Button();
            this.gbContar = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPagosImp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPagos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGestPrest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.gbClienteFecha = new System.Windows.Forms.GroupBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaF = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaI = new System.Windows.Forms.Label();
            this.cmbClientesFecha = new System.Windows.Forms.ComboBox();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.gbContar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbClienteFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbCliente.Controls.Add(this.cmbClientes);
            this.gbCliente.Controls.Add(this.btnBuscar);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.ForeColor = System.Drawing.Color.White;
            this.gbCliente.Location = new System.Drawing.Point(22, 107);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(810, 70);
            this.gbCliente.TabIndex = 8;
            this.gbCliente.TabStop = false;
            this.gbCliente.Visible = false;
            // 
            // cmbClientes
            // 
            this.cmbClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(176, 28);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(400, 25);
            this.cmbClientes.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(607, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
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
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(22, 498);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(110, 30);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Nuevo pago";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPagos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgvPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagos.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPagos.EnableHeadersVisualStyles = false;
            this.dgvPagos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgvPagos.Location = new System.Drawing.Point(22, 196);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPagos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(810, 287);
            this.dgvPagos.TabIndex = 12;
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnPagar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnPagar.Image")));
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.Location = new System.Drawing.Point(150, 498);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPagar.Size = new System.Drawing.Size(110, 30);
            this.btnPagar.TabIndex = 14;
            this.btnPagar.Text = "Listar Pagos";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // gbContar
            // 
            this.gbContar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContar.Controls.Add(this.label4);
            this.gbContar.Controls.Add(this.txtPagosImp);
            this.gbContar.Controls.Add(this.label10);
            this.gbContar.Controls.Add(this.txtPagos);
            this.gbContar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContar.ForeColor = System.Drawing.Color.White;
            this.gbContar.Location = new System.Drawing.Point(579, 489);
            this.gbContar.Name = "gbContar";
            this.gbContar.Size = new System.Drawing.Size(253, 69);
            this.gbContar.TabIndex = 64;
            this.gbContar.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 15);
            this.label4.TabIndex = 65;
            this.label4.Text = "Importe Total de Pagos :";
            // 
            // txtPagosImp
            // 
            this.txtPagosImp.Enabled = false;
            this.txtPagosImp.Location = new System.Drawing.Point(183, 40);
            this.txtPagosImp.Name = "txtPagosImp";
            this.txtPagosImp.Size = new System.Drawing.Size(54, 21);
            this.txtPagosImp.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 15);
            this.label10.TabIndex = 61;
            this.label10.Text = "Cantidad de Pagos :";
            // 
            // txtPagos
            // 
            this.txtPagos.Enabled = false;
            this.txtPagos.Location = new System.Drawing.Point(183, 14);
            this.txtPagos.Name = "txtPagos";
            this.txtPagos.Size = new System.Drawing.Size(54, 21);
            this.txtPagos.TabIndex = 60;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.lblGestPrest);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 60);
            this.panel1.TabIndex = 66;
            // 
            // lblGestPrest
            // 
            this.lblGestPrest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGestPrest.AutoSize = true;
            this.lblGestPrest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.lblGestPrest.Font = new System.Drawing.Font("Microsoft YaHei UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestPrest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblGestPrest.Location = new System.Drawing.Point(300, 9);
            this.lblGestPrest.Name = "lblGestPrest";
            this.lblGestPrest.Size = new System.Drawing.Size(294, 42);
            this.lblGestPrest.TabIndex = 66;
            this.lblGestPrest.Text = "Gestión de Pagos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Buscar por:";
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCliente.Location = new System.Drawing.Point(198, 88);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(68, 21);
            this.rbCliente.TabIndex = 68;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Checked = true;
            this.rbFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFecha.Location = new System.Drawing.Point(115, 88);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(62, 21);
            this.rbFecha.TabIndex = 67;
            this.rbFecha.TabStop = true;
            this.rbFecha.Text = "Fecha";
            this.rbFecha.UseVisualStyleBackColor = true;
            this.rbFecha.CheckedChanged += new System.EventHandler(this.rbFecha_CheckedChanged);
            // 
            // gbClienteFecha
            // 
            this.gbClienteFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbClienteFecha.BackColor = System.Drawing.Color.Transparent;
            this.gbClienteFecha.Controls.Add(this.dtpFechaFin);
            this.gbClienteFecha.Controls.Add(this.lblFechaF);
            this.gbClienteFecha.Controls.Add(this.dtpFechaInicio);
            this.gbClienteFecha.Controls.Add(this.lblFechaI);
            this.gbClienteFecha.Controls.Add(this.cmbClientesFecha);
            this.gbClienteFecha.Controls.Add(this.btnBuscarFecha);
            this.gbClienteFecha.Controls.Add(this.label2);
            this.gbClienteFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClienteFecha.ForeColor = System.Drawing.Color.White;
            this.gbClienteFecha.Location = new System.Drawing.Point(22, 106);
            this.gbClienteFecha.Name = "gbClienteFecha";
            this.gbClienteFecha.Size = new System.Drawing.Size(810, 70);
            this.gbClienteFecha.TabIndex = 70;
            this.gbClienteFecha.TabStop = false;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpFechaFin.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(550, 28);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(125, 22);
            this.dtpFechaFin.TabIndex = 18;
            // 
            // lblFechaF
            // 
            this.lblFechaF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFechaF.AutoSize = true;
            this.lblFechaF.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaF.Location = new System.Drawing.Point(499, 32);
            this.lblFechaF.Name = "lblFechaF";
            this.lblFechaF.Size = new System.Drawing.Size(46, 17);
            this.lblFechaF.TabIndex = 17;
            this.lblFechaF.Text = "Hasta:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpFechaInicio.CalendarFont = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.CustomFormat = "";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(331, 28);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(125, 22);
            this.dtpFechaInicio.TabIndex = 16;
            // 
            // lblFechaI
            // 
            this.lblFechaI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFechaI.AutoSize = true;
            this.lblFechaI.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaI.Location = new System.Drawing.Point(273, 33);
            this.lblFechaI.Name = "lblFechaI";
            this.lblFechaI.Size = new System.Drawing.Size(49, 17);
            this.lblFechaI.TabIndex = 15;
            this.lblFechaI.Text = "Desde:";
            // 
            // cmbClientesFecha
            // 
            this.cmbClientesFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbClientesFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientesFecha.FormattingEnabled = true;
            this.cmbClientesFecha.Location = new System.Drawing.Point(67, 28);
            this.cmbClientesFecha.Name = "cmbClientesFecha";
            this.cmbClientesFecha.Size = new System.Drawing.Size(177, 25);
            this.cmbClientesFecha.TabIndex = 5;
            this.cmbClientesFecha.SelectionChangeCommitted += new System.EventHandler(this.cmbClientesFecha_SelectionChangeCommitted);
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnBuscarFecha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscarFecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBuscarFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarFecha.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFecha.ForeColor = System.Drawing.Color.White;
            this.btnBuscarFecha.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarFecha.Image")));
            this.btnBuscarFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarFecha.Location = new System.Drawing.Point(694, 24);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(100, 30);
            this.btnBuscarFecha.TabIndex = 4;
            this.btnBuscarFecha.Text = "Buscar";
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente:";
            // 
            // FrmGestionPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 570);
            this.Controls.Add(this.gbClienteFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbCliente);
            this.Controls.Add(this.rbFecha);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbContar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbCliente);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmGestionPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGestionPago";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGestionPago_FormClosing);
            this.Load += new System.EventHandler(this.FrmGestionPago_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.gbContar.ResumeLayout(false);
            this.gbContar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbClienteFecha.ResumeLayout(false);
            this.gbClienteFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.GroupBox gbContar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPagosImp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPagos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGestPrest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.GroupBox gbClienteFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaF;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaI;
        private System.Windows.Forms.ComboBox cmbClientesFecha;
        private System.Windows.Forms.Button btnBuscarFecha;
        private System.Windows.Forms.Label label2;
    }
}
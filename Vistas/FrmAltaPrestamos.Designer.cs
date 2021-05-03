namespace Vistas
{
    partial class FrmAltaPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaPrestamos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarDestino = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.msgError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msgError)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAgregarDestino);
            this.groupBox1.Controls.Add(this.btnAgregarCliente);
            this.groupBox1.Controls.Add(this.cmbClientes);
            this.groupBox1.Controls.Add(this.cmbDestino);
            this.groupBox1.Controls.Add(this.cmbPeriodo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTasaInteres);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtImporte);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCuotas);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(11, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 395);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnAgregarDestino
            // 
            this.btnAgregarDestino.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarDestino.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarDestino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregarDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDestino.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDestino.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarDestino.Image")));
            this.btnAgregarDestino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDestino.Location = new System.Drawing.Point(315, 126);
            this.btnAgregarDestino.Name = "btnAgregarDestino";
            this.btnAgregarDestino.Size = new System.Drawing.Size(29, 24);
            this.btnAgregarDestino.TabIndex = 24;
            this.btnAgregarDestino.UseVisualStyleBackColor = false;
            this.btnAgregarDestino.Click += new System.EventHandler(this.btnAgregarDestino_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarCliente.Image")));
            this.btnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCliente.Location = new System.Drawing.Point(316, 82);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(29, 24);
            this.btnAgregarCliente.TabIndex = 23;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(138, 82);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(171, 27);
            this.cmbClientes.TabIndex = 22;
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(138, 125);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(171, 27);
            this.cmbDestino.TabIndex = 21;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(138, 169);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(171, 27);
            this.cmbPeriodo.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tasa de Interes:";
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Location = new System.Drawing.Point(138, 301);
            this.txtTasaInteres.MaxLength = 15;
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(171, 24);
            this.txtTasaInteres.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Importe:";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(138, 257);
            this.txtImporte.MaxLength = 40;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(171, 24);
            this.txtImporte.TabIndex = 12;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cantidad de Cuotas:";
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(138, 343);
            this.txtCuotas.MaxLength = 10;
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(171, 24);
            this.txtCuotas.TabIndex = 16;
            this.txtCuotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuotas_KeyPress);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(138, 210);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(125, 24);
            this.dtpFecha.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Periodo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Location = new System.Drawing.Point(138, 36);
            this.txtNumero.MaxLength = 8;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(171, 24);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Prestamo:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(262, 475);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(11, 475);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.pnlTitulo.Controls.Add(this.BtnCerrar);
            this.pnlTitulo.Controls.Add(this.label9);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(374, 40);
            this.pnlTitulo.TabIndex = 8;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(334, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(40, 40);
            this.BtnCerrar.TabIndex = 5;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "NUEVO PRESTAMO";
            // 
            // msgError
            // 
            this.msgError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.msgError.ContainerControl = this;
            this.msgError.Icon = ((System.Drawing.Icon)(resources.GetObject("msgError.Icon")));
            // 
            // FrmAltaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(374, 515);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Prestamo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAltaPrestamos_FormClosing);
            this.Load += new System.EventHandler(this.FrmAltaPrestamos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msgError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.ErrorProvider msgError;
        private System.Windows.Forms.Button btnAgregarDestino;
    }
}
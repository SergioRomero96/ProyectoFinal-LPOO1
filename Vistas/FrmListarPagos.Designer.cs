namespace Vistas
{
    partial class FrmListarPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarPagos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.lblGestPrest = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbPrestamos = new System.Windows.Forms.ComboBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwPagos = new System.Windows.Forms.DataGridView();
            this.gbContar = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPendienteImp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPagadoImp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPendiente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPagadas = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPagos)).BeginInit();
            this.gbContar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.lblGestPrest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 63);
            this.panel1.TabIndex = 52;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(742, 8);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(43, 43);
            this.BtnCerrar.TabIndex = 51;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lblGestPrest
            // 
            this.lblGestPrest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGestPrest.AutoSize = true;
            this.lblGestPrest.BackColor = System.Drawing.Color.Transparent;
            this.lblGestPrest.Font = new System.Drawing.Font("Microsoft YaHei UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestPrest.ForeColor = System.Drawing.Color.White;
            this.lblGestPrest.Location = new System.Drawing.Point(271, 8);
            this.lblGestPrest.Name = "lblGestPrest";
            this.lblGestPrest.Size = new System.Drawing.Size(244, 42);
            this.lblGestPrest.TabIndex = 50;
            this.lblGestPrest.Text = "Lista de Pagos";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.cmbPrestamos);
            this.groupBox1.Controls.Add(this.cmbClientes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(21, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 73);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Pago";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(292, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 23);
            this.txtNombre.TabIndex = 20;
            // 
            // cmbPrestamos
            // 
            this.cmbPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbPrestamos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrestamos.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrestamos.FormattingEnabled = true;
            this.cmbPrestamos.Location = new System.Drawing.Point(574, 31);
            this.cmbPrestamos.Name = "cmbPrestamos";
            this.cmbPrestamos.Size = new System.Drawing.Size(169, 23);
            this.cmbPrestamos.TabIndex = 18;
            this.cmbPrestamos.SelectionChangeCommitted += new System.EventHandler(this.cmbPrestamos_SelectionChangeCommitted);
            // 
            // cmbClientes
            // 
            this.cmbClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(51, 31);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(170, 23);
            this.cmbClientes.TabIndex = 17;
            this.cmbClientes.SelectionChangeCommitted += new System.EventHandler(this.cmbClientes_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "N° de Prestamo:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // dgwPagos
            // 
            this.dgwPagos.AllowUserToAddRows = false;
            this.dgwPagos.AllowUserToDeleteRows = false;
            this.dgwPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwPagos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.dgwPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwPagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgwPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwPagos.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwPagos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwPagos.EnableHeadersVisualStyles = false;
            this.dgwPagos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.dgwPagos.Location = new System.Drawing.Point(21, 161);
            this.dgwPagos.Name = "dgwPagos";
            this.dgwPagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwPagos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPagos.Size = new System.Drawing.Size(755, 283);
            this.dgwPagos.TabIndex = 54;
            // 
            // gbContar
            // 
            this.gbContar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContar.Controls.Add(this.label5);
            this.gbContar.Controls.Add(this.txtPendienteImp);
            this.gbContar.Controls.Add(this.label4);
            this.gbContar.Controls.Add(this.txtPagadoImp);
            this.gbContar.Controls.Add(this.label9);
            this.gbContar.Controls.Add(this.txtPendiente);
            this.gbContar.Controls.Add(this.label10);
            this.gbContar.Controls.Add(this.txtPagadas);
            this.gbContar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContar.ForeColor = System.Drawing.Color.White;
            this.gbContar.Location = new System.Drawing.Point(323, 450);
            this.gbContar.Name = "gbContar";
            this.gbContar.Size = new System.Drawing.Size(453, 77);
            this.gbContar.TabIndex = 63;
            this.gbContar.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 14);
            this.label5.TabIndex = 67;
            this.label5.Text = "Importe Pendiente :";
            // 
            // txtPendienteImp
            // 
            this.txtPendienteImp.Enabled = false;
            this.txtPendienteImp.Location = new System.Drawing.Point(372, 46);
            this.txtPendienteImp.Name = "txtPendienteImp";
            this.txtPendienteImp.Size = new System.Drawing.Size(54, 21);
            this.txtPendienteImp.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 14);
            this.label4.TabIndex = 65;
            this.label4.Text = "Importe Pagado :";
            // 
            // txtPagadoImp
            // 
            this.txtPagadoImp.Enabled = false;
            this.txtPagadoImp.Location = new System.Drawing.Point(372, 19);
            this.txtPagadoImp.Name = "txtPagadoImp";
            this.txtPagadoImp.Size = new System.Drawing.Size(54, 21);
            this.txtPagadoImp.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 14);
            this.label9.TabIndex = 63;
            this.label9.Text = "Cantidad de Cuotas Pendientes :";
            // 
            // txtPendiente
            // 
            this.txtPendiente.Enabled = false;
            this.txtPendiente.Location = new System.Drawing.Point(184, 46);
            this.txtPendiente.Name = "txtPendiente";
            this.txtPendiente.Size = new System.Drawing.Size(46, 21);
            this.txtPendiente.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 14);
            this.label10.TabIndex = 61;
            this.label10.Text = "Cantidad de Cuotas Pagadas :";
            // 
            // txtPagadas
            // 
            this.txtPagadas.Enabled = false;
            this.txtPagadas.Location = new System.Drawing.Point(184, 19);
            this.txtPagadas.Name = "txtPagadas";
            this.txtPagadas.Size = new System.Drawing.Size(46, 21);
            this.txtPagadas.TabIndex = 60;
            // 
            // FrmListarPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(797, 539);
            this.Controls.Add(this.gbContar);
            this.Controls.Add(this.dgwPagos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmListarPagos";
            this.Text = "Listar Pagos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListarPagos_FormClosing);
            this.Load += new System.EventHandler(this.FrmListarPagos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPagos)).EndInit();
            this.gbContar.ResumeLayout(false);
            this.gbContar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGestPrest;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPrestamos;
        private System.Windows.Forms.DataGridView dgwPagos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gbContar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPendienteImp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPagadoImp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPendiente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPagadas;
    }
}
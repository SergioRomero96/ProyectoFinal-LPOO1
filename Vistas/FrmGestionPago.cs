using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmGestionPago : Form
    {
        public static FrmGestionPago instancia;

        public FrmGestionPago()
        {
            InitializeComponent();
        }

        public static FrmGestionPago GetInstancia() 
        {
            if (instancia == null)
                instancia = new FrmGestionPago();
            return instancia;
        }

        private void FrmGestionPago_Load(object sender, EventArgs e)
        {
            cargarClientes();
            cargarPagos();
        }

        private void cargarClientes()
        {
            cmbClientes.DataSource = GestionCliente.list();
            cmbClientes.DisplayMember = "apellidoYnombre"; // valor a mostrar
            cmbClientes.ValueMember = "CLI_DNI";
            cmbClientes.SelectedIndex = -1;

            cmbClientesFecha.DataSource = GestionCliente.list();
            cmbClientesFecha.DisplayMember = "apellidoYnombre";
            cmbClientesFecha.ValueMember = "CLI_DNI";
        }

        private void FrmGestionPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaPago frmAltaPago = FrmAltaPago.GetInstancia();
            frmAltaPago.Show();
            //cargarClientes();
            //cargarPagos();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            FrmListarPagos frmHijo = new FrmListarPagos();
            
            AddOwnedForm(frmHijo);
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            frmHijo.TopLevel = false;
            frmHijo.Dock = DockStyle.Fill;
            this.Controls.Add(frmHijo);
            this.Tag = frmHijo;
            frmHijo.BringToFront();

            frmHijo.Show();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedIndex != -1)
            {
                dgvPagos.DataSource = GestionDePagos.buscar_Pagos(cmbClientes.SelectedValue.ToString());
                txtPagos.Text = GestionDePagos.contarPagos(cmbClientes.SelectedValue.ToString()).ToString();
                txtPagosImp.Text = "$" + " " + GestionDePagos.sumarPagos(cmbClientes.SelectedValue.ToString()).ToString();
            }
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            dgvPagos.DataSource = new DataTable();
            gbCliente.Visible = true;
            gbClienteFecha.Visible = false;
            limpiarCampos();
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            cargarPagos();
            gbClienteFecha.Visible = true;
            gbCliente.Visible = false;
            limpiarCampos();
        }

        private void cargarPagos()
        {
            dgvPagos.DataSource = GestionDePagos.buscar_Pagos(cmbClientesFecha.SelectedValue.ToString());
        }

        private void cmbClientesFecha_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarPagos();
            limpiarCampos();
            
        }

        private void limpiarCampos()
        {
            txtPagos.Clear();
            txtPagosImp.Clear();
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = Convert.ToDateTime(dtpFechaInicio.Text);
            DateTime fechaFin = Convert.ToDateTime(dtpFechaFin.Text);
            if (fechaInicio <= fechaFin)
            {
                dgvPagos.DataSource = GestionDePagos.BuscarPagosPorFecha(cmbClientesFecha.SelectedValue.ToString(), fechaInicio, fechaFin);
                txtPagos.Text = GestionDePagos.ContarPagosClienteFecha(cmbClientesFecha.SelectedValue.ToString(),fechaInicio, fechaFin).ToString();
                txtPagosImp.Text = GestionDePagos.SumarPagosClienteFecha(cmbClientesFecha.SelectedValue.ToString(),fechaInicio,fechaFin).ToString();
            }
            else
            {
                MessageBox.Show("La fecha desde debe ser menor o igual a fecha hasta", "Búsqueda de Pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

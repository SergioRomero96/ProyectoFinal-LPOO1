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
    public partial class FrmListarPagos : Form
    {
        private Pago pago;
        private string dniAux;
        private Cuota cuota;
        private static FrmListarPagos instancia;
        public FrmListarPagos()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListarPagos_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        public static FrmListarPagos GetInstancia()
        {
            if (instancia == null)
                instancia = new FrmListarPagos();
            return instancia;
        }

        private void cargarClientes()
        {
            cmbClientes.DataSource = GestionCliente.list();
            cmbClientes.DisplayMember = "CLI_DNI";
            cmbClientes.ValueMember = "CLI_DNI";
            cmbClientes.SelectedIndex = -1;
        }

        private void cargarClientesNombre()
        {
            DataRowView drv = (DataRowView)cmbClientes.SelectedItem;
            txtNombre.Text = drv["CLI_Apellido"].ToString() + ", " + drv["CLI_Nombre"].ToString();
        }

        private void limpiar()
        {
            txtPagadas.Clear();
            txtPagadoImp.Clear();
            txtPendiente.Clear();
            txtPendienteImp.Clear();
        }

        private void cmbClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string dniSeleccionado = cmbClientes.SelectedValue.ToString();
            if (dniAux != dniSeleccionado)
            {
                dgwPagos.DataSource = new DataTable();
                cmbPrestamos.DataSource = new DataTable();
                limpiar();
                cargarClientesNombre();
            }
            if (GestionPrestamo.BuscarPrestamosPorCliente(cmbClientes.SelectedValue.ToString()).Rows.Count != 0)
            {
                cargarClientesNombre();
                cargarPrestamos();
                cargarCuotas();
            }
            else
                MessageBox.Show("El cliente no posee ningún préstamo", "Gestion de préstamos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dniAux = cmbClientes.SelectedValue.ToString();
        }

        private void cargarPrestamos()
        {
            cmbPrestamos.DataSource = GestionPrestamo.BuscarPrestamosPorCliente(cmbClientes.SelectedValue.ToString());
            cmbPrestamos.DisplayMember = "PRE_Numero"; // valor a mostrar
            cmbPrestamos.ValueMember = "PRE_Numero";
        }

        private void cargarCuotas()
        {
            dgwPagos.DataSource = GestionDeCuotas.GetCuotas((int)cmbPrestamos.SelectedValue);
        }

        private void dgvCuotas_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwPagos.CurrentRow != null)
            {
                cuota.Cuo_Codigo = (int)dgwPagos.CurrentRow.Cells[0].Value;
                cuota.Cuo_Importe = (decimal)dgwPagos.CurrentRow.Cells[3].Value;
            }
        }

        private bool ValidarVacio()
        {
            return cmbClientes.SelectedIndex == -1 || cmbPrestamos.SelectedIndex == -1 || dgwPagos.CurrentRow == null;
        }

        private void cmbPrestamos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = (int)cmbPrestamos.SelectedValue;
            if (GestionDeCuotas.GetCuotas((int)cmbPrestamos.SelectedValue).Rows.Count != 0)
            {
                cargarCuotas();
                txtPagadas.Text = GestionDeCuotas.ContarCuotasPagadas(id).ToString();
                txtPendiente.Text = GestionDeCuotas.ContarCuotasPedientes(id).ToString();
                txtPagadoImp.Text = "$" +" "+ GestionDeCuotas.SumarCuotasPagadas(id).ToString();
                txtPendienteImp.Text = "$" + " " + GestionDeCuotas.SumarCuotasPedientes(id).ToString();
            }
            else
                MessageBox.Show("El préstamo ya fue CANCELADO", "Gestion de préstamos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmListarPagos_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }
    }
}

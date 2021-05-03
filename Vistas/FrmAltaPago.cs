using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using ClasesBase;

namespace Vistas
{
    public partial class FrmAltaPago : Form
    {
        private Pago pago;
        private string dniAux;
        private Cuota  cuota;
        private static FrmAltaPago instancia;

        public FrmAltaPago()
        {
            InitializeComponent();
            cuota = new Cuota();
            pago = new Pago();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static FrmAltaPago GetInstancia()
        {
            if (instancia == null)
                instancia = new FrmAltaPago();
            return instancia;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = FrmMain.GetInstancia();
            frmMain.BringToFront();
            this.Close();
        }

        private void FrmAltaPago_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void cargarClientes()
        {
            cmbClientes.DataSource = GestionCliente.listarPrestamoCliente();
            cmbClientes.DisplayMember = "detalle";
            cmbClientes.ValueMember = "CLI_DNI";
            cmbClientes.SelectedIndex = -1;
        }

        private void FrmAltaPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void cmbClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string dniSeleccionado = cmbClientes.SelectedValue.ToString();
            if (dniAux != dniSeleccionado)
                dgvCuotas.DataSource = new DataTable();
            if (GestionPrestamo.BuscarPrestamosPendientePorCliente(cmbClientes.SelectedValue.ToString()).Rows.Count != 0)
            {
                cargarPrestamos();
                cargarCuotas();
            }
            else
            {
                MessageBox.Show("El cliente no posee ningun préstamo", "Gestion de préstamos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbPrestamos.DataSource = new DataTable();
            }
            dniAux = cmbClientes.SelectedValue.ToString();
        }

        private void cargarPrestamos()
        {
            cmbPrestamos.DataSource = GestionPrestamo.BuscarPrestamosPendientePorCliente(cmbClientes.SelectedValue.ToString());
            cmbPrestamos.DisplayMember = "PRE_Numero"; // valor a mostrar
            cmbPrestamos.ValueMember = "PRE_Numero";            
        }

        private void cmbPrestamos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarCuotas();
        }

        private void cargarCuotas()
        {
            dgvCuotas.DataSource = GestionDeCuotas.GetCuotasPendientes((int)cmbPrestamos.SelectedValue);
            dgvCuotas.Columns["ID"].Visible = false;
            dgvCuotas.Columns["NumeroPrestamo"].Visible = false;
        }

        private void dgvCuotas_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvCuotas.CurrentRow != null)
            {
                cuota.Cuo_Codigo = (int) dgvCuotas.CurrentRow.Cells[0].Value;
                cuota.Cuo_Importe = (decimal) dgvCuotas.CurrentRow.Cells[3].Value;
            }
        }

        private bool ValidarVacio() 
        {
            bool error = false;
            msgError.Clear();
            if (cmbClientes.SelectedIndex.Equals(-1))
            {
                msgError.SetError(cmbClientes, "El campo CLIENTE es requerido");
                error = true;
            }
            if (cmbPrestamos.SelectedIndex.Equals(-1))
            {
                msgError.SetError(cmbPrestamos, "El campo PRÉSTAMO es requerido");
                error = true;
            }
            return error;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarVacio())
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea registrar el pago?", "Registrar pago", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion.Equals(DialogResult.OK))
                {
                    //actualizar estado cuota pagado
                    GestionDeCuotas.ActualizarCuota(cuota.Cuo_Codigo);
                    // guardar pago
                    pago.Cuo_Codigo = cuota.Cuo_Codigo;
                    pago.Pag_Fecha = dtpFecha.Value;
                    pago.Pag_Importe = cuota.Cuo_Importe;
                    GestionDePagos.insert_Pago(pago);
                    MessageBox.Show("Se registro con éxito el pago", "Registrar pago", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (GestionDeCuotas.GetCuotasPendientes((int)cmbPrestamos.SelectedValue).Rows.Count == 0)
                    {
                        GestionPrestamo.ActualizarEstadoPrestamo((int)cmbPrestamos.SelectedValue);
                        MessageBox.Show("El prestamo N° " + (int)cmbPrestamos.SelectedValue + " fue CANCELADO en su totalidad", "Gestión de préstamos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    FrmMain frmMain = FrmMain.GetInstancia();
                    frmMain.BringToFront();
                    this.Close();
                }
                else
                    MessageBox.Show("Pago no registrado", "Registrar pago", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Algunos campos están vacíos", "Registrar pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

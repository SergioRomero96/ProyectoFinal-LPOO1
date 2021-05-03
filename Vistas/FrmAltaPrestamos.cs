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
    public partial class FrmAltaPrestamos : Form
    {
        private Prestamo prestamo;
        private static FrmAltaPrestamos instancia;
        private FrmGestionPrestamo frmGestionPrestamo;
        private bool modificar = false;
        private int id;
        private FrmAltaClientes frmAltaCliente;
        private FrmAltaDestino frmAltaDestino;

        public FrmAltaPrestamos()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static FrmAltaPrestamos GetInstancia()
        {
            if (instancia == null)
                instancia = new FrmAltaPrestamos();
            return instancia;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validarCamposVacios())
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea agregar el préstamo?", "Agregar préstamo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion.Equals(DialogResult.OK))
                {
                    if (GestionPrestamo.contarPrestamosPendientes(Convert.ToInt32(cmbClientes.SelectedValue)) > 1)
                        MessageBox.Show("El cliente ya tiene préstamos pendientes para pagar", "Agregar préstamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        agregarPrestamo();
                }
                else
                    MessageBox.Show("Prestamo no registrado", "Agregar préstamo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Algunos campos están vacíos", "Agregar préstamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool validarCamposVacios()
        {
            bool error = false;
            msgError.Clear();
            if (txtCuotas.Text.Equals(""))
            {
                msgError.SetError(txtCuotas, "El campo CUOTAS es requerido");
                error = true;
            }
            if (txtImporte.Text.Equals(""))
            {
                msgError.SetError(txtImporte, "El campo IMPORTE es requerido");
                error = true;
            }
            if (txtTasaInteres.Text.Equals(""))
            {
                msgError.SetError(txtTasaInteres, "El campo TASA INTERÉS es requerido");
                error = true;
            }
            if (cmbClientes.SelectedIndex.Equals(-1))
            {
                msgError.SetError(cmbClientes, "El campo CLIENTE es requerido");
                error = true;
            }
            if (cmbDestino.SelectedIndex.Equals(-1))
            {
                msgError.SetError(cmbClientes, "El campo DESTINO es requerido");
                error = true;
            }
            if (cmbPeriodo.SelectedIndex.Equals(-1))
            {
                msgError.SetError(cmbPeriodo, "El campo PERIODO es requerido");
                error = true;
            }
            return error;
        }

        public void Set_Prestamo(Prestamo prestamo, bool modificar)
        {
            this.modificar = modificar;
            this.prestamo.Cli_Dni = prestamo.Cli_Dni;
        }

        private void agregarPrestamo()
        {
            prestamo = new Prestamo();
            prestamo.Pre_Importe = Convert.ToDecimal(txtImporte.Text);
            prestamo.Pre_CantidadCuotas = Convert.ToInt32(txtCuotas.Text);
            prestamo.Pre_TasaInteres = Convert.ToDouble(txtTasaInteres.Text);
            prestamo.Pre_Fecha =Convert.ToDateTime(dtpFecha.Text);
            prestamo.Des_Codigo = (int)cmbDestino.SelectedValue;
            prestamo.Per_Codigo = (int)cmbPeriodo.SelectedValue;
            prestamo.Cli_Dni = cmbClientes.SelectedValue.ToString();

            GestionPrestamo.InsertarPrestamo(prestamo);
            bool primero = true;
            
            DateTime fechaAux = new DateTime();
            for (int i = 1; i <= prestamo.Pre_CantidadCuotas; i++)
            {
                Cuota cuota = new Cuota();
                cuota.Cuo_Importe = (prestamo.Pre_Importe * (decimal)prestamo.Pre_TasaInteres / 100 + prestamo.Pre_Importe) / prestamo.Pre_CantidadCuotas;
                cuota.Cuo_Numero = i;
                if (primero)
                {
                    primero = false;
                    if (prestamo.Per_Codigo == 1)
                        cuota.Cuo_Vencimiento = prestamo.Pre_Fecha.AddDays(7);
                    else if (prestamo.Per_Codigo == 2)
                        cuota.Cuo_Vencimiento = prestamo.Pre_Fecha.AddMonths(1);
                    else if (prestamo.Per_Codigo == 3)
                        cuota.Cuo_Vencimiento = prestamo.Pre_Fecha.AddYears(1);
                }
                else
                {
                    if (prestamo.Per_Codigo == 1)
                        cuota.Cuo_Vencimiento =  fechaAux.AddDays(7);
                    else if (prestamo.Per_Codigo == 2)
                        cuota.Cuo_Vencimiento = fechaAux.AddMonths(1);
                    else if (prestamo.Per_Codigo == 3)
                        cuota.Cuo_Vencimiento = fechaAux.AddYears(1);                    
                }
                fechaAux = cuota.Cuo_Vencimiento;
                cuota.Pre_Numero = this.id;
                GestionDeCuotas.InsertarCuota(cuota);
            }

            frmGestionPrestamo = FrmGestionPrestamo.GetInstancia();
            frmGestionPrestamo.cargar_Prestamos();
            frmGestionPrestamo.BringToFront();
            MessageBox.Show("Préstamo agregado con éxito", "Agregar préstamo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !(Convert.ToChar(Keys.Back) == e.KeyChar))
                e.Handled = true;
        }

        private void txtCuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !(Convert.ToChar(Keys.Back) == e.KeyChar))
                e.Handled = true;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !(Convert.ToChar(Keys.Back) == e.KeyChar))
                e.Handled = true;
        }

        private void FrmAltaPrestamos_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void FrmAltaPrestamos_Load(object sender, EventArgs e)
        {
            cargarClientes();
            cargarDestino();
            cargarPeriodo();
            if (GestionPrestamo.ListarPrestamos().Rows.Count == 0)
                this.id = 1;
            else
                this.id = GestionPrestamo.ListarPrestamos().Rows.Count + 1;
            txtNumero.Text = this.id.ToString();
            txtNumero.Enabled = false;
        }

        private void cargarClientes()
        {
            cmbClientes.DataSource = GestionCliente.list();
            cmbClientes.DisplayMember = "detalle"; // valor a mostrar
            cmbClientes.ValueMember = "CLI_DNI";
        }

        private void cargarDestino()
        {
            cmbDestino.DisplayMember = "DES_Descripcion";
            cmbDestino.ValueMember = "DES_Codigo";
            cmbDestino.DataSource = GestionDestino.list();
        }

        private void cargarPeriodo()
        {
            cmbPeriodo.DisplayMember = "PER_Descripcion";
            cmbPeriodo.ValueMember = "PER_Codigo";
            cmbPeriodo.DataSource = GestionPrestamo.GetPeriodos();
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

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmAltaCliente = FrmAltaClientes.GetInstancia();
            frmAltaCliente.ShowDialog();
            cargarClientes();
        }

        private void btnAgregarDestino_Click(object sender, EventArgs e)
        {
            frmAltaDestino = FrmAltaDestino.GetInstancia();
            frmAltaDestino.ShowDialog();
            cargarDestino();
        }
    }
}

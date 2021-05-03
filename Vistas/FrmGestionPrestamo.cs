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
    public partial class FrmGestionPrestamo : Form
    {
        private FrmAltaPrestamos frmAltaPrestamo;
        public static FrmGestionPrestamo instancia;
        private Prestamo prestamo;
        private string destinoSeleccionado;
        private bool consultar = false;
        private int prestam;
        private string estado;

        public FrmGestionPrestamo()
        {
            InitializeComponent();
        }

        public static FrmGestionPrestamo GetInstancia() 
        {
            if (instancia == null)
                instancia = new FrmGestionPrestamo();
            return instancia;
        }

        private void FrmGestionPrestamo_Load(object sender, EventArgs e)
        {
            OpcionDefecto();
            gbContar.Visible = false;
        }

        public void cargar_Prestamos()
        {
            dgwPrestamos.DataSource = GestionPrestamo.ListarPrestamos();
            dgwPrestamos.Columns["Codigo_Destino"].Visible = false;
            dgwPrestamos.Columns["Codigo_Periodo"].Visible = false;
        }

        private void FrmGestionPrestamo_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void cargarDestino()
        {
            cmbDestino.DisplayMember = "DES_Descripcion";
            cmbDestino.ValueMember = "DES_Codigo";
            cmbDestino.DataSource = GestionDestino.list();
            cmbDestino.SelectedIndex = -1;
        }

        private void OpcionDefecto()
        {
            cargar_Prestamos();
            groupBuscar.Visible = true;
            dtpFechaInicio.Enabled = false;
            dtpFechaFin.Enabled = false;
            btnConsultar.Enabled = false;
            gbDestino.Visible = false;
        }

        private void rbDefecto_CheckedChanged(object sender, EventArgs e)
        {
            consultar = false;
            gbContar.Visible = false;
            btnAnular.Visible = true;
            btnAgregar.Visible = true;
            btnVerCuotas.Visible = true;
            OpcionDefecto();
        }

        private void rbDestino_CheckedChanged(object sender, EventArgs e)
        {
            consultar = true;
            btnAgregar.Visible = false;
            btnVerCuotas.Visible = false;
            btnAnular.Visible = false;
            cargarDestino();
            gbContar.Visible = true;
            limpiarContadores();
            if (cmbDestino.SelectedIndex == -1)
                cargar_Prestamos();
            else
            {
                destinoSeleccionado = cmbDestino.Text;
                dgwPrestamos.DataSource = GestionPrestamo.BuscarPrestamoPorDestino(destinoSeleccionado);
            }
            groupBuscar.Visible = false;
            gbDestino.Visible = true;
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            consultar = true;
            btnAgregar.Visible = false;
            btnVerCuotas.Visible = false;
            btnAnular.Visible = false;
            cargar_Prestamos();
            limpiarContadores();
            gbContar.Visible = true;
            gbDestino.Visible = false;
            groupBuscar.Visible = true;
            dtpFechaInicio.Enabled = true;
            dtpFechaFin.Enabled = true;
            btnConsultar.Enabled = true;

            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
        }
       private void limpiarContadores(){
        txtAnulados.Clear();
        txtCancelados.Clear();
        txtOtorgados.Clear();
        txtPendientes.Clear();
        }
        private void btnBuscarDestino_Click(object sender, EventArgs e)
        {
            if (cmbDestino.SelectedIndex > -1)
            {
                destinoSeleccionado = cmbDestino.Text;
                dgwPrestamos.DataSource = GestionPrestamo.BuscarPrestamoPorDestino(destinoSeleccionado);
                cargarPrestamosCantidadPorDestino((int)cmbDestino.SelectedValue);
                consultar = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultar = true;

           
            DateTime fechaInicio = Convert.ToDateTime(dtpFechaInicio.Text);
            DateTime fechaFin = Convert.ToDateTime(dtpFechaFin.Text);
            if (fechaInicio <= fechaFin)
            {
                dgwPrestamos.DataSource = GestionPrestamo.BuscarPrestamosPorFecha(fechaInicio, fechaFin);
                asignarContadores(fechaInicio, fechaFin);
            }
            else
            {
                MessageBox.Show("'Fecha desde' debe ser menor a 'fecha hasta'", "Buscar préstamos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void asignarContadores(DateTime fechaInicio, DateTime fechaFin)
        {
            txtPendientes.Text = GestionPrestamo.contarPrestamosPendientes(fechaInicio, fechaFin).ToString();
            txtOtorgados.Text = GestionPrestamo.contarPrestamosOtorgados(fechaInicio, fechaFin).ToString();
            txtCancelados.Text = GestionPrestamo.contarPrestamosCancelados(fechaInicio, fechaFin).ToString();
            txtAnulados.Text = GestionPrestamo.contarPrestamosAnulados(fechaInicio, fechaFin).ToString();
        }

        private void dgwPrestamos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwPrestamos.CurrentRow != null && !consultar)
            {
                prestamo = new Prestamo();
                prestamo.Pre_Numero = (int)dgwPrestamos.CurrentRow.Cells["ID"].Value;
                prestam = prestamo.Pre_Numero;
                prestamo.Cli_Dni = dgwPrestamos.CurrentRow.Cells["DNI"].Value.ToString();
                prestamo.Des_Codigo = (int)dgwPrestamos.CurrentRow.Cells["Codigo_Destino"].Value;
                prestamo.Per_Codigo = (int)dgwPrestamos.CurrentRow.Cells["Codigo_Periodo"].Value;
                prestamo.Pre_Fecha = (DateTime)dgwPrestamos.CurrentRow.Cells["Fecha"].Value;
                prestamo.Pre_Importe = (decimal)dgwPrestamos.CurrentRow.Cells["Importe"].Value;
                prestamo.Pre_TasaInteres = (double)dgwPrestamos.CurrentRow.Cells["Interes"].Value;
                prestamo.Pre_CantidadCuotas = (int)dgwPrestamos.CurrentRow.Cells["Cuotas"].Value;
                prestamo.Pre_Estado = dgwPrestamos.CurrentRow.Cells["Estado"].Value.ToString();
                estado = prestamo.Pre_Estado;
            }
        }

        private void btnVerCuotas_Click(object sender, EventArgs e)
        {
            FrmGestionCuotas frmHijo = new FrmGestionCuotas();
            frmHijo.Set_Prestamo(prestamo);
            AddOwnedForm(frmHijo);
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            frmHijo.TopLevel = false;
            frmHijo.Dock = DockStyle.Fill;
            this.Controls.Add(frmHijo);
            this.Tag = frmHijo;
            frmHijo.BringToFront();
            frmHijo.Show(); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPrestamo = FrmAltaPrestamos.GetInstancia();
            frmAltaPrestamo.ShowDialog();
        }

        private void cargarPrestamosCantidadPorDestino(int id)
        {
            txtAnulados.Text = GestionPrestamo.buscarPrestamoDestinoAnulado(id).Rows[0][0].ToString();
            txtCancelados.Text = GestionPrestamo.buscarPrestamoDestinoCancelado(id).Rows[0][0].ToString();
            txtOtorgados.Text = GestionPrestamo.buscarPrestamoDestinoOtorgado(id).Rows[0][0].ToString();
            txtPendientes.Text = GestionPrestamo.buscarPrestamoDestinoPendiente(id).Rows[0][0].ToString();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            int prestamos = GestionPrestamo.ContarPrestamo(prestam);
            int pendiente = GestionPrestamo.ContarPrestamoPendintes(prestam);
            if (prestamos == pendiente && estado!="ANULADO")
            {
                DialogResult opcion = MessageBox.Show("¿Desea anular el préstamo otorgado?", "Anular préstamo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion.Equals(DialogResult.OK))
                {
                    GestionPrestamo.ActualizarEstadoPendiente(prestam);
                    cargar_Prestamos();
                    MessageBox.Show("El préstamo se anulo con éxito", "Anular préstamo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("El prestamo ya contiene algún pago realizado o fue anulado", "Anular préstamo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}   


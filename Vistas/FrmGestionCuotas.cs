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
    public partial class FrmGestionCuotas : Form
    {
        private Prestamo prestamo;

        private static FrmGestionCuotas instancia;

        public FrmGestionCuotas()
        {
            InitializeComponent();
            prestamo = new Prestamo();
        }

        public static FrmGestionCuotas GetInstancia() 
        {
            if (instancia == null)
                instancia = new FrmGestionCuotas();
            return instancia;
        }

        private void FrmGestionCuotas_Load(object sender, EventArgs e)
        {
            dgwCuotas.DataSource = GestionDeCuotas.BuscarCuotasPorPrestamo(this.prestamo.Pre_Numero);
            dgwCuotas.Columns["ID"].Visible = false;
            cargarDetallePrestamo();
        }

        public void Set_Prestamo(Prestamo prestamo) 
        {
            this.prestamo = prestamo;
        }

        private void cargarDetallePrestamo() 
        {
            txtPrestamo.Text = prestamo.Pre_Numero.ToString();
            txtDNI.Text = prestamo.Cli_Dni;
            txtDestino.Text = GestionDestino.Get_Destino(prestamo.Des_Codigo);
            txtPeriodo.Text = GestionPrestamo.GetPeriodo(prestamo.Per_Codigo).Rows[0][1].ToString();
            txtImporte.Text = prestamo.Pre_Importe.ToString();
            txtInteres.Text = prestamo.Pre_TasaInteres.ToString();
            txtCuotas.Text = prestamo.Pre_CantidadCuotas.ToString();
            txtEstado.Text = prestamo.Pre_Estado;
            dtpFecha.Text = prestamo.Pre_Fecha.ToShortDateString();
        }

        private void FrmGestionCuotas_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

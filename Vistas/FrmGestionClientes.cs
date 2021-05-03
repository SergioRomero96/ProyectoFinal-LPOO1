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
    public partial class FrmGestionClientes : Form
    {
        private FrmAltaClientes frmAltaCliente;
        public static FrmGestionClientes instancia;
        private Cliente cliente;
        private Boolean orden = true;

        public static FrmGestionClientes GetInstancia()
        {
            if (instancia == null)
                instancia = new FrmGestionClientes();
            return instancia;
        }

        public FrmGestionClientes()
        {
            InitializeComponent();
        }

        public void cargar_Clientes()
        {
            dgwClientes.DataSource = GestionCliente.list_Clientes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaCliente = FrmAltaClientes.GetInstancia();
            frmAltaCliente.ShowDialog();
        }

        private void FrmGestionDeClientes_Load(object sender, EventArgs e)
        {
            cargar_Clientes();
        }

        private void FrmGestionDeClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAltaCliente = FrmAltaClientes.GetInstancia();
            frmAltaCliente.Set_Cliente(this.cliente, true);
            frmAltaCliente.lblCliente.Text = "MODIFICAR CLIENTE";
            frmAltaCliente.ShowDialog();
        }

        private void dgwClientes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwClientes.CurrentRow != null)
            {
                try
                {
                    cliente = new Cliente();
                    cliente.Cli_Dni = dgwClientes.CurrentRow.Cells["DNI"].Value.ToString();
                    cliente.Cli_Apellido = dgwClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                    cliente.Cli_Nombre = dgwClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                    cliente.Cli_Sexo = dgwClientes.CurrentRow.Cells["Sexo"].Value.ToString();
                    cliente.Cli_FechaNacimiento = Convert.ToDateTime(dgwClientes.CurrentRow.Cells["FechaNacimientos"].Value);
                    cliente.Cli_Ingresos = Convert.ToDecimal(dgwClientes.CurrentRow.Cells["Ingresos"].Value.ToString());
                    cliente.Cli_Direccion = dgwClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                    cliente.Cli_Telefono = dgwClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                }
                catch
                {
                    MessageBox.Show("No selecciono ningún cliente");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text != "")
                dgwClientes.DataSource = GestionCliente.buscar_Cliente(txtBusqueda.Text);
            else
                cargar_Clientes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea eliminar al cliente: " + this.cliente.Cli_Apellido + ", " + this.cliente.Cli_Nombre + " ?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (opcion.Equals(DialogResult.Yes))
            {
                if (GestionCliente.devolverTienePrestamo(Convert.ToInt32(this.cliente.Cli_Dni)) > 0)
                    MessageBox.Show("No se puede eliminar el cliente porque tiene préstamo asignado", "Eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    GestionCliente.delete_Cliente(cliente);
                    MessageBox.Show("Cliente eliminado con éxito", "Eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar_Clientes();
                }
            } 
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (orden)
            {
                dgwClientes.DataSource = GestionCliente.ordenar_Clientes().Tables[0];
                dgwClientes.Refresh();
            }
            else
                cargar_Clientes();
            orden = !orden;
        }
    }
}

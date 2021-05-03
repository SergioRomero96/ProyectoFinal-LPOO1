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
    public partial class FrmAltaClientes : Form
    {
        private Cliente cliente;
        public static FrmAltaClientes instancia;
        private FrmGestionClientes frmGestionClientes;
        private bool modificar = false;

        public static FrmAltaClientes GetInstancia()
        {
            if (instancia == null)
                instancia = new FrmAltaClientes();
            return instancia;
        }

        public FrmAltaClientes()
        {
            InitializeComponent();
            cliente = new Cliente();
        }

        /**/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !(Convert.ToChar(Keys.Back) == e.KeyChar))//No es numero y tecla borrar
                e.Handled = true;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(Convert.ToChar(Keys.Back) == e.KeyChar)
                && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(Convert.ToChar(Keys.Back) == e.KeyChar)
                && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !(Convert.ToChar(Keys.Back) == e.KeyChar))
                e.Handled = true;
        }

        private void txtIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !(Convert.ToChar(Keys.Back) == e.KeyChar))
                e.Handled = true;
        }

        private void cargar_Datos()
        {
            this.cliente.Cli_Dni = txtDni.Text;
            this.cliente.Cli_Apellido = txtApellido.Text.ToUpper();
            this.cliente.Cli_Nombre = txtNombre.Text.ToUpper();
            this.cliente.Cli_Sexo = obtenerSexo();
            this.cliente.Cli_FechaNacimiento = Convert.ToDateTime( dtpFechaNacimiento.Text);
            this.cliente.Cli_Direccion = txtDireccion.Text.ToUpper();
            this.cliente.Cli_Telefono = txtTelefono.Text;
            this.cliente.Cli_Ingresos = Convert.ToDecimal(txtIngresos.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmGestionClientes = FrmGestionClientes.GetInstancia();

            if (!validarCamposVacios())
            {
                cargar_Datos();
                if (!modificar)
                {
                    if (validar_Cliente())
                    {
                        agregar_Cliente();
                        frmGestionClientes.cargar_Clientes();
                        frmGestionClientes.BringToFront();
                        this.Close();
                    }
                    else
                        MessageBox.Show("El cliente ingresado ya existe", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    modificar_Cliente();
                    frmGestionClientes.cargar_Clientes();
                    frmGestionClientes.BringToFront();
                    this.Close();
                }
            }
            else 
            { 
                if (!modificar)
                    MessageBox.Show("Algunos campos están vacíos", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Algunos campos están vacíos", "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validar_Cliente()
        {
            return GestionCliente.validar_Cliente(cliente).Rows.Count == 0;
        }

        public void Set_Cliente(Cliente cliente, bool modificar)
        {
            this.modificar = modificar;
            this.cliente.Cli_Dni = cliente.Cli_Dni;
            txtDni.Text = cliente.Cli_Dni;
            txtDni.Enabled = false;
            seleccionarSexo(cliente);
            txtApellido.Text = cliente.Cli_Apellido;
            txtNombre.Text = cliente.Cli_Nombre;
            dtpFechaNacimiento.Value = cliente.Cli_FechaNacimiento;
            txtDireccion.Text = cliente.Cli_Direccion;
            txtTelefono.Text = cliente.Cli_Telefono;
            txtIngresos.Text = Convert.ToString(cliente.Cli_Ingresos);
        }

        private void seleccionarSexo(Cliente cliente)
        {
            if (cliente.Cli_Sexo.Equals("Femenino"))
                rbFemenino.Checked = true;
            else
                rbMasculino.Checked = true;
        }

        private bool validarCamposVacios() 
        {
            bool error = false;
            msgError.Clear();
            if (txtDni.Text.Equals(""))
            {
                msgError.SetError(txtDni, "El campo DNI es requerido");
                error = true;
            }
            if (txtApellido.Text.Equals(""))
            {
                msgError.SetError(txtApellido, "El campo APELLIDO es requerido");
                error = true;
            }
            if (txtNombre.Text.Equals(""))
            {
                msgError.SetError(txtNombre, "El campo NOMBRE es requerido");
                error = true;
            }
            if (txtDireccion.Text.Equals(""))
            {
                msgError.SetError(txtDireccion, "El campo DIRECCIÓN es requerido");
                error = true;
            }
            if (txtTelefono.Text.Equals(""))
            {
                msgError.SetError(txtTelefono, "El campo TELÉFONO es requerido");
                error = true;
            }
            if (txtIngresos.Text.Equals(""))
            {
                msgError.SetError(txtIngresos, "El campo INGRESOS es requerido");
                error = true;
            }
            return error;
        }

        private string obtenerSexo() 
        {
            string sexo = null;
            if (rbFemenino.Checked)
                sexo = "Femenino";
            if (rbMasculino.Checked)
                sexo = "Masculino";
            return sexo;
        }

        private void agregar_Cliente() 
        {
            GestionCliente.insert_Cliente(this.cliente);
            MessageBox.Show("Cliente agregado con éxito", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);  
        }

        private void modificar_Cliente()
        {
            GestionCliente.update_Cliente(this.cliente);
            MessageBox.Show("Cliente modificado con éxito", "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmGestionClientes = FrmGestionClientes.GetInstancia();
            frmGestionClientes.BringToFront();
            this.Close();
        }

        private void FrmAltaClientes_Load(object sender, EventArgs e)
        {

        }

        private void FrmAltaClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

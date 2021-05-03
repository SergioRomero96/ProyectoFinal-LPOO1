using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Runtime.InteropServices;
namespace Vistas
{
    public partial class FrmAltaDestino : Form
    {
        private Destino destino;
        public FrmGestionDestino frmGestionDestino;
        private static FrmAltaDestino instancia;
        private bool modificar = false;

        public FrmAltaDestino()
        {
            InitializeComponent();
            destino = new Destino();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private bool validarCamposVacios()
        {
            bool error = false;
            msgError.Clear();
            if (txtDescripcion.Text.Equals(""))
            {
                msgError.SetError(txtDescripcion, "El campo DESCRIPCIÓN es requerido");
                error = true;
            }
            return error;
        }

        private void agregarPeriodo()
        {
            destino = new Destino();
            destino.Des_Codigo = Convert.ToInt32(txtCodigo.Text);
            destino.Des_Descripcion = txtDescripcion.Text.ToUpper();
        }

        private void cargar_Datos()
        {
            this.destino.Des_Descripcion = txtDescripcion.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmGestionDestino = FrmGestionDestino.GetInstancia();
            cargar_Datos();
            if (!validarCamposVacios())
            {
                if (!modificar)
                    if (validar_Destino())
                        agregarDestino();
                    else
                        MessageBox.Show("El destino ingresado ya existe", "Agregar destino", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    modificar_Destino();
                    frmGestionDestino.cargar_Destinos();
                    this.Close();
                }
            }
            else
            {
                if (!modificar)
                    MessageBox.Show("Algunos campos están vacíos", "Agregar destino", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Algunos campos están vacíos", "Modificar destino", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validar_Destino()
        {
            return GestionDestino.validar_Destino(destino).Rows.Count == 0;
        }

        private void modificar_Destino()
        {
            GestionDestino.update_Destino(this.destino);
            MessageBox.Show("Destino modificado con éxito", "Modificar destino", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void agregarDestino()
        {
            frmGestionDestino = FrmGestionDestino.GetInstancia();
            Destino destino = new Destino();
            destino.Des_Descripcion = txtDescripcion.Text;
            GestionDestino.insert_Destino(destino);
            MessageBox.Show("Destino agregado con éxito", "Agregar destino", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmGestionDestino.cargar_Destinos();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !(Convert.ToChar(Keys.Back) == e.KeyChar))
                e.Handled = true;
        }

        public static FrmAltaDestino GetInstancia()
        {
            if (instancia == null)
                instancia = new FrmAltaDestino();
            return instancia;
        }

        public void Set_Destino(Destino destino, bool modificar)
        {
            this.modificar = modificar;
            this.destino.Des_Codigo = destino.Des_Codigo;
            txtCodigo.Text = destino.Des_Codigo.ToString();
            txtDescripcion.Text = destino.Des_Descripcion;
        }
  
        private void FrmAltaDestino_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void FrmAltaDestino_Load(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            if (!modificar)
            {
                int ultimoID = Convert.ToInt32(GestionDestino.Get_UltimoID().Rows[0][0]) + 1;
                txtCodigo.Text = ultimoID.ToString();
            }            
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
    }
}

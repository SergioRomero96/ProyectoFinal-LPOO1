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
    public partial class FrmAltaUsuario : Form
    {
        private FrmGestionUsuarios frmGestionUsuario;
        private static FrmAltaUsuario instancia;
        private bool modificar = false;
        private Usuario usuario;
        private string rol;

        public FrmAltaUsuario()
        {
            InitializeComponent();
            usuario = new Usuario();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static FrmAltaUsuario GetInstancia()
        {
            if (instancia == null)
                instancia = new FrmAltaUsuario();
            return instancia;
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            cargar_Roles();
            if (modificar)
                cmbRol.SelectedValue = rol;
        }

        private void cargar_Roles()
        {
            cmbRol.DisplayMember = "ROL_Descripcion";
            cmbRol.ValueMember = "ROL_Codigo";
            cmbRol.DataSource = GestionUsuario.GetRoles();
        }

        private void cargar_Datos() 
        {
            this.usuario.Usu_NombreUsuario = txtUsuario.Text;
            this.usuario.Usu_Password = txtPassword.Text;
            this.usuario.Usu_Apellido = txtApellido.Text.ToUpper();
            this.usuario.Usu_Nombre = txtNombre.Text.ToUpper();
            this.usuario.Rol_Codigo = (int)cmbRol.SelectedValue;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmGestionUsuario = FrmGestionUsuarios.GetInstancia();
            cargar_Datos();
            if (!validarCamposVacios())
            {
                if (!modificar)
                {
                    if (validar_Usuario())
                    {
                        agregar_Usuario();
                        frmGestionUsuario.cargar_Usuarios();
                        frmGestionUsuario.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("El usuario ingresado ya existe", "Agregar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    modificar_Usuario();
                    frmGestionUsuario.cargar_Usuarios();
                    frmGestionUsuario.Show();
                    this.Close();
                }
            }
            else
            {
                if (!modificar)
                    MessageBox.Show("Algunos campos están vacíos", "Agregar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Algunos campos están vacíos", "Modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarCamposVacios()
        {
            bool error = false;
            msgError.Clear();
            if (txtUsuario.Text.Equals(""))
            {
                msgError.SetError(txtUsuario, "El campo USUARIO es requerido");
                error = true;
            }
            if (txtPassword.Text.Equals(""))
            {
                msgError.SetError(txtPassword, "El campo CONTRASEÑA es requerido");
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
            return error;
        }

        private bool validar_Usuario() 
        {
            return GestionUsuario.ValidarUsuario(usuario).Rows.Count == 0;
        }

        private void agregar_Usuario() 
        {
            GestionUsuario.insert_Usuario(this.usuario);
            MessageBox.Show("Usuario agregado con éxito", "Agregar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);  
        }

        private void modificar_Usuario()
        {
            GestionUsuario.update_Usuario(this.usuario);
            MessageBox.Show("Usuario modificado con éxito","Modificar usuario",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmGestionUsuario = FrmGestionUsuarios.GetInstancia();
            frmGestionUsuario.BringToFront();
            this.Close();
        }

        private void FrmAltaUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        public void Set_Usuario(Usuario usuario,String rol, bool modificar) 
        {
            this.modificar = modificar;
            this.usuario.Usu_Id = usuario.Usu_Id;
            txtUsuario.Text = usuario.Usu_NombreUsuario;
            txtPassword.Text = usuario.Usu_Password;
            txtApellido.Text = usuario.Usu_Apellido;
            txtNombre.Text = usuario.Usu_Nombre;
            this.rol = rol;
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

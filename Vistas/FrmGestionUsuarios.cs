using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using ClasesBase.Cache;

namespace Vistas
{
    public partial class FrmGestionUsuarios : Form
    {
        private FrmAltaUsuario frmAltaUsuario;
        private Usuario usuario;
        private String rol;
        public static FrmGestionUsuarios instancia;

        public FrmGestionUsuarios()
        {
            InitializeComponent();
        }

        public static FrmGestionUsuarios GetInstancia()
        {
            if (instancia == null)
                instancia = new FrmGestionUsuarios();
            return instancia;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaUsuario = FrmAltaUsuario.GetInstancia();
            frmAltaUsuario.Show();
        }

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            cargar_Usuarios();
        }

        public void cargar_Usuarios()
        {
            dgwUsuarios.DataSource = GestionUsuario.list_Usuarios();
            dgwUsuarios.Columns["ID"].Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string apellido, nombre;
            int pos = txtBuscar.Text.IndexOf(' ');

            if (pos >= 0)
            {
                apellido = txtBuscar.Text.Substring(0, pos);
                nombre = txtBuscar.Text.Substring(pos + 1);
                if (apellido != "" && nombre != "")
                    dgwUsuarios.DataSource = GestionUsuario.buscar_Usuario(apellido, nombre,true);
                else
                    dgwUsuarios.DataSource = GestionUsuario.buscar_Usuario(apellido, nombre, false);
            }
            else
            {
                apellido = txtBuscar.Text;
                nombre = txtBuscar.Text;
                dgwUsuarios.DataSource = GestionUsuario.buscar_Usuario(apellido, nombre, false);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAltaUsuario frmAltaUsuario = FrmAltaUsuario.GetInstancia();
            frmAltaUsuario.Set_Usuario(this.usuario,rol, true);
            frmAltaUsuario.lblUsuario.Text = "MODIFICAR USUARIO";
            frmAltaUsuario.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion =  MessageBox.Show("Desea eliminar al usuario: " + this.usuario.Usu_NombreUsuario+" ?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(opcion.Equals(DialogResult.Yes))
            {
                if (UserLoginCache.UsuarioLogin.Usu_NombreUsuario != usuario.Usu_NombreUsuario)
                {
                    if (verificarAdministrador() || usuario.Rol_Codigo != 1)
                    {
                        GestionUsuario.delete_Usuario(usuario);
                        MessageBox.Show("Usuario eliminado con éxito", "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargar_Usuarios();
                    }
                    else
                        MessageBox.Show("Debe haber al menos un usuario del tipo 'Administrador'", "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("No se puede eliminar el usuario en sesión", "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private bool verificarAdministrador() 
        {
            return GestionUsuario.GetCantidadAdministradores() > 1;
        }

        private void FrmGestionUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void rbOrg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrg.Checked)
                cargar_Usuarios();
        }

        private void rbApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbApellido.Checked)
            {
                dgwUsuarios.DataSource = GestionUsuario.ordenar_Usuarios(false).Tables[0];
                dgwUsuarios.Refresh();
            }
        }

        private void rbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuario.Checked)
            {
                dgwUsuarios.DataSource = GestionUsuario.ordenar_Usuarios(true).Tables[0];
                dgwUsuarios.Refresh();
            }
        }

        private void dgwUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwUsuarios.CurrentRow != null)
            {
                usuario = new Usuario();
                usuario.Usu_Id = (int)dgwUsuarios.CurrentRow.Cells["ID"].Value;
                usuario.Usu_NombreUsuario = dgwUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                usuario.Usu_Password = dgwUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                usuario.Usu_Apellido = dgwUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
                usuario.Usu_Nombre = dgwUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                usuario.Rol_Codigo = (int)dgwUsuarios.CurrentRow.Cells["Id_Rol"].Value;
                rol = dgwUsuarios.CurrentRow.Cells["Id_Rol"].Value.ToString();

            }
        }
    }
}

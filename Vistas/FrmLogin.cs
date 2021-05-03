using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Threading.Tasks;
using ClasesBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        private List<Rol> listaRol = new List<Rol>();
        private List<Usuario> listaUsuarios = new List<Usuario>();

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.BackColor = System.Drawing.Color.Gold;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            inicio_sesion();
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                inicio_sesion();
        }

        private void inicio_sesion()
        {
            DataTable datos = GestionUsuario.ValidarLogin(txtUserName.Text, txtPassword.Text);
            if (datos.Rows.Count == 1)
            {
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Datos erróneos. Por favor, inténtelo otra vez.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

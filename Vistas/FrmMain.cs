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
using ClasesBase.Cache;

namespace Vistas
{
    public partial class FrmMain : Form
    {
        private static  FrmMain instancia;
        Button btnActive = new Button();

        public FrmMain()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void activar_focus(Button btnFocus)
        {
            btnFocus.BackColor = Color.DodgerBlue;
            if (btnFocus != btnActive)
                btnActive.BackColor = Color.Transparent;
            btnActive = btnFocus;
        }

        int lx, ly;
        int sw, sh;
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static FrmMain GetInstancia() 
        {
            if (instancia == null)
                instancia = new FrmMain();
            return instancia;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            activar_focus(btnInicio);
            AbrirFormEnPanel(new FrmDashboard());
            GestionDeAcceso();
            lblUsuario.Text += UserLoginCache.UsuarioLogin.Usu_NombreUsuario;
            lblApellidoyNombre.Text += UserLoginCache.UsuarioLogin.Usu_Apellido + ", " + UserLoginCache.UsuarioLogin.Usu_Nombre;
            lblRol.Text += GestionUsuario.Get_Rol(UserLoginCache.UsuarioLogin.Rol_Codigo);
        }

        private void GestionDeAcceso() 
        {
            //controlar los accesos
            int rol = UserLoginCache.UsuarioLogin.Rol_Codigo;
            if (rol == 1) 
            {
                this.btnPagos.Enabled = false;
                this.btnClientes.Enabled = false;
                this.btnPrestamos.Enabled = false;
            }
            else if( rol == 2)
            {
                this.btnUsuarios.Enabled = false;
                this.btnDestinos.Enabled = false;
                this.btnPeriodos.Enabled = false;
            }
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios frmGestionUsuarios = FrmGestionUsuarios.GetInstancia();
            frmGestionUsuarios.Show();
        }


        //---------------------------------------------NUEVO----------------------------------------


        //METODO PARA HORA Y FECHA ACTUAL ----------------------------------------------------------
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }
        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.pnlPrincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Desea cerrar el sistema? ", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resp == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 200)
                pnlMenu.Width = 50;
            else
                pnlMenu.Width = 200;
        }

        private void AbrirFormEnPanel(object formHijo) 
        {
            if (pnlContenedor.Controls.Count > 0)
                pnlContenedor.Controls.RemoveAt(0);
            Form fh = (Form) formHijo;
            fh.TopLevel = false; //mostrarse como ventana de nivel superior
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(fh);
            pnlContenedor.Tag = fh; //obtiene o establece el objeto que contiene datos sobre el control
            fh.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            activar_focus(btnClientes);
            FrmGestionClientes.instancia = null;
            AbrirFormEnPanel(FrmGestionClientes.GetInstancia());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            activar_focus(btnUsuarios);
            FrmGestionUsuarios.instancia = null;
            AbrirFormEnPanel(FrmGestionUsuarios.GetInstancia());
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            activar_focus(btnDestinos);
            FrmGestionDestino.instancia = null;
            AbrirFormEnPanel(FrmGestionDestino.GetInstancia());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            activar_focus(btnPagos);
            FrmGestionPago.instancia = null;
            AbrirFormEnPanel(FrmGestionPago.GetInstancia());
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            activar_focus(btnPrestamos);
            FrmGestionPrestamo.instancia = null;
            AbrirFormEnPanel(FrmGestionPrestamo.GetInstancia());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            activar_focus(btnInicio);
            AbrirFormEnPanel(new FrmDashboard());
        }

        private void btnPeriodos_Click(object sender, EventArgs e)
        {
            activar_focus(btnPeriodos);
            AbrirFormEnPanel(new FrmGestionPeriodo());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void cerrarSesion()
        {
            DialogResult opc = MessageBox.Show("¿Desea cerrar sesión?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (opc.Equals(DialogResult.Yes))
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Close();
            }
        }

        private void FrmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.D1))
            {
                activar_focus(btnInicio);
                AbrirFormEnPanel(new FrmDashboard());
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.D2))
            {
                int rol = UserLoginCache.UsuarioLogin.Rol_Codigo;
                if (rol == 1)
                    MessageBox.Show("No tiene el permiso necesario para acceder al módulo de Clientes", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    activar_focus(btnClientes);
                    FrmGestionClientes.instancia = null;
                    AbrirFormEnPanel(FrmGestionClientes.GetInstancia());
                }
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.D3))
            {
                int rol = UserLoginCache.UsuarioLogin.Rol_Codigo;
                if (rol == 2)
                    MessageBox.Show("No tiene el permiso necesario para acceder al módulo de Destinos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    activar_focus(btnDestinos);
                    FrmGestionDestino.instancia = null;
                    AbrirFormEnPanel(FrmGestionDestino.GetInstancia());
                }
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.D4))
            {
                int rol = UserLoginCache.UsuarioLogin.Rol_Codigo;
                if (rol == 2)
                    MessageBox.Show("No tiene el permiso necesario para acceder al módulo de Periodos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    activar_focus(btnPeriodos);
                    AbrirFormEnPanel(new FrmGestionPeriodo());
                }
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.D5))
            {
                int rol = UserLoginCache.UsuarioLogin.Rol_Codigo;
                if (rol == 1)
                    MessageBox.Show("No tiene el permiso necesario para acceder al módulo de Préstamos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    activar_focus(btnPrestamos);
                    FrmGestionPrestamo.instancia = null;
                    AbrirFormEnPanel(FrmGestionPrestamo.GetInstancia());
                }
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.D6))
            {
                int rol = UserLoginCache.UsuarioLogin.Rol_Codigo;
                if (rol == 1)
                    MessageBox.Show("No tiene el permiso necesario para acceder al módulo de Pagos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    activar_focus(btnPagos);
                    FrmGestionPago.instancia = null;
                    AbrirFormEnPanel(FrmGestionPago.GetInstancia());
                }
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.D7))
            {
                int rol = UserLoginCache.UsuarioLogin.Rol_Codigo;
                if (rol == 2)
                    MessageBox.Show("No tiene el permiso necesario para acceder al módulo de Usuarios", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    activar_focus(btnUsuarios);
                    FrmGestionUsuarios.instancia = null;
                    AbrirFormEnPanel(FrmGestionUsuarios.GetInstancia());
                }
            }
        }     
    }
}

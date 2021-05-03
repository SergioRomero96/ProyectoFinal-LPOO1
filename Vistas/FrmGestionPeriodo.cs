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
    public partial class FrmGestionPeriodo : Form
    {
        private static FrmGestionPeriodo instancia;

        public FrmGestionPeriodo()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public static FrmGestionPeriodo GetInstancia() 
        {
            if (instancia == null)
                instancia = new FrmGestionPeriodo();
            return instancia;
        }

        private void FrmGestionPeriodo_Load(object sender, EventArgs e)
        {
            dgwPeriodo.DataSource = GestionPrestamo.ListarPeriodos();
            dgwPeriodo.Columns["Codigo"].Visible = false;
        }

        private void FrmGestionPeriodo_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

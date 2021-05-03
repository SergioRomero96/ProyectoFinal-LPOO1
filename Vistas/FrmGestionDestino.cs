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
    public partial class FrmGestionDestino : Form
    {
        private FrmAltaDestino frmAltaDestino;
        private Destino destino;
        public static FrmGestionDestino instancia;

        public FrmGestionDestino()
        {
            InitializeComponent();
        }

        public void cargar_Destinos()
        {
            dgwDestino.DataSource = GestionDestino.list_Destino();
            dgwDestino.Columns["ID"].Visible = false;
        }

        private void FrmGestionDestino_Load(object sender, EventArgs e)
        {
            cargar_Destinos();
        }

        public static FrmGestionDestino GetInstancia()
        {
            if (instancia == null)
                instancia = new FrmGestionDestino();
            return instancia;
        }

        private void FrmGestionDestino_FormClosing(object sender, FormClosingEventArgs e)
        {
            instancia = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDestino = FrmAltaDestino.GetInstancia();
            frmAltaDestino.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAltaDestino frmAltaDestino = FrmAltaDestino.GetInstancia();
            frmAltaDestino.Set_Destino(this.destino, true);
            frmAltaDestino.lblDestino.Text = "MODIFICAR DESTINO";
            frmAltaDestino.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea eliminar el destino: " + this.destino.Des_Descripcion + " ?", "Eliminar destino", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (opcion.Equals(DialogResult.Yes))
            {
                if (GestionDestino.devolverTienePrestamo(Convert.ToInt32(this.destino.Des_Codigo)) > 0)
                {
                    MessageBox.Show("No se puede eliminar el destino porque tiene préstamo asignado", "Eliminar destino", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GestionDestino.delete_Destino(destino);
                    MessageBox.Show("Destino eliminado con éxito", "Eliminar destino", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar_Destinos();
                }
            }
        }

        private void dgwDestino_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgwDestino.CurrentRow != null)
            {
                destino = new Destino();
                destino.Des_Codigo = (int)dgwDestino.CurrentRow.Cells["ID"].Value;
                destino.Des_Descripcion = dgwDestino.CurrentRow.Cells["Descripcion"].Value.ToString();
            }
        }
    }
}

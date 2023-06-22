using CircConCentroFer2023.Entidades;
using System;
using System.Windows.Forms;

namespace CircConCentroFer2023.Windows
{
    public partial class frmGrilla : Form
    {
        public frmGrilla()
        {
            InitializeComponent();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmCircAE frm = new frmCircAE() { Text = "Ingresar nueva Circunferencia" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Circunferencia circ = frm.GetCircunferencia();
            DataGridViewRow r = ConstruirFila();
            SetearFila(r, circ);
            AgregarFila(r);
        }

        private void SetearFila(DataGridViewRow r, Circunferencia circ)
        {
            r.Cells[colRadio.Index].Value = circ.Radio;
            r.Cells[colCentro.Index].Value = circ.Centro.ToString();
            r.Cells[colSuperficie.Index].Value = circ.GetSuperficie();
            r.Cells[colPerimetro.Index].Value = circ.GetPerimetro();

            r.Tag = circ;//reservo la circ en la property tag

        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvCirc.Rows.Add(r);
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvCirc);
            return r;
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            //No tengo fila seleccionada
            if (dgvCirc.SelectedRows.Count==0)
            {
                return;
            }
            //obtener la fila
            var r = dgvCirc.SelectedRows[0];
            DialogResult dr=MessageBox.Show("¿Desea borrar la fila seleccionada?",
                "Confirmar Baja",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No) {
                return;
            }
            dgvCirc.Rows.Remove(r);

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            //No tengo fila seleccionada
            if (dgvCirc.SelectedRows.Count == 0)
            {
                return;
            }
            //obtener la fila
            var r = dgvCirc.SelectedRows[0];
            Circunferencia c =(Circunferencia) r.Tag;
            frmCircAE frm = new frmCircAE() { Text = "Editar Circunferencia" };
            frm.SetCircunferencia(c);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }
            c=frm.GetCircunferencia();
            SetearFila(r,c);

        }
    }
}

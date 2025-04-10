using Bombones2025.Entidades;
using Bombones2025.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones2025.Windows
{
    public partial class FrmRellenos : Form
    {
        private readonly RellenoServicio _rellenoServicio;
        private List<Relleno> _rellenos = new();
        public FrmRellenos(RellenoServicio rellenoServicio)
        {
            InitializeComponent();
            _rellenoServicio = rellenoServicio;
        }

        private void FrmRellenos_Load(object sender, EventArgs e)
        {
            _rellenos = _rellenoServicio.GetRellenos();

            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (Relleno relleno in _rellenos)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, relleno);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Relleno relleno)
        {
            r.Cells[0].Value = relleno.RellenoId;
            r.Cells[1].Value = relleno.Descripcion;
            r.Tag = relleno;
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            FrmRellenosAE frm = new FrmRellenosAE() { Text = "Nuevo Relleno" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Relleno relleno = frm.GetRelleno();
            if (relleno == null) return;
            if (!_rellenoServicio.Existe(relleno))
            {
                _rellenoServicio.Guardar(relleno);
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, relleno);
                AgregarFila(r);
                MessageBox.Show("Relleno agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El relleno ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            Relleno relleno = (Relleno)r.Tag!;
            FrmRellenosAE frm = new FrmRellenosAE() { Text = "Editar Relleno" };
            frm.SetRelleno(relleno);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            relleno = frm.GetRelleno();
            if (relleno == null) return;
            if (!_rellenoServicio.Existe(relleno))
            {
                _rellenoServicio.Guardar(relleno);
                SetearFila(r, relleno);
                MessageBox.Show("Relleno editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El relleno ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsbBorrar_Click(object sender, EventArgs e)
        {
            if(dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            Relleno relleno = (Relleno)r.Tag!;
            DialogResult dr = MessageBox.Show($"Borrar  {relleno}?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;
            _rellenoServicio.Borrar(relleno);
            dgvDatos.Rows.Remove(r);
            MessageBox.Show("Relleno borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

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
    public partial class FrmFrutosSecos : Form
    {
        private readonly FrutoSecoServicio _frutoServicio;

        private List<FrutoSeco> _frutosSecos = new List<FrutoSeco>();
        public FrmFrutosSecos(FrutoSecoServicio frutoServicio)
        {
            InitializeComponent();
            _frutoServicio = frutoServicio;
        }

        private void FrmFrutosSecos_Load(object sender, EventArgs e)
        {
            _frutosSecos = _frutoServicio.GetFrutos();

            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (FrutoSeco fruto in _frutosSecos)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, fruto);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, FrutoSeco fruto)
        {
            r.Cells[0].Value = fruto.FrutoSecoId;
            r.Cells[1].Value = fruto.Descripcion;

            r.Tag = fruto;
        }

        private void TsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            FrmFrutosSecosAE frm = new FrmFrutosSecosAE() { Text = " Nuevo fruto seco:" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;

            FrutoSeco fruto = frm.GetFruto();
            if (fruto == null) return;

            if (!_frutoServicio.Existe(fruto))
            {
                _frutoServicio.Guardar(fruto);
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, fruto);
                AgregarFila(r);

                MessageBox.Show("Fruto agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fruto existente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            FrutoSeco frutoParaBorrar = (FrutoSeco)r.Tag!;
            DialogResult dr = MessageBox.Show($"Borrar {frutoParaBorrar}??", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;

            _frutoServicio.Borrar(frutoParaBorrar);
            dgvDatos.Rows.Remove(r);
            MessageBox.Show("Fruto eliminado!");
        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }   
            var r = dgvDatos.SelectedRows[0];
            FrutoSeco fruto = (FrutoSeco)r.Tag!;

            FrmFrutosSecosAE frm = new FrmFrutosSecosAE() { Text = " Editar fruto seco:" };
            frm.SetFruto(fruto);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;

            fruto = frm.GetFruto();
            if (fruto == null) return;

            if(!_frutoServicio.Existe(fruto))
            {
                _frutoServicio.Guardar(fruto);
                SetearFila(r, fruto);
                MessageBox.Show("Fruto editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fruto existente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

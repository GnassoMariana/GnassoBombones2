using Bombones2025.Entidades;
using Bombones2025.Servicios;

namespace Bombones2025.Windows
{
    public partial class FrmChocolates : Form
    {
        private readonly ChocolateServicio _chocolateServicio;
        private List<Chocolate> _chocolates = new();
        public FrmChocolates(ChocolateServicio chocoServicio)
        {

            InitializeComponent();
            _chocolateServicio = chocoServicio;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmChocolates_Load(object sender, EventArgs e)
        {
            _chocolates = _chocolateServicio.GetChocolates();
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (Chocolate choco in _chocolates)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, choco);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Chocolate choco)
        {
            r.Cells[0].Value = choco.ChocolateId;
            r.Cells[1].Value = choco.Descripcion;

            r.Tag = choco;
        }

        private void TsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            FrmChocolatesAE frm = new FrmChocolatesAE() { Text = "Nuevo chocolate" };
            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Chocolate choco = frm.GetChocolate();
            if (choco == null) return;

            if (_chocolateServicio.Existe(choco))
            {
                _chocolateServicio.Guardar(choco);
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, choco);
                AgregarFila(r);
                MessageBox.Show("Chocolate agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Él chocolate ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            Chocolate chocoBorrar = (Chocolate)r.Tag!;

            DialogResult dr = MessageBox.Show($"Borrar {chocoBorrar.Descripcion}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;

            _chocolateServicio.Borrar(chocoBorrar);
            dgvDatos.Rows.Remove(r);
            MessageBox.Show("Chocolate borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            Chocolate choco = (Chocolate)r.Tag!;

            FrmChocolatesAE frm = new FrmChocolatesAE() { Text = "Editar chocolate" };
            frm.SetChocolate(choco);
            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                return;
            }
            choco = frm.GetChocolate();
            if (choco == null) return;

            if(!_chocolateServicio.Existe(choco))
            {
                _chocolateServicio.Guardar(choco);
                SetearFila(r, choco);
                MessageBox.Show("Chocolate editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Él chocolate ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}

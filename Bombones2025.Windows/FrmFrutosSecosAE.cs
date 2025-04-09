using Bombones2025.Entidades;

namespace Bombones2025.Windows
{
    public partial class FrmFrutosSecosAE : Form
    {
        private FrutoSeco fruto;
        public FrmFrutosSecosAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (fruto is not null)
            {
                TxtFruto.Text = fruto.Descripcion;
            }
        }

        public FrutoSeco GetFruto()
        {
            return fruto;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (fruto is null)
                {
                    fruto = new FrutoSeco();

                }               
                fruto.Descripcion = TxtFruto.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TxtFruto.Text))
            {
                valido = false;
                errorProvider1.SetError(TxtFruto, "Escribir el nombre!!!");
            }
            return valido;
        }

        internal void SetFruto(FrutoSeco fruto)
        {
            this.fruto = fruto;
        }
    }
}

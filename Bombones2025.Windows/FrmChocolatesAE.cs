using Bombones2025.Entidades;
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
    public partial class FrmChocolatesAE : Form
    {
        private Chocolate chocolate;
        public FrmChocolatesAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (chocolate is not null)
            {
                TxtChocolate.Text = chocolate.Descripcion;
            }
        }

        public Chocolate GetChocolate()
        {
            return chocolate;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (chocolate is null)
                {
                    chocolate = new Chocolate();
                }
                chocolate.Descripcion = TxtChocolate.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TxtChocolate.Text))
            {
                valido = false;
                errorProvider1.SetError(TxtChocolate, "Escribir el nombre!!!");
            }
            return valido;
        }

        private void FrmChocolatesAE_Load(object sender, EventArgs e)
        {

        }

        public void SetChocolate(Chocolate choco)
        {
            chocolate = choco;
        }
    }
}

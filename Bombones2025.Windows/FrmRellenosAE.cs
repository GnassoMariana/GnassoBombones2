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
    public partial class FrmRellenosAE : Form
    {
        private Relleno? relleno;
        public FrmRellenosAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (relleno is not null)
            {
                TxtRelleno.Text = relleno.Descripcion;
            }
        }

        public Relleno? GetRelleno()
        {
            return relleno;
        }

        private void FrmRellenosAE_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(ValidarDatos())
            {
                if(relleno is null)
                {
                    relleno = new Relleno();
                }
                relleno.Descripcion = TxtRelleno.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if(string.IsNullOrEmpty(TxtRelleno.Text))
            {
                valido = false;
                errorProvider1.SetError(TxtRelleno, "Escribir el nombre!!!");
            }
            return valido;
        }

        internal void SetRelleno(Relleno relleno)
        {
           this.relleno = relleno;
        }
    }
}

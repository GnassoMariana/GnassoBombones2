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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnPaises_Click(object sender, EventArgs e)
        {
            PaisServicio servicio = new PaisServicio("Paises.Txt");
            FrmPaises frm = new FrmPaises(servicio) { Text = "Listado de Paises" };
            frm.ShowDialog(this);
        }

        private void btnFrutos_Click(object sender, EventArgs e)
        {
            FrutoSecoServicio servicio = new FrutoSecoServicio("FrutosSecos.txt");
            FrmFrutosSecos frm = new FrmFrutosSecos(servicio) { Text = "Lista de frutos secos:" };
            frm.ShowDialog(this);
        }

        private void BtnChocolate_Click(object sender, EventArgs e)
        {
            ChocolateServicio servicio = new ChocolateServicio("Chocolates.txt");
            FrmChocolates frm = new FrmChocolates(servicio) { Text = "Listado de chocolates" };
            frm.ShowDialog(this);

        }

        private void BtnRellenos_Click(object sender, EventArgs e)
        {
            RellenoServicio servicio = new RellenoServicio("Rellenos.txt");
            FrmRellenos frm = new FrmRellenos(servicio) { Text = "Listado de rellenos" };
            frm.ShowDialog(this);

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

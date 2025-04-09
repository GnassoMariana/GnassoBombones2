﻿using Bombones2025.Entidades;
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
    }
}

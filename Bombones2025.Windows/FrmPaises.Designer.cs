namespace Bombones2025.Windows
{
    partial class FrmPaises 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colPais = new DataGridViewTextBoxColumn();
            TxtCantidadPaginas = new TextBox();
            CboPaginas = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            BtnUltimo = new Button();
            BtnSiguiente = new Button();
            BtnAnterior = new Button();
            BtnPrimero = new Button();
            TsbNuevo = new ToolStripButton();
            TsbBorrar = new ToolStripButton();
            TsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TsbFiltrar = new ToolStripButton();
            TsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            TsbImprimir = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            TsbCerrar = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 67);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtCantidadPaginas);
            splitContainer1.Panel2.Controls.Add(CboPaginas);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(BtnUltimo);
            splitContainer1.Panel2.Controls.Add(BtnSiguiente);
            splitContainer1.Panel2.Controls.Add(BtnAnterior);
            splitContainer1.Panel2.Controls.Add(BtnPrimero);
            splitContainer1.Size = new Size(914, 756);
            splitContainer1.SplitterDistance = 604;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 5;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, colPais });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Margin = new Padding(3, 4, 3, 4);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(914, 604);
            dgvDatos.TabIndex = 2;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            colId.Width = 125;
            // 
            // colPais
            // 
            colPais.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPais.HeaderText = "País";
            colPais.MinimumWidth = 6;
            colPais.Name = "colPais";
            colPais.ReadOnly = true;
            // 
            // TxtCantidadPaginas
            // 
            TxtCantidadPaginas.Location = new Point(201, 51);
            TxtCantidadPaginas.Margin = new Padding(3, 4, 3, 4);
            TxtCantidadPaginas.Name = "TxtCantidadPaginas";
            TxtCantidadPaginas.ReadOnly = true;
            TxtCantidadPaginas.Size = new Size(97, 27);
            TxtCantidadPaginas.TabIndex = 19;
            // 
            // CboPaginas
            // 
            CboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            CboPaginas.FormattingEnabled = true;
            CboPaginas.Location = new Point(83, 51);
            CboPaginas.Margin = new Padding(3, 4, 3, 4);
            CboPaginas.Name = "CboPaginas";
            CboPaginas.Size = new Size(77, 28);
            CboPaginas.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 55);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 16;
            label2.Text = "de:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 55);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 17;
            label1.Text = "Pág.:";
            // 
            // BtnUltimo
            // 
            BtnUltimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnUltimo.Image = Properties.Resources.last_24px;
            BtnUltimo.Location = new Point(790, 44);
            BtnUltimo.Margin = new Padding(3, 4, 3, 4);
            BtnUltimo.Name = "BtnUltimo";
            BtnUltimo.Size = new Size(86, 55);
            BtnUltimo.TabIndex = 12;
            BtnUltimo.UseVisualStyleBackColor = true;
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSiguiente.Image = Properties.Resources.next_24px;
            BtnSiguiente.Location = new Point(697, 44);
            BtnSiguiente.Margin = new Padding(3, 4, 3, 4);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(86, 55);
            BtnSiguiente.TabIndex = 13;
            BtnSiguiente.UseVisualStyleBackColor = true;
            // 
            // BtnAnterior
            // 
            BtnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAnterior.Image = Properties.Resources.previous_24px;
            BtnAnterior.Location = new Point(605, 44);
            BtnAnterior.Margin = new Padding(3, 4, 3, 4);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(86, 55);
            BtnAnterior.TabIndex = 14;
            BtnAnterior.UseVisualStyleBackColor = true;
            // 
            // BtnPrimero
            // 
            BtnPrimero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnPrimero.Image = Properties.Resources.first_24px;
            BtnPrimero.Location = new Point(512, 44);
            BtnPrimero.Margin = new Padding(3, 4, 3, 4);
            BtnPrimero.Name = "BtnPrimero";
            BtnPrimero.Size = new Size(86, 55);
            BtnPrimero.TabIndex = 15;
            BtnPrimero.UseVisualStyleBackColor = true;
            // 
            // TsbNuevo
            // 
            TsbNuevo.Image = Properties.Resources.Nuevo;
            TsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            TsbNuevo.ImageTransparentColor = Color.Magenta;
            TsbNuevo.Name = "TsbNuevo";
            TsbNuevo.Size = new Size(56, 64);
            TsbNuevo.Text = "Nuevo";
            TsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbNuevo.Click += TsbNuevo_Click;
            // 
            // TsbBorrar
            // 
            TsbBorrar.Image = Properties.Resources.Delete;
            TsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbBorrar.ImageTransparentColor = Color.Magenta;
            TsbBorrar.Name = "TsbBorrar";
            TsbBorrar.Size = new Size(54, 64);
            TsbBorrar.Text = "Borrar";
            TsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbBorrar.Click += TsbBorrar_Click;
            // 
            // TsbEditar
            // 
            TsbEditar.Image = Properties.Resources.Edit;
            TsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            TsbEditar.ImageTransparentColor = Color.Magenta;
            TsbEditar.Name = "TsbEditar";
            TsbEditar.Size = new Size(52, 64);
            TsbEditar.Text = "Editar";
            TsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbEditar.Click += TsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 67);
            // 
            // TsbFiltrar
            // 
            TsbFiltrar.Image = Properties.Resources.filter_40px;
            TsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbFiltrar.ImageTransparentColor = Color.Magenta;
            TsbFiltrar.Name = "TsbFiltrar";
            TsbFiltrar.Size = new Size(51, 64);
            TsbFiltrar.Text = "Filtrar";
            TsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // TsbActualizar
            // 
            TsbActualizar.Image = Properties.Resources.Update;
            TsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            TsbActualizar.ImageTransparentColor = Color.Magenta;
            TsbActualizar.Name = "TsbActualizar";
            TsbActualizar.Size = new Size(79, 64);
            TsbActualizar.Text = "Actualizar";
            TsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 67);
            // 
            // TsbImprimir
            // 
            TsbImprimir.Image = Properties.Resources.Print;
            TsbImprimir.ImageScaling = ToolStripItemImageScaling.None;
            TsbImprimir.ImageTransparentColor = Color.Magenta;
            TsbImprimir.Name = "TsbImprimir";
            TsbImprimir.Size = new Size(70, 64);
            TsbImprimir.Text = "Imprimir";
            TsbImprimir.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 67);
            // 
            // TsbCerrar
            // 
            TsbCerrar.Image = Properties.Resources.Close;
            TsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbCerrar.ImageTransparentColor = Color.Magenta;
            TsbCerrar.Name = "TsbCerrar";
            TsbCerrar.Size = new Size(53, 64);
            TsbCerrar.Text = "Cerrar";
            TsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbCerrar.Click += TsbCerrar_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbNuevo, TsbBorrar, TsbEditar, toolStripSeparator1, TsbFiltrar, TsbActualizar, toolStripSeparator2, TsbImprimir, toolStripSeparator3, TsbCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 67);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // FrmPaises
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 823);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPaises";
            Text = "Paises";
            Load += FrmPaises_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private TextBox TxtCantidadPaginas;
        private ComboBox CboPaginas;
        private Label label2;
        private Label label1;
        private Button BtnUltimo;
        private Button BtnSiguiente;
        private Button BtnAnterior;
        private Button BtnPrimero;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colPais;
        private ToolStripButton TsbNuevo;
        private ToolStripButton TsbBorrar;
        private ToolStripButton TsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsbFiltrar;
        private ToolStripButton TsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton TsbImprimir;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton TsbCerrar;
        private ToolStrip toolStrip1;
    }
}
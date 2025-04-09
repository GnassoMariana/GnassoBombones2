namespace Bombones2025.Windows
{
    partial class FrmPrincipal
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
            BtnPaises = new Button();
            btnFrutos = new Button();
            BtnChocolate = new Button();
            BtnRellenos = new Button();
            SuspendLayout();
            // 
            // BtnPaises
            // 
            BtnPaises.Location = new Point(46, 61);
            BtnPaises.Margin = new Padding(3, 4, 3, 4);
            BtnPaises.Name = "BtnPaises";
            BtnPaises.Size = new Size(99, 72);
            BtnPaises.TabIndex = 0;
            BtnPaises.Text = "Países";
            BtnPaises.UseVisualStyleBackColor = true;
            BtnPaises.Click += BtnPaises_Click;
            // 
            // btnFrutos
            // 
            btnFrutos.Location = new Point(204, 62);
            btnFrutos.Name = "btnFrutos";
            btnFrutos.Size = new Size(94, 70);
            btnFrutos.TabIndex = 1;
            btnFrutos.Text = "Frutos secos";
            btnFrutos.UseVisualStyleBackColor = true;
            btnFrutos.Click += btnFrutos_Click;
            // 
            // BtnChocolate
            // 
            BtnChocolate.Location = new Point(361, 62);
            BtnChocolate.Name = "BtnChocolate";
            BtnChocolate.Size = new Size(94, 70);
            BtnChocolate.TabIndex = 2;
            BtnChocolate.Text = "Chocolates";
            BtnChocolate.UseVisualStyleBackColor = true;
            BtnChocolate.Click += BtnChocolate_Click;
            // 
            // BtnRellenos
            // 
            BtnRellenos.Location = new Point(512, 64);
            BtnRellenos.Name = "BtnRellenos";
            BtnRellenos.Size = new Size(94, 69);
            BtnRellenos.TabIndex = 3;
            BtnRellenos.Text = "Rellenos";
            BtnRellenos.UseVisualStyleBackColor = true;
            BtnRellenos.Click += BtnRellenos_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(BtnRellenos);
            Controls.Add(BtnChocolate);
            Controls.Add(btnFrutos);
            Controls.Add(BtnPaises);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnPaises;
        private Button btnFrutos;
        private Button BtnChocolate;
        private Button BtnRellenos;
    }
}
namespace Bombones2025.Windows
{
    partial class FrmFrutosSecosAE
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
            components = new System.ComponentModel.Container();
            TxtFruto = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            BtnCancelar = new Button();
            BtnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // TxtFruto
            // 
            TxtFruto.Location = new Point(101, 78);
            TxtFruto.Margin = new Padding(3, 4, 3, 4);
            TxtFruto.MaxLength = 200;
            TxtFruto.Name = "TxtFruto";
            TxtFruto.Size = new Size(430, 27);
            TxtFruto.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 78);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 3;
            label1.Text = "Fruto:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(373, 143);
            BtnCancelar.Margin = new Padding(3, 4, 3, 4);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(86, 69);
            BtnCancelar.TabIndex = 5;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(167, 143);
            BtnOK.Margin = new Padding(3, 4, 3, 4);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(86, 69);
            BtnOK.TabIndex = 6;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // FrmFrutosSecosAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 268);
            Controls.Add(TxtFruto);
            Controls.Add(label1);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnOK);
            MaximumSize = new Size(622, 315);
            MinimumSize = new Size(622, 315);
            Name = "FrmFrutosSecosAE";
            Text = "FrmFrutosSecosAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtFruto;
        private Label label1;
        private ErrorProvider errorProvider1;
        private Button BtnCancelar;
        private Button BtnOK;
    }
}
namespace Empresa2XAOficial
{
    partial class ListagemDeEmpresa
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
            this.b_voltar = new System.Windows.Forms.PictureBox();
            this.b_adicionarEmpresa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.b_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_adicionarEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // b_voltar
            // 
            this.b_voltar.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.BotaoVoltar;
            this.b_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_voltar.Location = new System.Drawing.Point(47, 380);
            this.b_voltar.Name = "b_voltar";
            this.b_voltar.Size = new System.Drawing.Size(151, 49);
            this.b_voltar.TabIndex = 2;
            this.b_voltar.TabStop = false;
            this.b_voltar.Click += new System.EventHandler(this.b_voltar_Click_1);
            // 
            // b_adicionarEmpresa
            // 
            this.b_adicionarEmpresa.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.BotaoAdicionarEmpresa;
            this.b_adicionarEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_adicionarEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_adicionarEmpresa.Location = new System.Drawing.Point(591, 380);
            this.b_adicionarEmpresa.Name = "b_adicionarEmpresa";
            this.b_adicionarEmpresa.Size = new System.Drawing.Size(167, 49);
            this.b_adicionarEmpresa.TabIndex = 3;
            this.b_adicionarEmpresa.TabStop = false;
            this.b_adicionarEmpresa.Click += new System.EventHandler(this.b_adicionarEmpresa_Click);
            // 
            // ListagemDeEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.ListagemDeEmpresas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_adicionarEmpresa);
            this.Controls.Add(this.b_voltar);
            this.DoubleBuffered = true;
            this.Name = "ListagemDeEmpresa";
            this.Text = "ListagemDeEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.b_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_adicionarEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox b_voltar;
        private System.Windows.Forms.PictureBox b_adicionarEmpresa;
    }
}
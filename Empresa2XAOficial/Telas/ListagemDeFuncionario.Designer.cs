namespace Empresa2XAOficial
{
    partial class ListagemDeFuncionario
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
            this.b_adicionarFuncionario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.b_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_adicionarFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // b_voltar
            // 
            this.b_voltar.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.BotaoVoltar;
            this.b_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_voltar.Location = new System.Drawing.Point(39, 384);
            this.b_voltar.Name = "b_voltar";
            this.b_voltar.Size = new System.Drawing.Size(151, 54);
            this.b_voltar.TabIndex = 1;
            this.b_voltar.TabStop = false;
            this.b_voltar.Click += new System.EventHandler(this.b_voltar_Click);
            // 
            // b_adicionarFuncionario
            // 
            this.b_adicionarFuncionario.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.BotaoAdicionarFuncionario;
            this.b_adicionarFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_adicionarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_adicionarFuncionario.Location = new System.Drawing.Point(596, 384);
            this.b_adicionarFuncionario.Name = "b_adicionarFuncionario";
            this.b_adicionarFuncionario.Size = new System.Drawing.Size(164, 53);
            this.b_adicionarFuncionario.TabIndex = 2;
            this.b_adicionarFuncionario.TabStop = false;
            this.b_adicionarFuncionario.Click += new System.EventHandler(this.b_adicionarFuncionario_Click);
            // 
            // ListagemDeFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.ListagemDeFuncionarios;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_adicionarFuncionario);
            this.Controls.Add(this.b_voltar);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "ListagemDeFuncionario";
            this.Text = "ListagemDeFuncionario";
            this.Load += new System.EventHandler(this.ListagemDeFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_adicionarFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox b_adicionarFuncionario;
        private System.Windows.Forms.PictureBox b_voltar;
    }
}
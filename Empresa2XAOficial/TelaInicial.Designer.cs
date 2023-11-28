namespace Empresa2XAOficial
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_cadastrofuncionario = new System.Windows.Forms.PictureBox();
            this.b_verfuncionario = new System.Windows.Forms.PictureBox();
            this.b_cadastroempresa = new System.Windows.Forms.PictureBox();
            this.b_vermepresa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.b_cadastrofuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_verfuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_cadastroempresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_vermepresa)).BeginInit();
            this.SuspendLayout();
            // 
            // b_cadastrofuncionario
            // 
            this.b_cadastrofuncionario.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.BotaoCadastrarFuncionario;
            this.b_cadastrofuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_cadastrofuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_cadastrofuncionario.Location = new System.Drawing.Point(31, 179);
            this.b_cadastrofuncionario.Name = "b_cadastrofuncionario";
            this.b_cadastrofuncionario.Size = new System.Drawing.Size(164, 37);
            this.b_cadastrofuncionario.TabIndex = 0;
            this.b_cadastrofuncionario.TabStop = false;
            this.b_cadastrofuncionario.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // b_verfuncionario
            // 
            this.b_verfuncionario.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.BotaoVerFuncionarios;
            this.b_verfuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_verfuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_verfuncionario.Location = new System.Drawing.Point(200, 179);
            this.b_verfuncionario.Name = "b_verfuncionario";
            this.b_verfuncionario.Size = new System.Drawing.Size(164, 37);
            this.b_verfuncionario.TabIndex = 1;
            this.b_verfuncionario.TabStop = false;
            this.b_verfuncionario.Click += new System.EventHandler(this.b_verfuncionario_Click);
            // 
            // b_cadastroempresa
            // 
            this.b_cadastroempresa.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.BotaoCadastrarEmpresa;
            this.b_cadastroempresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_cadastroempresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_cadastroempresa.Location = new System.Drawing.Point(31, 222);
            this.b_cadastroempresa.Name = "b_cadastroempresa";
            this.b_cadastroempresa.Size = new System.Drawing.Size(164, 37);
            this.b_cadastroempresa.TabIndex = 2;
            this.b_cadastroempresa.TabStop = false;
            this.b_cadastroempresa.Click += new System.EventHandler(this.b_cadastroempresa_Click);
            // 
            // b_vermepresa
            // 
            this.b_vermepresa.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.BotaoVerEmpresas;
            this.b_vermepresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_vermepresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_vermepresa.Location = new System.Drawing.Point(200, 222);
            this.b_vermepresa.Name = "b_vermepresa";
            this.b_vermepresa.Size = new System.Drawing.Size(164, 37);
            this.b_vermepresa.TabIndex = 3;
            this.b_vermepresa.TabStop = false;
            this.b_vermepresa.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.TelaInicial;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_vermepresa);
            this.Controls.Add(this.b_cadastroempresa);
            this.Controls.Add(this.b_verfuncionario);
            this.Controls.Add(this.b_cadastrofuncionario);
            this.DoubleBuffered = true;
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b_cadastrofuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_verfuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_cadastroempresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_vermepresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox b_cadastrofuncionario;
        private System.Windows.Forms.PictureBox b_verfuncionario;
        private System.Windows.Forms.PictureBox b_cadastroempresa;
        private System.Windows.Forms.PictureBox b_vermepresa;
    }
}


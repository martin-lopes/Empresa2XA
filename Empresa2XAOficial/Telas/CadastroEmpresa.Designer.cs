namespace Empresa2XAOficial
{
    partial class CadastroEmpresa
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
            this.b_salvar = new System.Windows.Forms.PictureBox();
            this.tx_razaosocial = new System.Windows.Forms.TextBox();
            this.tx_nomefantasia = new System.Windows.Forms.TextBox();
            this.rb_simplesnacional = new System.Windows.Forms.RadioButton();
            this.gb_regimetributario = new System.Windows.Forms.GroupBox();
            this.rb_real = new System.Windows.Forms.RadioButton();
            this.rb_lucropresumido = new System.Windows.Forms.RadioButton();
            this.tx_datainicioatv = new System.Windows.Forms.DateTimePicker();
            this.tx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tx_situacaocadastral = new System.Windows.Forms.ComboBox();
            this.tx_capitalsocial = new System.Windows.Forms.TextBox();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.tx_nomeproprietario = new System.Windows.Forms.TextBox();
            this.tx_naturezajuridica = new System.Windows.Forms.ComboBox();
            this.tx_estado = new System.Windows.Forms.ComboBox();
            this.gb_tipo = new System.Windows.Forms.GroupBox();
            this.rb_filial = new System.Windows.Forms.RadioButton();
            this.rb_matriz = new System.Windows.Forms.RadioButton();
            this.gb_porte = new System.Windows.Forms.GroupBox();
            this.rb_grande = new System.Windows.Forms.RadioButton();
            this.rb_medio = new System.Windows.Forms.RadioButton();
            this.rb_pequeno = new System.Windows.Forms.RadioButton();
            this.tx_cpfproprietario = new System.Windows.Forms.MaskedTextBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.tx_cnpj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.b_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_salvar)).BeginInit();
            this.gb_regimetributario.SuspendLayout();
            this.gb_tipo.SuspendLayout();
            this.gb_porte.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_voltar
            // 
            this.b_voltar.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.BotaoVoltar;
            this.b_voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_voltar.Location = new System.Drawing.Point(38, 379);
            this.b_voltar.Name = "b_voltar";
            this.b_voltar.Size = new System.Drawing.Size(151, 50);
            this.b_voltar.TabIndex = 3;
            this.b_voltar.TabStop = false;
            this.b_voltar.Click += new System.EventHandler(this.b_voltar_Click);
            // 
            // b_salvar
            // 
            this.b_salvar.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.BotaoSalvar;
            this.b_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_salvar.Location = new System.Drawing.Point(605, 379);
            this.b_salvar.Name = "b_salvar";
            this.b_salvar.Size = new System.Drawing.Size(147, 50);
            this.b_salvar.TabIndex = 4;
            this.b_salvar.TabStop = false;
            this.b_salvar.Click += new System.EventHandler(this.b_salvar_Click);
            // 
            // tx_razaosocial
            // 
            this.tx_razaosocial.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_razaosocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_razaosocial.Location = new System.Drawing.Point(49, 100);
            this.tx_razaosocial.Name = "tx_razaosocial";
            this.tx_razaosocial.Size = new System.Drawing.Size(239, 15);
            this.tx_razaosocial.TabIndex = 5;
            // 
            // tx_nomefantasia
            // 
            this.tx_nomefantasia.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_nomefantasia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nomefantasia.Location = new System.Drawing.Point(307, 102);
            this.tx_nomefantasia.Name = "tx_nomefantasia";
            this.tx_nomefantasia.Size = new System.Drawing.Size(188, 15);
            this.tx_nomefantasia.TabIndex = 6;
            // 
            // rb_simplesnacional
            // 
            this.rb_simplesnacional.AutoSize = true;
            this.rb_simplesnacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rb_simplesnacional.Location = new System.Drawing.Point(6, 12);
            this.rb_simplesnacional.Name = "rb_simplesnacional";
            this.rb_simplesnacional.Size = new System.Drawing.Size(135, 21);
            this.rb_simplesnacional.TabIndex = 8;
            this.rb_simplesnacional.TabStop = true;
            this.rb_simplesnacional.Text = "Simples nacional";
            this.rb_simplesnacional.UseVisualStyleBackColor = true;
            this.rb_simplesnacional.CheckedChanged += new System.EventHandler(this.rb_simplesnacional_CheckedChanged);
            // 
            // gb_regimetributario
            // 
            this.gb_regimetributario.Controls.Add(this.rb_real);
            this.gb_regimetributario.Controls.Add(this.rb_lucropresumido);
            this.gb_regimetributario.Controls.Add(this.rb_simplesnacional);
            this.gb_regimetributario.Location = new System.Drawing.Point(35, 137);
            this.gb_regimetributario.Name = "gb_regimetributario";
            this.gb_regimetributario.Size = new System.Drawing.Size(460, 37);
            this.gb_regimetributario.TabIndex = 9;
            this.gb_regimetributario.TabStop = false;
            // 
            // rb_real
            // 
            this.rb_real.AutoSize = true;
            this.rb_real.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rb_real.Location = new System.Drawing.Point(351, 12);
            this.rb_real.Name = "rb_real";
            this.rb_real.Size = new System.Drawing.Size(58, 21);
            this.rb_real.TabIndex = 10;
            this.rb_real.TabStop = true;
            this.rb_real.Text = "Real";
            this.rb_real.UseVisualStyleBackColor = true;
            // 
            // rb_lucropresumido
            // 
            this.rb_lucropresumido.AutoSize = true;
            this.rb_lucropresumido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rb_lucropresumido.Location = new System.Drawing.Point(168, 12);
            this.rb_lucropresumido.Name = "rb_lucropresumido";
            this.rb_lucropresumido.Size = new System.Drawing.Size(135, 21);
            this.rb_lucropresumido.TabIndex = 9;
            this.rb_lucropresumido.TabStop = true;
            this.rb_lucropresumido.Text = "Lucro presumido";
            this.rb_lucropresumido.UseVisualStyleBackColor = true;
            this.rb_lucropresumido.CheckedChanged += new System.EventHandler(this.rd_lucropresumido_CheckedChanged);
            // 
            // tx_datainicioatv
            // 
            this.tx_datainicioatv.Location = new System.Drawing.Point(43, 195);
            this.tx_datainicioatv.Name = "tx_datainicioatv";
            this.tx_datainicioatv.Size = new System.Drawing.Size(224, 22);
            this.tx_datainicioatv.TabIndex = 10;
            // 
            // tx_telefone
            // 
            this.tx_telefone.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_telefone.Location = new System.Drawing.Point(286, 199);
            this.tx_telefone.Mask = "(00) 00000-0000";
            this.tx_telefone.Name = "tx_telefone";
            this.tx_telefone.Size = new System.Drawing.Size(188, 15);
            this.tx_telefone.TabIndex = 11;
            // 
            // tx_situacaocadastral
            // 
            this.tx_situacaocadastral.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_situacaocadastral.FormattingEnabled = true;
            this.tx_situacaocadastral.Items.AddRange(new object[] {
            "Ativa",
            "Nula",
            "Suspensa",
            "Inapta",
            "Baixada"});
            this.tx_situacaocadastral.Location = new System.Drawing.Point(515, 97);
            this.tx_situacaocadastral.Name = "tx_situacaocadastral";
            this.tx_situacaocadastral.Size = new System.Drawing.Size(196, 24);
            this.tx_situacaocadastral.TabIndex = 12;
            // 
            // tx_capitalsocial
            // 
            this.tx_capitalsocial.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_capitalsocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_capitalsocial.Location = new System.Drawing.Point(517, 151);
            this.tx_capitalsocial.Name = "tx_capitalsocial";
            this.tx_capitalsocial.Size = new System.Drawing.Size(188, 15);
            this.tx_capitalsocial.TabIndex = 13;
            // 
            // tx_cidade
            // 
            this.tx_cidade.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cidade.Location = new System.Drawing.Point(203, 253);
            this.tx_cidade.Name = "tx_cidade";
            this.tx_cidade.Size = new System.Drawing.Size(141, 15);
            this.tx_cidade.TabIndex = 14;
            // 
            // tx_nomeproprietario
            // 
            this.tx_nomeproprietario.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_nomeproprietario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nomeproprietario.Location = new System.Drawing.Point(43, 349);
            this.tx_nomeproprietario.Name = "tx_nomeproprietario";
            this.tx_nomeproprietario.Size = new System.Drawing.Size(416, 15);
            this.tx_nomeproprietario.TabIndex = 15;
            // 
            // tx_naturezajuridica
            // 
            this.tx_naturezajuridica.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_naturezajuridica.FormattingEnabled = true;
            this.tx_naturezajuridica.Items.AddRange(new object[] {
            "EI – Empresário Individual",
            "MEI – Microempreendedor Individual",
            "Sociedade Anônima",
            "Sociedade Simples Limitada",
            "Sociedade Limitada Unipessoal"});
            this.tx_naturezajuridica.Location = new System.Drawing.Point(491, 197);
            this.tx_naturezajuridica.Name = "tx_naturezajuridica";
            this.tx_naturezajuridica.Size = new System.Drawing.Size(220, 24);
            this.tx_naturezajuridica.TabIndex = 16;
            // 
            // tx_estado
            // 
            this.tx_estado.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_estado.FormattingEnabled = true;
            this.tx_estado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.tx_estado.Location = new System.Drawing.Point(41, 250);
            this.tx_estado.Name = "tx_estado";
            this.tx_estado.Size = new System.Drawing.Size(156, 24);
            this.tx_estado.TabIndex = 17;
            // 
            // gb_tipo
            // 
            this.gb_tipo.Controls.Add(this.rb_filial);
            this.gb_tipo.Controls.Add(this.rb_matriz);
            this.gb_tipo.Location = new System.Drawing.Point(35, 290);
            this.gb_tipo.Name = "gb_tipo";
            this.gb_tipo.Size = new System.Drawing.Size(154, 38);
            this.gb_tipo.TabIndex = 11;
            this.gb_tipo.TabStop = false;
            // 
            // rb_filial
            // 
            this.rb_filial.AutoSize = true;
            this.rb_filial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rb_filial.Location = new System.Drawing.Point(91, 12);
            this.rb_filial.Name = "rb_filial";
            this.rb_filial.Size = new System.Drawing.Size(57, 21);
            this.rb_filial.TabIndex = 9;
            this.rb_filial.TabStop = true;
            this.rb_filial.Text = "Filial";
            this.rb_filial.UseVisualStyleBackColor = true;
            // 
            // rb_matriz
            // 
            this.rb_matriz.AutoSize = true;
            this.rb_matriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rb_matriz.Location = new System.Drawing.Point(6, 12);
            this.rb_matriz.Name = "rb_matriz";
            this.rb_matriz.Size = new System.Drawing.Size(67, 21);
            this.rb_matriz.TabIndex = 8;
            this.rb_matriz.TabStop = true;
            this.rb_matriz.Text = "Matriz";
            this.rb_matriz.UseVisualStyleBackColor = true;
            this.rb_matriz.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // gb_porte
            // 
            this.gb_porte.Controls.Add(this.rb_grande);
            this.gb_porte.Controls.Add(this.rb_medio);
            this.gb_porte.Controls.Add(this.rb_pequeno);
            this.gb_porte.Location = new System.Drawing.Point(195, 291);
            this.gb_porte.Name = "gb_porte";
            this.gb_porte.Size = new System.Drawing.Size(282, 37);
            this.gb_porte.TabIndex = 11;
            this.gb_porte.TabStop = false;
            // 
            // rb_grande
            // 
            this.rb_grande.AutoSize = true;
            this.rb_grande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rb_grande.Location = new System.Drawing.Point(204, 12);
            this.rb_grande.Name = "rb_grande";
            this.rb_grande.Size = new System.Drawing.Size(77, 21);
            this.rb_grande.TabIndex = 10;
            this.rb_grande.TabStop = true;
            this.rb_grande.Text = "Grande";
            this.rb_grande.UseVisualStyleBackColor = true;
            // 
            // rb_medio
            // 
            this.rb_medio.AutoSize = true;
            this.rb_medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rb_medio.Location = new System.Drawing.Point(109, 12);
            this.rb_medio.Name = "rb_medio";
            this.rb_medio.Size = new System.Drawing.Size(67, 21);
            this.rb_medio.TabIndex = 9;
            this.rb_medio.TabStop = true;
            this.rb_medio.Text = "Médio";
            this.rb_medio.UseVisualStyleBackColor = true;
            // 
            // rb_pequeno
            // 
            this.rb_pequeno.AutoSize = true;
            this.rb_pequeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rb_pequeno.Location = new System.Drawing.Point(6, 12);
            this.rb_pequeno.Name = "rb_pequeno";
            this.rb_pequeno.Size = new System.Drawing.Size(86, 21);
            this.rb_pequeno.TabIndex = 8;
            this.rb_pequeno.TabStop = true;
            this.rb_pequeno.Text = "Pequeno";
            this.rb_pequeno.UseVisualStyleBackColor = true;
            // 
            // tx_cpfproprietario
            // 
            this.tx_cpfproprietario.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_cpfproprietario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cpfproprietario.Location = new System.Drawing.Point(500, 302);
            this.tx_cpfproprietario.Mask = "000.000.000-00";
            this.tx_cpfproprietario.Name = "tx_cpfproprietario";
            this.tx_cpfproprietario.Size = new System.Drawing.Size(205, 15);
            this.tx_cpfproprietario.TabIndex = 18;
            // 
            // tx_endereco
            // 
            this.tx_endereco.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_endereco.Location = new System.Drawing.Point(362, 253);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(343, 15);
            this.tx_endereco.TabIndex = 19;
            // 
            // tx_cnpj
            // 
            this.tx_cnpj.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_cnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cnpj.Location = new System.Drawing.Point(500, 350);
            this.tx_cnpj.Name = "tx_cnpj";
            this.tx_cnpj.Size = new System.Drawing.Size(205, 15);
            this.tx_cnpj.TabIndex = 20;
            // 
            // CadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.CadastroEmpresa___atualizado3versao;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx_cnpj);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.tx_cpfproprietario);
            this.Controls.Add(this.gb_porte);
            this.Controls.Add(this.gb_tipo);
            this.Controls.Add(this.tx_estado);
            this.Controls.Add(this.tx_naturezajuridica);
            this.Controls.Add(this.tx_nomeproprietario);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.tx_capitalsocial);
            this.Controls.Add(this.tx_situacaocadastral);
            this.Controls.Add(this.tx_telefone);
            this.Controls.Add(this.tx_datainicioatv);
            this.Controls.Add(this.gb_regimetributario);
            this.Controls.Add(this.tx_nomefantasia);
            this.Controls.Add(this.tx_razaosocial);
            this.Controls.Add(this.b_salvar);
            this.Controls.Add(this.b_voltar);
            this.DoubleBuffered = true;
            this.Name = "CadastroEmpresa";
            this.Text = "CadastroEmpresa";
            this.Load += new System.EventHandler(this.CadastroEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_salvar)).EndInit();
            this.gb_regimetributario.ResumeLayout(false);
            this.gb_regimetributario.PerformLayout();
            this.gb_tipo.ResumeLayout(false);
            this.gb_tipo.PerformLayout();
            this.gb_porte.ResumeLayout(false);
            this.gb_porte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox b_voltar;
        private System.Windows.Forms.PictureBox b_salvar;
        private System.Windows.Forms.TextBox tx_razaosocial;
        private System.Windows.Forms.TextBox tx_nomefantasia;
        private System.Windows.Forms.RadioButton rb_simplesnacional;
        private System.Windows.Forms.GroupBox gb_regimetributario;
        private System.Windows.Forms.RadioButton rb_real;
        private System.Windows.Forms.RadioButton rb_lucropresumido;
        private System.Windows.Forms.DateTimePicker tx_datainicioatv;
        private System.Windows.Forms.MaskedTextBox tx_telefone;
        private System.Windows.Forms.ComboBox tx_situacaocadastral;
        private System.Windows.Forms.TextBox tx_capitalsocial;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.TextBox tx_nomeproprietario;
        private System.Windows.Forms.ComboBox tx_naturezajuridica;
        private System.Windows.Forms.ComboBox tx_estado;
        private System.Windows.Forms.GroupBox gb_tipo;
        private System.Windows.Forms.RadioButton rb_filial;
        private System.Windows.Forms.RadioButton rb_matriz;
        private System.Windows.Forms.GroupBox gb_porte;
        private System.Windows.Forms.RadioButton rb_grande;
        private System.Windows.Forms.RadioButton rb_medio;
        private System.Windows.Forms.RadioButton rb_pequeno;
        private System.Windows.Forms.MaskedTextBox tx_cpfproprietario;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.TextBox tx_cnpj;
    }
}
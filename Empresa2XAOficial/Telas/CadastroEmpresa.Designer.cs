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
            this.g_regimetributario = new System.Windows.Forms.GroupBox();
            this.rd_real = new System.Windows.Forms.RadioButton();
            this.rd_lucropresumido = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.tx_situacaocadastral = new System.Windows.Forms.ComboBox();
            this.tx_capitalsocial = new System.Windows.Forms.TextBox();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.tx_nomeproprietario = new System.Windows.Forms.TextBox();
            this.tx_naturezajuridica = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_filial = new System.Windows.Forms.RadioButton();
            this.rd_matriz = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_grande = new System.Windows.Forms.RadioButton();
            this.rd_medio = new System.Windows.Forms.RadioButton();
            this.rd_pequeno = new System.Windows.Forms.RadioButton();
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.b_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_salvar)).BeginInit();
            this.g_regimetributario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // g_regimetributario
            // 
            this.g_regimetributario.Controls.Add(this.rd_real);
            this.g_regimetributario.Controls.Add(this.rd_lucropresumido);
            this.g_regimetributario.Controls.Add(this.rb_simplesnacional);
            this.g_regimetributario.Location = new System.Drawing.Point(35, 137);
            this.g_regimetributario.Name = "g_regimetributario";
            this.g_regimetributario.Size = new System.Drawing.Size(460, 37);
            this.g_regimetributario.TabIndex = 9;
            this.g_regimetributario.TabStop = false;
            // 
            // rd_real
            // 
            this.rd_real.AutoSize = true;
            this.rd_real.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rd_real.Location = new System.Drawing.Point(351, 12);
            this.rd_real.Name = "rd_real";
            this.rd_real.Size = new System.Drawing.Size(58, 21);
            this.rd_real.TabIndex = 10;
            this.rd_real.TabStop = true;
            this.rd_real.Text = "Real";
            this.rd_real.UseVisualStyleBackColor = true;
            // 
            // rd_lucropresumido
            // 
            this.rd_lucropresumido.AutoSize = true;
            this.rd_lucropresumido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rd_lucropresumido.Location = new System.Drawing.Point(168, 12);
            this.rd_lucropresumido.Name = "rd_lucropresumido";
            this.rd_lucropresumido.Size = new System.Drawing.Size(135, 21);
            this.rd_lucropresumido.TabIndex = 9;
            this.rd_lucropresumido.TabStop = true;
            this.rd_lucropresumido.Text = "Lucro presumido";
            this.rd_lucropresumido.UseVisualStyleBackColor = true;
            this.rd_lucropresumido.CheckedChanged += new System.EventHandler(this.rd_lucropresumido_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 195);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 10;
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
            this.tx_situacaocadastral.Location = new System.Drawing.Point(517, 98);
            this.tx_situacaocadastral.Name = "tx_situacaocadastral";
            this.tx_situacaocadastral.Size = new System.Drawing.Size(188, 24);
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
            this.tx_nomeproprietario.Location = new System.Drawing.Point(43, 348);
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
            this.tx_naturezajuridica.Size = new System.Drawing.Size(214, 24);
            this.tx_naturezajuridica.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(41, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_filial);
            this.groupBox1.Controls.Add(this.rd_matriz);
            this.groupBox1.Location = new System.Drawing.Point(35, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 38);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // rd_filial
            // 
            this.rd_filial.AutoSize = true;
            this.rd_filial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rd_filial.Location = new System.Drawing.Point(91, 12);
            this.rd_filial.Name = "rd_filial";
            this.rd_filial.Size = new System.Drawing.Size(57, 21);
            this.rd_filial.TabIndex = 9;
            this.rd_filial.TabStop = true;
            this.rd_filial.Text = "Filial";
            this.rd_filial.UseVisualStyleBackColor = true;
            // 
            // rd_matriz
            // 
            this.rd_matriz.AutoSize = true;
            this.rd_matriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rd_matriz.Location = new System.Drawing.Point(6, 12);
            this.rd_matriz.Name = "rd_matriz";
            this.rd_matriz.Size = new System.Drawing.Size(67, 21);
            this.rd_matriz.TabIndex = 8;
            this.rd_matriz.TabStop = true;
            this.rd_matriz.Text = "Matriz";
            this.rd_matriz.UseVisualStyleBackColor = true;
            this.rd_matriz.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_grande);
            this.groupBox2.Controls.Add(this.rd_medio);
            this.groupBox2.Controls.Add(this.rd_pequeno);
            this.groupBox2.Location = new System.Drawing.Point(195, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 37);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // rd_grande
            // 
            this.rd_grande.AutoSize = true;
            this.rd_grande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rd_grande.Location = new System.Drawing.Point(204, 12);
            this.rd_grande.Name = "rd_grande";
            this.rd_grande.Size = new System.Drawing.Size(77, 21);
            this.rd_grande.TabIndex = 10;
            this.rd_grande.TabStop = true;
            this.rd_grande.Text = "Grande";
            this.rd_grande.UseVisualStyleBackColor = true;
            // 
            // rd_medio
            // 
            this.rd_medio.AutoSize = true;
            this.rd_medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rd_medio.Location = new System.Drawing.Point(109, 12);
            this.rd_medio.Name = "rd_medio";
            this.rd_medio.Size = new System.Drawing.Size(67, 21);
            this.rd_medio.TabIndex = 9;
            this.rd_medio.TabStop = true;
            this.rd_medio.Text = "Médio";
            this.rd_medio.UseVisualStyleBackColor = true;
            // 
            // rd_pequeno
            // 
            this.rd_pequeno.AutoSize = true;
            this.rd_pequeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rd_pequeno.Location = new System.Drawing.Point(6, 12);
            this.rd_pequeno.Name = "rd_pequeno";
            this.rd_pequeno.Size = new System.Drawing.Size(86, 21);
            this.rd_pequeno.TabIndex = 8;
            this.rd_pequeno.TabStop = true;
            this.rd_pequeno.Text = "Pequeno";
            this.rd_pequeno.UseVisualStyleBackColor = true;
            // 
            // tx_cpf
            // 
            this.tx_cpf.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cpf.Location = new System.Drawing.Point(500, 302);
            this.tx_cpf.Mask = "000.000.000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(205, 15);
            this.tx_cpf.TabIndex = 18;
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
            // CadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.CadastroEmpresa_atualizado;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tx_naturezajuridica);
            this.Controls.Add(this.tx_nomeproprietario);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.tx_capitalsocial);
            this.Controls.Add(this.tx_situacaocadastral);
            this.Controls.Add(this.tx_telefone);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.g_regimetributario);
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
            this.g_regimetributario.ResumeLayout(false);
            this.g_regimetributario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox b_voltar;
        private System.Windows.Forms.PictureBox b_salvar;
        private System.Windows.Forms.TextBox tx_razaosocial;
        private System.Windows.Forms.TextBox tx_nomefantasia;
        private System.Windows.Forms.RadioButton rb_simplesnacional;
        private System.Windows.Forms.GroupBox g_regimetributario;
        private System.Windows.Forms.RadioButton rd_real;
        private System.Windows.Forms.RadioButton rd_lucropresumido;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox tx_telefone;
        private System.Windows.Forms.ComboBox tx_situacaocadastral;
        private System.Windows.Forms.TextBox tx_capitalsocial;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.TextBox tx_nomeproprietario;
        private System.Windows.Forms.ComboBox tx_naturezajuridica;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_filial;
        private System.Windows.Forms.RadioButton rd_matriz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_grande;
        private System.Windows.Forms.RadioButton rd_medio;
        private System.Windows.Forms.RadioButton rd_pequeno;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.TextBox tx_endereco;
    }
}
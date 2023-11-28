namespace Empresa2XAOficial
{
    partial class CadastroFuncionario
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
            this.tx_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tx_telefone = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tx_cidade = new System.Windows.Forms.TextBox();
            this.tx_endereco = new System.Windows.Forms.TextBox();
            this.tx_estadocivil = new System.Windows.Forms.ComboBox();
            this.tx_funcao = new System.Windows.Forms.ComboBox();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_rg = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_nascimento = new System.Windows.Forms.DateTimePicker();
            this.tx_salario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.b_voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_salvar)).BeginInit();
            this.SuspendLayout();
            // 
            // b_voltar
            // 
            this.b_voltar.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.BotaoVoltar;
            this.b_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_voltar.Location = new System.Drawing.Point(36, 377);
            this.b_voltar.Name = "b_voltar";
            this.b_voltar.Size = new System.Drawing.Size(151, 50);
            this.b_voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.b_voltar.TabIndex = 4;
            this.b_voltar.TabStop = false;
            this.b_voltar.Click += new System.EventHandler(this.b_voltar_Click);
            // 
            // b_salvar
            // 
            this.b_salvar.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.BotaoSalvar;
            this.b_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_salvar.Location = new System.Drawing.Point(608, 377);
            this.b_salvar.Name = "b_salvar";
            this.b_salvar.Size = new System.Drawing.Size(147, 50);
            this.b_salvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.b_salvar.TabIndex = 5;
            this.b_salvar.TabStop = false;
            // 
            // tx_cpf
            // 
            this.tx_cpf.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cpf.Location = new System.Drawing.Point(515, 122);
            this.tx_cpf.Mask = "000.000.000-00";
            this.tx_cpf.Name = "tx_cpf";
            this.tx_cpf.Size = new System.Drawing.Size(190, 15);
            this.tx_cpf.TabIndex = 19;
            // 
            // tx_telefone
            // 
            this.tx_telefone.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_telefone.Location = new System.Drawing.Point(180, 166);
            this.tx_telefone.Mask = "(00) 00000-0000";
            this.tx_telefone.Name = "tx_telefone";
            this.tx_telefone.Size = new System.Drawing.Size(188, 15);
            this.tx_telefone.TabIndex = 20;
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
            this.comboBox1.Location = new System.Drawing.Point(36, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // tx_cidade
            // 
            this.tx_cidade.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_cidade.Location = new System.Drawing.Point(204, 218);
            this.tx_cidade.Name = "tx_cidade";
            this.tx_cidade.Size = new System.Drawing.Size(141, 15);
            this.tx_cidade.TabIndex = 22;
            // 
            // tx_endereco
            // 
            this.tx_endereco.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_endereco.Location = new System.Drawing.Point(362, 218);
            this.tx_endereco.Name = "tx_endereco";
            this.tx_endereco.Size = new System.Drawing.Size(343, 15);
            this.tx_endereco.TabIndex = 23;
            // 
            // tx_estadocivil
            // 
            this.tx_estadocivil.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_estadocivil.FormattingEnabled = true;
            this.tx_estadocivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Divorciado(a)",
            "Casado(a)",
            "Viúvo(a)"});
            this.tx_estadocivil.Location = new System.Drawing.Point(36, 263);
            this.tx_estadocivil.Name = "tx_estadocivil";
            this.tx_estadocivil.Size = new System.Drawing.Size(223, 24);
            this.tx_estadocivil.TabIndex = 24;
            // 
            // tx_funcao
            // 
            this.tx_funcao.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_funcao.FormattingEnabled = true;
            this.tx_funcao.Items.AddRange(new object[] {
            "Gerente",
            "Caixa",
            "Atendente",
            "Auxiliar de limpeza",
            "Analista",
            "Coordenador"});
            this.tx_funcao.Location = new System.Drawing.Point(266, 263);
            this.tx_funcao.Name = "tx_funcao";
            this.tx_funcao.Size = new System.Drawing.Size(149, 24);
            this.tx_funcao.TabIndex = 25;
            // 
            // tx_nome
            // 
            this.tx_nome.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_nome.Location = new System.Drawing.Point(46, 122);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(241, 15);
            this.tx_nome.TabIndex = 26;
            // 
            // tx_rg
            // 
            this.tx_rg.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_rg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_rg.Location = new System.Drawing.Point(46, 166);
            this.tx_rg.Name = "tx_rg";
            this.tx_rg.Size = new System.Drawing.Size(117, 15);
            this.tx_rg.TabIndex = 27;
            // 
            // tx_email
            // 
            this.tx_email.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_email.Location = new System.Drawing.Point(384, 166);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(321, 15);
            this.tx_email.TabIndex = 28;
            // 
            // tx_nascimento
            // 
            this.tx_nascimento.Location = new System.Drawing.Point(304, 117);
            this.tx_nascimento.Name = "tx_nascimento";
            this.tx_nascimento.Size = new System.Drawing.Size(188, 22);
            this.tx_nascimento.TabIndex = 30;
            // 
            // tx_salario
            // 
            this.tx_salario.BackColor = System.Drawing.Color.Gainsboro;
            this.tx_salario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tx_salario.Location = new System.Drawing.Point(430, 272);
            this.tx_salario.Name = "tx_salario";
            this.tx_salario.Size = new System.Drawing.Size(285, 15);
            this.tx_salario.TabIndex = 31;
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Empresa2XAOficial.Properties.Resources.CadastroFuncionario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tx_salario);
            this.Controls.Add(this.tx_nascimento);
            this.Controls.Add(this.tx_email);
            this.Controls.Add(this.tx_rg);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.tx_funcao);
            this.Controls.Add(this.tx_estadocivil);
            this.Controls.Add(this.tx_endereco);
            this.Controls.Add(this.tx_cidade);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tx_telefone);
            this.Controls.Add(this.tx_cpf);
            this.Controls.Add(this.b_salvar);
            this.Controls.Add(this.b_voltar);
            this.DoubleBuffered = true;
            this.Name = "CadastroFuncionario";
            this.Text = "CadastroFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.b_voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b_salvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox b_voltar;
        private System.Windows.Forms.PictureBox b_salvar;
        private System.Windows.Forms.MaskedTextBox tx_cpf;
        private System.Windows.Forms.MaskedTextBox tx_telefone;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tx_cidade;
        private System.Windows.Forms.TextBox tx_endereco;
        private System.Windows.Forms.ComboBox tx_estadocivil;
        private System.Windows.Forms.ComboBox tx_funcao;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_rg;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.DateTimePicker tx_nascimento;
        private System.Windows.Forms.TextBox tx_salario;
    }
}
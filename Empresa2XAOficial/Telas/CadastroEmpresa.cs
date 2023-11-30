using Empresa2XAOficial;
using EmpresaX2A.Configuracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa2XAOficial
{
    public partial class CadastroEmpresa : Form
    {
        public Empresa _empresa;
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void b_voltar_Click(object sender, EventArgs e)
        {
            Form listagemempresa = new ListagemDeEmpresa();
            this.Hide();
            listagemempresa.ShowDialog();
            this.Close();
        }

        private void rb_simplesnacional_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rd_lucropresumido_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void b_salvar_Click(object sender, EventArgs e)
        {
            string razaosocial = tx_razaosocial.Text;
            string nomefantasia = tx_nomefantasia.Text;
            string situacaocadastral = tx_situacaocadastral.Text;
            
            //regime tributario
            string regimetributario = "";
            if (rb_simplesnacional.Checked) { regimetributario = rb_simplesnacional.Text; }
            else if(rb_lucropresumido.Checked) { regimetributario = rb_lucropresumido.Text; }
            else if(rb_real.Checked) { regimetributario = rb_real.Text; }

            string txdatainicioatv = tx_datainicioatv.Text;
            string telefone = tx_telefone.Text;
            string txcapitalsocial = tx_capitalsocial.Text;
            string estado = tx_estado.Text;
            string cidade = tx_cidade.Text;
            string endereco = tx_endereco.Text;

            //tipo
            string tipo = "";
            if (rb_matriz.Checked) { tipo = rb_matriz.Text; }
            else if (rb_filial.Checked) { tipo = rb_filial.Text; }

            //porte
            string porte = "";
            if (rb_pequeno.Checked) { porte = rb_pequeno.Text; }
            else if (rb_medio.Checked) { porte = rb_medio.Text; }
            else if(rb_grande.Checked) { porte = rb_grande.Text; }

            string naturezajuridica = tx_naturezajuridica.Text;
            string nomeproprietario = tx_nomeproprietario.Text;
            string cpfproprietario = tx_cpfproprietario.Text;
            string cnpj = tx_cnpj.Text;

            double capitalsocial = Convert.ToDouble(txcapitalsocial);
            DateTime datainicioatv = Convert.ToDateTime(txdatainicioatv);

            VerifyCpf cpf = new VerifyCpf(cpfproprietario);
            bool cpfverificado = cpf.Digitos(cpfproprietario);

            if(cpf.Digitos(cpfproprietario))
            {
                _empresa = new Empresa(razaosocial, nomefantasia, situacaocadastral, regimetributario, datainicioatv, telefone,
                    capitalsocial, estado, cidade, endereco, tipo, porte, naturezajuridica, nomeproprietario, cpfproprietario, cnpj);
                Inserir(_empresa);
            }
                
            else { MessageBox.Show("Erro no cadastro. CPF inválido.", "Cadastro de Empresa", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        void Inserir(Empresa _emprsa)
        {
            try
            {
                Conexao conexao = new Conexao();
                var comando = conexao.Comando("insert into empresa values (null, @razaosocial, @nomefantasia, @situacaocadastral," +
                    "@regimetributario, @datainicioatv, @telefone, @capitalsocial, @estado, @cidade, @endereco, @tipo," +
                    "@porte, @naturezajuridica, @nomeproprietario, @cpfproprietario, @cnpj)");

                comando.Parameters.AddWithValue("@razaosocial", _empresa.RazaoSocial);
                comando.Parameters.AddWithValue("@nomefantasia", _empresa.NomeFantasia);
                comando.Parameters.AddWithValue("@situacaocadastral", _empresa.SituacaoCadastral);
                comando.Parameters.AddWithValue("@regimetributario", _empresa.RegimeTributario);
                comando.Parameters.AddWithValue("@datainicioatv", _empresa.DataInicioAtv);
                comando.Parameters.AddWithValue("@telefone", _empresa.Telefone);
                comando.Parameters.AddWithValue("@capitalsocial", _empresa.CapitalSocial);
                comando.Parameters.AddWithValue("@estado", _empresa.Estado);
                comando.Parameters.AddWithValue("@cidade", _empresa.Cidade);
                comando.Parameters.AddWithValue("@endereco", _empresa.Endereco);
                comando.Parameters.AddWithValue("@tipo", _empresa.Tipo);
                comando.Parameters.AddWithValue("@porte", _empresa.Porte);
                comando.Parameters.AddWithValue("@naturezajuridica", _empresa.NaturezaJuridica);
                comando.Parameters.AddWithValue("@nomeproprietario", _empresa.NomeProprietario);
                comando.Parameters.AddWithValue("@cpfproprietario", _empresa.CpfProprietario);
                comando.Parameters.AddWithValue("@cnpj", _empresa.Cnpj);


                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0) { MessageBox.Show("Empresa cadastrada com sucesso.", "Cadastro de Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}

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
    public partial class CadastroFuncionario : Form
    {
        public Funcionario _funcionario;

        public List<Funcionario> listaFuncionarios = new List<Funcionario>();
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void b_voltar_Click(object sender, EventArgs e)
        {
            Form listagemfuncionario = new ListagemDeFuncionario();
            this.Hide();
            listagemfuncionario.ShowDialog();
            this.Close();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void b_salvar_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string estadocivil = tx_estadocivil.Text;
            string telefone = tx_telefone.Text;
            string txdatanasc = tx_nascimento.Text;
            string rg = tx_rg.Text;
            string txcpf = tx_cpf.Text;
            string txemail = tx_email.Text;
            string cidade = tx_cidade.Text;
            string estado = tx_estado.Text;
            string funcao = tx_funcao.Text;
            string txsalario = tx_salario.Text;
            string endereco = tx_endereco.Text;


            double salario = Convert.ToDouble(txsalario);
            DateTime datanasc = Convert.ToDateTime(txdatanasc);

            VerifyCpf cpf = new VerifyCpf(txcpf);
            bool cpfverificado = cpf.Digitos(txcpf);

            VerifyEmail email = new VerifyEmail(txemail);
            bool emailverificado = email.Caracteres(txemail);

            if (cpf.Digitos(txcpf))
            {
                //MessageBox.Show("CPF válido!", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (email.Caracteres(txemail))
                {
                    //MessageBox.Show("Email válido!", "Validação de email", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

                else
                {
                    MessageBox.Show("Email Inválido! Insira um email verdadeiro.", "Validação de email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                MessageBox.Show("CPF Inválido! Insira um CPF verdadeiro para prosseguir.", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (email.Caracteres(txemail) && cpf.Digitos(txcpf))
            {
                _funcionario = new Funcionario(nome, datanasc, txcpf, rg, telefone, txemail, estado, cidade, endereco, estadocivil, funcao, salario);
                Inserir(_funcionario);

            }

            else
            {
                MessageBox.Show("Erro no cadastro. CPF inválido.", "Cadastro de Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Inserir(Funcionario _funcionario)
        {
            try
            {
                Conexao conexao = new Conexao();
                var comando = conexao.Comando("insert into funcionario values (null, @nome, @datanasc, @cpf, @rg, @telefone, @email, @estado, @cidade, @endereco, @estadocivil, @funcao, @salario)");

                comando.Parameters.AddWithValue("@nome", _funcionario.Nome);
                comando.Parameters.AddWithValue("@datanasc", _funcionario.Datanasc);
                comando.Parameters.AddWithValue("@cpf", _funcionario.Cpf);
                comando.Parameters.AddWithValue("@rg", _funcionario.Rg);
                comando.Parameters.AddWithValue("@telefone", _funcionario.Telefone);
                comando.Parameters.AddWithValue("@email", _funcionario.Email);
                comando.Parameters.AddWithValue("@estado", _funcionario.Estado);
                comando.Parameters.AddWithValue("@cidade", _funcionario.Cidade);
                comando.Parameters.AddWithValue("@endereco", _funcionario.Endereco);
                comando.Parameters.AddWithValue("@estadocivil", _funcionario.Estadocivil);
                comando.Parameters.AddWithValue("@funcao", _funcionario.Funcao);
                comando.Parameters.AddWithValue("@salario", _funcionario.Salario);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0) { MessageBox.Show("Funcionário cadastrado com sucesso.", "Cadastro de Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}

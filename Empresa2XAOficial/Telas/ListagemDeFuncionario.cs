using Empresa2XAOficial;
using MySql.Data.MySqlClient;
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
    public partial class ListagemDeFuncionario : Form
    {
        public ListagemDeFuncionario()
        {
            InitializeComponent();
        }

        private void b_voltar_Click(object sender, EventArgs e)
        {
            Form telainicial = new TelaInicial();
            this.Hide();
            telainicial.ShowDialog();
            this.Close();
        }

        private void b_adicionarFuncionario_Click(object sender, EventArgs e)
        {
            Form cadastrofuncionario = new CadastroFuncionario();
            this.Hide();
            cadastrofuncionario.ShowDialog();
            this.Close();
        }

        private void ListagemDeFuncionario_Load(object sender, EventArgs e)
        {
            using (var conexao = new MySqlConnection("server=localhost;uid=root;pwd=An4Di3go1!;database=bd_empresa2xa_modelofisico"))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT * FROM funcionario";
                    using (var da = new MySqlDataAdapter(query, conexao))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtgrade_funcionario.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }
        }

        private void dtgrade_funcionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

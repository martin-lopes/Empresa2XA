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
    public partial class ListagemDeEmpresa : Form
    {
        public ListagemDeEmpresa()
        {
            InitializeComponent();
        }

        

        private void b_voltar_Click_1(object sender, EventArgs e)
        {
            Form telainicial = new TelaInicial();
            this.Hide();
            telainicial.ShowDialog();
            this.Close();
        }

        private void b_salvar_Click(object sender, EventArgs e)
        {

        }

        private void b_adicionarEmpresa_Click(object sender, EventArgs e)
        {
            Form cadastroempresa = new CadastroEmpresa();
            this.Hide();
            cadastroempresa.ShowDialog();
            this.Close();
        }

        private void ListagemDeEmpresa_Load(object sender, EventArgs e)
        {
            using (var conexao = new MySqlConnection("server=localhost;uid=root;pwd=An4Di3go1!;database=bd_empresa2xa_modelofisico"))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT * FROM empresa";
                    using (var da = new MySqlDataAdapter(query, conexao))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtgrade_empresa.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }
        }
    }
}

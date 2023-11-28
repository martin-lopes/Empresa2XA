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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form cadastrofuncionario = new CadastroFuncionario();
            this.Hide();
            cadastrofuncionario.ShowDialog();
            this.Close();
        }

        private void b_cadastroempresa_Click(object sender, EventArgs e)
        {
            Form cadastroempresa = new CadastroEmpresa();
            this.Hide();
            cadastroempresa.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form listagemempresa = new ListagemDeEmpresa();
            this.Hide();
            listagemempresa.ShowDialog();
            this.Close();
        }

        private void b_verfuncionario_Click(object sender, EventArgs e)
        {
            Form listagemfuncionario = new ListagemDeFuncionario();
            this.Hide();
            listagemfuncionario.ShowDialog();
            this.Close();
        }
    }
}

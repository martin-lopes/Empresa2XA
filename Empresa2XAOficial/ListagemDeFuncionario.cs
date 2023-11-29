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
    }
}

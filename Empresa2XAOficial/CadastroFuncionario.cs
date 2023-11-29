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
    }
}

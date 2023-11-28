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
    }
}

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
        public CadastroEmpresa()
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
    }
}

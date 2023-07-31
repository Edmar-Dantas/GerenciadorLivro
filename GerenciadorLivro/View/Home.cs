using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorLivro.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterar telaAlterar = new();
            telaAlterar.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaExcluir telaExcluir = new();
            telaExcluir.Show();
        }

        private void porNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaBuscarNome telaBuscarNome = new();
            telaBuscarNome.Show();
        }

        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaBuscarCod telaBuscarCod = new();
            telaBuscarCod.Show();
        }
    }
}

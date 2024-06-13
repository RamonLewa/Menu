using Menu.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FClientes clientes = new FClientes();
            clientes.ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            FEstoque estoque = new FEstoque();
            estoque.ShowDialog();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            FFornecedores fornecedores = new FFornecedores();
            fornecedores.ShowDialog();
        }
    }
}

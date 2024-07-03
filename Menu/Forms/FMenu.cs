using Menu.Classes;
using Menu.Forms;
using Menu.Properties;
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
    public partial class FMenu : SGForm
    {
        private int xOffset;

        public FMenu()
        {
            InitializeComponent();
            FullWidthScreen();
        }

        private async void btnClientes_Click(object sender, EventArgs e)
        {
            var fClientes = new FClientes();
            await fClientes.LoadDataAsync();
            fClientes.ShowDialog();
            
        }

        private async void btnEstoque_Click(object sender, EventArgs e)
        {
            var fEstoque = new FEstoque();
            await fEstoque.LoadDataAsync();
            fEstoque.ShowDialog();
        }

        private async void btnFornecedores_Click(object sender, EventArgs e)
        {
            var fFornecedores = new FFornecedores();
            await fFornecedores.LoadDataAsync();
            fFornecedores.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void clientesCadastrosToolStripMenu_Click(object sender, EventArgs e)
        {
            var fClientes = new FClientes();
            await fClientes.LoadDataAsync();
            fClientes.ShowDialog();
        }

        private async void estoqueCadastrosToolStripMenu_Click(object sender, EventArgs e)
        {
            var fEstoque = new FEstoque();
            await fEstoque.LoadDataAsync();
            fEstoque.ShowDialog();
        }

        private async void fornecedoresCadastrosToolStripMenu_Click(object sender, EventArgs e)
        {
            var fFornecedores = new FFornecedores();
            await fFornecedores.LoadDataAsync();
            fFornecedores.ShowDialog();
        }

        private void sairCadastrosToolStripMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {
            using (var dc = new DataContext())
            {
                var emitente = dc.TEmitente.FirstOrDefault();
                this.Text += emitente.RazaoSocial;
            }
        }

        #region ButtonImages

        private void btnClientes_MouseEnter(object sender, EventArgs e)
        {
            btnClientes.BackgroundImage = Resources.pessoa_selecionado;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            btnClientes.BackgroundImage = Resources.pessoa;
        }

        private void btnEstoque_MouseEnter(object sender, EventArgs e)
        {
            btnEstoque.BackgroundImage = Resources.caixa_selecionado;
        }

        private void btnEstoque_MouseLeave(object sender, EventArgs e)
        {
            btnEstoque.BackgroundImage= Resources.caixa;
        }

        private void btnFornecedores_MouseEnter(object sender, EventArgs e)
        {
            btnFornecedores.BackgroundImage = Resources.homem_gravata_selecionado;
        }

        private void btnFornecedores_MouseLeave(object sender, EventArgs e)
        {
            btnFornecedores.BackgroundImage= Resources.homem_gravata;
        }

        #endregion
    }
}

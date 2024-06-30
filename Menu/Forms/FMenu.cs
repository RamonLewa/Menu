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
    public partial class FMenu : SGForm
    {
        private int xOffset;

        public FMenu()
        {
            InitializeComponent();
            FullWidthScreen();
            timer1.Interval = 100;
            timer1.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            xOffset -= 5;

            if (xOffset < -lblTextoMenu.Width)
            {
                xOffset = this.Width;
            }

            lblTextoMenu.Location = new Point(xOffset, lblTextoMenu.Location.Y);
        }
    }
}

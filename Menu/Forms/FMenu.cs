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

        private async void btnClientes_Click(object sender, EventArgs e)
        {
            var fClientes = await FClientes.CreateAndLoadAsync();
            fClientes.ShowDialog();
        }

        private async void btnEstoque_Click(object sender, EventArgs e)
        {
            var fClientes = await FClientes.CreateAndLoadAsync();
            fClientes.ShowDialog();
        }

        private async void btnFornecedores_Click(object sender, EventArgs e)
        {
            var fClientes = await FClientes.CreateAndLoadAsync();
            fClientes.ShowDialog();
        }
    }
}

using FirebirdSql.Data.FirebirdClient;
using Menu.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.Forms
{
    public partial class FFornecedores : Form
    {
        public FFornecedores()
        {
            InitializeComponent();
        }

        private async void FFornecedores_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            using (var context = new DataContext())
            {
                await context.TFornecedor.LoadAsync();
                dataGridFornecedores.DataSource = context.TCliente.Local.ToBindingList();
            }
        }
    }
}
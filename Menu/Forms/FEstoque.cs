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
using FirebirdSql.Data.Client;

namespace Menu.Forms
{
    public partial class FEstoque : Form
    {
        public FEstoque()
        {
            InitializeComponent();
        }

        private async void FEstoque_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            using (var context = new DataContext())
            {
                await context.TEstoque.LoadAsync();
                dataGridEstoque.DataSource = context.TEstoque.Local.ToBindingList();
            }
        }
    }
}

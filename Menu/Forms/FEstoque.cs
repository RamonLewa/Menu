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
using Menu.Tables;
using System.Threading;

namespace Menu.Forms
{
    public partial class FEstoque : Form
    {
        public FEstoque()
        {
            InitializeComponent();
            this.Load += new EventHandler(FEstoque_Load);
        }
        private async void FEstoque_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        public async Task LoadDataAsync()
        {
            List<TEstoque> estoque;

            using (var context = new DataContext())
            {
                // Carregar dados assincronamente e paralelamente
                estoque = await Task.Run(() =>
                {
                    return context.TEstoque
                                  .AsParallel()
                                  .WithDegreeOfParallelism(Environment.ProcessorCount)
                                  .ToList();
                });
            }

            // Atualizar DataGridView na thread da UI
            dataGridEstoque.DataSource = estoque;
        }

        public static async Task<FEstoque> CreateAndLoadAsync()
        {
            var form = new FEstoque();
            await form.LoadDataAsync();
            return form;
        }
    }
}

using FirebirdSql.Data.FirebirdClient;
using Menu.Classes;
using Menu.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.Forms
{
    public partial class FFornecedores : Form
    {
        public FFornecedores()
        {
            InitializeComponent();
            this.Load += new EventHandler(FFornecedores_Load);
        }

        private async void FFornecedores_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        public async Task LoadDataAsync()
        {
            List<TFornecedor> fornecedores;

            using (var context = new DataContext())
            {
                // Carregar dados assincronamente e paralelamente
                fornecedores = await Task.Run(() =>
                {
                    return context.TFornecedor
                                  .AsParallel()
                                  .WithDegreeOfParallelism(Environment.ProcessorCount)
                                  .ToList();
                });
            }

            // Atualizar DataGridView na thread da UI
            dataGridFornecedores.DataSource = fornecedores;
        }

        public static async Task<FFornecedores> CreateAndLoadAsync()
        {
            var form = new FFornecedores();
            await form.LoadDataAsync();
            return form;
        }
    }
}
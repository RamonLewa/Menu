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
        }

        private async Task LoadDataAsync()
        {
            List<TFornecedor> fornecedor;
            using (var context = new DataContext())
            {
                fornecedor = await Task.Run(() => context.TFornecedor.ToList());
            }

            await Task.Factory.StartNew(() =>
            {
                dataGridFornecedores.DataSource = fornecedor;
            }, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
        }

        public static async Task<FFornecedores> CreateAndLoadAsync()
        {
            var form = new FFornecedores();
            await form.LoadDataAsync();
            return form;
        }
    }
}
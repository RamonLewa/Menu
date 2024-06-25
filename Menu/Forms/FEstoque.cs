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
        }

        public async Task LoadDataAsync()
        {
            List<TEstoque> estoque;

            using (var context = new DataContext())
            {
                estoque = await Task.Run(() =>
                {
                    return context.TEstoque
                                  .AsParallel()
                                  .WithDegreeOfParallelism(Environment.ProcessorCount)
                                  .ToList();
                });
            }

            dataGridEstoque.DataSource = estoque;
        }
    }
}

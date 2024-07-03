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
    public partial class FFornecedores : SGForm
    {
        public FFornecedores()
        {
            InitializeComponent();
            FullWidthScreen();
        }

        public async Task LoadDataAsync()
        {
            List<TFornecedor> fornecedores;

            using (var context = new DataContext())
            {
                fornecedores = await Task.Run(() =>
                {
                    return context.TFornecedor
                                  .AsParallel()
                                  .WithDegreeOfParallelism(Environment.ProcessorCount)
                                  .OrderBy(cli => cli.Controle)
                                  .ToList();
                });
            }

            dataGridFornecedores.DataSource = fornecedores;
        }

        private void dataGridFornecedores_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuFornecedores.Show(dataGridFornecedores, new Point(e.X, e.Y));
            }
        }

        private void exportarFornecedores_Click(object sender, EventArgs e)
        {
            FExportaFornecedores fExportaFornecedores = new FExportaFornecedores();
            fExportaFornecedores.ShowDialog();
        }

        private void importarFornecedores_Click(object sender, EventArgs e)
        {
            ImportarPlanilhaFornecedores planilha = new ImportarPlanilhaFornecedores();
            planilha.ImportExcelFile();
        }
    }
}
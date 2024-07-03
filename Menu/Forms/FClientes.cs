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
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.Forms
{
    public partial class FClientes : SGForm
    {
        public FClientes()
        {
            InitializeComponent();
            FullWidthScreen();
        }

        public async Task LoadDataAsync()
        {
            List<TCliente> clientes;

            using (var context = new DataContext())
            {
                clientes = await Task.Run(() =>
                {
                    return context.TCliente
                                  .AsParallel()
                                  .WithDegreeOfParallelism(Environment.ProcessorCount)
                                  .OrderBy(cli => cli.Controle)
                                  .ToList();
                });
            }

            DataGridClientes.DataSource = clientes;
        }

        private void dataGridClientes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuClientes.Show(DataGridClientes, new Point(e.X, e.Y));
            }
        }

        private void exportarClientes_Click(object sender, EventArgs e)
        {
            FExportaClientes fExportaClientes = new FExportaClientes();
            fExportaClientes.ShowDialog();
        }

        private void importarClientes_Click(object sender, EventArgs e)
        {
            ImportarPlanilhaClientes planilha = new ImportarPlanilhaClientes();
            planilha.ImportExcelFile();
        }
    }
}

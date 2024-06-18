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
    public partial class FClientes : Form
    {
        public FClientes()
        {
            InitializeComponent();
            this.Load += new EventHandler(FClientes_Load);
        }

        private async void FClientes_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        public async Task LoadDataAsync()
        {
            List<TCliente> clientes;

            using (var context = new DataContext())
            {
                // Carregar dados assincronamente e paralelamente
                clientes = await Task.Run(() =>
                {
                    return context.TCliente
                                  .AsParallel()
                                  .WithDegreeOfParallelism(Environment.ProcessorCount)
                                  .ToList();
                });
            }

            // Atualizar DataGridView na thread da UI
            DataGridClientes.DataSource = clientes;
        }

        private void dataGridClientes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = DataGridClientes.HitTest(e.X, e.Y);

                if (hitTestInfo.RowIndex >= 0 && hitTestInfo.ColumnIndex >= 0)
                {
                    DataGridClientes.ClearSelection();
                    DataGridClientes.Rows[hitTestInfo.RowIndex].Cells[hitTestInfo.ColumnIndex].Selected = true;

                    ContextMenuClientes.Show(DataGridClientes, new Point(e.X, e.Y));
                }
            }
        }

        private void exportarClientes_Click(object sender, EventArgs e)
        {
            ExportarPlanilhaClientes planilha = new ExportarPlanilhaClientes();
            planilha.CreateExcelFile();
        }
    }
}

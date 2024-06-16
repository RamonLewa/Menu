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
    public partial class FClientes : Form
    {
        public FClientes()
        {
            InitializeComponent();
        }

        private async Task LoadDataAsync()
        {
            List<TCliente> clientes;
            using (var context = new DataContext())
            {
                clientes = await Task.Run(() => context.TCliente.ToList());
            }

            await Task.Factory.StartNew(() =>
            {
                DataGridClientes.DataSource = clientes;
            }, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
        }

        public static async Task<FClientes> CreateAndLoadAsync()
        {
            var form = new FClientes();
            await form.LoadDataAsync();
            return form;
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

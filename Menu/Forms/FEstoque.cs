﻿using FirebirdSql.Data.FirebirdClient;
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
                                  .OrderBy(est => est.Controle)
                                  .ToList();
                });
            }

            dataGridEstoque.DataSource = estoque;
        }

        private void dataGridEstoque_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridEstoque.HitTest(e.X, e.Y);

                if (hitTestInfo.RowIndex >= 0 && hitTestInfo.ColumnIndex >= 0)
                {
                    dataGridEstoque.ClearSelection();
                    dataGridEstoque.Rows[hitTestInfo.RowIndex].Cells[hitTestInfo.ColumnIndex].Selected = true;

                    contextMenuEstoque.Show(dataGridEstoque, new Point(e.X, e.Y));
                }
            }
        }

        private void exportarEstoque_Click(object sender, EventArgs e)
        {
            FExportaEstoque fExportaEstoque = new FExportaEstoque();
            fExportaEstoque.ShowDialog();
        }
    }
}

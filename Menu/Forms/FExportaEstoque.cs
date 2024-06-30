using Menu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.Forms
{
    public partial class FExportaEstoque : SGForm
    {
        public FExportaEstoque()
        {
            InitializeComponent();
            comboBoxFiltro.SelectedIndex = 0;
        }

        private void checkBoxSelecionarTodosEstoque_CheckedChanged(object sender, EventArgs e)
        {
            bool checkAll = checkBoxSelecionarTodosEstoque.Checked;

            for (int i = 0; i < checkedListEstoque.Items.Count; i++)
            {
                checkedListEstoque.SetItemChecked(i, checkAll);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var filtro = comboBoxFiltro.SelectedItem.ToString();
            ExportarPlanilhaEstoque ex = new ExportarPlanilhaEstoque();
            ex.CreateExcelFile(checkedListEstoque.CheckedItems, filtro);
        }
    }
}

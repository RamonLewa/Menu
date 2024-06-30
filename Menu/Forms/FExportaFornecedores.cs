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
    public partial class FExportaFornecedores : SGForm
    {
        public FExportaFornecedores()
        {
            InitializeComponent();
            comboBoxFiltro.SelectedIndex = 0;
        }

        private void checkBoxSelecionarTodosForn_CheckedChanged(object sender, EventArgs e)
        {
            bool checkAll = checkBoxSelecionarTodosForn.Checked;

            for (int i = 0; i < checkedListFornecedores.Items.Count; i++)
            {
                checkedListFornecedores.SetItemChecked(i, checkAll);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            var filtro = comboBoxFiltro.SelectedItem.ToString();
            ExportarPlanilhaFornecedores ex = new ExportarPlanilhaFornecedores();
            ex.CreateExcelFile(checkedListFornecedores.CheckedItems, filtro);
        }
    }
}

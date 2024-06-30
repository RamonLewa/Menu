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
    public partial class FExportaClientes : SGForm
    {
        public FExportaClientes()
        {
            InitializeComponent();
            comboBoxFiltro.SelectedIndex = 0;
        }

        private void checkBoxSelecionarTodosClientes_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica o estado da CheckBox
            bool checkAll = checkBoxSelecionarTodosClientes.Checked;

            // Marca ou desmarca todos os itens do CheckedListBox
            for (int i = 0; i < checkedListClientes.Items.Count; i++)
            {
                checkedListClientes.SetItemChecked(i, checkAll);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filtro = comboBoxFiltro.SelectedItem.ToString();
            ExportarPlanilhaClientes ex = new ExportarPlanilhaClientes();
            ex.CreateExcelFile(checkedListClientes.CheckedItems, filtro);
        }
    }
}

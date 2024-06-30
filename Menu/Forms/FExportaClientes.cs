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
    public partial class FExportaClientes : Form
    {
        public FExportaClientes()
        {
            InitializeComponent();
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
    }
}

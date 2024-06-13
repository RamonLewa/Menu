using FirebirdSql.Data.FirebirdClient;
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
    public partial class FEstoque : Form
    {
        public FEstoque()
        {
            InitializeComponent();
        }

        private void FEstoque_Load(object sender, EventArgs e)
        {
            string configSoftMaster = "C:\\SGBR\\Master\\ConfigSoftMaster.ini";
            string connectionString = ConnectionParams.ConnectionString(configSoftMaster);
            using (FbConnection connection = new FbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM TCLIENTE";
                    FbDataAdapter adapter = new FbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridEstoque.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
    }
}

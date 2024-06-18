using Menu.Tables;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.Classes
{
    public class ExportarPlanilhaClientes
    {
        public void CreateExcelFile()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var context = new DataContext())
            {
                List<TCliente> clientes = context.TCliente.ToList();
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Planilha teste");

                    worksheet.Cells[1, 1].Value = "Nome";

                    for(int i = 0;  i < clientes.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = clientes[i].Cliente;
                    }

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Planilha Excel|*.xlsx"; 
                    saveFileDialog.Title = "Salvar Planilha Clientes";
                    saveFileDialog.FileName = "Clientes";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if(saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string caminhoArquivo = saveFileDialog.FileName;
                        package.SaveAs(caminhoArquivo);
                        MessageBox.Show("Arquivo gerado com sucesso!");
                    }
                }
            }
        }
    }
}
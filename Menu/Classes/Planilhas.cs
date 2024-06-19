using Menu.Tables;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
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

    public class ImportarPlanilhaClientes
    {
        public void ImportExcelFile()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Planilha Excel|*.xlsx";
            openFileDialog.Title = "Selecionar Planilha de Clientes";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = openFileDialog.FileName;

                using (var package = new ExcelPackage(new FileInfo(caminhoArquivo)))
                {
                    var worksheet = package.Workbook.Worksheets[0];

                    int rowCount = worksheet.Dimension.Rows;

                    DateTime dateTime = DateTime.Now;

                    List<TCliente> clientes = new List<TCliente>();

                    for (int row = 2; row <= rowCount; row++)
                    {
                        var cliente = new TCliente
                        {
                            Cliente = Truncate(worksheet.Cells[row, 1].Value?.ToString(), 50),
                            Fantasia = Truncate(worksheet.Cells[row, 2].Value?.ToString(), 50),
                            CNPJ = Truncate(worksheet.Cells[row, 3].Value?.ToString(), 20),
                            RG = Truncate(worksheet.Cells[row, 4].Value?.ToString(), 20),
                            Endereco = Truncate(worksheet.Cells[row, 5].Value?.ToString(), 100),
                            Complemento = Truncate(worksheet.Cells[row, 6].Value?.ToString(), 50),
                            Bairro = Truncate(worksheet.Cells[row, 7].Value?.ToString(), 50),
                            CEP = Truncate(worksheet.Cells[row, 8].Value?.ToString(), 10),
                            Numero = Truncate(worksheet.Cells[row, 9].Value?.ToString(), 10),
                            Cidade = Truncate(worksheet.Cells[row, 10].Value?.ToString(), 50),
                            UF = Truncate(worksheet.Cells[row, 11].Value?.ToString(), 2),
                            Telefone = Truncate(worksheet.Cells[row, 12].Value?.ToString(), 20),
                            Email = Truncate(worksheet.Cells[row, 13].Value?.ToString(), 50),
                            DataHoraCadastro = dateTime,
                            Ativo = "SIM",
                        };

                        // Adiciona o cliente à lista
                        clientes.Add(cliente);
                    }

                    // Salva a lista de clientes no banco de dados
                    using (var context = new DataContext())
                    {
                        context.TCliente.AddRange(clientes);
                        context.SaveChanges();
                    }

                    MessageBox.Show("Dados importados com sucesso!");
                }
            }
        }
        // Método para truncar strings que excedem o comprimento máximo permitido
        private string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
    }
}
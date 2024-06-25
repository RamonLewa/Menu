using Menu.Forms;
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
                    var worksheet = package.Workbook.Worksheets.Add("Planilha clientes");

                    worksheet.Cells[1, 1].Value = "Código";
                    worksheet.Cells[1, 2].Value = "Cliente";
                    worksheet.Cells[1, 3].Value = "Fantasia";
                    worksheet.Cells[1, 4].Value = "CPF";
                    worksheet.Cells[1, 5].Value = "CNPJ";
                    worksheet.Cells[1, 6].Value = "Telefone";
                    worksheet.Cells[1, 7].Value = "Celular";
                    worksheet.Cells[1, 8].Value = "País";
                    worksheet.Cells[1, 9].Value = "UF";
                    worksheet.Cells[1, 10].Value = "Cidade";
                    worksheet.Cells[1, 11].Value = "Bairro";
                    worksheet.Cells[1, 12].Value = "Endereço";
                    worksheet.Cells[1, 13].Value = "Número";
                    worksheet.Cells[1, 14].Value = "CEP";
                    worksheet.Cells[1, 15].Value = "Complemento";
                    worksheet.Cells[1, 16].Value = "E-mail";
                    worksheet.Cells[1, 17].Value = "E-mail2";
                    worksheet.Cells[1, 18].Value = "Nacionalidade";
                    worksheet.Cells[1, 19].Value = "Naturalidade";
                    worksheet.Cells[1, 2].Value = "Data nascimento";
                    worksheet.Cells[1, 21].Value = "Tipo de cliente";
                    worksheet.Cells[1, 22].Value = "RG";
                    worksheet.Cells[1, 23].Value = "IE";
                    worksheet.Cells[1, 24].Value = "Estado civil";
                    worksheet.Cells[1, 25].Value = "Sexo";
                    worksheet.Cells[1, 26].Value = "IM";
                    worksheet.Cells[1, 27].Value = "Data e hora cadastro";
                    worksheet.Cells[1, 28].Value = "Pai";
                    worksheet.Cells[1, 29].Value = "Mãe";
                    worksheet.Cells[1, 30].Value = "Nome cônjuge";
                    worksheet.Cells[1, 31].Value = "Nome contato jurídico";
                    worksheet.Cells[1, 32].Value = "Data última venda";
                    worksheet.Cells[1, 33].Value = "Limite de crédito";
                    worksheet.Cells[1, 34].Value = "Cód. convênio";
                    worksheet.Cells[1, 35].Value = "Convênio";
                    worksheet.Cells[1, 36].Value = "Profissão";
                    worksheet.Cells[1, 37].Value = "Empresa";
                    worksheet.Cells[1, 38].Value = "Fone trabalho";
                    worksheet.Cells[1, 39].Value = "Renda mensal";
                    worksheet.Cells[1, 40].Value = "Dias sem comprar";
                    worksheet.Cells[1, 41].Value = "Código cidade IGBE";
                    worksheet.Cells[1, 42].Value = "Status";
                    worksheet.Cells[1, 43].Value = "Cód vendedor";
                    worksheet.Cells[1, 44].Value = "Vendedor";
                    worksheet.Cells[1, 45].Value = "Ativo";
                    worksheet.Cells[1, 46].Value = "Campo 1";
                    worksheet.Cells[1, 47].Value = "Campo 2";
                    worksheet.Cells[1, 48].Value = "Campo 3";
                    worksheet.Cells[1, 49].Value = "Campo 4";
                    worksheet.Cells[1, 50].Value = "Campo 5";
                    worksheet.Cells[1, 51].Value = "Campo 6";
                    worksheet.Cells[1, 52].Value = "Campo 7";
                    worksheet.Cells[1, 53].Value = "Campo 8";
                    worksheet.Cells[1, 54].Value = "Campo 9";
                    worksheet.Cells[1, 55].Value = "Campo 10";

                    for (int i = 0; i < clientes.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = clientes[i].Controle;
                        worksheet.Cells[i + 2, 2].Value = clientes[i].Cliente;
                        worksheet.Cells[i + 2, 3].Value = clientes[i].Fantasia;
                        worksheet.Cells[i + 2, 4].Value = clientes[i].CPF;
                        worksheet.Cells[i + 2, 5].Value = clientes[i].CNPJ;
                        worksheet.Cells[i + 2, 6].Value = clientes[i].Telefone;
                        worksheet.Cells[i + 2, 7].Value = clientes[i].Celular;
                        worksheet.Cells[i + 2, 8].Value = clientes[i].Pais;
                        worksheet.Cells[i + 2, 9].Value = clientes[i].UF;
                        worksheet.Cells[i + 2, 10].Value = clientes[i].Cidade;
                        worksheet.Cells[i + 2, 11].Value = clientes[i].Bairro;
                        worksheet.Cells[i + 2, 12].Value = clientes[i].Endereco;
                        worksheet.Cells[i + 2, 13].Value = clientes[i].Numero;
                        worksheet.Cells[i + 2, 14].Value = clientes[i].CEP;
                        worksheet.Cells[i + 2, 15].Value = clientes[i].Complemento;
                        worksheet.Cells[i + 2, 16].Value = clientes[i].Email;
                        worksheet.Cells[i + 2, 17].Value = clientes[i].Email2;
                        worksheet.Cells[i + 2, 18].Value = clientes[i].Nacionalidade;
                        worksheet.Cells[i + 2, 29].Value = clientes[i].Naturalidade;
                        worksheet.Cells[i + 2, 20].Value = clientes[i].DataNascimento;
                        worksheet.Cells[i + 2, 21].Value = clientes[i].TipoCliente;
                        worksheet.Cells[i + 2, 22].Value = clientes[i].RG;
                        worksheet.Cells[i + 2, 23].Value = clientes[i].IE;
                        worksheet.Cells[i + 2, 24].Value = clientes[i].EstadoCivil;
                        worksheet.Cells[i + 2, 25].Value = clientes[i].Sexo;
                        worksheet.Cells[i + 2, 26].Value = clientes[i].IM;
                        worksheet.Cells[i + 2, 27].Value = clientes[i].DataHoraCadastro;
                        worksheet.Cells[i + 2, 28].Value = clientes[i].Pai;
                        worksheet.Cells[i + 2, 29].Value = clientes[i].Mae;
                        worksheet.Cells[i + 2, 30].Value = clientes[i].NomeConjuge;
                        worksheet.Cells[i + 2, 31].Value = clientes[i].NomeContatoJuridico;
                        worksheet.Cells[i + 2, 32].Value = clientes[i].DataUltimaVenda;
                        worksheet.Cells[i + 2, 33].Value = clientes[i].LimiteCredito;
                        worksheet.Cells[i + 2, 34].Value = clientes[i].CodConvenio;
                        worksheet.Cells[i + 2, 35].Value = clientes[i].Convenio;
                        worksheet.Cells[i + 2, 36].Value = clientes[i].Profissao;
                        worksheet.Cells[i + 2, 37].Value = clientes[i].EmpresaQueTrabalha;
                        worksheet.Cells[i + 2, 38].Value = clientes[i].FoneTrabalho;
                        worksheet.Cells[i + 2, 39].Value = clientes[i].RendaMensal;
                        worksheet.Cells[i + 2, 40].Value = clientes[i].DiasSemComprar;
                        worksheet.Cells[i + 2, 41].Value = clientes[i].CodigoCidadeIGBE;
                        worksheet.Cells[i + 2, 42].Value = clientes[i].Status;
                        worksheet.Cells[i + 2, 43].Value = clientes[i].CodVendedor;
                        worksheet.Cells[i + 2, 44].Value = clientes[i].Vendedor;
                        worksheet.Cells[i + 2, 45].Value = clientes[i].Ativo;
                        worksheet.Cells[i + 2, 46].Value = clientes[i].Campo1;
                        worksheet.Cells[i + 2, 47].Value = clientes[i].Campo2;
                        worksheet.Cells[i + 2, 48].Value = clientes[i].Campo3;
                        worksheet.Cells[i + 2, 49].Value = clientes[i].Campo4;
                        worksheet.Cells[i + 2, 50].Value = clientes[i].Campo5;
                        worksheet.Cells[i + 2, 51].Value = clientes[i].Campo6;
                        worksheet.Cells[i + 2, 52].Value = clientes[i].Campo7;
                        worksheet.Cells[i + 2, 53].Value = clientes[i].Campo8;
                        worksheet.Cells[i + 2, 54].Value = clientes[i].Campo9;
                        worksheet.Cells[i + 2, 55].Value = clientes[i].Campo10;
                    }

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Planilha Excel|*.xlsx";
                    saveFileDialog.Title = "Salvar Planilha Clientes";
                    saveFileDialog.FileName = "Clientes";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string caminhoArquivo = saveFileDialog.FileName;
                        package.SaveAs(caminhoArquivo);
                        MessageBox.Show("Arquivo gerado com sucesso!");
                    }
                }
            }
        }
    }

    public class ExportarPlanilhaFornecedores
    {
        public void CreateExcelFile()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var context = new DataContext())
            {
                List<TFornecedor> clientes = context.TFornecedor.ToList();
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Planilha fornecedores");

                    worksheet.Cells[1, 1].Value = "Código";
                    worksheet.Cells[1, 2].Value = "Nome fantasia";
                    worksheet.Cells[1, 3].Value = "Razão social";
                    worksheet.Cells[1, 4].Value = "CPF";
                    worksheet.Cells[1, 5].Value = "RG";
                    worksheet.Cells[1, 6].Value = "CNPJ";
                    worksheet.Cells[1, 7].Value = "Celular";
                    worksheet.Cells[1, 8].Value = "Telefone";
                    worksheet.Cells[1, 9].Value = "País";
                    worksheet.Cells[1, 10].Value = "UF";
                    worksheet.Cells[1, 11].Value = "Cód. cidade";
                    worksheet.Cells[1, 12].Value = "Cidade";
                    worksheet.Cells[1, 13].Value = "Bairro";
                    worksheet.Cells[1, 14].Value = "Endereço";
                    worksheet.Cells[1, 15].Value = "CEP";
                    worksheet.Cells[1, 16].Value = "Número";
                    worksheet.Cells[1, 17].Value = "Complemento";
                    worksheet.Cells[1, 18].Value = "IE";
                    worksheet.Cells[1, 19].Value = "IM";
                    worksheet.Cells[1, 20].Value = "SAC";
                    worksheet.Cells[1, 21].Value = "E-mail";
                    worksheet.Cells[1, 22].Value = "Site";
                    worksheet.Cells[1, 23].Value = "Forma de pagamento";
                    worksheet.Cells[1, 24].Value = "Nome contato jurídica";
                    worksheet.Cells[1, 25].Value = "Data hora cadastro";
                    worksheet.Cells[1, 26].Value = "Campo 1";
                    worksheet.Cells[1, 27].Value = "Campo 2";
                    worksheet.Cells[1, 28].Value = "Campo 3";
                    worksheet.Cells[1, 29].Value = "Campo 4";
                    worksheet.Cells[1, 30].Value = "Campo 5";
                    worksheet.Cells[1, 31].Value = "Campo 6";
                    worksheet.Cells[1, 32].Value = "Campo 7";
                    worksheet.Cells[1, 33].Value = "Campo 8";
                    worksheet.Cells[1, 34].Value = "Campo 9";
                    worksheet.Cells[1, 35].Value = "Campo 10";
                    worksheet.Cells[1, 36].Value = "Cód. cidade IBGE";
                    worksheet.Cells[1, 37].Value = "Ativo";

                    for (int i = 0; i < clientes.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = clientes[i].Controle;
                        worksheet.Cells[i + 2, 2].Value = clientes[i].NomeFantasia;
                        worksheet.Cells[i + 2, 3].Value = clientes[i].RazaoSocial;
                        worksheet.Cells[i + 2, 4].Value = clientes[i].CPF;
                        worksheet.Cells[i + 2, 5].Value = clientes[i].RG;
                        worksheet.Cells[i + 2, 6].Value = clientes[i].CNPJ;
                        worksheet.Cells[i + 2, 7].Value = clientes[i].Celular;
                        worksheet.Cells[i + 2, 8].Value = clientes[i].Telefone;
                        worksheet.Cells[i + 2, 9].Value = clientes[i].Pais;
                        worksheet.Cells[i + 2, 10].Value = clientes[i].UF;
                        worksheet.Cells[i + 2, 11].Value = clientes[i].CodCidade;
                        worksheet.Cells[i + 2, 12].Value = clientes[i].Cidade;
                        worksheet.Cells[i + 2, 13].Value = clientes[i].Bairro;
                        worksheet.Cells[i + 2, 14].Value = clientes[i].Endereco;
                        worksheet.Cells[i + 2, 15].Value = clientes[i].CEP;
                        worksheet.Cells[i + 2, 16].Value = clientes[i].Numero;
                        worksheet.Cells[i + 2, 17].Value = clientes[i].Complemento;
                        worksheet.Cells[i + 2, 18].Value = clientes[i].IE;
                        worksheet.Cells[i + 2, 19].Value = clientes[i].IM;
                        worksheet.Cells[i + 2, 20].Value = clientes[i].SAC;
                        worksheet.Cells[i + 2, 21].Value = clientes[i].Email;
                        worksheet.Cells[i + 2, 22].Value = clientes[i].Site;
                        worksheet.Cells[i + 2, 23].Value = clientes[i].FormaPagamento;
                        worksheet.Cells[i + 2, 24].Value = clientes[i].NomeContatoJuridica;
                        worksheet.Cells[i + 2, 25].Value = clientes[i].DataHoraCadastro;
                        worksheet.Cells[i + 2, 26].Value = clientes[i].Campo1;
                        worksheet.Cells[i + 2, 27].Value = clientes[i].Campo2;
                        worksheet.Cells[i + 2, 28].Value = clientes[i].Campo3;
                        worksheet.Cells[i + 2, 29].Value = clientes[i].Campo4;
                        worksheet.Cells[i + 2, 30].Value = clientes[i].Campo5;
                        worksheet.Cells[i + 2, 31].Value = clientes[i].Campo6;
                        worksheet.Cells[i + 2, 32].Value = clientes[i].Campo7;
                        worksheet.Cells[i + 2, 33].Value = clientes[i].Campo8;
                        worksheet.Cells[i + 2, 34].Value = clientes[i].Campo9;
                        worksheet.Cells[i + 2, 35].Value = clientes[i].Campo10;
                        worksheet.Cells[i + 2, 36].Value = clientes[i].CodigoCidadeIBGE;
                        worksheet.Cells[i + 2, 37].Value = clientes[i].Ativo;
                    }

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Planilha Excel|*.xlsx";
                    saveFileDialog.Title = "Salvar Planilha Fornecedores";
                    saveFileDialog.FileName = "Fornecedores";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
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
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
        public void CreateExcelFile(CheckedListBox.CheckedItemCollection checkedItems, string filtro)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var context = new DataContext())
            {
                List<TCliente> clientes;

                switch (filtro)
                {
                    case "Ativos":
                        clientes = context.TCliente.Where(cli => cli.Ativo == "SIM").OrderBy(cli => cli.Controle).ToList();
                        break;
                    case "Inativos":
                        clientes = context.TCliente.Where(cli => cli.Ativo != "SIM").OrderBy(cli => cli.Controle).ToList();
                        break;
                    default:
                        clientes = context.TCliente.OrderBy(cli => cli.Controle).ToList();
                        break;
                }

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Planilha clientes");

                    // Dicionário para mapear o nome da coluna com o índice da célula
                    Dictionary<string, string> columnMap = new Dictionary<string, string>()
                {
                    { "Código", "Controle" }, { "Cliente", "Cliente" }, { "Fantasia", "Fantasia" }, { "CPF", "CPF" },
                    { "CNPJ", "CNPJ" }, { "Telefone", "Telefone" }, { "Celular", "Celular" }, { "País", "Pais" },
                    { "UF", "UF" }, { "Cidade", "Cidade" }, { "Bairro", "Bairro" }, { "Endereço", "Endereco" },
                    { "Número", "Numero" }, { "CEP", "CEP" }, { "Complemento", "Complemento" }, { "E-mail", "Email" },
                    { "E-mail2", "Email2" }, { "Nacionalidade", "Nacionalidade" }, { "Naturalidade", "Naturalidade" },
                    { "Data nascimento", "DataNascimento" }, { "Tipo de cliente", "TipoCliente" }, { "RG", "RG" },
                    { "IE", "IE" }, { "Estado civil", "EstadoCivil" }, { "Sexo", "Sexo" }, { "IM", "IM" },
                    { "Data e hora cadastro", "DataHoraCadastro" }, { "Pai", "Pai" }, { "Mãe", "Mae" },
                    { "Nome cônjuge", "NomeConjuge" }, { "Nome contato jurídico", "NomeContatoJuridico" },
                    { "Data última venda", "DataUltimaVenda" }, { "Limite de crédito", "LimiteCredito" },
                    { "Cód. convênio", "CodConvenio" }, { "Convênio", "Convenio" }, { "Profissão", "Profissao" },
                    { "Empresa", "EmpresaQueTrabalha" }, { "Fone trabalho", "FoneTrabalho" }, { "Renda mensal", "RendaMensal" },
                    { "Dias sem comprar", "DiasSemComprar" }, { "Código cidade IGBE", "CodigoCidadeIGBE" }, { "Status", "Status" },
                    { "Cód vendedor", "CodVendedor" }, { "Vendedor", "Vendedor" }, { "Ativo", "Ativo" },
                    { "Campo 1", "Campo1" }, { "Campo 2", "Campo2" }, { "Campo 3", "Campo3" }, { "Campo 4", "Campo4" },
                    { "Campo 5", "Campo5" }, { "Campo 6", "Campo6" }, { "Campo 7", "Campo7" }, { "Campo 8", "Campo8" },
                    { "Campo 9", "Campo9" }, { "Campo 10", "Campo10" }
                };

                    // Adiciona os cabeçalhos
                    int colIndex = 1;
                    foreach (string col in checkedItems)
                    {
                        worksheet.Cells[1, colIndex].Value = col;
                        colIndex++;
                    }

                    // Adiciona os dados
                    for (int i = 0; i < clientes.Count; i++)
                    {
                        colIndex = 1;
                        foreach (string col in checkedItems)
                        {
                            string propertyName;
                            if (columnMap.TryGetValue(col, out propertyName))
                            {
                                var propertyInfo = typeof(TCliente).GetProperty(propertyName);
                                if (propertyInfo != null)
                                {
                                    worksheet.Cells[i + 2, colIndex].Value = propertyInfo.GetValue(clientes[i]);
                                }
                            }
                            colIndex++;
                        }
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
    public class ExportarPlanilhaEstoque
    {
        public void CreateExcelFile()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var context = new DataContext())
            {
                List<TEstoque> clientes = context.TEstoque.ToList();
                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Planilha produtos");

                    worksheet.Cells[1, 1].Value = "Código";
                    worksheet.Cells[1, 1].Value = "Produto";
                    worksheet.Cells[1, 1].Value = "Cód. barras";
                    worksheet.Cells[1, 1].Value = "Referência";
                    worksheet.Cells[1, 1].Value = "Unidade";
                    worksheet.Cells[1, 1].Value = "Preço de custo";
                    worksheet.Cells[1, 1].Value = "Perc. lucro";
                    worksheet.Cells[1, 1].Value = "Preço de venda";
                    worksheet.Cells[1, 1].Value = "Cód. grupo";
                    worksheet.Cells[1, 1].Value = "Grupo";
                    worksheet.Cells[1, 1].Value = "Cód. fornecedor";
                    worksheet.Cells[1, 1].Value = "Fornecedor";
                    worksheet.Cells[1, 1].Value = "Tamanho";
                    worksheet.Cells[1, 1].Value = "Peso";
                    worksheet.Cells[1, 1].Value = "Qtde total comprada";
                    worksheet.Cells[1, 1].Value = "Qtde total vendida";
                    worksheet.Cells[1, 1].Value = "Data última compra";
                    worksheet.Cells[1, 1].Value = "Data última venda";
                    worksheet.Cells[1, 1].Value = "Data e hora cadastro";
                    worksheet.Cells[1, 1].Value = "Qtde mínima";
                    worksheet.Cells[1, 1].Value = "Qtde máxima";
                    worksheet.Cells[1, 1].Value = "Qtde";
                    worksheet.Cells[1, 1].Value = "Ativo";
                    worksheet.Cells[1, 1].Value = "NCM";
                    worksheet.Cells[1, 1].Value = "Perc. crédito ICMS";
                    worksheet.Cells[1, 1].Value = "Usa grade";
                    worksheet.Cells[1, 1].Value = "Usa serial";
                    worksheet.Cells[1, 1].Value = "Origem";
                    worksheet.Cells[1, 1].Value = "Cód. tributação IPI";
                    worksheet.Cells[1, 1].Value = "Tributação IPI";
                    worksheet.Cells[1, 1].Value = "Cód. tributação PIS";
                    worksheet.Cells[1, 1].Value = "Tributação PIS";
                    worksheet.Cells[1, 1].Value = "Cód. tributação COFINS";
                    worksheet.Cells[1, 1].Value = "Tributação COFINS";
                    worksheet.Cells[1, 1].Value = "Tipo tributação";
                    worksheet.Cells[1, 1].Value = "Perc. ICMS interna";
                    worksheet.Cells[1, 1].Value = "Perc. MVA original";
                    worksheet.Cells[1, 1].Value = "Perc. ICMS próprio S.T";
                    worksheet.Cells[1, 1].Value = "IAT";
                    worksheet.Cells[1, 1].Value = "IPPT";
                    worksheet.Cells[1, 1].Value = "CSOSN/CST";
                    worksheet.Cells[1, 1].Value = "Descrição CSOSN/CST";
                    worksheet.Cells[1, 1].Value = "Pesado";
                    worksheet.Cells[1, 1].Value = "Base de cálculo ICMS retido";
                    worksheet.Cells[1, 1].Value = "Valor ICMS retido";
                    worksheet.Cells[1, 1].Value = "Alíquota ICMS ECF";
                    worksheet.Cells[1, 1].Value = "Mensagem NFE";
                    worksheet.Cells[1, 1].Value = "Cód. unidade de medida";
                    worksheet.Cells[1, 1].Value = "Cód. aplicação produto";
                    worksheet.Cells[1, 1].Value = "Aplicação produto";
                    worksheet.Cells[1, 1].Value = "Qtde inicial";
                    worksheet.Cells[1, 1].Value = "Alíquota ISS";
                    worksheet.Cells[1, 1].Value = "Cód. imposto médio";
                    worksheet.Cells[1, 1].Value = "Perc. imposto médio";
                    worksheet.Cells[1, 1].Value = "Cód. CST origem";
                    worksheet.Cells[1, 1].Value = "Código CST origem";
                    worksheet.Cells[1, 1].Value = "Cód. emitente";
                    worksheet.Cells[1, 1].Value = "Validade produto";
                    worksheet.Cells[1, 1].Value = "Fator conversão";
                    worksheet.Cells[1, 1].Value = "Tributação serviço";
                    worksheet.Cells[1, 1].Value = "Redução base de cálculo serviço";
                    worksheet.Cells[1, 1].Value = "Status";
                    worksheet.Cells[1, 1].Value = "Descrição complementar";
                    worksheet.Cells[1, 1].Value = "Preço de venda USS";
                    worksheet.Cells[1, 1].Value = "Perc. máximo desconto";
                    worksheet.Cells[1, 1].Value = "Valor comissão fixo";
                    worksheet.Cells[1, 1].Value = "Preço mínimo USS";
                    worksheet.Cells[1, 1].Value = "Preço mínimo";
                    worksheet.Cells[1, 1].Value = "Cód. compra";
                    worksheet.Cells[1, 1].Value = "Valor conversão";
                    worksheet.Cells[1, 1].Value = "Valor frete";
                    worksheet.Cells[1, 1].Value = "Valor outros";
                    worksheet.Cells[1, 1].Value = "Valor ICMS ST";
                    worksheet.Cells[1, 1].Value = "Valor IPI";
                    worksheet.Cells[1, 1].Value = "Valor unitário compra";
                    worksheet.Cells[1, 1].Value = "Perc. PIS";
                    worksheet.Cells[1, 1].Value = "Perc. COFINS";
                    worksheet.Cells[1, 1].Value = "CAMPO1";
                    worksheet.Cells[1, 1].Value = "CAMPO2";
                    worksheet.Cells[1, 1].Value = "CAMPO3";
                    worksheet.Cells[1, 1].Value = "CAMPO4";
                    worksheet.Cells[1, 1].Value = "CAMPO5";
                    worksheet.Cells[1, 1].Value = "CAMPO6";
                    worksheet.Cells[1, 1].Value = "CAMPO7";
                    worksheet.Cells[1, 1].Value = "CAMPO8";
                    worksheet.Cells[1, 1].Value = "CAMPO9";
                    worksheet.Cells[1, 1].Value = "CAMPO10";

                    for (int i = 0; i < clientes.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = clientes[i].Controle;
                    }

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Planilha Excel|*.xlsx";
                    saveFileDialog.Title = "Salvar Planilha Produtos";
                    saveFileDialog.FileName = "Produtos";
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
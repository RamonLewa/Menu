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
using System.Windows.Media;

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

                    int colIndex = 1;
                    foreach (string col in checkedItems)
                    {
                        worksheet.Cells[1, colIndex].Value = col;
                        colIndex++;
                    }

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
        public void CreateExcelFile(CheckedListBox.CheckedItemCollection checkedItems, string filtro)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var context = new DataContext())
            {
                List<TFornecedor> fornecedores;

                switch (filtro)
                {
                    case "Ativos":
                        fornecedores = context.TFornecedor.Where(forn => forn.Ativo == "SIM").OrderBy(forn => forn.Controle).ToList();
                        break;
                    case "Inativos":
                        fornecedores = context.TFornecedor.Where(forn => forn.Ativo != "SIM").OrderBy(forn => forn.Controle).ToList();
                        break;
                    default:
                        fornecedores = context.TFornecedor.OrderBy(forn => forn.Controle).ToList();
                        break;
                }

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Planilha fornecedores");

                    Dictionary<string, string> columnMap = new Dictionary<string, string>()
                    {
                        { "Código", "Controle" }, { "Nome fantasia", "NomeFantasia" }, { "Razão social", "RazaoSocial" }, 
                        { "CPF", "CPF" }, { "RG", "RG" }, { "CNPJ", "CNPJ" }, { "Celular", "Celular" }, 
                        { "Telefone", "Telefone" }, { "País", "Pais" }, { "UF", "UF" }, { "Cód. cidade", "CodCidade" }, 
                        { "Cidade", "Cidade" }, { "Bairro", "Bairro" }, { "Endereço", "Endereco" }, { "CEP", "CEP" }, 
                        { "Número", "Numero" }, { "Complemento", "Complemento" }, { "IE", "IE" }, { "IM", "IM" },
                        { "SAC", "SAC" }, { "E-mail", "Email" }, { "Site", "Site" }, { "Forma de pagamento", "FormaPagamento" },
                        { "Nome contato jurídica", "NomeContatoJuridica" }, { "Data hora cadastro", "DataHoraCadastro" },
                        { "Campo 1", "Campo1" }, { "Campo 2", "Campo2" }, { "Campo 3", "Campo3" }, { "Campo 4", "Campo4" },
                        { "Campo 5", "Campo5" }, { "Campo 6", "Campo6" }, { "Campo 7", "Campo7" }, { "Campo 8", "Campo8" },
                        { "Campo 9", "Campo9" }, { "Campo 10", "Campo10" }, { "Cód. cidade IGBE", "CodigoCidadeIGBE"}, { "Ativo", "Ativo"},
                    };

                    int colIndex = 1;
                    foreach (string col in checkedItems)
                    {
                        worksheet.Cells[1, colIndex].Value = col;
                        colIndex++;
                    }

                    for (int i = 0; i < fornecedores.Count; i++)
                    {
                        colIndex = 1;
                        foreach (string col in checkedItems)
                        {
                            string propertyName;
                            if (columnMap.TryGetValue(col, out propertyName))
                            {
                                var propertyInfo = typeof(TFornecedor).GetProperty(propertyName);
                                if (propertyInfo != null)
                                {
                                    worksheet.Cells[i + 2, colIndex].Value = propertyInfo.GetValue(fornecedores[i]);
                                }
                            }
                            colIndex++;
                        }
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
        public void CreateExcelFile(CheckedListBox.CheckedItemCollection checkedItems, string filtro)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var context = new DataContext())
            {
                List<TEstoque> estoque;

                switch (filtro)
                {
                    case "Com quantidade positiva":
                        estoque = context.TEstoque.Where(est => est.Qtde > 0).OrderBy(est => est.Controle).ToList();
                        break;
                    case "Zerados":
                        estoque = context.TEstoque.Where(est => est.Qtde == 0).OrderBy(est => est.Controle).ToList();
                        break;
                    case "Negativos":
                        estoque = context.TEstoque.Where(est => est.Qtde < 0).OrderBy (est => est.Controle).ToList();
                        break; 
                    case "Ativos":
                        estoque = context.TEstoque.Where(est => est.Ativo == "SIM").OrderBy (est => est.Controle).ToList();
                        break; 
                    case "Inativos":
                        estoque = context.TEstoque.Where(est => est.Ativo != "SIM").OrderBy (est => est.Controle).ToList();
                        break;
                    default:
                        estoque = context.TEstoque.OrderBy(est => est.Controle).ToList();
                        break;

                }

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Planilha produtos");

                    Dictionary<string, string> columnMap = new Dictionary<string, string>()
                    {
                        { "Código", "Controle" }, { "Produto", "Produto" }, { "Cód.barras", "CodBarras" },
                        { "Referência", "Referencia" }, { "Unidade", "Unidade" }, { "Preço de custo", "PrecoCusto" },
                        { "Perc. lucro", "PercLucro" }, { "Preço de venda", "PrecoVenda" }, { "Cód. grupo", "CodGrupo" },
                        { "Grupo", "Grupo" }, { "Cód. fornecedor", "CodFornecedor" }, { "Fornecedor", "Fornecedor" },
                        { "Tamanho", "Tamanho" }, { "Peso", "Peso" }, { "Qtde total comprada", "QtdeTotalComprada" },
                        { "Qtde total vendida", "QtdeTotalVendida" }, { "Data última compra", "DataUltimaCompra" },
                        { "Data última venda", "DataUltimaVenda" }, { "Data e hora cadastro", "DataHoraCadastro" },
                        { "Qtde mínima", "QtdeMinima" }, { "Qtde máxima", "QtdeMaxima" }, { "Qtde", "Qtde" },
                        { "Ativo", "Ativo" }, { "NCM", "NCM" }, { "Perc. crédito ICMS", "PercCreditoICMS" },
                        { "Usa grade", "UsaGrade" }, { "Usa serial", "UsaSerial" }, { "Origem", "Origem" },
                        { "Cód. tributação IPI", "CodTributacaoIPI" }, { "Tributação IPI", "TributacaoIPI" },
                        { "Cód. tributação PIS", "CodTributacaoPIS" }, { "Tributação PIS", "TributacaoPIS" },
                        { "Cód. tributação COFINS", "CodTributacaoCOFINS" }, { "Tributação COFINS", "TributacaoCOFINS" },
                        { "Tipo tributação", "TipoTributacao" }, { "Perc. ICMS interna", "PercICMSSTInterna" },
                        { "Perc. MVA original", "PercMVAOriginal" }, { "Perc. ICMS Próprio S.T", "PercICMSProprioST" },
                        { "IAT", "IAT" }, { "IPPT", "IPPT" }, { "CSOSN/CST", "CSOSN" }, { "Descrição CSOSN/CST", "DescricaoCSOSN" },
                        { "Pesado", "Pesado" }, { "Base de cálculo ICMS retido", "BaseCalculoICMSSTRetido" },
                        { "Valor ICMS retido", "ValorICMSSTRetido" }, { "Alíquota ICMS ECF", "AliquotaICMSECF" },
                        { "Mensagem NFE", "MensagemNFe" }, { "Cód. mensagem NFE", "CodMensagemNFe" },
                        { "Cód. unidade de medida", "CodUnidadeMedida" }, { "Cód. aplicação produto", "CodAplicacaoProduto" },
                        { "Aplicação produto", "AplicacaoProduto" }, { "Qtde inicial", "QtdeInicial" },
                        { "Alíquota ISS", "AliquotaISS" }, { "Cód. imposto médio", "CodImpostoMedio" },
                        { "Perc. imposto médio", "PercImpostoMedio" }, { "Cód. CST origem", "CodCSTOrigem" }, 
                        { "Cód. emitente", "CodEmitente" }, { "Validade produto", "DiasValidadeProduto" },
                        { "Fator conversão", "FatorConversao" }, { "Tributação serviço", "TributacaoServico" },
                        { "Redução base de cálculo serviço", "ReducaoBaseCalculoServico" }, { "Status", "Status" },
                        { "Descrição complementar", "DescricaoComplementar" }, { "Preço de venda USS", "PrecoVendaUSS" },
                        { "Perc. máximo desconto", "PercMaximoDesconto" }, { "Valor comissão fixo", "ValorComissaoFixo" },
                        { "Perc. comissão", "PercComissao" }, { "Preço mínimo USS", "PrecoMinimoUSS" }, { "Preço mínimo", "PrecoMinimo" },
                        { "Cód. compra", "CodCompra" }, { "Valor conversão", "ValorConversao" }, { "Valor frete", "ValorFrete" },
                        { "Valor outros", "ValorOutros" }, { "Valor ICMS ST", "ValorICMSST" },
                        { "Valor IPI", "ValorIPI" }, { "Valor unitário compra", "ValorUnitarioCompra" },
                        { "Perc. PIS", "PercPIS" }, { "Perc. COFINS", "PercCOFINS" }, { "Campo 1", "Campo1" },
                        { "Campo 2", "Campo2" }, { "Campo 3", "Campo3" }, { "Campo 4", "Campo4" }, { "Campo 5", "Campo5" },
                        { "Campo 6", "Campo6" }, { "Campo 7", "Campo7" }, { "Campo 8", "Campo8" }, { "Campo 9", "Campo9" },
                        { "Campo 10", "Campo10" }, { "Marca", "Marca" }, { "Perc. redução de B.C", "PercReducaoBC" },
                        { "Perc. redução de B.C S.T", "PercReducaoBCST" }, { "Cód. subgrupo", "CodSubgrupo" },
                        { "Subgrupo", "Subgrupo" }, { "Controlar validade", "ControlarValidade" }, { "Cód. marca", "CodMarca" },
                        { "Preço revenda", "PrecoRevenda" }, { "Perc. IPI", "PercIPI" }, { "CFOP", "CFOP" },
                        { "UN conversão venda", "UnidadeConversaoVenda" }, { "Valor conversão venda", "ValorConversaoVenda" },
                        { "Cód. tabela preço", "CodTabelaPreco" }, { "Tabela preço", "NomeTabelaPreco" },
                        { "Perc. imposto estadual", "PercImpostoMedioEstadual" }, { "Perc. imposto municipal", "PercImpostoMedioMunicipal" },
                        { "Cód. enquadramento IPI", "CodigoEnquadramentoIPI" }, { "CEST", "CEST" }, { "Qtde em produção", "QtdeEmProducao" },
                        { "Qtde pedido de venda", "QtdePedidoVenda" }, { "Qtde pedido de compra", "QtdePedidoCompra" },
                        { "Qtde reservada", "QtdeReservada" }, { "Qtde real", "QtdeReal" }, { "Qtde em produção MP", "QtdeEmProducaoMP" },
                        { "Unidade medida etiqueta", "UnidadeMedidaEtiqueta" }, { "Fator conversão etiqueta", "FatorConversaoEtiqueta" },
                        { "Cód. ANP", "CodigoANP" }, { "Descrição ANP", "DescricaoANP" }, { "Perc. GLP", "PercGLPComb" },
                        { "Perc. GNN", "PercGNNComb" }, { "Perc. GNI", "PercGNIComb" }, { "Valor partida", "ValorPartidaComb" },
                        { "Selo IPI", "SeloIPI" }, { "Alíquota FCP", "AliquotaFCP" }, { "% FCP", "PercFCPST" },
                        { "CNPJ fabricante", "CNPJFabricante" }, { "Cód. benefício fiscal", "CodigoBeneficioFiscal" },
                        { "Cód. ANVISA", "CodigoANVISA" }, { "Cód. UN trib.", "CodigoUnidadeTributavel" }, { "UN trib", "UnidadeTributavel" },
                        { "Qtde trib.", "QtdeTributavel" }, { "Desmontar na Venda", "DesmontarNaVenda" }, { "Alíquota ICMS ST retido", "AliquotaICMSSTRet" }, 
                        { "Valor BC ICMS ST retido", "ValorBCICMSSTRet" }, { "Alíquota ICMS efetivo", "AliquotaICMSEfet" },
                        { "% ICMS efetivo", "PercReducaoICMSEfet" }, { "Valor BC ICMS efetivo", "ValorBCICMSEfet" }, { "Valor ICMS efetivo", "ValorICMSEfet" },
                        { "Valor BC ICMS Substituto", "ValorICMSSubstituto" }, { "Valor ICMS ST retido", "ValorICMSSTRet" }, { "Cód. barras caixa", "CodigoBarrasCaixa" },
                        { "Valor PMC", "ValorPMC" }, { "Enviar Dados", "EnviarDados" }, { "Valor FCP ST", "ValorFCPST" }, { "Localização", "Localizacao" },
                        { "Cód. barras interno", "CodigoBarrasInterno" }, { "Cód. barras tributável", "CodigoBarrasTrib" }, { "Vacina", "Vacina" },
                        { "% Desconto caixa", "PercDescontoCaixa" }, { "Perc. cashback", "PercCashback" }, { "Tipo barra", "TipoBarras" },
                    };

                    int colIndex = 1;
                    foreach (string col in checkedItems)
                    {
                        worksheet.Cells[1, colIndex].Value = col;
                        colIndex++;
                    }

                    for (int i = 0; i < estoque.Count; i++)
                    {
                        colIndex = 1;
                        foreach (string col in checkedItems)
                        {
                            string propertyName;
                            if (columnMap.TryGetValue(col, out propertyName))
                            {
                                var propertyInfo = typeof(TEstoque).GetProperty(propertyName);
                                if (propertyInfo != null)
                                {
                                    worksheet.Cells[i + 2, colIndex].Value = propertyInfo.GetValue(estoque[i]);
                                }
                            }
                            colIndex++;
                        }
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
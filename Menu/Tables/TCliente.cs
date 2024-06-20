using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Tables
{
    public class TCliente
    {
        [DisplayName("Código")]
        public int Controle { get; set; }

        [DisplayName("Cliente")]
        public string Cliente { get; set; }

        [DisplayName("Fantasia")]
        public string Fantasia { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [DisplayName("Celular")]
        public string Celular { get; set; }

        [DisplayName("País")]
        public string Pais { get; set; }

        [DisplayName("UF")]
        public string UF { get; set; }

        [DisplayName("Cidade")]
        public string Cidade { get; set; }

        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [DisplayName("Número")]
        public string Numero { get; set; }

        [DisplayName("CEP")]
        public string CEP { get; set; }

        [DisplayName("Complemento")]
        public string Complemento { get; set; }

        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayName("E-mail 2")]
        public string Email2 { get; set; }

        [DisplayName("Nacionalidade")]
        public string Nacionalidade { get; set; }

        [DisplayName("Naturalidade")]
        public string Naturalidade { get; set; }

        [DisplayName("Data nascimento")]
        public DateTime? DataNascimento { get; set; }

        [DisplayName("Tipo de cliente")]
        public string TipoCliente { get; set; }

        [DisplayName("RG")]
        public string RG { get; set; }

        [DisplayName("IE")]
        public string IE { get; set; }

        [DisplayName("Estado civil")]
        public string EstadoCivil { get; set; }

        [DisplayName("Sexo")]
        public string Sexo { get; set; }

        [DisplayName("IM")]
        public string IM { get; set; }

        [DisplayName("Data e hora cadastro")]
        public DateTime? DataHoraCadastro { get; set; }

        [DisplayName("Pai")]
        public string Pai { get; set; }

        [DisplayName("Mãe")]
        public string Mae { get; set; }

        [DisplayName("Nome cônjuge")]
        public string NomeConjuge { get; set; }

        [DisplayName("Nome contato jurídico")]
        public string NomeContatoJuridico { get; set; }

        [DisplayName("Data última venda")]
        public DateTime? DataUltimaVenda { get; set; }

        [DisplayName("Limite crédito")]
        public decimal? LimiteCredito { get; set; }

        [DisplayName("Cód. convênio")]
        public int? CodConvenio { get; set; }

        [DisplayName("Convênio")]
        public string Convenio { get; set; }

        [DisplayName("Profissão")]
        public string Profissao { get; set; }

        [DisplayName("Empresa")]
        public string EmpresaQueTrabalha { get; set; }

        [DisplayName("Fone trabalho")]
        public string FoneTrabalho { get; set; }

        [DisplayName("Renda mensal")]
        public decimal? RendaMensal { get; set; }

        [DisplayName("Dias sem comprar")]
        public int? DiasSemComprar { get; set; }

        [DisplayName("Código cidade IBGE")]
        public int? CodigoCidadeIGBE { get; set; }

        [DisplayName("Status")]
        public string Status { get; set; }

        [DisplayName("Cód. vendedor")]
        public int? CodVendedor { get; set; }

        [DisplayName("Vendedor")]
        public string Vendedor { get; set; }

        [DisplayName("Ativo")]
        public string Ativo { get; set; }

        [DisplayName("Campo 1")]
        public string Campo1 { get; set; }

        [DisplayName("Campo 2")]
        public string Campo2 { get; set; }

        [DisplayName("Campo 3")]
        public string Campo3 { get; set; }

        [DisplayName("Campo 4")]
        public string Campo4 { get; set; }

        [DisplayName("Campo 5")]
        public string Campo5 { get; set; }

        [DisplayName("Campo 6")]
        public string Campo6 { get; set; }

        [DisplayName("Campo 7")]
        public string Campo7 { get; set; }

        [DisplayName("Campo 8")]
        public string Campo8 { get; set; }

        [DisplayName("Campo 9")]
        public string Campo9 { get; set; }

        [DisplayName("Campo 10")]
        public string Campo10 { get; set; }

    }

    public class TClienteTypeConfiguration : IEntityTypeConfiguration<TCliente>
    {
        public void Configure(EntityTypeBuilder<TCliente> builder)
        {
            builder.ToTable("TCLIENTE");

            builder.HasKey(e => e.Controle);

            builder.Property(e => e.Controle).HasColumnName("CONTROLE").IsRequired();

            builder.Property(e => e.Cliente).HasColumnName("CLIENTE");

            builder.Property(e => e.Fantasia).HasColumnName("FANTASIA");

            builder.Property(e => e.CPF).HasColumnName("CPF");

            builder.Property(e => e.CNPJ).HasColumnName("CNPJ");

            builder.Property(e => e.Telefone).HasColumnName("TELEFONE");

            builder.Property(e => e.Celular).HasColumnName("CELULAR");

            builder.Property(e => e.Pais).HasColumnName("PAIS");

            builder.Property(e => e.UF).HasColumnName("UF");

            builder.Property(e => e.Cidade).HasColumnName("CIDADE");

            builder.Property(e => e.Bairro).HasColumnName("BAIRRO");

            builder.Property(e => e.Endereco).HasColumnName("ENDERECO");

            builder.Property(e => e.Numero).HasColumnName("NUMERO");

            builder.Property(e => e.CEP).HasColumnName("CEP");

            builder.Property(e => e.Complemento).HasColumnName("COMPLEMENTO");

            builder.Property(e => e.Email).HasColumnName("EMAIL");

            builder.Property(e => e.Email2).HasColumnName("EMAIL2");

            builder.Property(e => e.Nacionalidade).HasColumnName("NACIONALIDADE");

            builder.Property(e => e.Naturalidade).HasColumnName("NATURALIDADE");

            builder.Property(e => e.DataNascimento).HasColumnName("DATANASCIMENTO");

            builder.Property(e => e.TipoCliente).HasColumnName("TIPOCLIENTE");

            builder.Property(e => e.RG).HasColumnName("RG");

            builder.Property(e => e.IE).HasColumnName("IE");

            builder.Property(e => e.EstadoCivil).HasColumnName("ESTADOCIVIL");

            builder.Property(e => e.Sexo).HasColumnName("SEXO");

            builder.Property(e => e.IM).HasColumnName("IM");

            builder.Property(e => e.DataHoraCadastro).HasColumnName("DATAHORACADASTRO");

            builder.Property(e => e.Pai).HasColumnName("PAI");

            builder.Property(e => e.Mae).HasColumnName("MAE");

            builder.Property(e => e.NomeConjuge).HasColumnName("NOMECONJUGE");

            builder.Property(e => e.NomeContatoJuridico).HasColumnName("NOMECONTATOJURIDICA");

            builder.Property(e => e.DataUltimaVenda).HasColumnName("DATAULTIMAVENDA");

            builder.Property(e => e.LimiteCredito).HasColumnName("LIMITECREDITO");

            builder.Property(e => e.CodConvenio).HasColumnName("CODCONVENIO");

            builder.Property(e => e.Convenio).HasColumnName("CONVENIO");

            builder.Property(e => e.Profissao).HasColumnName("PROFISSAO");

            builder.Property(e => e.EmpresaQueTrabalha).HasColumnName("EMPRESAQUETRABALHA");

            builder.Property(e => e.FoneTrabalho).HasColumnName("FONETRABALHO");

            builder.Property(e => e.RendaMensal).HasColumnName("RENDAMENSAL");

            builder.Property(e => e.DiasSemComprar).HasColumnName("DIASSEMCOMPRAR");

            builder.Property(e => e.CodigoCidadeIGBE).HasColumnName("CODIGOCIDADEIBGE");

            builder.Property(e => e.Status).HasColumnName("STATUS");

            builder.Property(e => e.CodVendedor).HasColumnName("CODVENDEDOR");

            builder.Property(e => e.Vendedor).HasColumnName("VENDEDOR");

            builder.Property(e => e.Ativo).HasColumnName("ATIVO");

            builder.Property(e => e.Campo1).HasColumnName("CAMPO1");

            builder.Property(e => e.Campo2).HasColumnName("CAMPO2");

            builder.Property(e => e.Campo3).HasColumnName("CAMPO3");

            builder.Property(e => e.Campo4).HasColumnName("CAMPO4");

            builder.Property(e => e.Campo5).HasColumnName("CAMPO5");

            builder.Property(e => e.Campo6).HasColumnName("CAMPO6");

            builder.Property(e => e.Campo7).HasColumnName("CAMPO7");

            builder.Property(e => e.Campo8).HasColumnName("CAMPO8");

            builder.Property(e => e.Campo9).HasColumnName("CAMPO9");

            builder.Property(e => e.Campo10).HasColumnName("CAMPO10");

        }
    }
}
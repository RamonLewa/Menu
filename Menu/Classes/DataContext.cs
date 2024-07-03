using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using Menu.Tables;
using Microsoft.EntityFrameworkCore;

namespace Menu.Classes
{
    public class ConnectionParams
    {
        public static string ConnectionString(string configSoftMaster)
        {
            string caminhoBancoDados = "C:\\SGBR\\Master\\ConfigSoftMaster.ini";

            if (File.Exists(configSoftMaster))
            {
                string[] linhas = File.ReadAllLines(configSoftMaster);
                foreach (string linha in linhas)
                {
                    if (linha.StartsWith("Conexao="))
                    {
                        caminhoBancoDados = linha.Substring("Conexao=".Length);
                        break;
                    }
                }

                if (string.IsNullOrEmpty(caminhoBancoDados))
                {
                    throw new Exception("Banco de dados não encontrado");
                }
            }
            else
            {
                throw new FileNotFoundException("Arquivo ConfigSoftMaster não encontrado", configSoftMaster);
            }

            return $"DataSource=localhost;Database={caminhoBancoDados};Port=3050;User=SYSDBA;Password=masterkey;Charset=UTF8;Dialect=3;Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000";
        }
    }

    public class DataContext : DbContext
    {
        public DbSet<TCliente> TCliente { get; set; }
        public DbSet<TEstoque> TEstoque { get; set; }
        public DbSet<TFornecedor> TFornecedor { get; set; }
        public DbSet<TEmitente> TEmitente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new TClienteTypeConfiguration().Configure(modelBuilder.Entity<TCliente>());
            new TEstoqueTypeConfiguration().Configure(modelBuilder.Entity<TEstoque>());
            new TFornecedorTypeConfiguration().Configure(modelBuilder.Entity<TFornecedor>());
            new TEmitenteEntityTypeConfiguration().Configure(modelBuilder.Entity<TEmitente>());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string configSoftMaster = "C:\\SGBR\\Master\\ConfigSoftMaster.ini";
            optionsBuilder.UseFirebird(ConnectionParams.ConnectionString(configSoftMaster));
        }
    }
}

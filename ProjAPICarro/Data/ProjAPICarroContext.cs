using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPICarro.Data
{
    public class ProjAPICarroContext : DbContext
    {
        public ProjAPICarroContext (DbContextOptions<ProjAPICarroContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Carro> Carro { get; set; } = default!;
        public DbSet<Models.Pessoa>? Pessoas { get; set; } = default!;
        public DbSet<Models.Cliente>? Cliente { get; set; } = default!;

        public DbSet<Models.Funcionario>? Funcionario { get; set; }

        public DbSet<Models.Venda>? Venda { get; set; }

        public DbSet<Models.CarroServico>? CarroServico { get; set; }

        public DbSet<Models.Compra>? Compra { get; set; }

        public DbSet<Models.Servico>? Servico { get; set; }

        public DbSet<Models.Boleto>? Boleto { get; set; }
        public DbSet<Models.Cargo>? Cargo { get; set; }
        public DbSet<Models.Cartao>? Cartao { get; set; }
        public DbSet<Models.Endereco>? Endereco { get; set; }
        public DbSet<Models.Pagamento>? Pagamento { get; set; }
        public DbSet<Models.Pix>? Pix { get; set; }
        public DbSet<Models.TipoPix>? TipoPix { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configura a chave primária na entidade raiz Pessoa
            modelBuilder.Entity<Pessoa>()
                .HasKey(p => p.Documento);

            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Funcionario>().ToTable("Funcionarios");

         }
  
    }
}

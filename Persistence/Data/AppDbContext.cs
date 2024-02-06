using Microsoft.EntityFrameworkCore;
using RegistoMovimentosSrJoaquim.Business.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistoMovimentosSrJoaquim.Persistence.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Movimento>? Movimentos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Trust Server Certificate -> Para conectar precisa de Certificado, como não tenho, cria e define como trusted
            string connectionString = ConfigurationManager.ConnectionStrings["Lagostim"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
                                        maxRetryCount: 5,
                                        maxRetryDelay: TimeSpan.FromSeconds(30),
                                        errorNumbersToAdd: null));
        }

        // Relações

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Movimento>()
        //        .HasOne(r => r.Cliente)
        //        .WithMany(c => Movimentos)
        //        .HasForeignKey(r => r.IdCliente)
        //        .onDelete(DeleteBehavior.Restrict);
        //}
    }
}

// Comandos Package Manager Console
// View -> Other Windows -> Package Manager Console

// 1º COMANDO
// add-migration -> Pega na Classe Modelo e na Classe Context e Gera Codigo CSharp que Gera Base de Dados
// antes de fazer migration, clean rebuild e rebuild solution

// 2º COMANDO
// Update-Database -> Pega na Migração Gerada e Propraga para a Base de Dados, se a BD NÃO Existe cria, se Existe faz Atualização 

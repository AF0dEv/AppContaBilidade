using Microsoft.EntityFrameworkCore;
using RegistoMovimentosSrJoaquim.Business.Models;

namespace RegistoMovimentosSrJoaquim.Persistence
{
    class AppDbContext : DbContext
    {
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Movimento>? Movimentos { get; set; }

        private static AppDbContext? instance = null;

        public static AppDbContext getInstancia()
        {
            if (instance == null)
                instance = new AppDbContext();

            return instance;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data Source=62.28.39.135,62444;Initial Catalog=AfonsoGestaoClix;User ID=EFAafonso;Password=Abc.123##;Trust Server Certificate=True");
        }
    }
}
using Contiero.ControleFinanceiro.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contiero.ControleFinanceiro.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        public DbSet<Conta> Contas  { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Conta>().ToTable("Contas");
        }
    }
}

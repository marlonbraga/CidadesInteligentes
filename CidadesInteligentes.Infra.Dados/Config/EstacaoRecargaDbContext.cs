using CidadesInteligentes.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadesInteligentes.Infra.Dados.Config
{
    public class EstacaoRecargaDbContext : DbContext
    {
        public DbSet<EstacaoRecarga> EstacoesRecarga { get; set; }

        public EstacaoRecargaDbContext()
        {

        }

        public EstacaoRecargaDbContext(DbContextOptions<EstacaoRecargaDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetConnectionString());
            base.OnConfiguring(optionsBuilder);
        }

        private string GetConnectionString()
        {
            //Alterar para as configurações desejadas. Considerar trazer a string de um arquivo de propriedades etc.
            return "Server=(localdb)\\MSSQLLocalDB;Database=CidadesInteligentes;Trusted_Connection=True;MultipleActiveResultSets=True";
        }
    }
}

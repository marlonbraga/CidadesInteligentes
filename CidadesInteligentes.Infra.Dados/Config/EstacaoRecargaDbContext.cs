using CidadesInteligentes.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadesInteligentes.Infra.Dados.Config
{
    internal class EstacaoRecargaDbContext : DbContext
    {
        public DbSet<EstacaoRecarga> EstacoesRecarga { get; set; }
    }
}

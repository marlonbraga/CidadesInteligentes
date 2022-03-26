using CidadesInteligentes.Dominio.Interfaces;
using CidadesInteligentes.Infra.Dados.Config;
using Microsoft.EntityFrameworkCore;

namespace CidadesInteligentes.Infra.Dados.Repositorio
{
    public class RepositorioBase<T> : IBase<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<EstacaoRecargaDbContext> _optionsBuilder;

        public RepositorioBase()
        {
            _optionsBuilder = new DbContextOptions<EstacaoRecargaDbContext>();
        }

        public void Adicionar(T obj)
        {
            using (var db = new EstacaoRecargaDbContext(_optionsBuilder))
            {
                db.Set<T>().Add(obj);
                db.SaveChanges();
            }
        }

        public void Atualizar(T obj)
        {
            using (var db = new EstacaoRecargaDbContext(_optionsBuilder))
            {
                db.Set<T>().Update(obj);
                db.SaveChanges();
            }
        }

        public void Excluir(T obj)
        {
            using (var db = new EstacaoRecargaDbContext(_optionsBuilder))
            {
                db.Set<T>().Remove(obj);
                db.SaveChanges();
            }
        }

        public IList<T> Listar()
        {
            using (var db = new EstacaoRecargaDbContext(_optionsBuilder))
            {
                return db.Set<T>().AsNoTracking().ToList();
            }
        }

        public T RecuperarPorId(Guid id)
        {
            using (var db = new EstacaoRecargaDbContext(_optionsBuilder))
            {
                return db.Set<T>().Find(id);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

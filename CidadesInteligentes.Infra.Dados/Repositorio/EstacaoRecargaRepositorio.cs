using CidadesInteligentes.Dominio.Entidades;
using CidadesInteligentes.Dominio.Interfaces;

namespace CidadesInteligentes.Infra.Dados.Repositorio
{
    public class EstacaoRecargaRepositorio : RepositorioBase<EstacaoRecarga>, IEstacaoRecarga
    {
        public EstacaoRecarga RecuperarPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}

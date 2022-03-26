using CidadesInteligentes.Aplicacao.Interfaces;
using CidadesInteligentes.Dominio.Entidades;
using CidadesInteligentes.Dominio.Interfaces;

namespace CidadesInteligentes.Aplicacao.Aplicacoes
{
    public class EstacoesRecargaApp : IEstacoesRecargaApp
    {
        IEstacaoRecarga _estacaoRecargaInterface;

        public EstacoesRecargaApp(IEstacaoRecarga estacaoRecargaInterface)
        {
            _estacaoRecargaInterface = estacaoRecargaInterface;
        }

        public void Adicionar(EstacaoRecarga obj)
        {
            _estacaoRecargaInterface.Adicionar(obj);
        }

        public void Atualizar(EstacaoRecarga obj)
        {
            _estacaoRecargaInterface.Atualizar(obj);
        }

        public void Excluir(EstacaoRecarga obj)
        {
            _estacaoRecargaInterface.Excluir(obj);
        }

        public IList<EstacaoRecarga> Listar()
        {
            return _estacaoRecargaInterface.Listar();
        }

        public EstacaoRecarga RecuperarPorId(Guid id)
        {
            return _estacaoRecargaInterface.RecuperarPorId(id);
        }
    }
}

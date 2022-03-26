using CidadesInteligentes.Dominio.Entidades;

namespace CidadesInteligentes.Dominio.Interfaces
{
    public interface IEstacaoRecarga : IBase<EstacaoRecarga>
    {
        //Obtém os métodos de IBase
        EstacaoRecarga RecuperarPorNome(string nome);
    }
}

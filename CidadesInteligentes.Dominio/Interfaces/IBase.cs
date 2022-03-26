namespace CidadesInteligentes.Dominio.Interfaces
{
    public interface IBase<T> where T : class
    {
        //Adicionar (C)
        void Adicionar(T obj);

        //Ler (R)
        T RecuperarPorId(Guid id);

        //Atualizar (U)
        void Atualizar(T obj);

        //Excluir (D)
        void Excluir(T obj);

        //Listar
        IList<T> Listar();
    }
}

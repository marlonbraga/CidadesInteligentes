﻿namespace CidadesInteligentes.Aplicacao.Interfaces
{
    public interface IBaseApp<T> where T : class
    {
        void Adicionar(T obj);

        T RecuperarPorId(Guid id);

        void Atualizar(T obj);

        void Excluir(T obj);

        IList<T> Listar();
    }
}

using CidadesInteligentes.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadesInteligentes.Dominio.Interfaces
{
    public interface IEstacaoRecarga : IBase<EstacaoRecarga>
    {
        //Obtém os métodos de IBase
        EstacaoRecarga RecuperarPorNome(string nome);
    }
}

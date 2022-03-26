using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadesInteligentes.Dominio.Entidades
{
    public enum TipoEstacao
    {
        EstacaoVeicular,
        EstacaoMovel
    }
    public class EstacaoRecarga
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public TipoEstacao Tipo { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}

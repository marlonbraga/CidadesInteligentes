using AutoMapper;
using CidadesInteligentes.Dominio.Entidades;
using CidadesInteligentes.MVC.Models;

namespace CidadesInteligentes.MVC.Automapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<EstacaoRecarga, EstacaoRecargaViewModel>();
        }
    }
}

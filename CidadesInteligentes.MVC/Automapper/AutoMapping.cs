using AutoMapper;
using CidadesInteligentes.Dominio.Entidades;
using CidadesInteligentes.MVC.Models;
using System.Collections.Generic;

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

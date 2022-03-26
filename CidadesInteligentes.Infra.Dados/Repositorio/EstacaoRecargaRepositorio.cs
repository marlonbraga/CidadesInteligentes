﻿using CidadesInteligentes.Dominio.Entidades;
using CidadesInteligentes.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

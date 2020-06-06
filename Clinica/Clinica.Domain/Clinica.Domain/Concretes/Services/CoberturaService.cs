using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Interfaces.Services;
using Clinica.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clinica.Domain.Concretes.Services
{
    public class CoberturaService : ICoberturaService
    {
        private readonly ICoberturaRepository _coberturaRepository;

        public CoberturaService(ICoberturaRepository coberturaRepository)
        {
            _coberturaRepository = coberturaRepository;
        }

        public Cobertura ObterPorId(Guid id)
        {
            return _coberturaRepository.Listar(x => x.Id == id).FirstOrDefault();
        }

        public ICollection<Cobertura> ListarCobertura()
        {
            return _coberturaRepository.Listar();
        }
    } 
}

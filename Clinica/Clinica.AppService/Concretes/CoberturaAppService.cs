using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels.Cobertura;
using System;
using System.Collections.Generic;
using AutoMapper;
using Clinica.Domain.Interfaces.Services;

namespace Clinica.AppService.Concretes
{
    public class CoberturaAppService : ICoberturaAppService
    {
        private readonly ICoberturaService _coberturaService;
        private readonly IMapper _mapper;

        public CoberturaAppService(ICoberturaService coberturaService, IMapper mapper)
        {
            _coberturaService = coberturaService;
            _mapper = mapper;
        }

        public CoberturaViewModel ObterPorId(Guid id)
        {
            return _mapper.Map<CoberturaViewModel>(_coberturaService.ObterPorId(id));
        }

        public ICollection<CoberturaViewModel> Listar()
        {
            return _mapper.Map<ICollection<CoberturaViewModel>>(_coberturaService.ListarCobertura());
        }
    }
}

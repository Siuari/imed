using System;
using AutoMapper;
using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels.Medico;
using Clinica.Domain.Models;
using System.Collections.Generic;
using Clinica.Domain.Interfaces.Services;

namespace Clinica.AppService.Concretes
{
    public class MedicoAppService : IMedicoAppService
    {
        private readonly IMedicoService _medicoService;
        private readonly IMapper _mapper;

        public MedicoAppService(IMedicoService medicoService, IMapper mapper)
        {
            _medicoService = medicoService;
            _mapper = mapper;
        }

        public void CadastrarMedico(CadastrarMedicoViewModel viewModel)
        {
            _medicoService.CadastrarMedico(_mapper.Map<Medico>(viewModel));
        }

        public ICollection<MedicoViewModel> ListarMedicos()
        {
            return _mapper.Map<ICollection<MedicoViewModel>>(_medicoService.ListarMedicos());
        }

        public MedicoViewModel AtualizarMedico(AtualizarMedicoViewModel viewModel)
        {
            return _mapper.Map<MedicoViewModel>(_medicoService.AtualizarMedico(_mapper.Map<Medico>(viewModel)));
        }

        public MedicoViewModel DeletarMedico(Guid id)
        {
            return _mapper.Map<MedicoViewModel>(_medicoService.DeletarMedico(id));
        }
    }
}

using System.Collections.Generic;
using AutoMapper;
using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels.Medico;
using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Models;

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
    }
}

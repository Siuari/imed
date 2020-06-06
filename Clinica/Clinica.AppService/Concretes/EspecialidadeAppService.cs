using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels.Especialidade;
using Clinica.AppService.ViewModels.Medico;
using Clinica.Domain.Interfaces.Services;

namespace Clinica.AppService.Concretes
{
    public class EspecialidadeAppService : IEspecialidadeAppService
    {
        private readonly IEspecialidadeService _especialidadeService;
        private readonly IMapper _mapper;

        public EspecialidadeAppService(IEspecialidadeService especialidadeService, IMapper mapper)
        {
            _especialidadeService = especialidadeService;
            _mapper = mapper;
        }

        public ICollection<EspecialidadeViewModel> Listar()
        {
            return _mapper.Map<ICollection<EspecialidadeViewModel>>(_especialidadeService.Listar());
        }

        public EspecialidadeComMedicosViewModel ObterPorIdComMedicos(Guid id)
        {
            return _mapper.Map<EspecialidadeComMedicosViewModel>(_especialidadeService.ObterPorIdComMedicos(id));
        }
    }
}

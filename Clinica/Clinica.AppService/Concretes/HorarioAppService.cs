using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels.Horario;
using Clinica.Domain.Interfaces.Services;

namespace Clinica.AppService.Concretes
{
    public class HorarioAppService : IHorarioAppService
    {
        private readonly IHorarioService _horarioService;
        private readonly IMapper _mapper;

        public HorarioAppService(IHorarioService horarioService, IMapper mapper)
        {
            _horarioService = horarioService;
            _mapper = mapper;
        }

        public ICollection<HorarioListagemViewModel> ListarHorarios()
        {
            return _mapper.Map<ICollection<HorarioListagemViewModel>>(_horarioService.ListarHorarios());
        }
    }
}

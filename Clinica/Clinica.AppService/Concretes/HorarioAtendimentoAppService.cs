using System;
using System.Collections.Generic;
using AutoMapper;
using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels.Horario_Atendimento;
using Clinica.Domain.Enums;
using Clinica.Domain.Interfaces.Services;
using Clinica.Domain.Models;

namespace Clinica.AppService.Concretes
{
    public class HorarioAtendimentoAppService : IHorarioAtendimentoAppService
    {
        private readonly IHorarioAtendimentoService _horarioAtendimentoService;
        private readonly IMapper _mapper;

        public HorarioAtendimentoAppService(IHorarioAtendimentoService horarioAtendimentoService, IMapper mapper)
        {
            _horarioAtendimentoService = horarioAtendimentoService;
            _mapper = mapper;
        }

        public void CadastrarHorarioAtendimento(CadastrarHorarioAtendimentoViewModel viewModel)
        {
            _horarioAtendimentoService.CadastrarHorarioAtendimento(_mapper.Map<HorarioAtendimento>(viewModel));
        }

        public DataHorarioAtendimentoViewModel ObterHorarioAtendimentoDoDia(EnumDia dia, Guid idEspecialidade)
        {
            var dataHorarioAtendimento = _horarioAtendimentoService.ObterHorarioAtendimentoDoDia(dia, idEspecialidade);

            var viewModel = new DataHorarioAtendimentoViewModel
            {
                IdHorarioAtendimento = dataHorarioAtendimento.Item2,
                DataConsulta = dataHorarioAtendimento.Item1
            };

            return viewModel;
        }

        public ICollection<HorarioAtendimentoViewModel> ListarHorariosAtendimentos()
        {
            return _mapper.Map<ICollection<HorarioAtendimentoViewModel>>(_horarioAtendimentoService.ListarHorariosAtendimentos());
        }
    }
}

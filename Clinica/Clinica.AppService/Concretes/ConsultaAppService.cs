using AutoMapper;
using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels.Consulta;
using Clinica.Domain.Interfaces.Services;
using Clinica.Domain.Models;
using System;
using System.Collections.Generic;

namespace Clinica.AppService.Concretes
{
    public class ConsultaAppService : IConsultaAppService
    {
        private readonly IConsultaService _consultaService;
        private readonly IMapper _mapper;

        public ConsultaAppService(IConsultaService consultaService, IMapper mapper)
        {
            _consultaService = consultaService;
            _mapper = mapper;
        }

        public void InserirConsulta(CadastrarConsultaViewModel ViewModel)
        {
            _consultaService.InserirConsulta(_mapper.Map<Consulta>(ViewModel));
        }

        public ConsultaDeletadaViewModel CancelarConsulta(Guid id)
        {
            return _mapper.Map<ConsultaDeletadaViewModel>(_consultaService.CancelarConsulta(id));
        }

        public ICollection<ConsultaViewModel> ListarConsultasPorIdPaciente(Guid idPaciente)
        {
            return _mapper.Map<ICollection<ConsultaViewModel>>(_consultaService.ListarConsultasPorIdPaciente(idPaciente));
        }

        public ICollection<ConsultaViewModel> ListarConsultasPorIdMedico(Guid idMedico)
        {
            return _mapper.Map<ICollection<ConsultaViewModel>>(_consultaService.ListarConsultasPorIdMedico(idMedico));
        }

        public ConsultaViewModel ObterConsultaPorId(Guid id)
        {
            return _mapper.Map<ConsultaViewModel>(_consultaService.ObterConsultaPorId(id));
        }

        public ConsultaMarcadaViewModel ObterConsultaAgendada(Guid idPaciente)
        {
            return _mapper.Map<ConsultaMarcadaViewModel>(_consultaService.ObterConsultaAgendada(idPaciente));
        }

        public ConsultaPagaViewModel PagarConsulta(PagarConsultaViewModel viewModel)
        {
            return _mapper.Map<ConsultaPagaViewModel>(_consultaService.PagarConsulta(viewModel.Id, _mapper.Map<IEnumerable<Pagamento>>(viewModel.Pagamentos)));
        }
    }
}

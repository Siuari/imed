using System;
using AutoMapper;
using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels;
using Clinica.AppService.ViewModels.Paciente;
using Clinica.Domain.Interfaces.Services;
using Clinica.Domain.Models;

namespace Clinica.AppService.Concretes
{
    public class PacienteAppService : IPacienteAppService
    {
        private readonly IPacienteService _pacienteService;
        private readonly IMapper _mapper;

        public PacienteAppService(IPacienteService pacienteService, IMapper mapper)
        {
            _pacienteService = pacienteService;
            _mapper = mapper;
        }
        
        public void Inserir(CadastrarPacienteViewModel viewModel)
        {
            _pacienteService.Inserir(_mapper.Map<Paciente>(viewModel));
        }

        public PacienteViewModel ObterPorId(Guid id)
        {
            return _mapper.Map<PacienteViewModel>(_pacienteService.ObterPorId(id));
        }

        public PacienteDeletadoViewModel RemoverPaciente(Guid id)
        {
            return _mapper.Map<PacienteDeletadoViewModel>(_pacienteService.RemoverPaciente(id));
        }
    }
}

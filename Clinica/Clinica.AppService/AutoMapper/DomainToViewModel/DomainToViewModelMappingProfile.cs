﻿using AutoMapper;
using Clinica.AppService.ViewModels;
using Clinica.AppService.ViewModels.Consulta;
using Clinica.AppService.ViewModels.Medico;
using Clinica.AppService.ViewModels.Paciente;
using Clinica.AppService.ViewModels.Especialidade;
using Clinica.AppService.ViewModels.Horario;
using Clinica.AppService.ViewModels.Horario_Atendimento;
using Clinica.AppService.ViewModels.Usuario;
using Clinica.Domain.Models;
using HorarioAtendimentoViewModel = Clinica.AppService.ViewModels.Consulta.HorarioAtendimentoViewModel;
using MedicoViewModel = Clinica.AppService.ViewModels.Horario_Atendimento.MedicoViewModel;

namespace Clinica.AppService.AutoMapper.DomainToViewModel
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UsuarioLogadoViewModel>();
            CreateMap<Paciente, PacienteLogadoViewModel>();
            CreateMap<Consulta, ConsultaPagaViewModel>();
            CreateMap<Consulta, ConsultaCadastradaViewModel>();
            
            CreateMap<Consulta, ConsultaVencidaViewModel>()
                .ForPath(x => x.Medico.Id, opt => opt.MapFrom(src => src.HorarioAtendimento.Medico.Id))
                .ForPath(x => x.Medico.Nome, opt => opt.MapFrom(src => src.HorarioAtendimento.Medico.Nome))
                .ForPath(x => x.Medico.Crm, opt => opt.MapFrom(src => src.HorarioAtendimento.Medico.Crm))
                .ForPath(x => x.Medico.Especialidade, opt => opt.MapFrom(src => src.HorarioAtendimento.Medico.Especialidade.Descricao));
            
            CreateMap<Paciente, PacienteViewModel>();
            CreateMap<Paciente, PacienteDeletadoViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Medico, ViewModels.Medico.MedicoViewModel>();
            CreateMap<Especialidade, EspecialidadeViewModel>();
            CreateMap<Especialidade, EspecialidadeComMedicosViewModel>();
            CreateMap<Medico, ViewModels.Especialidade.MedicoViewModel>();
            CreateMap<Consulta, ConsultaViewModel>();
            CreateMap<Paciente, PacienteConsultaViewModel>();
            CreateMap<Cobertura, CoberturaViewModel>();
            CreateMap<HorarioAtendimento, ViewModels.Horario_Atendimento.HorarioAtendimentoViewModel>();
            CreateMap<Medico, MedicoViewModel>();
            CreateMap<Horario, HorarioViewModel>();
            CreateMap<Horario, HorarioListagemViewModel>();
            
            CreateMap<HorarioAtendimento, HorarioAtendimentoViewModel>()
                .ForMember(x => x.HoraInicio, opt => opt.MapFrom(src => src.Horario.HoraInicio))
                .ForMember(x => x.Dia, opt => opt.MapFrom(src => src.Horario.Dia));

            CreateMap<Consulta, ConsultaMarcadaViewModel>()
                .ForMember(consultaMarcadaViewModel => consultaMarcadaViewModel.NomePaciente,
                    memberConfigurationExpression =>
                        memberConfigurationExpression.MapFrom(consulta => consulta.Paciente.Nome))
                .ForMember(consultaMarcadaViewModel => consultaMarcadaViewModel.HoraConsulta,
                    memberConfigurationExpression =>
                        memberConfigurationExpression.MapFrom(
                            consulta => consulta.HorarioAtendimento.Horario.HoraInicio))
                .ForMember(consultaMarcadaViewModel => consultaMarcadaViewModel.NomeMedico,
                    memberConfigurationExpression =>
                        memberConfigurationExpression.MapFrom(consulta => consulta.HorarioAtendimento.Medico.Nome));
        }
    }
}

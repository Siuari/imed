using System.Linq;
using AutoMapper;
using Clinica.AppService.ViewModels;
using Clinica.AppService.ViewModels.Consulta;
using Clinica.AppService.ViewModels.Horario_Atendimento;
using Clinica.AppService.ViewModels.Medico;
using Clinica.AppService.ViewModels.Paciente;
using Clinica.Domain.Models;
using HorarioAtendimentoViewModel = Clinica.AppService.ViewModels.Medico.HorarioAtendimentoViewModel;

namespace Clinica.AppService.AutoMapper.ViewModelToDomain
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AtualizarMedicoViewModel, Medico>();
            CreateMap<AtualizarNomeCpfPacienteViewModel, Paciente>();
            CreateMap<CadastrarConsultaViewModel, Consulta>();
            CreateMap<CadastrarHorarioAtendimentoViewModel, HorarioAtendimento>();
            CreateMap<CadastrarMedicoViewModel, Medico>();
            CreateMap<CadastrarPacienteViewModel, Paciente>();
            CreateMap<EnderecoCadastroClienteViewModel, Endereco>();
            CreateMap<HorarioAtendimentoViewModel, HorarioAtendimento>();
        }
    }
}

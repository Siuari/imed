using AutoMapper;
using Clinica.AppService.ViewModels;
using Clinica.AppService.ViewModels.Medico;
using Clinica.AppService.ViewModels.Paciente;
using Clinica.Domain.Models;

namespace Clinica.AppService.AutoMapper.ViewModelToDomain
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CadastrarPacienteViewModel, Paciente>();
            CreateMap<AtualizarNomeCpfPaciente, Paciente>();
            CreateMap<EnderecoCadastroClienteViewModel, Endereco>();
            CreateMap<CadastrarMedicoViewModel, Medico>();
        }
    }
}

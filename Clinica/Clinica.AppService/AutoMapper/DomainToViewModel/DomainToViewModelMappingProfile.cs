using AutoMapper;
using Clinica.AppService.ViewModels;
using Clinica.AppService.ViewModels.Medico;
using Clinica.Domain.Models;

namespace Clinica.AppService.AutoMapper.DomainToViewModel
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Paciente, PacienteViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Medico, MedicoViewModel>();
            CreateMap<Especialidade, EspecialidadeViewModel>();
        }
    }
}

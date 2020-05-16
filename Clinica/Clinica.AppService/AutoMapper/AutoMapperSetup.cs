using AutoMapper;
using Clinica.AppService.AutoMapper.DomainToViewModel;
using Clinica.AppService.AutoMapper.ViewModelToDomain;

namespace Clinica.AppService.AutoMapper
{
    public class AutoMapperSetup
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile(new ViewModelToDomainMappingProfile());
                ps.AddProfile(new DomainToViewModelMappingProfile());
            });
        }
    }
}

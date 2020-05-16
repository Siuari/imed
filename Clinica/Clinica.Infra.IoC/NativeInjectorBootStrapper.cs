using AutoMapper;
using Clinica.AppService.Concretes;
using Clinica.AppService.Interfaces;
using Clinica.Domain.Concretes.Services;
using Clinica.Domain.Interfaces.Repositories;
using Clinica.Domain.Interfaces.Repositories.Base;
using Clinica.Domain.Interfaces.Services;
using Clinica.Infra.Context;
using Clinica.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Clinica.Infra.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddScoped<ClinicaContext, ClinicaContext>();

            service.AddScoped<ICoberturaRepository, CoberturaRepository>();
            service.AddScoped<IConsultaRepository, ConsultaRepository>();
            service.AddScoped<IEnderecoRepository, EnderecoRepository>();
            service.AddScoped<IHorarioAtendimentoRepository, HorarioAtendimentoRepository>();
            service.AddScoped<IPacienteRepository, PacienteRepository>();
            service.AddScoped<IUsuarioRepository, UsuarioRepository>();
            service.AddScoped<IMedicoRepository, MedicoRepository>();

            //service.AddScoped<ICoberturaService, CoberturaService>();
            //service.AddScoped<IConsultaService>();
            //service.AddScoped<IEnderecoService>();
            //service.AddScoped<IHorarioAtendimentoRepository>();
            service.AddScoped<IPacienteService, PacienteService>();
            service.AddScoped<IMedicoService, MedicoSercive>();

            service.AddScoped<IPacienteAppService, PacienteAppService>();
            service.AddScoped<IMedicoAppService, MedicoAppService>();

            service.AddScoped<IMapper, Mapper>();

        }
    }
}

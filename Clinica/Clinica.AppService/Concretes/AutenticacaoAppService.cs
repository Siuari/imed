using AutoMapper;
using Clinica.AppService.Interfaces;
using Clinica.AppService.ViewModels;
using Clinica.AppService.ViewModels.Usuario;
using Clinica.Domain.Interfaces.Services;

namespace Clinica.AppService.Concretes
{
    public class AutenticacaoAppService : IAutenticacaoAppService
    {
        private readonly IAutenticacaoService _autenticacaoService;
        private readonly IMapper _mapper;

        public AutenticacaoAppService(IAutenticacaoService autenticacaoService, IMapper mapper)
        {
            _autenticacaoService = autenticacaoService;
            _mapper = mapper;
        }

        public UsuarioLogadoViewModel Login(LoginViewModel viewModel)
        {
            return _mapper.Map<UsuarioLogadoViewModel>(_autenticacaoService.Login(viewModel.Login, viewModel.Senha));
        }
    }
}

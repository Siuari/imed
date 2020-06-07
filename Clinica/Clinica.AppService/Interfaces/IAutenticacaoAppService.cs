using Clinica.AppService.ViewModels;
using Clinica.AppService.ViewModels.Usuario;

namespace Clinica.AppService.Interfaces
{
    public interface IAutenticacaoAppService
    {
        UsuarioLogadoViewModel Login(LoginViewModel viewModel);
    }
}

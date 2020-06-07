using Clinica.Domain.Models;

namespace Clinica.Domain.Interfaces.Services
{
    public interface IAutenticacaoService
    {
        Usuario Login(string login, string senha);
    }
}
